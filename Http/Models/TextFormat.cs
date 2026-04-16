namespace BotMax.Http.Models;

using System.Text.Json.Serialization;


/// <summary>
/// Формат текста сообщения
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum TextFormat
{
    /// <summary>Markdown форматирование</summary>
    [JsonPropertyName("markdown")]
    Markdown,

    /// <summary>HTML форматирование</summary>
    [JsonPropertyName("html")]
    Html
}
