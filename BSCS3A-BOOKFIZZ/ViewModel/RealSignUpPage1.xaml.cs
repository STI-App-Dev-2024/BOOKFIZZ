namespace BSCS3A_BOOKFIZZ
{

    public partial class RealSignUpPage1 : ContentPage
    {
        public RealSignUpPage1()
        {
            InitializeComponent();
        }

        private async void Backsign_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(".");
            {


            }
        }


        private async void NextBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new RealSignUpPage2());
        }

        private void addBtn_Clicked(object sender, EventArgs e)
        {
        }
    }
}