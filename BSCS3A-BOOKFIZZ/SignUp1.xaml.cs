namespace BSCS3A_BOOKFIZZ
{

    public partial class SignUp1 : ContentPage
    {
        public SignUp1()
        {
            InitializeComponent();
            Shell.SetNavBarIsVisible(this, false);
        }

        private void NextBtn_Clicked(object sender, EventArgs e)
        {
            // Get user input from the form fields
            string firstName = FirstName.Text?.Trim();
            string middleName = MiddleName.Text?.Trim();
            string lastName = LastName.Text?.Trim();

            // Validate input
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                DisplayAlert("Error", "First Name and Last Name are required.", "OK");
                return;
            }

            // Create a temporary user object (can later be connected to a database)
            var user = new User
            {
                FirstName = firstName,
                MiddleName = middleName,
                LastName = lastName
            };

            // Simulate saving data or passing it to the next page
            Navigation.PushAsync(new SignUp2(user));
        }

        private void AddPicture_Clicked(object sender, EventArgs e)
        {

        }
    }

    // Temporary User class to hold data (can be extended to support database)
    public class User
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
    }
}