namespace BotMax.Http.Models.Buttons;

using System.Text.Json.Serialization;

public class OpenAppButton : Button
{
    [JsonPropertyName("type")]
    public override string Type { get; set; } = "open_app";

    [JsonPropertyName("text")]
    public string Text { get; set; }

    [JsonPropertyName("web_app")]
    public string? WebApp { get; set; }

    [JsonPropertyName("contact_id")]
    public long? ContactId { get; set; }

    [JsonPropertyName("payload")]
    public string? Payload { get; set; }
}
