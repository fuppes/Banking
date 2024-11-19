namespace Banking
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(Dashboard), typeof(Dashboard));
            Routing.RegisterRoute(nameof(Überweisungen), typeof(Überweisungen));
            Routing.RegisterRoute(nameof(Transactions), typeof(Transactions));
            Routing.RegisterRoute(nameof(Kontoauszüge), typeof(Kontoauszüge));
        }
    }
}
