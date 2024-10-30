using Microsoft.Maui.Controls;

namespace BookFizz 
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("Home", typeof(MainPage));
            Routing.RegisterRoute("Account", typeof(Account));
            Routing.RegisterRoute("Categories", typeof(Categories));
            Routing.RegisterRoute("Notification", typeof(Notification));
            Routing.RegisterRoute("Community", typeof(Community));
            Routing.RegisterRoute("Messages", typeof(Messages));
            Routing.RegisterRoute("Library", typeof(Library));
            Routing.RegisterRoute("CreatePage", typeof(CreatePage));

        }

    }
}
