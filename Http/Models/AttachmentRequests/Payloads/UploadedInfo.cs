namespace BotMax.Http.Models.AttachmentRequests.Payloads;

using System.Text.Json.Serialization;

public class UploadedInfo : AttachmentRequestPayload
{
    /// <summary>
    /// Токен — уникальный ID загруженного медиафайла
    /// </summary>
    [JsonPropertyName("token")]
    public string? Token { get; set; }
}
