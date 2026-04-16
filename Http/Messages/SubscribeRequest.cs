using System.Text.Json.Serialization;

namespace BotMax.Http.Messages;

public class SubscribeRequest(string url)
{
    /// <summary>
    /// URL HTTPS-endpoint бота
    /// </summary>
    [JsonPropertyName("url")]
    public string Url { get; private set; } = url;

    /// <summary>
    /// Список типов обновлений, которые хочет получать бот
    /// </summary>
    [JsonPropertyName("update_types")]
    public string[]? UpdateTypes { get; set; }

    /// <summary>
    /// Cекрет, который должен быть отправлен в заголовке X-Max-Bot-Api-Secret в каждом запросе Webhook. 
    /// Разрешены только символы A-Z, a-z, 0-9, и дефис. Заголовок рекомендован, чтобы запрос поступал из установленного веб-узла
    /// </summary>
    [JsonPropertyName("secret")]
    public string? Secret { get; set; }
}
