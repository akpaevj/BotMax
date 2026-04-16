namespace BotMax.Http.Models.AttachmentRequests;

using BotMax.Http.Models.AttachmentRequests.Payloads;
using System.Text.Json.Serialization;

public abstract class UploadedInfoAttachmentRequest : AttachmentRequest
{
    /// <summary>
    /// Это информация, которую вы получите, как только аудио/видео будет загружено
    /// </summary>
    [JsonPropertyName("payload")]
    public UploadedInfo Payload { get; set; }
}
