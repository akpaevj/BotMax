using BotMax.Http.Models;
using System.Text.Json.Serialization;

namespace BotMax.Http.Messages;

public class SubscriptionsResponse
{
    /// <summary>
    /// Список текущих подписок
    /// </summary>
    [JsonPropertyName("subscriptions")]
    public List<Subscription> Subscriptions { get; set; }
}
