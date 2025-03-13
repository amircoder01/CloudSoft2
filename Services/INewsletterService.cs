using CloudSoft2.Models;

namespace CloudSoft2.Services;

public interface INewsletterService
{
    Task<OperationResult> SignUpForNewsletterAsync(Subscriber subscriber);
    Task<OperationResult> OptOutFromNewsletterAsync(string email);
    Task<IEnumerable<Subscriber>> GetActiveSubscribersAsync();
}