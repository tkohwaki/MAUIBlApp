namespace MAUIBlApp;

public interface IHostIF {
    /// <summary>
    /// 共有データ
    /// </summary>
    /// <value>カウント値</value>
    public int Count { get; set; }
    /// <summary>
    /// イベントハンドラ
    /// </summary>
    public event EventHandler ComponentEvent;
    /// <summary>
    /// クライアント側からイベント発生
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public void FireClientEvent(object sender, EventArgs e);
    /// <summary>
    /// ホスト側からクライアントの画面更新
    /// </summary>
    /// <value></value>
    public Action RefreshClient { get; set; }
}
/// <summary>
/// IHostIFの実装
/// </summary>
public class HostInterface : IHostIF {
    public int Count { get; set; } = 0;
    public event EventHandler ComponentEvent = null!;
    public void FireClientEvent(object sender, EventArgs e) {
        ComponentEvent?.Invoke(sender,e);
    }
    public Action RefreshClient {get; set; } = null!;
}