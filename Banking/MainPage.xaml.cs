using Banking.Models;

namespace Banking
{
    [QueryProperty("username", "username")]
    public partial class MainPage : ContentPage
    {
        int count = 0;
        private string _username;
        public string Username { 
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
            var tempvalue = random.Next(0, 5000000);
            User.Accountbalance = tempvalue + random.NextDouble();

            User.IBAN = "DE75512108001245126199";

            string baseUri = Shell.Current.CurrentState.Location.ToString();
            baseUri = baseUri.TrimEnd('/');
            await Shell.Current.GoToAsync($"//Dashboard?username={User.Username}", true);
        }
    }
    
}
