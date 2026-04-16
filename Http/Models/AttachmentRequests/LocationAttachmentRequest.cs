namespace BotMax.Http.Models.AttachmentRequests;

using System.Text.Json.Serialization;

public class LocationAttachmentRequest : AttachmentRequest
{
    /// <summary>
    /// Тип вложения
    /// </summary>
    [JsonPropertyName("type")]
    public override string Type => "location";

    /// <summary>
    /// Широта
    /// </summary>
    [JsonPropertyName("latitude")]
    public double Latitude { get; set; }

    /// <summary>
    /// Долгота
    /// </summary>
    [JsonPropertyName("longitude")]
    public double Longitude { get; set; }
}
