namespace BotMax.Http.Messages;

public class UpdatesRequest
{
    /// <summary>
    /// Максимальное количество обновлений для получения
    /// </summary>
    public int? Limit { get; set; }

    /// <summary>
    /// Список типов обновлений, которые бот хочет получить (например, message_created, message_callback)
    /// </summary>
    public string[]? MessageTypes { get; set; }
}
