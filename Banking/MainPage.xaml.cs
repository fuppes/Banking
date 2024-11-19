using Banking.Models;

namespace Banking
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

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
            User user= new User();
            user.Username=UsernameEntry.Text;

            user.Password=PasswordEntry.Text;

            Random random = new Random();
            var tempvalue = random.Next(0, 5000000);
            user.Accountbalance =tempvalue+ random.NextDouble();

            user.IBAN = "DE75512108001245126199";
            await Shell.Current.GoToAsync(nameof(Dashboard),true);
        }
    }

}
