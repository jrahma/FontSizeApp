namespace FontSizeApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        Resources["LabelFontSize"] = Convert.ToInt32(Preferences.Get("LabelFontSize", "25"));

		MainPage = new AppShell();
	}
}

