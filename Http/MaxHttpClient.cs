using BotMax.Http.Converters;
using BotMax.Http.Messages;
using BotMax.Http.Models;
using BotMax.Http.Models.Users;
using System.Net;
using System.Net.Http.Json;
using System.Text.Json;

namespace BotMax.Http
{
    public class MaxHttpClient : IDisposable
    {
        private readonly JsonSerializerOptions _options;
        private HttpClient _client;
        private bool disposedValue;

        public MaxHttpClient(string token)
        {
            _options = new JsonSerializerOptions();
            _options.Converters.Add(new UpdateJsonConverter());
            _options.Converters.Add(new AttachmentJsonConverter());
            _options.Converters.Add(new AttachmentRequestJsonConverter());
            _options.Converters.Add(new ButtonJsonConverter());
            _options.Converters.Add(new MarkupElementJsonConverter());

            _client = new HttpClient
            {
                BaseAddress = new Uri("https://platform-api.max.ru/")
            };
            _client.DefaultRequestHeaders.Add("Authorization", token);
        }

        #region bots

        public async Task<BotInfo> Me(CancellationToken cancellationToken = default)
            => await GetAsync<BotInfo>(BuildUri("me"), cancellationToken);

        #endregion

        #region suscriptions

        public async Task<SubscriptionsResponse> Subscriptions(CancellationToken cancellationToken = default)
            => await GetAsync<SubscriptionsResponse>(BuildUri("subscriptions"), cancellationToken);

        public async Task<RequestResult> Subscribe(SubscribeRequest request, CancellationToken cancellationToken = default)
            => await PostAsync<RequestResult, SubscribeRequest>(BuildUri("subscriptions"), request, cancellationToken);

        public async Task<RequestResult> Unsubscribe(UnsibscribeRequest request, CancellationToken cancellationToken = default)
        {
            var parameters = new Dictionary<string, string?>
            {
                { "url", request.Url }
            };

            return await DeleteAsync<RequestResult>(BuildUri("subscriptions", parameters), cancellationToken);
        }

        public async Task<UpdatesResponse> Updates(UpdatesRequest request, CancellationToken cancellationToken = default)
        {
            var parameters = new Dictionary<string, string?>();

            if (request.Limit != null)
                parameters.Add("limit", request.Limit.ToString());

            if (request.MessageTypes != null)
                parameters.Add("types", string.Join(',', request.MessageTypes));

            return await GetAsync<UpdatesResponse>(BuildUri("updates", parameters), cancellationToken);
        }

        #endregion

        #region messages

        public async Task<Message[]> GetMessages(GetMessagesRequest request, CancellationToken cancellationToken = default)
        {
            var parameters = new Dictionary<string, string?>();

            if (request.ChatId != null)
                parameters.Add("chat_id", request.ChatId.ToString());

            if (request.MessageIds != null)
                parameters.Add("message_ids", string.Join(',', request.MessageIds));

            if (request.From != null)
                parameters.Add("from", request.From.ToString());

            if (request.To != null)
                parameters.Add("to", request.To.ToString());

            if (request.Count != null)
                parameters.Add("count", request.Count.ToString());

            return await GetAsync<Message[]>(BuildUri("updates", parameters), cancellationToken);
        }

        public async Task<Message> PostMessage(PostMessageRequest request, CancellationToken cancellationToken = default)
        {
            var parameters = new Dictionary<string, string?>();

            if (request.UserId != null)
                parameters.Add("user_id", request.UserId.ToString());

            if (request.ChatId != null)
                parameters.Add("chat_id", request.ChatId.ToString());

            if (request.DisableLinkPreview != null)
                parameters.Add("disable_link_preview", request.DisableLinkPreview.ToString());

            return await PostAsync<Message, NewMessageBody>(BuildUri("messages", parameters), request.Message, cancellationToken);
        }

        public async Task<RequestResult> EditMessage(EditMessageRequest request, CancellationToken cancellationToken = default)
        {
            var parameters = new Dictionary<string, string?>
            {
                { "message_id", request.MessageId }
            };

            return await PutAsync<RequestResult, EditMessage>(BuildUri("messages", parameters), request.EditMessage, cancellationToken);
        }

        public async Task<RequestResult> DeleteMessage(DeleteMessageRequest request, CancellationToken cancellationToken = default)
        {
            var parameters = new Dictionary<string, string?>
            {
                { "message_id", request.MessageId }
            };

            return await DeleteAsync<RequestResult>(BuildUri("messages", parameters), cancellationToken);
        }

        public async Task<Message> GetMessage(GetMessageRequest request, CancellationToken cancellationToken = default)
            => await GetAsync<Message>(BuildUri($"messages/{request.MessageId}"), cancellationToken);

        public async Task<GetVideoInfoResponse> GetVideoInfo(GetVideoInfoRequest request, CancellationToken cancellationToken = default)
            => await GetAsync<GetVideoInfoResponse>(BuildUri($"videos/{request.VideoToken}"), cancellationToken);

        public async Task<RequestResult> PostAnswers(AnswersRequest request, CancellationToken cancellationToken = default)
        {
            var parameters = new Dictionary<string, string?>()
            {
                { "callback_id", request.CallbackId }
            };

            return await PostAsync<RequestResult, Answer>(BuildUri("answers", parameters), request.Answer, cancellationToken);
        }

        #endregion

        #region Private helper methods

        private async Task<T> GetAsync<T>(Uri uri, CancellationToken cancellationToken = default)
        {
            using var response = await _client.GetAsync(uri, cancellationToken);
            await EnsureSuccessStatusCode(response);
            return await response.Content.ReadFromJsonAsync<T>(_options, cancellationToken) ?? throw new InvalidOperationException("Response is null");
        }

        private async Task<T> PostAsync<T, T2>(Uri uri, T2? content, CancellationToken cancellationToken = default)
        {
            var d = JsonSerializer.Serialize(content);
            using var response = await _client.PostAsJsonAsync(uri, content, _options, cancellationToken);
            await EnsureSuccessStatusCode(response);
            return await response.Content.ReadFromJsonAsync<T>(_options,cancellationToken) ?? throw new InvalidOperationException("Response is null");
        }

        private async Task<T> PutAsync<T, T2>(Uri uri, T2? content, CancellationToken cancellationToken = default)
        {
            using var response = await _client.PutAsJsonAsync(uri, content, _options, cancellationToken);
            await EnsureSuccessStatusCode(response);
            return await response.Content.ReadFromJsonAsync<T>(_options, cancellationToken) ?? throw new InvalidOperationException("Response is null");
        }

        private async Task<T> DeleteAsync<T>(Uri uri, CancellationToken cancellationToken = default)
        {
            using var response = await _client.DeleteAsync(uri, cancellationToken);
            await EnsureSuccessStatusCode(response);
            return await response.Content.ReadFromJsonAsync<T>(_options, cancellationToken) ?? throw new InvalidOperationException("Response is null");
        }

        private async Task EnsureSuccessStatusCode(HttpResponseMessage response)
        {
            if (response.IsSuccessStatusCode)
                return;

            var statusCode = response.StatusCode;
            var content = await response.Content.ReadAsStringAsync();

            var errorMessage = statusCode switch
            {
                HttpStatusCode.BadRequest => $"Недействительный запрос (400): {content}",
                HttpStatusCode.Unauthorized => $"Ошибка аутентификации (401): {content}",
                HttpStatusCode.NotFound => $"Ресурс не найден (404): {content}",
                HttpStatusCode.MethodNotAllowed => $"Метод не допускается (405): {content}",
                HttpStatusCode.TooManyRequests => $"Превышено количество запросов (429): {content}",
                HttpStatusCode.ServiceUnavailable => $"Сервис недоступен (503): {content}",
                _ => $"HTTP ошибка {(int)statusCode} ({statusCode}): {content}"
            };

            throw new HttpRequestException(errorMessage, null, statusCode);
        }

        private Uri BuildUri(string uri)
            => BuildUri(uri, []);

        private Uri BuildUri(string uri, Dictionary<string, string?> parameters)
            => new UriBuilder(_client.BaseAddress!)
            {
                Path = uri,
                Query = parameters.ToQueryString(),
            }.Uri;

        #endregion

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _client?.Dispose();
                    _client = null!;
                }

                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}