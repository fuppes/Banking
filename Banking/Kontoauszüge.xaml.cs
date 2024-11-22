namespace Banking;

public partial class Kontoauszüge : ContentPage
{
	public Kontoauszüge()
	{
		InitializeComponent();
	}

    private async void CounterBtn12_Clicked(object sender, EventArgs e)
    {
        var uriBuilder = new UriBuilder
        {
            Path = "//Dashboard"
        };
        string uri = uriBuilder.Uri.ToString();

        await Shell.Current.GoToAsync(uri, true);
    }

    private async void CounterBtn13_Clicked(object sender, EventArgs e)
    {

        await Shell.Current.GoToAsync(nameof(Kontoauszugfehler), true);
    }
}