using System;
using Microsoft.Maui.Controls;

namespace BookFizz
{
    public partial class Messages : ContentPage
    {
        public Messages()
        {
            InitializeComponent();
        }

        // Navigate to Account page when profile image is clicked
        private async void NavigateToAccount()
        {
            await Navigation.PushAsync(new Account());
        }

        // Navigate to Category page when category icon is clicked
        private async void NavigateToCategory()
        {
            await Navigation.PushAsync(new Categories());
        }

        // Navigate to Notification page when notification icon is clicked
        private async void NavigateToNotification()
        {
            await Navigation.PushAsync(new Notification());
        }

        // Navigate to Home page when home button is clicked
        private async void NavigateToHome(object sender, EventArgs e)
        {
            // Pop all pages to the root page to clear the stack
            await Shell.Current.Navigation.PopToRootAsync(false);

            // Navigate to the Home page
            await Shell.Current.GoToAsync("Home");
        }

        // Navigate to Community page when community button is clicked
        private async void NavigateToCommunity(object sender, EventArgs e)
        {
            // Pop all pages to the root page to clear the stack
            await Shell.Current.Navigation.PopToRootAsync(false);

            // Navigate to the Community page
            await Shell.Current.GoToAsync("Community");
        }


        // Navigate to Create page when plus button is clicked
        private async void NavigateToCreatePage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreatePage());
        }


        // Navigate to Messages page when messages button is clicked
        private void NavigateToMessages(object sender, EventArgs e)
        {
            // Check if already on the Home page, do nothing if true
            if (Navigation.NavigationStack.LastOrDefault() is Messages)
            {
                // Optionally show a message or feedback here
                return; // Do nothing, as we are already on the Home page
            }
        }

        // Navigate to Library page when library button is clicked
        private async void NavigateToLibrary(object sender, EventArgs e)
        {
            // Pop all pages to the root page to clear the stack
            await Shell.Current.Navigation.PopToRootAsync(false);

            // Navigate to the Messages page
            await Shell.Current.GoToAsync("Library");
        }
    }
}
