namespace BotMax.Http.Models.Attachments.Payloads;

using BotMax.Http.Models.Users;
using System.Text.Json.Serialization;

public class ContactAttachmentPayload : AttachmentPayload
{
    /// <summary>
    /// Информация о пользователе в формате VCF.
    /// </summary>
    [JsonPropertyName("vcf_info")]
    public string? VcfInfo { get; set; }

    /// <summary>
    /// Информация о пользователе
    /// </summary>
    [JsonPropertyName("max_info")]
    public User? MaxInfo { get; set; }
}
