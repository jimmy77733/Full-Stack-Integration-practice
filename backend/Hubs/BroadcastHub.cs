using Microsoft.AspNetCore.SignalR;

// Hub 繼承自 Microsoft.AspNetCore.SignalR.Hub
public class BroadcastHub : Hub
{
    // 這是客戶端可以呼叫的伺服器方法
    public async Task SendMessage(string user, string message)
    {
        // Clients.All：將訊息廣播給所有連接到此 Hub 的客戶端
        // "ReceiveMessage"：這是客戶端需要訂閱的事件名稱
        await Clients.All.SendAsync("ReceiveMessage", user, message);
    }
}
