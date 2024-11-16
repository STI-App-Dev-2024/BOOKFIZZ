namespace BSCS3A_BOOKFIZZ;

public partial class WelcomePage : ContentPage
{
    public WelcomePage()
    {
        InitializeComponent();
    }

    private async void SignUpButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new SignUp1());
    }
    private async void OnLabelTapped(object sender, EventArgs e)
    {


        // You can add further functionality like navigating to a new page
        // Example: await Navigation.PushAsync(new SomeOtherPage());
        await Navigation.PushAsync(new LogIn());
    }
}