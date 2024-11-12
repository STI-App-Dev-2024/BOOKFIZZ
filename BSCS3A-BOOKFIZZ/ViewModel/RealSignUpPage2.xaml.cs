namespace BSCS3A_BOOKFIZZ;

public partial class RealSignUpPage2 : ContentPage
{
	public RealSignUpPage2()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new homepage());
    }

    private void BackButton_Clicked(object sender, EventArgs e)
    {

    }

    private void reentereye_Clicked(object sender, EventArgs e)
    {

    }

    private void CreatePassEye_Clicked(object sender, EventArgs e)
    {

    }
}