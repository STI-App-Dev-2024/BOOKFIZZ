using Microsoft.Maui.Controls;

namespace BookFizz
{
    public partial class ViewNovel : ContentPage
    {
        public ViewNovel()
        {
            InitializeComponent(); // Initializes the UI components from XAML
        }

        // Back button navigation to MainPage
        private async void OnBackButtonTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        // Forward button navigation back to ViewNovel (or any other page you want)
        private async void OnForwardButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ViewNovel()); // This can navigate to a new instance of ViewNovel
        }
    }
}
