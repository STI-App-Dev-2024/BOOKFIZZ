namespace BSCS3A_BOOKFIZZ
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            NavigationPage.SetHasNavigationBar(this, false);
        }
        
        private async void Notif_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Notification());

        }

        private void Category_Clicked(object sender, EventArgs e)
        {

        }

        private async void Profile_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new AccountPage());
        }

        private async void Search_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new SearchPage());
        }

        private void Home_Clicked(object sender, EventArgs e)
        {

        }

        private async void Community_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new CommunityPage());
        }

        private void createadd_Clicked(object sender, EventArgs e)
        {

        }

        private void Message_Clicked(object sender, EventArgs e)
        {

        }

        private void Library_Clicked(object sender, EventArgs e)
        {

        }

        private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
        {
            await Navigation.PushModalAsync(new SearchPage());
        }
    }

}
