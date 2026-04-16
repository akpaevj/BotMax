using System.Text.Json.Serialization;

namespace BotMax.Http.Models;

/// <summary>
/// Тип чата
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ChatType
{
    /// <summary>Групповой чат</summary>
    [JsonPropertyName("chat")]
    Chat,

    /// <summary>Диалог</summary>
    [JsonPropertyName("dialog")]
    Dialog
}
