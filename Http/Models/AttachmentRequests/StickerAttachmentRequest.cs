namespace BotMax.Http.Models.AttachmentRequests;

using BotMax.Http.Models.AttachmentRequests.Payloads;
using System.Text.Json.Serialization;

public class StickerAttachmentRequest : AttachmentRequest
{
    /// <summary>
    /// Тип вложения
    /// </summary>
    [JsonPropertyName("type")]
    public override string Type => "sticker";

    [JsonPropertyName("payload")]
    public StickerAttachmentRequestPayload Payload { get; set; }
}
