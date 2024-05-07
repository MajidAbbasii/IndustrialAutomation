using Microsoft.AspNetCore.Components;
using Industrial.Client.Models;

namespace Industrial.Client.Components.Shared;

public partial class UserMenu
{
    [Parameter] public string Class { get; set; }
    [EditorRequired] [Parameter] public UserModel User { get; set; }
}