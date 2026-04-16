using BotMax.Http.Models.Updates;
using System.Text.Json.Serialization;

namespace BotMax.Http.Messages
{
    public class UpdatesResponse
    {
        [JsonPropertyName("updates")]
        public List<Update> Updates { get; set; }

        [JsonPropertyName("marker")]
        public long Marker { get; set; }
    }
}
