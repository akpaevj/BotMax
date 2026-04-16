namespace BotMax.Http.Models;

using BotMax.Http.Models.Users;
using System.Collections.Generic;
using System.Text.Json.Serialization;

/// <summary>
/// Объект, представляющий чат (групповой чат или диалог)
/// </summary>
public class Chat
{
    /// <summary>ID чата</summary>
    [JsonPropertyName("chat_id")]
    public long ChatId { get; set; }

    /// <summary>Тип чата</summary>
    [JsonPropertyName("type")]
    public ChatType Type { get; set; }

    /// <summary>Статус чата</summary>
    [JsonPropertyName("status")]
    public ChatStatus Status { get; set; }

    /// <summary>Отображаемое название чата. Может быть null для диалогов</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>Иконка чата</summary>
    [JsonPropertyName("icon")]
    public Image? Icon { get; set; }

    /// <summary>Время последнего события в чате</summary>
    [JsonPropertyName("last_event_time")]
    public long LastEventTime { get; set; }

    /// <summary>Количество участников чата. Для диалогов всегда 2</summary>
    [JsonPropertyName("participants_count")]
    public int ParticipantsCount { get; set; }

    /// <summary>ID владельца чата</summary>
    [JsonPropertyName("owner_id")]
    public long? OwnerId { get; set; }

    /// <summary>Участники чата с временем последней активности. Может быть null, если запрашивается список чатов</summary>
    [JsonPropertyName("participants")]
    public object? Participants { get; set; }

    /// <summary>Доступен ли чат публично (для диалогов всегда false)</summary>
    [JsonPropertyName("is_public")]
    public bool IsPublic { get; set; }

    /// <summary>Ссылка на чат</summary>
    [JsonPropertyName("link")]
    public string? Link { get; set; }

    /// <summary>Описание чата</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Данные о пользователе в диалоге (только для чатов типа "dialog")</summary>
    [JsonPropertyName("dialog_with_user")]
    public UserWithPhoto? DialogWithUser { get; set; }

    /// <summary>ID сообщения, содержащего кнопку, через которую был инициирован чат</summary>
    [JsonPropertyName("chat_message_id")]
    public string? ChatMessageId { get; set; }

    /// <summary>Закреплённое сообщение в чате (возвращается только при запросе конкретного чата)</summary>
    [JsonPropertyName("pinned_message")]
    public Message? PinnedMessage { get; set; }
}