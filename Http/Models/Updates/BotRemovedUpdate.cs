namespace BotMax.Http.Models.Updates;

using BotMax.Http.Models.Users;
using System.Text.Json.Serialization;

public class BotRemovedUpdate : Update
{
    /// <summary>
    /// ID чата, откуда был удалён бот
    /// </summary>
    [JsonPropertyName("chat_id")]
    public long ChatId { get; set; }

    /// <summary>
    /// Пользователь, удаливший бота из чата
    /// </summary>
    [JsonPropertyName("user")]
    public User User { get; set; }

    /// <summary>
    /// Указывает, был ли бот удалён из канала или нет
    /// </summary>
    [JsonPropertyName("is_channel")]
    public bool IsChannel { get; set; }
}
