namespace Banking;

public partial class Überweisung_erfolgreich : ContentPage
{
	public Überweisung_erfolgreich()
	{
		InitializeComponent();
	}

    private async void CounterBtn17_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Dashboard), true);
    }
}