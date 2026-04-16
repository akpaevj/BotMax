namespace BotMax.Http.Models.Updates;

using BotMax.Http.Models.Users;
using System.Text.Json.Serialization;

public class UserRemovedUpdate : Update
{
    /// <summary>
    /// ID чата, где произошло событие
    /// </summary>
    [JsonPropertyName("chat_id")]
    public long ChatId { get; set; }

    /// <summary>
    /// Пользователь, удалённый из чата
    /// </summary>
    [JsonPropertyName("user")]
    public User User { get; set; }

    /// <summary>
    /// Администратор, который удалил пользователя из чата. Может быть null, если пользователь покинул чат сам
    /// </summary>
    [JsonPropertyName("admin_id")]
    public long? AdminId { get; set; }

    /// <summary>
    /// Указывает, был ли пользователь добавлен в канал или нет
    /// </summary>
    [JsonPropertyName("is_channel")]
    public bool IsChannel { get; set; }
}
