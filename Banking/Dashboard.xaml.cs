using System.ComponentModel;
using System.Runtime.CompilerServices;
using Banking.Models;

namespace Banking;

public partial class Dashboard : ContentPage, INotifyPropertyChanged
{

    public string _username;


    
    public string username { get => _username; set { _username = value;
            OnPropertyChanged();
            LoadItem(value);

           
        } }

    public Dashboard()
	{
		InitializeComponent();
        

		
        
	}

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);

        //var test = Shell.Current.CurrentState.Location.AbsoluteUri;
        // Navigationspfad abrufen
        var query = Shell.Current.CurrentState.Location.Query;
        
        // Query-Parameter parsen
        if (!string.IsNullOrEmpty(query))
        {
            var parameters = System.Web.HttpUtility.ParseQueryString(query);
            _username = parameters["username"];
            Console.WriteLine($"Empfangener Parameter: {username}");
        }
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
    private void LoadItem(string id)
    {
        // Lade Logik, z. B. Daten aus einer Datenbank abrufen
        Console.WriteLine($"Lade Item mit der ID: {id}");
    }

    // Für die UI-Updates
    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}