namespace BotMax.Http.Messages;

public class GetVideoInfoRequest(string videoToken)
{
    /// <summary>
    /// Токен видео-вложения
    /// </summary>
    public string VideoToken { get; private set; } = videoToken;
}
