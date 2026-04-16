namespace BotMax.Http.Models;

using System.Text.Json.Serialization;

/// <summary>
/// Миниатюра видео
/// </summary>
public class VideoThumbnail
{
    /// <summary>
    /// URL изображения
    /// </summary>
    [JsonPropertyName("url")]
    public string Url { get; set; }
}
