namespace MAUIBlApp;

public interface IHostIF {
    /// <summary>
    /// 共有データ
    /// </summary>
    /// <value>カウント値</value>
    public int Count { get; set; }
    /// <summary>
    /// クライアントイベントハンドラ
    /// </summary>
    public event EventHandler ComponentEvent;
    /// <summary>
    /// クライアント側からイベント発生
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public void FireClientEvent(object sender, EventArgs e);
    /// <summary>
    /// ホストイベントハンドラ
    /// </summary> <summary>
    /// 
    /// </summary>
    public event EventHandler HostEvent;
    //
    /// <summary>
    /// ホスト側からイベント発生
    /// </summary>
    /// <value></value>
    public void FireHostEvent(object sender, EventArgs e);
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
    public event EventHandler HostEvent = null!;
    public void FireHostEvent(object sender, EventArgs e) {
        HostEvent?.Invoke(sender,e);
    }
}