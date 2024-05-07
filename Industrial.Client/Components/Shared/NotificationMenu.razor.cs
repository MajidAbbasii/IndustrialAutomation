using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using MudBlazor;
using MudBlazor.Utilities;
using Industrial.Client.Models.Notification;
using Industrial.Client.Services;

namespace Industrial.Client.Components.Shared;

public partial class NotificationMenu : MudComponentBase
{
    private string Classname =>
        new CssBuilder()
            .AddClass(Class)
            .Build();
    
    [Parameter] public IEnumerable<NotificationModel>? Notifications { get; set; }
    [Parameter] public EventCallback<MouseEventArgs> OnClickViewAll { get; set; }
}