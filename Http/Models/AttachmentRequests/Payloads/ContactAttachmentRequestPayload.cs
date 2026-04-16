namespace BotMax.Http.Models.AttachmentRequests.Payloads;

using System.Text.Json.Serialization;

public class ContactAttachmentRequestPayload : AttachmentRequestPayload
{
    /// <summary>
    /// Имя контакта
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// ID контакта, если он зарегистирован в MAX
    /// </summary>
    [JsonPropertyName("contact_id")]
    public long? ContactId { get; set; }

    /// <summary>
    /// Телефон контакта в формате VCF
    /// </summary>
    [JsonPropertyName("vcf_info")]
    public string? VcfInfo { get; set; }

    /// <summary>
    /// Полная информация о контакте в формате VCF
    /// </summary>
    [JsonPropertyName("vcf_phone")]
    public string? VcfPhone { get; set; }
}
