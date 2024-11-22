using System.ComponentModel;
using System.Runtime.CompilerServices;
using Banking.Models;

namespace Banking;

[QueryProperty(nameof(Username), "username")]
[QueryProperty(nameof(AccountBalance), "accountbalance")]
public partial class Dashboard : ContentPage, INotifyPropertyChanged
{
    private string _username;
    private string _accountBalance;

    public string Username
    {
        get => _username;
        set
        {
            if (_username != value)
            {
                _username = value;
                OnPropertyChanged();
                LoadName(value); // Lade Daten nur, wenn der Wert sich ändert
            }
        }
    }

    public string AccountBalance
    {
        get => _accountBalance;
        set
        {
            if (_accountBalance != value)
            {
                _accountBalance = value;
                OnPropertyChanged();
                LoadBalance(value); // Lade Daten nur, wenn der Wert sich ändert
            }
        }
    }

    public Dashboard()
    {
        InitializeComponent();
    }

    private void LoadName(string username)
    {
        lblUser.Text += username;
    }

    private void LoadBalance(string balance)
    {
        lblBalance.Text += balance + " €";
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

    private async void CounterBtn21_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.Navigation.PopToRootAsync();
    }

    // Für die UI-Updates
    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
