using Microsoft.Maui.Controls;

namespace BookFizz
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new LoginPage(); // Start with LoginPage instead of AppShell
        }
    }
}
