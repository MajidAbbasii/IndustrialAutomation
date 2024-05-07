using System.Net.Http.Json;
using Industrial.Client.Models.Notification;

namespace Industrial.Client.Services;

public class NotificationsService : INotificationsService
{
    private const string UriRequest = "sample-data/notifications.json";
    private readonly HttpClient _httpClient;

    public NotificationsService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<IEnumerable<NotificationModel>> GetNotifications()
    {
        var notifications = await _httpClient.GetFromJsonAsync<IEnumerable<NotificationModel>>(UriRequest);
        return notifications ?? throw new InvalidOperationException();
    }

    public async Task<IEnumerable<NotificationModel>> GetActiveNotifications()
    {
        var notifications = await _httpClient.GetFromJsonAsync<IEnumerable<NotificationModel>>(UriRequest);
        var activeNotifications = (notifications ?? throw new InvalidOperationException()).Where(n => n.IsActive);
        return activeNotifications ?? throw new InvalidOperationException();
    }
}