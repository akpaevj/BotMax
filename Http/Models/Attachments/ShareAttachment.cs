namespace BotMax.Http.Models.Attachments;

using BotMax.Http.Models.Attachments.Payloads;
using System.Text.Json.Serialization;

public class ShareAttachment : Attachment
{
    [JsonPropertyName("type")]
    public override string Type => "share";

    [JsonPropertyName("payload")]
    public ShareAttachmentPayload Payload { get; set; }

    [JsonPropertyName("title")]
    public string? Title { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("image_url")]
    public string? ImageUrl { get; set; }
}
