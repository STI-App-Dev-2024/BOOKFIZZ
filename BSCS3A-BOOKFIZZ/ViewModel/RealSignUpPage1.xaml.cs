namespace BSCS3A_BOOKFIZZ;

public partial class RealSignUpPage1 : ContentPage
{
    public RealSignUpPage1()
    {
        InitializeComponent();
    }

    private async void Backsign_Clicked(object sender, EventArgs e)
    {
        if (Navigation.NavigationStack.Count > 1)
        {

            Navigation.PopModalAsync();
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
