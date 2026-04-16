using BotMax.Http.Models.Attachments.Payloads;
using System.Text.Json.Serialization;

namespace BotMax.Http.Messages;

public class GetVideoInfoResponse
{
    /// <summary>
    /// Токен видео-вложения
    /// </summary>
    [JsonPropertyName("token")]
    public string Token { get; private set; }

    /// <summary>
    /// URL-ы для скачивания или воспроизведения видео. Может быть null, если видео недоступно
    /// </summary>
    [JsonPropertyName("urls")]
    public VideoUrls? Urls { get; private set; }

    /// <summary>
    /// Миниатюра видео
    /// </summary>
    [JsonPropertyName("thumbnail")]
    public PhotoAttachmentPayload? Thumbnail { get; private set; }

    /// <summary>
    /// Ширина видео
    /// </summary>
    [JsonPropertyName("width")]
    public int Width { get; private set; }

    /// <summary>
    /// Высота видео
    /// </summary>
    [JsonPropertyName("height")]
    public int Height { get; private set; }

    /// <summary>
    /// Длина видео в секундах
    /// </summary>
    [JsonPropertyName("duration")]
    public int Duration { get; private set; }
}
