using System.Text.Json.Serialization;

namespace BotMax.Http.Models;

/// <summary>
/// Статистика сообщения. Возвращается только для постов в каналах
/// </summary>
public class MessageStat
{
    /// <summary>
    /// Количество пользователей, которые увидели пост в канале. Просмотр засчитывается, когда пост попадает в область видимости экрана
    /// </summary>
    [JsonPropertyName("views")]
    public int Views { get; set; }
}
