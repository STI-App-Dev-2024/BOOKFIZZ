namespace BSCS3A_BOOKFIZZ;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
<<<<<<< HEAD
        

    }

=======
	}
	//welcomepage
>>>>>>> c8088262794ced46510eec5250f02b616ae3de45
    private async void SignUpButton_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushModalAsync(new RealSignUpPage1());
        
    }

}
