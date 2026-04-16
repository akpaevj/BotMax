using System.Text.Json.Serialization;

namespace BotMax.Http.Models.MarkupElements;

public class LinkMarkupElement : MarkupElement
{
    /// <summary>
    /// Тип элемента разметки
    /// </summary>
    [JsonPropertyName("type")]
    public override string Type => "link";

    /// <summary>
    /// URL ссылки
    /// </summary>
    [JsonPropertyName("url")]
    public string Url { get; set; }
}
