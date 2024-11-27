namespace BSCS3A_BOOKFIZZ
{

	public partial class SignUp2 : ContentPage
	{
        private bool isPasswordVisible = false;
        private bool isReenterPasswordVisible = false;
        private readonly User _user;
        public SignUp2(User user)
		{
			InitializeComponent();
            _user = user;
		}
        private void CreatePassEye_Clicked(object sender, EventArgs e)
        {
            // Toggle password visibility for the main password field
            isPasswordVisible = !isPasswordVisible;
            EntryPass.IsPassword = !isPasswordVisible;

            // Change eye icon to indicate visibility state
            CreatePassEye.Source = isPasswordVisible ? "eye.png" : "eye.png";
        }

        private void reentereye_Clicked(object sender, EventArgs e)
        {
            // Toggle password visibility for the confirm password field
            isReenterPasswordVisible = !isReenterPasswordVisible;
            reenter.IsPassword = !isReenterPasswordVisible;

            // Change eye icon to indicate visibility state
            reentereye.Source = isReenterPasswordVisible ? "eye.png" : "eye.png";
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            string username = EntryUser.Text;
            string email = EntryEmail.Text;
            string password = EntryPass.Text;
            string confirmPassword = reenter.Text;

            // Basic validation
            if (string.IsNullOrWhiteSpace(username))
            {
                await DisplayAlert("Error", "Username cannot be empty.", "OK");
                return;
            }

            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
            {
                await DisplayAlert("Error", "Enter a valid email address.", "OK");
                return;
            }

            if (string.IsNullOrWhiteSpace(password) || password.Length < 6)
            {
                await DisplayAlert("Error", "Password must be at least 6 characters long.", "OK");
                return;
            }

            if (password != confirmPassword)
            {
                await DisplayAlert("Error", "Passwords do not match.", "OK");
                return;
            }

            // Simulate account creation
            await DisplayAlert("Success", $"Account created for {username}!", "OK");
            Navigation.PushModalAsync(new MainPage());

            // Reset fields after successful registration
            EntryUser.Text = string.Empty;
            EntryEmail.Text = string.Empty;
            EntryPass.Text = string.Empty;
            reenter.Text = string.Empty;
        }
    }
}
