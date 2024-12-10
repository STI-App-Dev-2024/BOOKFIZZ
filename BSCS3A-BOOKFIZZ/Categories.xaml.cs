namespace BSCS3A_BOOKFIZZ;

public partial class Categories : ContentPage
{
	public Categories()
	{
		InitializeComponent();
	}

    private async void backCategories_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
}