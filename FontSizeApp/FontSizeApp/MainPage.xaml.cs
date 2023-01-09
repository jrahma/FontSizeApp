namespace FontSizeApp;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		Shell.Current.GoToAsync(nameof(Page2));
	}

    void SliderFontSize_ValueChanged(System.Object sender, Microsoft.Maui.Controls.ValueChangedEventArgs e)
    {
        Preferences.Set("LabelFontSize", (int)Math.Round(SliderFontSize.Value));
        Resources["LabelFontSize"] = Convert.ToInt32(Preferences.Get("LabelFontSize", "25"));

        LabelFontSize.FontSize = (int)Resources["LabelFontSize"];
        CounterBtn.FontSize = (int)Resources["LabelFontSize"];
		LabelFontSizeInt.Text = Resources["LabelFontSize"].ToString();
    }
}


