using System.Text.Json.Serialization;

namespace BotMax.Http.Models.MarkupElements;

public class MonospacedMarkupElement : MarkupElement
{
    /// <summary>
    /// Тип элемента разметки
    /// </summary>
    [JsonPropertyName("type")]
    public override string Type => "monospaced";
}
