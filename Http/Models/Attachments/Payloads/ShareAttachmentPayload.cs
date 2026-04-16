namespace BotMax.Http.Models.Attachments.Payloads;

using System.Text.Json.Serialization;

public class ShareAttachmentPayload : AttachmentPayload
{
    /// <summary>
    /// URL, прикрепленный к сообщению в качестве предпросмотра медиа
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>
    /// Токен вложения
    /// </summary>
    [JsonPropertyName("token")]
    public string? Token { get; set; }
}
