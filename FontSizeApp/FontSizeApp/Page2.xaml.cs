namespace FontSizeApp;

public partial class Page2 : ContentPage
{
	public Page2()
	{
		InitializeComponent();
	}

    private void CloseClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }
}
