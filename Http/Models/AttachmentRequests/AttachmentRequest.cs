namespace BotMax.Http.Models.AttachmentRequests;

using System.Text.Json.Serialization;

/// <summary>
/// Запрос на вложение для сообщения
/// </summary>
public abstract class AttachmentRequest
{
    /// <summary>
    /// Тип вложения
    /// </summary>
    [JsonPropertyName("type")]
    public abstract string Type { get; }
}