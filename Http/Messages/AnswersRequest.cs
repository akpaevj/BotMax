using BotMax.Http.Models;

namespace BotMax.Http.Messages;

public class AnswersRequest(string callbackId, Answer answer)
{
    /// <summary>
    /// Если вы хотите отправить сообщение пользователю, укажите его ID
    /// </summary>
    public string CallbackId { get; set; } = callbackId;

    /// <summary>
    /// Отправляемый ответ
    /// </summary>
    public Answer Answer { get; private set; } = answer;
}
