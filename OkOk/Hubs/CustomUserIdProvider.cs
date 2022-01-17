using Microsoft.AspNetCore.SignalR;
using OkOk.Data;
using OkOk.Models.Identity;

public class CustomUserIdProvider : IUserIdProvider
{
    public string GetUserId(HubConnectionContext connection)
    {
        return connection.User.Identity.Name;
    }
}
