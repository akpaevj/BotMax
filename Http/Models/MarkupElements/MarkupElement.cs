using System.Text.Json.Serialization;

namespace BotMax.Http.Models.MarkupElements;

/// <summary>
/// Разметка текста сообщения
/// </summary>
[JsonDerivedType(typeof(StrongMarkupElement))]
[JsonDerivedType(typeof(EmphasizedMarkupElement))]
[JsonDerivedType(typeof(MonospacedMarkupElement))]
[JsonDerivedType(typeof(LinkMarkupElement))]
[JsonDerivedType(typeof(StrikethroughMarkupElement))]
[JsonDerivedType(typeof(UnderlineMarkupElement))]
[JsonDerivedType(typeof(UserMentionMarkupElement))]
public abstract class MarkupElement
{
    /// <summary>
    /// Тип элемента разметки
    /// </summary>
    [JsonPropertyName("type")]
    public abstract string Type { get; }

    /// <summary>
    /// Индекс начала элемента разметки в тексте. Нумерация с нуля
    /// </summary>
    [JsonPropertyName("from")]
    public int From { get; set; }

    /// <summary>
    /// Длина элемента разметки
    /// </summary>
    [JsonPropertyName("length")]
    public int Length { get; set; }
}
