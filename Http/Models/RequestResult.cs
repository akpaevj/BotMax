using System.Text.Json.Serialization;

namespace BotMax.Http.Models;

public class RequestResult
{
    /// <summary>
    /// true, если запрос был успешным, false — в противном случае
    /// </summary>
    [JsonPropertyName("success")]
    public bool Success { get; set; }

    /// <summary>
    /// Объяснительное сообщение, если результат не был успешным
    /// </summary>
    [JsonPropertyName("message")]
    public string Message { get; set; }
}
