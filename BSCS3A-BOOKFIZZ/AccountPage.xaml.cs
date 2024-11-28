namespace BSCS3A_BOOKFIZZ;

public partial class AccountPage : ContentPage
{
	public AccountPage()
	{
		InitializeComponent();
	}

    private void backprofile_Clicked(object sender, EventArgs e)
    {

    }

    private void ProfileAccount_Clicked(object sender, EventArgs e)
    {

    }

    private void btnhistory_Clicked(object sender, EventArgs e)
    {

    }

    private void btnfollowings_Clicked(object sender, EventArgs e)
    {

    }

    private void btnpersonalInfo_Clicked(object sender, EventArgs e)
    {

    }

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushModalAsync(new WelcomePage());
    }
}