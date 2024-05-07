using Industrial.Client.Models.Notification;

namespace Industrial.Client.Services;

public interface INotificationsService
{
    Task<IEnumerable<NotificationModel>> GetNotifications();
    Task<IEnumerable<NotificationModel>> GetActiveNotifications();
}