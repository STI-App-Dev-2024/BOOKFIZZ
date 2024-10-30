using System;
using Microsoft.Maui.Controls;

namespace BookFizz
{
    public partial class Library : ContentPage
    {
        public Library()
        {
            InitializeComponent();
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
        private async void NavigateToMessages(object sender, EventArgs e)
        {
            // Pop all pages to the root page to clear the stack
            await Shell.Current.Navigation.PopToRootAsync(false);

            // Navigate to the Community page
            await Shell.Current.GoToAsync("Messages");
        }

        // Navigate to Library page when library button is clicked
        private void NavigateToLibrary(object sender, EventArgs e)
        {
            // Check if already on the Community page, do nothing if true
            if (Navigation.NavigationStack.LastOrDefault() is Library)
            {
                // Optionally show a message or feedback here
                return; 
            }
        }
    }
}
