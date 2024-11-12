namespace BSCS3A_BOOKFIZZ;

public partial class ForgotPasswordPage : ContentPage
{
	public ForgotPasswordPage()
	{
		InitializeComponent();
	}

    private async void forgotpassBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new SignUpPage());
    }
}