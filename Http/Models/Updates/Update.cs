namespace BotMax.Http.Models.Updates;

using System.Text.Json.Serialization;

/// <summary>
/// Объект Update представляет различные типы событий, произошедших в чате
/// </summary>
public class Update
{
    /// <summary>
    /// Тип обновления (события)
    /// </summary>
    [JsonPropertyName("update_type")]
    public string UpdateType { get; set; }

    /// <summary>
    /// Unix-время, когда произошло событие
    /// </summary>
    [JsonPropertyName("timestamp")]
    public long Timestamp { get; set; }
}
