using BotMax.Http.Models.Attachments;
using BotMax.Http.Models.MarkupElements;
using System.Text.Json.Serialization;

namespace BotMax.Http.Models;

/// <summary>
/// Схема, представляющая тело сообщения
/// </summary>
public class MessageBody
{
    /// <summary>
    /// Уникальный ID сообщения
    /// </summary>
    [JsonPropertyName("mid")]
    public string Mid { get; set; }

    /// <summary>
    /// ID последовательности сообщения в чате
    /// </summary>
    [JsonPropertyName("seq")]
    public long Seq { get; set; }

    /// <summary>
    /// Новый текст сообщения
    /// </summary>
    [JsonPropertyName("text")]
    public string Text { get; set; }

    /// <summary>
    /// Вложения сообщения. Могут быть одним из типов Attachment. Смотрите описание схемы
    /// </summary>
    [JsonPropertyName("attachments")]
    public Attachment[]? Attachments { get; set; }

    /// <summary>
    /// Разметка текста сообщения
    /// </summary>
    [JsonPropertyName("markup")]
    public MarkupElement[]? Markup { get; set; }
}
