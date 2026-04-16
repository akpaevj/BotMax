using System.Text.Json.Serialization;

namespace BotMax.Http.Models;

/// <summary>
/// Тип связанного сообщения
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum MessageLinkType
{
    [JsonPropertyName("forward")]
    Forward,

    [JsonPropertyName("reply")]
    Reply
}
