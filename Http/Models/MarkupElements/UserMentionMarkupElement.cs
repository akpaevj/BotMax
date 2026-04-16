using System.Text.Json.Serialization;

namespace BotMax.Http.Models.MarkupElements;

public class UserMentionMarkupElement : MarkupElement
{
    /// <summary>
    /// Тип элемента разметки
    /// </summary>
    [JsonPropertyName("type")]
    public override string Type => "user_mention";

    /// <summary>
    /// @username упомянутого пользователя
    /// </summary>
    [JsonPropertyName("user_link")]
    public string? UserLink { get; set; }

    /// <summary>
    /// ID упомянутого пользователя без имени
    /// </summary>
    [JsonPropertyName("user_id")]
    public long? UserId { get; set; }
}
