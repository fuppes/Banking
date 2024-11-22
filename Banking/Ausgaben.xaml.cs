namespace Banking;

public partial class Ausgaben : ContentPage
{
	public Ausgaben()
	{
		InitializeComponent();
	}

    private async void CounterBtn19_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Transactions), true);
    }
}