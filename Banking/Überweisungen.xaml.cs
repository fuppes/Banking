namespace Banking;

public partial class Überweisungen : ContentPage
{
	public Überweisungen()
	{
		InitializeComponent();
	}

    private async void CounterBtn5_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Letzte_Überweisungen), true);
    }

    private async void CounterBtn6_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Überweisung_tätigen), true);
    }

    private async void CounterBtn7_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Dashboard), true);
    }
}