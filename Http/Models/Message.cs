namespace BotMax.Http.Models;

using BotMax.Http.Models.Users;
using System;
using System.Text.Json.Serialization;

/// <summary>
/// Сообщение в чате
/// </summary>
public class Message
{
    /// <summary>
    /// Пользователь, отправивший сообщение
    /// </summary>
    [JsonPropertyName("sender")]
    public User? Sender { get; set; }

    /// <summary>
    /// Получатель сообщения. Может быть пользователем или чатом
    /// </summary>
    [JsonPropertyName("recipient")]
    public Recipient Recipient { get; set; }

    /// <summary>
    /// Время создания сообщения в формате Unix-time
    /// </summary>
    [JsonPropertyName("timestamp")]
    public long Timestamp { get; set; }

    /// <summary>
    /// Пересланное или ответное сообщение
    /// </summary>
    [JsonPropertyName("link")]
    public LinkedMessage? Link { get; set; }

    /// <summary>
    /// Содержимое сообщения. Текст + вложения. Может быть null, если сообщение содержит только пересланное сообщение
    /// </summary>
    [JsonPropertyName("body")]
    public MessageBody Body { get; set; }

    /// <summary>
    /// Статистика сообщения. Возвращается только для постов в каналах
    /// </summary>
    [JsonPropertyName("stat")]
    public MessageStat? Stat { get; set; }

    /// <summary>
    /// Публичная ссылка на пост в канале. Отсутствует для диалогов и групповых чатов
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}
