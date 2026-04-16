namespace BotMax.Http.Models.AttachmentRequests;

using BotMax.Http.Models.Attachments.Payloads;
using System.Text.Json.Serialization;

public class ShareAttachmentRequest : AttachmentRequest
{
    /// <summary>
    /// Тип вложения
    /// </summary>
    [JsonPropertyName("type")]
    public override string Type => "share";

    /// <summary>
    /// Полезная нагрузка запроса ShareAttachmentRequest
    /// </summary>
    [JsonPropertyName("payload")]
    public ShareAttachmentPayload Payload { get; set; }
}
