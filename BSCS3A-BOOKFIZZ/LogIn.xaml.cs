namespace BSCS3A_BOOKFIZZ
{

    public partial class LogIn : ContentPage
    {
        public LogIn()
        {
            InitializeComponent();

        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            NavigationPage.SetHasNavigationBar(this, false);
        }
        private void LoginBtn_Clicked(object sender, EventArgs e)

        {
            // Hardcoded credentials for now. Replace this logic later with database authentication
            string username = ((Entry)this.FindByName("LoginUsername")).Text;
            string password = LoginPass.Text;

            if (IsValidLogin(username, password))
            {
                DisplayPromptAsync("Success", "Logged in successfully!");
                // Navigate to the next page, for example, a dashboard page
                // await Navigation.PushAsync(new DashboardPage());
            }
            else
            {
                DisplayAlert("Error", "Invalid credentials. Please try again.", "OK");
            }
        }

        // Event handler to toggle password visibility
        private void seeBtn_Clicked(object sender, EventArgs e)
        {
            // Toggle password visibility
            LoginPass.IsPassword = !LoginPass.IsPassword;
            // Optionally, you can change the button image to reflect the password visibility state
            if (LoginPass.IsPassword)
            {
                seeBtn.Source = "eye.png"; // Use the "eye" image for hidden password
            }
            else
            {
                seeBtn.Source = "eye_off.png"; // Use the "eye_off" image for visible password
            }
        }

        // Simple login validation function (replace with database logic later)
        private bool IsValidLogin(string username, string password)
        {
            // Hardcoded validation (replace this with your database query later)
            const string validUsername = "user";
            const string validPassword = "password123";

            return username == validUsername && password == validPassword;
        }

        // Event handler for Forgot Password label (you can modify it later)
        //private async void ForgotPassword_Clicked(object sender, EventArgs e)
        //{
            // You can navigate to a "Forgot Password" page or show a dialog for resetting the password
           // await DisplayAlert("Forgot Password", "Redirecting to reset password page.", "OK");
            // Example: Navigate to password reset page
            // await Navigation.PushAsync(new ResetPasswordPage());
        //}

        private async void backLogin_Clicked(object sender, EventArgs e)
        { 
            await Navigation.PopModalAsync();

        }

        private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
        {
            await Navigation.PushModalAsync(new ForgotPass());
        }
    }
}