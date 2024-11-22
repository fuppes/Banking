namespace Banking;

public partial class Überweisung_erfolgreich : ContentPage
{
	public Überweisung_erfolgreich()
	{
		InitializeComponent();
	}

    private async void CounterBtn17_Clicked(object sender, EventArgs e)
    {
        var uriBuilder = new UriBuilder
        {
            Path = "//Dashboard"
        };
        string uri = uriBuilder.Uri.ToString();

        await Shell.Current.GoToAsync(uri, true);
    }
}