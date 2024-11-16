namespace BSCS3A_BOOKFIZZ
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
            MainPage = new NavigationPage(new WelcomePage());
            MainPage = new NavigationPage(new SignUp1());
            
        }
    }
}
