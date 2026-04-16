namespace BotMax.Http.Models.Attachments;

using BotMax.Http.Models.Attachments.Payloads;
using System.Text.Json.Serialization;

public class ContactAttachment : Attachment
{
    [JsonPropertyName("type")]
    public override string Type => "contact";

    [JsonPropertyName("payload")]
    public ContactAttachmentPayload Payload { get; set; }
}
