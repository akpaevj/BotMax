using System.Text.Json.Serialization;

namespace BotMax.Http.Models.MarkupElements;

public class StrongMarkupElement : MarkupElement
{
    /// <summary>
    /// Тип элемента разметки
    /// </summary>
    [JsonPropertyName("type")]
    public override string Type => "strong";
}
