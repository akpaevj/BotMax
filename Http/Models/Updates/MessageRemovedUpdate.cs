namespace BotMax.Http.Models.Updates;

using System.Text.Json.Serialization;

public class MessageRemovedUpdate : Update
{
    /// <summary>
    /// ID удаленного сообщения
    /// </summary>
    [JsonPropertyName("message_id")]
    public string MessageId { get; set; }

    /// <summary>
    /// ID чата, где сообщение было удалено
    /// </summary>
    [JsonPropertyName("chat_id")]
    public long? ChatId { get; set; }

    /// <summary>
    /// Пользователь, удаливший сообщение
    /// </summary>
    [JsonPropertyName("user_id")]
    public long? UserId { get; set; }
}
