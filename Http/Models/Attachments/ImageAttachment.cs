namespace BotMax.Http.Models.Attachments;

using BotMax.Http.Models.Attachments.Payloads;
using System.Text.Json.Serialization;

public class ImageAttachment : Attachment
{
    [JsonPropertyName("type")]
    public override string Type => "image";

    [JsonPropertyName("payload")]
    public PhotoAttachmentPayload Payload { get; set; }
}
