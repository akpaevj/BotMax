namespace BotMax.Http.Models.Attachments;

using BotMax.Http.Models.Attachments.Payloads;
using System.Text.Json.Serialization;

public class AudioAttachment : Attachment
{
    [JsonPropertyName("type")]
    public override string Type => "audio";

    [JsonPropertyName("payload")]
    public MediaAttachmentPayload Payload { get; set; }

    /// <summary>
    /// Аудио транскрипция
    /// </summary>
    [JsonPropertyName("transcription")]
    public string? Transcription { get; set; }
}
