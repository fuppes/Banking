namespace Banking;

public partial class Kontoauszüge : ContentPage
{
	public Kontoauszüge()
	{
		InitializeComponent();
	}

    private async void CounterBtn12_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Dashboard), true);
    }

    private async void CounterBtn13_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Kontoauszugfehler), true);
    }
}