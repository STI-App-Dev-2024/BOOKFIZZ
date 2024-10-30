using System;
using Microsoft.Maui.Controls;

namespace BookFizz
{
    public partial class Community : ContentPage
    {
        public Community()
        {
            InitializeComponent();
        }

        // Navigate to Home page when home button is clicked
        private async void NavigateToHome(object sender, EventArgs e)
        {
            if (Navigation.NavigationStack.LastOrDefault() is not MainPage)
            {
                await Navigation.PushAsync(new MainPage());
            }
        }

        // Handle Community button click without navigation
        private void NavigateToCommunity(object sender, EventArgs e)
        {
            // Check if already on the Community page, do nothing if true
            if (Navigation.NavigationStack.LastOrDefault() is Community)
            {
                // Optionally show a message or feedback here
                return; // Do nothing, as we are already on the Community page
            }

            // If you need to navigate to Community from other pages, you can use:
            // await Shell.Current.GoToAsync("Community");
        }

        // Navigate to Create page when plus button is clicked
        private async void NavigateToCreatePage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreatePage()); // Opens CreatePage without tabs
        }


        // Navigate to Messages page when messages button is clicked
        private async void NavigateToMessages(object sender, EventArgs e)
        {
            // Pop all pages to the root page to clear the stack
            await Shell.Current.Navigation.PopToRootAsync(false);

            // Navigate to the Community page
            await Shell.Current.GoToAsync("Messages");
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
