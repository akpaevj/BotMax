namespace BotMax.Http.Models.AttachmentRequests;

using System.Text.Json.Serialization;

public class FileAttachmentRequest : UploadedInfoAttachmentRequest
{
    /// <summary>
    /// Тип вложения
    /// </summary>
    [JsonPropertyName("type")]
    public override string Type => "file";
}
