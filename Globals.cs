using Microsoft.AspNetCore.SignalR;
using Microsoft.Azure.SignalR.Samples.ChatRoom;

public static class Globals
{
    public static IHubContext<Chat> ChatHub { get; set; }
}