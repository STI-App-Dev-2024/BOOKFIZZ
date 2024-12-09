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

        private async void profileImage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new AccountPage());
        }
        

        private async void Category_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Categories());
        }

        private async void Notification_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Notification());
        }
        

        private void searchBtn_SearchButtonPressed(object sender, EventArgs e)
        {

        }

        private void homeBtn_Clicked(object sender, EventArgs e)
        {

        }

        private async void CommunityBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new CommunityPage());
        }
        

        private void AddBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void messageBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void LibraryBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void ABtn_Clicked(object sender, EventArgs e)
        {

        }

        private void P1Btn_Clicked(object sender, EventArgs e)
        {

        }

        private void aBtN_Clicked_1(object sender, EventArgs e)
        {

        }

        private void R1Btn_Clicked(object sender, EventArgs e)
        {

        }
    }
}