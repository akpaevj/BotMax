namespace BotMax.Http.Models.Attachments;

using System.Text.Json.Serialization;

/// <summary>
/// Вложения сообщения
/// </summary>
public abstract class Attachment
{
    /// <summary>
    /// Тип вложения
    /// </summary>
    [JsonPropertyName("type")]
    public abstract string Type { get; }
}
