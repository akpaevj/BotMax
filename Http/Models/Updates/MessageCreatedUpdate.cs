namespace BotMax.Http.Models.Updates;

using BotMax.Http.Models;

using System.Text.Json.Serialization;

public class MessageCreatedUpdate : Update
{
    /// <summary>
    /// Новое созданное сообщение
    /// </summary>
    [JsonPropertyName("message")]
    public Message Message { get; set; }

    /// <summary>
    /// Текущий язык пользователя в формате IETF BCP 47. Доступно только в диалогах
    /// </summary>
    [JsonPropertyName("user_locale")]
    public string UserLocale { get; set; }
}
