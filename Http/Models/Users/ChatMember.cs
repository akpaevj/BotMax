namespace BotMax.Http.Models.Users;

using System.Collections.Generic;
using System.Text.Json.Serialization;

/// <summary>
/// Информация о пользователе в чате
/// </summary>
public class ChatMember
{
    /// <summary>
    /// Идентификатор пользователя или бота
    /// </summary>
    [JsonPropertyName("user_id")]
    public long UserId { get; set; }

    /// <summary>
    /// Отображаемое имя пользователя или бота
    /// </summary>
    [JsonPropertyName("first_name")]
    public string FirstName { get; set; }

    /// <summary>
    /// Отображаемая фамилия пользователя. Для ботов это поле не возвращается
    /// </summary>
    [JsonPropertyName("last_name")]
    public string? LastName { get; set; }

    /// <summary>
    /// Никнейм бота или уникальное публичное имя пользователя.
    /// В случае с пользователем может быть null, если тот недоступен или имя не задано
    /// </summary>
    [JsonPropertyName("username")]
    public string? UserName { get; set; }

    /// <summary>
    /// true, если это бот
    /// </summary>
    [JsonPropertyName("is_bot")]
    public bool IsBot { get; set; }

    /// <summary>
    /// Время последней активности пользователя или бота в MAX (Unix-время в миллисекундах).
    /// Если пользователь отключил в настройках профиля мессенджера MAX возможность видеть,
    /// что он в сети онлайн, поле может не возвращаться
    /// </summary>
    [JsonPropertyName("last_activity_time")]
    public long LastActivityTime { get; set; }

    /// <summary>
    /// Устаревшее поле, скоро будет удалено
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Описание пользователя или бота. до 16000 символов.
    /// В случае с пользователем может принимать значение null, если описание не заполнено
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// URL аватара пользователя или бота в уменьшенном размере
    /// </summary>
    [JsonPropertyName("avatar_url")]
    public string? AvatarUrl { get; set; }

    /// <summary>
    /// URL аватара пользователя или бота в полном размере
    /// </summary>
    [JsonPropertyName("full_avatar_url")]
    public string? FullAvatarUrl { get; set; }

    /// <summary>
    /// Время последней активности пользователя в чате.
    /// Может быть устаревшим для суперчатов (равно времени вступления)
    /// </summary>
    [JsonPropertyName("last_access_time")]
    public long LastAccessTime { get; set; }

    /// <summary>
    /// Является ли пользователь владельцем чата
    /// </summary>
    [JsonPropertyName("is_owner")]
    public bool IsOwner { get; set; }

    /// <summary>
    /// Является ли пользователь администратором чата
    /// </summary>
    [JsonPropertyName("is_admin")]
    public bool IsAdmin { get; set; }

    /// <summary>
    /// Дата присоединения к чату в формате Unix time
    /// </summary>
    [JsonPropertyName("join_time")]
    public long JoinTime { get; set; }

    /// <summary>
    /// Перечень прав пользователя
    /// </summary>
    [JsonPropertyName("permissions")]
    public ChatAdminPermission[]? Permissions { get; set; }

    /// <summary>
    /// Заголовок, который будет показан на клиенте.
    /// Если пользователь администратор или владелец и ему не установлено это название,
    /// то поле не передаётся, клиенты на своей стороне подменят на "владелец" или "админ"
    /// </summary>
    [JsonPropertyName("alias")]
    public string? Alias { get; set; }
}