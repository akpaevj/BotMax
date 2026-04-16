namespace BotMax.Http.Models.AttachmentRequests;

using BotMax.Http.Models.AttachmentRequests.Payloads;
using System.Text.Json.Serialization;

public class InlineKeyboardAttachmentRequest : AttachmentRequest
{
    /// <summary>
    /// Тип вложения
    /// </summary>
    [JsonPropertyName("type")]
    public override string Type => "inline_keyboard";

    [JsonPropertyName("payload")]
    public InlineKeyboardAttachmentRequestPayload Payload { get; set; }
}
