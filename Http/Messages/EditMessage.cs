using BotMax.Http.Models;
using BotMax.Http.Models.AttachmentRequests;

namespace BotMax.Http.Messages;

public class EditMessage()
{
    /// <summary>
    /// Новый текст сообщения
    /// </summary>
    public string? Text { get; set; }

    /// <summary>
    /// Вложения сообщения. Если пусто, все вложения будут удалены
    /// </summary>
    public AttachmentRequest[]? Attachments { get; set; }

    /// <summary>
    /// Ссылка на сообщение
    /// </summary>
    public NewMessageLink? Link { get; set; }

    /// <summary>
    /// Если false, участники чата не будут уведомлены (по умолчанию true)
    /// </summary>
    public bool? Notify { get; set; }

    /// <summary>
    /// Если установлен, текст сообщения будет форматирован данным способом
    /// </summary>
    public TextFormat? Format { get; set; }
}
