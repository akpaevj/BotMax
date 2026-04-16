namespace BotMax.Http.Models;

using BotMax.Http.Models.AttachmentRequests;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

/// <summary>
/// Тело нового сообщения для отправки или редактирования
/// </summary>
public class NewMessageBody
{
    /// <summary>
    /// Новый текст сообщения, до 4000 символов
    /// </summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }

    /// <summary>
    /// Вложения сообщения. Если пусто, все вложения будут удалены
    /// </summary>
    [JsonPropertyName("attachments")]
    public AttachmentRequest[]? Attachments { get; set; }

    /// <summary>
    /// Ссылка на сообщение (ответ или пересылка)
    /// </summary>
    [JsonPropertyName("link")]
    public NewMessageLink? Link { get; set; }

    /// <summary>
    /// Если false, участники чата не будут уведомлены (по умолчанию true)
    /// </summary>
    [JsonPropertyName("notify")]
    public bool? Notify { get; set; } = true;

    /// <summary>
    /// Если установлен, текст сообщения будет форматирован данным способом
    /// </summary>
    [JsonPropertyName("format")]
    public TextFormat? Format { get; set; }
}