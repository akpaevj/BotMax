using BotMax.Http.Models.Users;
using System.Text.Json.Serialization;

namespace BotMax.Http.Models;

/// <summary>
/// Пересланное или ответное сообщение
/// </summary>
public class LinkedMessage
{
    /// <summary>
    /// Тип связанного сообщения
    /// </summary>
    [JsonPropertyName("type")]
    public MessageLinkType Type { get; set; }

    /// <summary>
    /// Пользователь, отправивший сообщение
    /// </summary>
    [JsonPropertyName("sender")]
    public User? Sender { get; set; }

    /// <summary>
    /// Чат, в котором сообщение было изначально опубликовано. Только для пересланных сообщений
    /// </summary>
    [JsonPropertyName("chat_id")]
    public long? ChatId { get; set; }

    /// <summary>
    /// Схема, представляющая тело сообщения
    /// </summary>
    [JsonPropertyName("message")]
    public MessageBody? Message { get; set; }
}
