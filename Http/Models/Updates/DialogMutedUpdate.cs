namespace BotMax.Http.Models.Updates;

using BotMax.Http.Models.Users;
using System.Text.Json.Serialization;

public class DialogMutedUpdate : Update
{
    /// <summary>
    /// ID чата, где произошло событие
    /// </summary>
    [JsonPropertyName("chat_id")]
    public long ChatId { get; set; }

    /// <summary>
    /// Пользователь, который отключил уведомления
    /// </summary>
    [JsonPropertyName("user")]
    public User User { get; set; }

    /// <summary>
    /// Время в формате Unix, до наступления которого диалог был отключён
    /// </summary>
    [JsonPropertyName("muted_until")]
    public long MutedUntil { get; set; }

    /// <summary>
    /// Текущий язык пользователя в формате IETF BCP 47
    /// </summary>
    [JsonPropertyName("user_locale")]
    public string? UserLocale { get; set; }
}
