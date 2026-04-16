using System.Text.Json.Serialization;

namespace BotMax.Http.Models;

/// <summary>
/// Статус чата
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ChatStatus
{
    /// <summary>Бот является активным участником чата</summary>
    [JsonPropertyName("active")]
    Active,

    /// <summary>Бот был удалён из чата</summary>
    [JsonPropertyName("removed")]
    Removed,

    /// <summary>Бот покинул чат</summary>
    [JsonPropertyName("left")]
    Left,

    /// <summary>Чат был закрыт</summary>
    [JsonPropertyName("closed")]
    Closed
}
