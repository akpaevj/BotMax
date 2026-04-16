namespace BotMax.Http.Models.Attachments;

using BotMax.Http.Models.Attachments.Payloads;
using System.Text.Json.Serialization;

public class StickerAttachment : Attachment
{
    [JsonPropertyName("type")]
    public override string Type => "sticker";

    [JsonPropertyName("payload")]
    public StickerAttachmentPayload Payload { get; set; }

    /// <summary>
    /// Ширина стикера
    /// </summary>
    [JsonPropertyName("width")]
    public int Width { get; set; }

    /// <summary>
    /// Высота стикера
    /// </summary>
    [JsonPropertyName("height")]
    public int Height { get; set; }
}
