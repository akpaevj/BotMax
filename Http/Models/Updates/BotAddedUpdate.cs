namespace BotMax.Http.Models.Updates;

using BotMax.Http.Models.Users;
using System.Text.Json.Serialization;

public class BotAddedUpdate : Update
{
    /// <summary>
    /// ID чата, куда был добавлен бот
    /// </summary>
    [JsonPropertyName("chat_id")]
    public long ChatId { get; set; }

    /// <summary>
    /// Пользователь, добавивший бота в чат
    /// </summary>
    [JsonPropertyName("user")]
    public User User { get; set; }

    /// <summary>
    /// Указывает, был ли бот добавлен в канал или нет
    /// </summary>
    [JsonPropertyName("is_channel")]
    public bool IsChannel { get; set; }
}
