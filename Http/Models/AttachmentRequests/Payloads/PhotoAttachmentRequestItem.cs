namespace BotMax.Http.Models.AttachmentRequests.Payloads;

using System.Text.Json.Serialization;

public class PhotoAttachmentRequestItem
{
    /// <summary>
    /// Закодированная информация загруженного изображения
    /// </summary>
    [JsonPropertyName("token")]
    public string Token { get; set; }
}
