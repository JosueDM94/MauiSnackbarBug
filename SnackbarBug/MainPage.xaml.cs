using CommunityToolkit.Maui.Alerts;

namespace SnackbarBug;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
        //Application.Current.MainPage.DisplaySnackbar("Lorem ipsum dolor sit amet, consectetur adipiscing elit.", duration: TimeSpan.FromSeconds(5));
        Shell.Current.DisplaySnackbar("Lorem ipsum dolor sit amet, consectetur adipiscing elit.", duration: TimeSpan.FromSeconds(5));
	}
}