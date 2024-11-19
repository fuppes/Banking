namespace Banking;

public partial class Überweisungen : ContentPage
{
	public Überweisungen()
	{
		InitializeComponent();
	}

    private async void CounterBtn5_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Überweisungen), true);
    }

    private async void CounterBtn6_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Überweisungen), true);
    }
}