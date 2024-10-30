using System;
using Microsoft.Maui.Controls;

namespace BookFizz
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // Navigate to Account page when profile image button is clicked
        private async void OnProfileImageClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("Account");
        }

        // Navigate to Category page when category icon button is clicked
        private async void OnCategoriesIconClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("Categories");
        }

        // Navigate to Notification page when notification icon button is clicked
        private async void OnNotificationIconClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("Notification");
        }

        // Add your existing navigation methods here for bottom navigation
        private void NavigateToHome(object sender, EventArgs e)
        {
            // Check if already on the Home page, do nothing if true
            if (Navigation.NavigationStack.LastOrDefault() is MainPage)
            {
                // Optionally show a message or feedback here
                return; // Do nothing, as we are already on the Home page
            }
        }

        private async void NavigateToCommunity(object sender, EventArgs e)
        {
            // Pop all pages to the root page to clear the stack
            await Shell.Current.Navigation.PopToRootAsync(false);

            // Navigate to the Community page
            await Shell.Current.GoToAsync("Community");
        }


        private async void NavigateToCreatePage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreatePage());
        }

        private async void NavigateToMessages(object sender, EventArgs e)
        {
            // Pop all pages to the root page to clear the stack
            await Shell.Current.Navigation.PopToRootAsync(false);

            // Navigate to the Community page
            await Shell.Current.GoToAsync("Messages");
        }

        private async void NavigateToLibrary(object sender, EventArgs e)
        {
            // Pop all pages to the root page to clear the stack
            await Shell.Current.Navigation.PopToRootAsync(false);

            // Navigate to the Messages page
            await Shell.Current.GoToAsync("Library");
        }
    }
}
