namespace BotMax.Http.Models.Attachments;

using System.Text.Json.Serialization;

public class LocationAttachment : Attachment
{
    [JsonPropertyName("type")]
    public override string Type => "location";

    [JsonPropertyName("latitude")]
    public double? Latitude { get; set; }

    [JsonPropertyName("longitude")]
    public double? Longitude { get; set; }
}
