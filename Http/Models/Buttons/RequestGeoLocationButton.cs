namespace BotMax.Http.Models.Buttons;

using System.Text.Json.Serialization;

public class RequestGeoLocationButton : Button
{
    [JsonPropertyName("type")]
    public override string Type { get; set; } = "request_geo_location";

    [JsonPropertyName("text")]
    public string Text { get; set; }

    [JsonPropertyName("quick")]
    public bool? Quick { get; set; }
}
