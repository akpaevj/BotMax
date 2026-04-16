namespace BotMax.Http.Models.Attachments;

using BotMax.Http.Models;
using BotMax.Http.Models.Attachments.Payloads;
using System.Text.Json.Serialization;

public class VideoAttachment : Attachment
{
    [JsonPropertyName("type")]
    public override string Type => "video";

    [JsonPropertyName("payload")]
    public MediaAttachmentPayload Payload { get; set; }

    /// <summary>
    /// Миниатюра видео
    /// </summary>
    [JsonPropertyName("thumbnail")]
    public VideoThumbnail? Thumbnail { get; set; }

    /// <summary>
    /// Ширина видео
    /// </summary>
    [JsonPropertyName("width")]
    public int? Width { get; set; }

    /// <summary>
    /// Высота видео
    /// </summary>
    [JsonPropertyName("height")]
    public int? Height { get; set; }

    /// <summary>
    /// Длина видео в секундах
    /// </summary>
    [JsonPropertyName("duration")]
    public int? Duration { get; set; }
}
