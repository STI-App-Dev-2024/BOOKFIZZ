namespace BSCS3A_BOOKFIZZ
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
            MainPage = new NavigationPage(new SearchPage());
            MainPage = new NavigationPage(new CommunityPost());
            MainPage = new NavigationPage(new CommunityPage());
            MainPage = new NavigationPage(new ForgotPass());
            MainPage = new NavigationPage(new AccountPage());
            MainPage = new NavigationPage(new LogIn());
            MainPage = new NavigationPage(new SignUp2(new User()));
            MainPage = new NavigationPage(new SignUp1());
            MainPage = new NavigationPage(new MainPage());
            MainPage = new NavigationPage(new WelcomePage());
            


        }

    }
}

