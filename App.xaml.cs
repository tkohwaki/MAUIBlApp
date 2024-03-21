namespace MAUIBlApp;

public partial class App : Application
{
	public App(IHostIF hif)
	{
		InitializeComponent();
		// MainPageのロード(IHostIF(Singleton)インスタンスを渡す)
		MainPage = new MainPage(hif);
	}
}
