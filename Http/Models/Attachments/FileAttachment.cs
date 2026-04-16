namespace BotMax.Http.Models.Attachments;

using BotMax.Http.Models.Attachments.Payloads;
using System.Text.Json.Serialization;

public class FileAttachment : Attachment
{
    [JsonPropertyName("type")]
    public override string Type => "file";

    [JsonPropertyName("payload")]
    public FileAttachmentPayload Payload { get; set; }

    /// <summary>
    /// Имя загруженного файла
    /// </summary>
    [JsonPropertyName("filename")]
    public string? FileName { get; set; }

    /// <summary>
    /// Размер файла в байтах
    /// </summary>
    [JsonPropertyName("size")]
    public long? Size { get; set; }
}
