namespace BSCS3A_BOOKFIZZ;

public partial class SignUpPage : ContentPage
{
	public SignUpPage()
	{
		InitializeComponent();
	}

    private async void LoginBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new homepage());
    }

    private void seeBtn_Clicked(object sender, EventArgs e)
    {

    }

    private void LogInBackBtn_Clicked(object sender, EventArgs e)
    {

    }
}