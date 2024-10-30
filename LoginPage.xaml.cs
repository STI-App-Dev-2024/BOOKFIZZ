namespace BookFizz
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            string username = UsernameEntry.Text;
            string password = PasswordEntry.Text;

            if (username == "user" && password == "password")
            {
                // On successful login, navigate to the MainPage (AppShell)
                Application.Current.MainPage = new AppShell();
            }
            else
            {
                await DisplayAlert("Login Failed", "Invalid username or password.", "OK");
            }
        }
    }
}

