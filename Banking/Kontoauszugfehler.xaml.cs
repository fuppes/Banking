namespace Banking;

public partial class Kontoauszugfehler : ContentPage
{
	public Kontoauszugfehler()
	{
		InitializeComponent();
	}

    private async void CounterBtn14_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Kontoauszüge), true);
    }

    private async void CounterBtn14_Clicked_1(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Kontoauszüge), true);
    }
}