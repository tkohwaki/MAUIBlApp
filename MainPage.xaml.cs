namespace MAUIBlApp;

public partial class MainPage : ContentPage
{
	private readonly IHostIF _hostif;
	/// <summary>
	/// コンストラクタ(IHostIFのインスタンスを取得)
	/// </summary>
	/// <param name="hostif"></param>
	public MainPage(IHostIF hostif)
	{
		InitializeComponent();
		_hostif = hostif;
		// Client(Blazor Component)イベントハンドラ設定
		_hostif.ComponentEvent += OnClientEvent;
		lblNumber.Text = _hostif.Count.ToString();
	}
	/// <summary>
	/// ボタンクリック時処理
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	public void OnBtnClick(object sender, EventArgs e) {
		// インターフェースのカウントアップ
		_hostif.Count++;
		lblNumber.Text = _hostif.Count.ToString();
		// Client(Blazor Component)へイベント通知
		_hostif.FireHostEvent(sender,e);
	}
	/// <summary>
	/// Client(Blazor Component)イベントハンドラ
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	public void OnClientEvent(object? sender, EventArgs e) {
		lblNumber.Text = _hostif.Count.ToString();
	}
}
