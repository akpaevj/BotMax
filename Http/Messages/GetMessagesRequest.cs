namespace BotMax.Http.Messages;

public class GetMessagesRequest
{
    /// <summary>
    /// ID чата, чтобы получить сообщения из определённого чата. Обязательный параметр, если не указан message_ids
    /// </summary>
    public long? ChatId { get; set; }

    /// <summary>
    /// Список ID сообщений, которые нужно получить (через запятую). Обязательный параметр, если не указан chat_id
    /// </summary>
    public string[]? MessageIds { get; set; }

    /// <summary>
    /// Время начала для запрашиваемых сообщений (в формате Unix timestamp)
    /// </summary>
    public long? From { get; set; }

    /// <summary>
    /// Время окончания для запрашиваемых сообщений (в формате Unix timestamp)
    /// </summary>
    public long? To { get; set; }

    /// <summary>
    /// Максимальное количество сообщений в ответе
    /// </summary>
    public int? Count { get; set; }
}
