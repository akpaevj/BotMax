namespace BotMax.Http.Models.AttachmentRequests.Payloads;

using BotMax.Http.Models.Buttons;
using System.Text.Json.Serialization;

public class InlineKeyboardAttachmentRequestPayload : AttachmentRequestPayload
{
    [JsonPropertyName("buttons")]
    public Button[][] Buttons { get; set; }
}
