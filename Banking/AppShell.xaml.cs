namespace Banking
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("Dashboard", typeof(Dashboard));
            Routing.RegisterRoute(nameof(Überweisungen), typeof(Überweisungen));
            Routing.RegisterRoute(nameof(Transactions), typeof(Transactions));
            Routing.RegisterRoute(nameof(Kontoauszüge), typeof(Kontoauszüge));
            Routing.RegisterRoute(nameof(Kontoauszugfehler), typeof(Kontoauszugfehler));
            Routing.RegisterRoute(nameof(Überweisung_tätigen), typeof(Überweisung_tätigen));
            Routing.RegisterRoute(nameof(Überweisung_erfolgreich), typeof(Überweisung_erfolgreich));
            Routing.RegisterRoute(nameof(Letzte_Überweisungen), typeof(Letzte_Überweisungen));
            Routing.RegisterRoute(nameof(AllTransactions), typeof(AllTransactions));
            Routing.RegisterRoute(nameof(Einnahmen), typeof(Einnahmen));
            Routing.RegisterRoute(nameof(Ausgaben), typeof(Ausgaben));
            Routing.RegisterRoute("MainPage", typeof(MainPage));
        }
    }
}
