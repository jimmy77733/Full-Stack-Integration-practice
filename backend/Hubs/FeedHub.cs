using Microsoft.AspNetCore.SignalR;
// 這裡省略資料庫和服務注入...

public class FeedHub : Hub
{
    // 1. 客戶端呼叫這個方法來發出按讚動作
    public async Task SendLikeUpdate(int postId)
    {
        // 實際應用中，這裡會更新資料庫的 Likes 欄位
        // 然後廣播通知
        
        // 假設從資料庫獲取更新後的 Likes 數量
        int newLikes = new Random().Next(10, 50); 
        
        // 【優化點 5: 分組更新】: 只推送 ID 和新的 Likes 數量
        // 客戶端只需要更新數字，而不是重新載入整個列表
        await Clients.All.SendAsync("ReceiveLikeUpdate", postId, newLikes); 
    }

    // 2. 客戶端呼叫這個方法來發送評論
    public async Task SendComment(Comment comment)
    {
        // 實際應用中，這裡會將評論存入資料庫
        // 然後廣播新評論給所有用戶
        await Clients.All.SendAsync("ReceiveNewComment", comment);
    }
}