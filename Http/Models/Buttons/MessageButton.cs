namespace BotMax.Http.Models.Buttons;

using System.Text.Json.Serialization;

public class MessageButton : Button
{
    [JsonPropertyName("type")]
    public override string Type { get; set; } = "message";

    [JsonPropertyName("text")]
    public string Text { get; set; }
}
