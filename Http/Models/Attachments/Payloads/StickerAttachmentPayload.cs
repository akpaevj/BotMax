namespace BotMax.Http.Models.Attachments.Payloads;

using System.Text.Json.Serialization;

public class StickerAttachmentPayload : AttachmentPayload
{
    /// <summary>
    /// URL медиа-вложения. Этот URL будет получен в объекте Update после отправки сообщения в чат.
    /// </summary>
    [JsonPropertyName("url")]
    public string Url { get; set; }

    /// <summary>
    /// ID стикера
    /// </summary>
    [JsonPropertyName("code")]
    public string Code { get; set; }
}
