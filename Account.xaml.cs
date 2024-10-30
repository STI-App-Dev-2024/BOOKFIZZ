using Microsoft.Maui.Controls;

namespace BookFizz
{
    public partial class Account : ContentPage
    {
        public Account()
        {
            InitializeComponent();
        }

        private async void OnPersonalInfoTapped(object sender, EventArgs e)
        {
            // Navigate to PersonalInfoPage
            await Navigation.PushAsync(new PersonalInfo());
        }

        private async void OnFollowingsTapped(object sender, EventArgs e)
        {
            // Navigate to FollowingsPage (you will need to create this page)
            await Navigation.PushAsync(new Followings());
        }

        private async void OnHistoryTapped(object sender, EventArgs e)
        {
            // Navigate to HistoryPage (you will need to create this page)
            await Navigation.PushAsync(new History());
        }

        private async void OnLogoutTapped(object sender, EventArgs e)
        {
            bool confirm = await DisplayAlert("Log Out", "Are you sure you want to log out?", "Yes", "No");
            if (confirm)
            {
                // Logic to log out and return to the login page
                await Navigation.PopToRootAsync(); // Assuming the login page is the root page
            }
        }
    }
}
