namespace BotMax.Http.Models.AttachmentRequests.Payloads;

using System.Text.Json.Serialization;

public class StickerAttachmentRequestPayload : AttachmentRequestPayload
{
    /// <summary>
    /// Код стикера
    /// </summary>
    [JsonPropertyName("code")]
    public string Code { get; set; }
}
