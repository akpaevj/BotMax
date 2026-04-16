namespace BotMax.Http.Models.AttachmentRequests;

using BotMax.Http.Models.AttachmentRequests.Payloads;
using System.Text.Json.Serialization;

public class ContactAttachmentRequest : AttachmentRequest
{
    /// <summary>
    /// Тип вложения
    /// </summary>
    [JsonPropertyName("type")]
    public override string Type => "contact";

    [JsonPropertyName("payload")]
    public ContactAttachmentRequestPayload Payload { get; set; }
}
