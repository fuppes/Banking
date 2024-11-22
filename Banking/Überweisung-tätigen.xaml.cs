namespace Banking;

public partial class Überweisung_tätigen : ContentPage
{
	public Überweisung_tätigen()
	{
		InitializeComponent();
	}

    private async void CounterBtn15_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Überweisung_erfolgreich), true);
    }

    private async void CounterBtn22_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Überweisungen), true);
    }
}