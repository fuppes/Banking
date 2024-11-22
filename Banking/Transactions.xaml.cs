namespace Banking;

public partial class Transactions : ContentPage
{
	public Transactions()
	{
		InitializeComponent();
	}

    private async void CounterBtn8_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(AllTransactions), true);
    }

    private async void CounterBtn9_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Ausgaben), true);
    }

    private async void CounterBtn10_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Einnahmen), true);
    }

    private async void CounterBtn11_Clicked(object sender, EventArgs e)
    {
        var uriBuilder = new UriBuilder
        {
            Path = "//Dashboard"
        };
        string uri = uriBuilder.Uri.ToString();

        await Shell.Current.GoToAsync(uri, true);
    }
}