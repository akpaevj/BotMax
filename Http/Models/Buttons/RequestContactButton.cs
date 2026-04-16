namespace BotMax.Http.Models.Buttons;

using System.Text.Json.Serialization;

public class RequestContactButton : Button
{
    [JsonPropertyName("type")]
    public override string Type { get; set; } = "request_contact";

    [JsonPropertyName("text")]
    public string Text { get; set; }
}
