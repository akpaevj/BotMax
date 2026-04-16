using BotMax.Http.Models;

namespace BotMax.Http.Messages;

public class PostMessageRequest(NewMessageBody message)
{
    /// <summary>
    /// Если вы хотите отправить сообщение пользователю, укажите его ID
    /// </summary>
    public long? UserId { get; set; }

    /// <summary>
    /// Если сообщение отправляется в чат, укажите его ID
    /// </summary>
    public long? ChatId { get; set; }

    /// <summary>
    /// Если false, сервер не будет генерировать превью для ссылок в тексте сообщения
    /// </summary>
    public bool? DisableLinkPreview { get; set; }

    /// <summary>
    /// Отправляемое сообщение
    /// </summary>
    public NewMessageBody Message { get; private set; } = message;
}
