namespace BotMax.Http.Models.Buttons;

using System.Text.Json.Serialization;

public class CallbackButton : Button
{
    [JsonPropertyName("type")]
    public override string Type { get; set; } = "callback";

    [JsonPropertyName("text")]
    public string Text { get; set; }

    [JsonPropertyName("payload")]
    public string Payload { get; set; }
}