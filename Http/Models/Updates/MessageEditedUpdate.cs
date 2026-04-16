namespace BotMax.Http.Models.Updates;

using BotMax.Http.Models;

using System.Text.Json.Serialization;

public class MessageEditedUpdate : Update
{
    /// <summary>
    /// Отредактированное сообщение
    /// </summary>
    [JsonPropertyName("message")]
    public Message Message { get; set; }
}
