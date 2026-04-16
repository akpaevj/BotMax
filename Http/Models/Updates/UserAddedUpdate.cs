namespace BotMax.Http.Models.Updates;

using BotMax.Http.Models.Users;
using System.Text.Json.Serialization;

public class UserAddedUpdate : Update
{
    /// <summary>
    /// ID чата, где произошло событие
    /// </summary>
    [JsonPropertyName("chat_id")]
    public long ChatId { get; set; }

    /// <summary>
    /// Пользователь, добавленный в чат
    /// </summary>
    [JsonPropertyName("user")]
    public User User { get; set; }

    /// <summary>
    /// Пользователь, который добавил пользователя в чат. Может быть null, если пользователь присоединился к чату по ссылке
    /// </summary>
    [JsonPropertyName("inviter_id")]
    public long? InviterId { get; set; }

    /// <summary>
    /// Указывает, был ли пользователь добавлен в канал или нет
    /// </summary>
    [JsonPropertyName("is_channel")]
    public bool IsChannel { get; set; }
}
