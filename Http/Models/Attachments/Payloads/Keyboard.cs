namespace BotMax.Http.Models.Attachments.Payloads;

using BotMax.Http.Models.Buttons;
using System.Text.Json.Serialization;

public class Keyboard : AttachmentPayload
{
    [JsonPropertyName("buttons")]
    public Button[][] Buttons { get; set; }
}
