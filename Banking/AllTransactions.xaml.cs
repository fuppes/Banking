namespace Banking;

public partial class AllTransactions : ContentPage
{
	public AllTransactions()
	{
		InitializeComponent();
	}

    private async void CounterBtn20_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Transactions), true);
    }
}