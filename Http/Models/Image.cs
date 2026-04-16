using System.Text.Json.Serialization;

namespace BotMax.Http.Models;

public class Image
{
    [JsonPropertyName("url")]
    public string Url { get; set; }
}
