namespace BotMax.Http.Messages;

public class EditMessageRequest(string messageId, EditMessage editMessage)
{
    /// <summary>
    /// ID редактируемого сообщения
    /// </summary>
    public string MessageId { get; set; } = messageId;

    /// <summary>
    /// Тело сообщения
    /// </summary>
    public EditMessage EditMessage { get; set; } = editMessage;
}