using BotMax.Http;
using BotMax.Http.Messages;
using BotMax.Http.Models;
using BotMax.Http.Models.AttachmentRequests;
using BotMax.Http.Models.Attachments;
using BotMax.Http.Models.Updates;
using System;
using System.Collections.Generic;
using System.Text;

namespace BotMax;

public class MaxClient(string token)
{
    public MaxHttpClient HttpClient { get; } = new MaxHttpClient(token);

    public async Task<SubscriptionsResponse> GetSubscriptions(CancellationToken cancellationToken = default)
        => await HttpClient.Subscriptions(cancellationToken);

    public async Task Subscribe(string url, string? secret = null, string[]? updateTypes = null, CancellationToken cancellationToken = default)
    {
        var response = await HttpClient.Subscribe(
            new SubscribeRequest(url)
            {
                Secret = secret,
                UpdateTypes = updateTypes
            }, cancellationToken);

        if (response?.Success != true)
            throw new Exception($"Ошибка подписки на webhooks: {response?.Message}");
    }

    public async Task Unsubscribe(string url, CancellationToken cancellationToken = default)
    {
        var response = await HttpClient.Unsubscribe(
            new UnsibscribeRequest(url)
            , cancellationToken);

        if (response?.Success != true)
            throw new Exception($"Ошибка отписки от webhooks: {response?.Message}");
    }

    public async Task SendMessage(string message, long userId, TextFormat? format = null, AttachmentRequest[]? attachments = null, CancellationToken cancellationToken = default)
    {
        var messageBody = new NewMessageBody
        {
            Text = message,
            Format = format,
            Attachments = attachments
        };

        var request = new PostMessageRequest(messageBody)
        {
            UserId = userId
        };

        await HttpClient.PostMessage(request, cancellationToken);
    }

    public async Task EditMessage(string mid, string text, TextFormat? format = null, AttachmentRequest[]? attachments = null, CancellationToken cancellationToken = default)
    {
        var body = new EditMessage()
        {
            Attachments = attachments,
            Format = format
        };

        var request = new EditMessageRequest(mid, body);

        await HttpClient.EditMessage(request, cancellationToken);
    }

    public async Task Reply(string message, Message replyTo, TextFormat? format = null, AttachmentRequest[]? attachments = null, CancellationToken cancellationToken = default)
    {
        var messageBody = new NewMessageBody
        {
            Text = message,
            Format = format,
            Attachments = attachments,
            Link = new NewMessageLink()
            {
                Mid = replyTo.Body.Mid,
                Type = MessageLinkType.Reply
            }
        };

        var request = new PostMessageRequest(messageBody)
        {
            UserId = replyTo.Sender!.UserId
        };

        await HttpClient.PostMessage(request, cancellationToken);
    }

    public async Task<List<Update>> GetUpdates(List<string>? messageTypes = null, CancellationToken cancellationToken = default)
    {
        var request = new UpdatesRequest();

        if (messageTypes != null)
            request.MessageTypes = [.. messageTypes];

        var response = await HttpClient.Updates(request, cancellationToken);

        return response.Updates;
    }

    public async Task AnswerCallback(string callbackId, string text, TextFormat? format = null, AttachmentRequest[]? attachments = null, CancellationToken cancellationToken = default)
    {
        var messageBody = new NewMessageBody
        {
            Text = text,
            Attachments = attachments,
            Format = format
        };

        var answer = new Answer()
        {
            Message = messageBody
        };

        var request = new AnswersRequest(callbackId, answer);

        await HttpClient.PostAnswers(request, cancellationToken);
    }
}
