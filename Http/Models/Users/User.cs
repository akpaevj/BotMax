using System.Text.Json.Serialization;

namespace BotMax.Http.Models.Users;

public class User
{
    /// <summary>
    /// Уникальный идентификатор пользователя
    /// </summary>
    [JsonPropertyName("user_id")]
    public long UserId { get; set; }

    /// <summary>
    /// Имя пользователя
    /// </summary>
    [JsonPropertyName("first_name")]
    public string FirstName { get; set; }

    /// <summary>
    /// Фамилия пользователя
    /// </summary>
    [JsonPropertyName("last_name")]
    public string? LastName { get; set; }

    /// <summary>
    /// UserName (никнейм) пользователя
    /// </summary>
    [JsonPropertyName("username")]
    public string? UserName { get; set; }

    /// <summary>
    /// Является ли пользователь ботом
    /// </summary>
    [JsonPropertyName("is_bot")]
    public bool IsBot { get; set; }

    /// <summary>
    /// Время последней активности (Unix timestamp)
    /// </summary>
    [JsonPropertyName("last_activity_time")]
    public long LastActivityTime { get; set; }

    /// <summary>
    /// Отображаемое имя пользователя
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
