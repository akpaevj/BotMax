namespace BotMax.Http.Models.Updates;

using BotMax.Http.Models;

using System.Text.Json.Serialization;

public class MessageCallbackUpdate : Update
{
    [JsonPropertyName("callback")]
    public Callback? Callback { get; set; }

    /// <summary>
    /// Изначальное сообщение, содержащее встроенную клавиатуру. Может быть null, если оно было удалено к моменту, когда бот получил это обновление
    /// </summary>
    [JsonPropertyName("message")]
    public Message? Message { get; set; }

    /// <summary>
    /// Текущий язык пользователя в формате IETF BCP 47. Доступно только в диалогах
    /// </summary>
    [JsonPropertyName("user_locale")]
    public string? UserLocale { get; set; }
}
