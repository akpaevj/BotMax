using System.Text.Json.Serialization;

namespace BotMax.Http.Models;

public class Subscription
{
    /// <summary>
    /// URL вебхука
    /// </summary>
    [JsonPropertyName("url")]
    public string Url { get; set; }

    /// <summary>
    /// Unix-время, когда была создана подписка
    /// </summary>
    [JsonPropertyName("time")]
    public long Time { get; set; }

    /// <summary>
    /// Типы обновлений, на которые подписан бот
    /// </summary>
    [JsonPropertyName("update_types")]
    public string[] UpdateTypes { get; set; } = [];
}
