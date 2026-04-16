namespace BotMax.Http.Models.Buttons;

using System.Text.Json.Serialization;

public class LinkButton : Button
{
    [JsonPropertyName("type")]
    public override string Type { get; set; } = "link";

    [JsonPropertyName("text")]
    public string Text { get; set; }

    [JsonPropertyName("url")]
    public string Url { get; set; }
}
