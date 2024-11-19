using Banking.Models;

namespace Banking;

[QueryProperty("user", "1")]
[QueryProperty("test", "2")]
public partial class Dashboard : ContentPage
{
    public User User { get; set; }
	public Dashboard(User user)
	{
		InitializeComponent();

        this.User = user;

		
        
	}

    private async void CounterBtn2_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Überweisungen), true);
    }

    private async void CounterBtn3_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Transactions), true);
    }

    private async void CounterBtn4_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Kontoauszüge), true);
    }
}