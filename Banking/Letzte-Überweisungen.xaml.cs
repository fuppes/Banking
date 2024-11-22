namespace Banking;

public partial class Letzte_Überweisungen : ContentPage
{
	public Letzte_Überweisungen()
	{
		InitializeComponent();
	}

    private async void CounterBtn15_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Überweisungen), true);
    }
}