namespace BotMax.Http.Messages;

public class DeleteMessageRequest(string messageId)
{
    /// <summary>
    /// ID удаляемого сообщения
    /// </summary>
    public string MessageId { get; private set; } = messageId;
}
