namespace BSCS3A_BOOKFIZZ;

public partial class ForgotPass : ContentPage
{
	public ForgotPass()
	{
		InitializeComponent();
	}

    private async void forgotpassBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
}