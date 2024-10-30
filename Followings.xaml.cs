using Microsoft.Maui.Controls;

namespace BookFizz
{
    public partial class Followings : ContentPage
    {
        public Followings()
        {
            InitializeComponent();
            // Display the "Following" list by default
            DisplayFollowingList();
        }

        // Display Followers list with dummy data
        private void OnFollowersButtonClicked(object sender, EventArgs e)
        {
            FollowersButton.BackgroundColor = Colors.Orange;
            FollowersButton.TextColor = Colors.White;
            FollowingButton.BackgroundColor = Colors.LightGray;
            FollowingButton.TextColor = Colors.Black;

            // Dummy data for followers
            UserList.ItemsSource = new[] { "Maya", "John Doe", "Jane Smith" };
        }

        // Display Following list with dummy data
        private void OnFollowingButtonClicked(object sender, EventArgs e)
        {
            FollowingButton.BackgroundColor = Colors.Orange;
            FollowingButton.TextColor = Colors.White;
            FollowersButton.BackgroundColor = Colors.LightGray;
            FollowersButton.TextColor = Colors.Black;

            // Dummy data for following
            UserList.ItemsSource = new[] { "Wollly", "Alice", "Bob" };
        }

        // Helper method to display following list on page load
        private void DisplayFollowingList()
        {
            FollowingButton.BackgroundColor = Colors.Orange;
            FollowingButton.TextColor = Colors.White;
            FollowersButton.BackgroundColor = Colors.LightGray;
            FollowersButton.TextColor = Colors.Black;

            // Set default following list
            UserList.ItemsSource = new[] { "Wollly", "Alice", "Bob" };
        }
    }
}
