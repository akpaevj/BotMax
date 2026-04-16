namespace BotMax.Http.Models.AttachmentRequests.Payloads;

using System.Text.Json.Serialization;

public class PhotoAttachmentRequestPayload : AttachmentRequestPayload
{
    /// <summary>
    /// Любой внешний URL изображения, которое вы хотите прикрепить
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>
    /// Токен существующего вложения
    /// </summary>
    [JsonPropertyName("token")]
    public string? Token { get; set; }

    /// <summary>
    /// Токены, полученные после загрузки изображений
    /// </summary>
    [JsonPropertyName("photos")]
    public PhotoAttachmentRequestItem[]? Photos { get; set; }
}
