namespace BotMax.Http.Models.Attachments.Payloads;

using System.Text.Json.Serialization;

public class PhotoAttachmentPayload : AttachmentPayload
{
    /// <summary>
    /// Уникальный ID этого изображения
    /// </summary>
    [JsonPropertyName("photo_id")]
    public long PhotoId { get; set; }

    /// <summary>
    /// Используйте token, если вы пытаетесь повторно использовать одно и то же вложение в другом сообщении.
    /// </summary>
    [JsonPropertyName("token")]
    public string Token { get; set; }

    /// <summary>
    /// URL изображения
    /// </summary>
    [JsonPropertyName("url")]
    public string Url { get; set; }
}
