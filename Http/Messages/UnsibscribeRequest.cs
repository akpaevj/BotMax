namespace BotMax.Http.Messages;

public class UnsibscribeRequest(string url)
{
    /// <summary>
    /// URL, который нужно удалить из подписок на WebHook
    /// </summary>
    public string Url { get; private set; } = url;
}
