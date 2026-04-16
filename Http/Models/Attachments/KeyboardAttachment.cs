namespace BotMax.Http.Models.Attachments;

using BotMax.Http.Models.Attachments.Payloads;
using System.Text.Json.Serialization;

public class KeyboardAttachment : Attachment
{
    [JsonPropertyName("type")]
    public override string Type => "inline_keyboard";

    [JsonPropertyName("payload")]
    public Keyboard Payload { get; set; }
}
