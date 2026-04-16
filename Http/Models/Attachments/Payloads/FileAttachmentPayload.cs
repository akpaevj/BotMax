namespace BotMax.Http.Models.Attachments.Payloads;

using System.Text.Json.Serialization;

public class FileAttachmentPayload : AttachmentPayload
{
    /// <summary>
    /// URL медиа-вложения. Этот URL будет получен в объекте Update после отправки сообщения в чат.
    /// </summary>
    [JsonPropertyName("url")]
    public string Url { get; set; }

    /// <summary>
    /// Используйте token, если вы пытаетесь повторно использовать одно и то же вложение в другом сообщении.
    /// </summary>
    [JsonPropertyName("token")]
    public string Token { get; set; }
}
