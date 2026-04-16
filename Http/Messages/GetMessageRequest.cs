namespace BotMax.Http.Messages;

public class GetMessageRequest(string messageId)
{
    /// <summary>
    /// ID сообщения (mid), чтобы получить одно сообщение в чате
    /// </summary>
    public string MessageId { get; private set; } = messageId;
}
