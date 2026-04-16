namespace BotMax.Http.Models.Updates;

using BotMax.Http.Models.Users;
using System.Text.Json.Serialization;

public class BotStartedUpdate : Update
{
    /// <summary>
    /// ID чата, где произошло событие
    /// </summary>
    [JsonPropertyName("chat_id")]
    public long ChatId { get; set; }

    /// <summary>
    /// Пользователь, который нажал кнопку 'Start'
    /// </summary>
    [JsonPropertyName("user")]
    public User User { get; set; }

    /// <summary>
    /// Дополнительные данные из дип-линков, переданные при запуске бота
    /// </summary>
    [JsonPropertyName("payload")]
    public string? Payload { get; set; }

    /// <summary>
    /// Текущий язык пользователя в формате IETF BCP 47
    /// </summary>
    [JsonPropertyName("user_locale")]
    public string? UserLocale { get; set; }
}
