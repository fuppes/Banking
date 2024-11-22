using Banking.Models;

namespace Banking
{
    [QueryProperty("username", "username")]
    public partial class MainPage : ContentPage
    {
        int count = 0;
        private string _username;
        public string Username
        {
            get => _username;
            set
            {
                _username = value;
                OnPropertyChanged();
            }

        }

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }


        private async void CounterBtn_Clicked(object sender, EventArgs e)
        {
            User.Username = UsernameEntry.Text;
            User.Password = PasswordEntry.Text;

            Random random = new Random();
            User.Accountbalance = random.Next(0, 5000000) + random.NextDouble();
            User.Accountbalance=Math.Round(User.Accountbalance,2);
            User.IBAN = "DE75512108001245126199";
            var uriBuilder = new UriBuilder
            {
                Path = "//Dashboard",
                Query = $"?username={Uri.EscapeDataString(User.Username)}&accountbalance={Uri.EscapeDataString(User.Accountbalance.ToString())}"
            };
            string uri = uriBuilder.Uri.ToString();
            
            // Navigation zur Dashboard-Seite mit Query-Parameter
            await Shell.Current.GoToAsync(uri, true);
        }
    }

}
