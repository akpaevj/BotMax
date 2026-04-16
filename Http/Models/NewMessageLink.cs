namespace BotMax.Http.Models;

using System.Text.Json.Serialization;

/// <summary>
/// Ссылка на сообщение (для ответа или пересылки)
/// </summary>
public class NewMessageLink
{
    /// <summary>
    /// Тип ссылки сообщения
    /// </summary>
    [JsonPropertyName("type")]
    public MessageLinkType Type { get; set; }

    /// <summary>
    /// ID сообщения исходного сообщения
    /// </summary>
    [JsonPropertyName("mid")]
    public string Mid { get; set; }
}
