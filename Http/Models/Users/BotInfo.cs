namespace BotMax.Http.Models.Users;

using System.Collections.Generic;
using System.Text.Json.Serialization;

public class BotInfo
{
    [JsonPropertyName("user_id")]
    public long UserId { get; set; }

    [JsonPropertyName("first_name")]
    public string FirstName { get; set; }

    [JsonPropertyName("last_name")]
    public string? LastName { get; set; }

    [JsonPropertyName("username")]
    public string? UserName { get; set; }

    [JsonPropertyName("is_bot")]
    public bool IsBot { get; set; }

    [JsonPropertyName("last_activity_time")]
    public long LastActivityTime { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("avatar_url")]
    public string? AvatarUrl { get; set; }

    [JsonPropertyName("full_avatar_url")]
    public string? FullAvatarUrl { get; set; }

    [JsonPropertyName("commands")]
    public BotCommand[]? Commands { get; set; }
}
