namespace BotMax.Http.Models.AttachmentRequests;

using BotMax.Http.Models.AttachmentRequests.Payloads;
using System.Text.Json.Serialization;

public class ImageAttachmentRequest : AttachmentRequest
{
    /// <summary>
    /// Тип вложения
    /// </summary>
    [JsonPropertyName("type")]
    public override string Type => "image";

    /// <summary>
    /// Запрос на прикрепление изображения (все поля являются взаимоисключающими)
    /// </summary>
    [JsonPropertyName("payload")]
    public PhotoAttachmentRequestPayload Payload { get; set;}
}
