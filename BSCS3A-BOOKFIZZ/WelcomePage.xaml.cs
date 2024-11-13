namespace BSCS3A_BOOKFIZZ;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}
	//welcomepage
    private async void SignUpButton_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushModalAsync(new RealSignUpPage1());
        
    }

}
