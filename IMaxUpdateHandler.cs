using BotMax.Http.Models.Updates;

namespace BotMax
{
    public interface IMaxUpdateHandler
    {
        Task HandleErrorAsync(Exception exception, CancellationToken cancellationToken);
        Task HandleUpdateAsync(Update update, CancellationToken cancellationToken);
    }
}
