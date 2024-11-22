namespace Banking;

public partial class Einnahmen : ContentPage
{
	public Einnahmen()
	{
		InitializeComponent();
	}

    private async void CounterBtn18_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Transactions), true);
    }
}