namespace BotMax.Http.Models;

using BotMax.Http.Models.Users;
using System.Text.Json.Serialization;

public class Callback
{
    /// <summary>
    /// Unix-время, когда пользователь нажал кнопку
    /// </summary>
    [JsonPropertyName("timestamp")]
    public long Timestamp { get; set; }

    /// <summary>
    /// Текущий ID клавиатуры
    /// </summary>
    [JsonPropertyName("callback_id")]
    public string CallbackId { get; set; }

    /// <summary>
    /// Токен кнопки
    /// </summary>
    [JsonPropertyName("payload")]
    public string? Payload { get; set; }

    /// <summary>
    /// Пользователь, нажавший на кнопку
    /// </summary>
    [JsonPropertyName("user")]
    public User? User { get; set; }
}
