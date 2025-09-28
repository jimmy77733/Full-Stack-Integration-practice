// 1. 定義滾動函式
function scrollMessagesToBottom() {
    // 使用 'messages-container' 類別來找到聊天容器
    // 更好的做法是使用 ID，但我們先用 querySelector
    var container = document.querySelector('.messages-container');
    if (container) {
        container.scrollTop = container.scrollHeight;
    }
}

// 2. 匯出函式：讓 Blazor 可以存取
// 我們將它包裝在一個物件裡匯出
export {
    scrollMessagesToBottom
};