namespace BotMax.Http.Models.Buttons;

using System.Text.Json.Serialization;

public abstract class Button
{
    [JsonPropertyName("type")]
    public abstract string Type { get; set; }
}
