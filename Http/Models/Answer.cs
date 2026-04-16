using System.Text.Json.Serialization;

namespace BotMax.Http.Models;

public class Answer
{
    /// <summary>
    /// Заполните это, если хотите изменить текущее сообщение
    /// </summary>
    [JsonPropertyName("message")]
    public NewMessageBody? Message { get; set; }

    /// <summary>
    /// Заполните это, если хотите просто отправить одноразовое уведомление пользователю
    /// </summary>
    [JsonPropertyName("notification")]
    public string? Notification { get; set; }
}
