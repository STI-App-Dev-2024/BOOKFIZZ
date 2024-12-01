namespace BSCS3A_BOOKFIZZ;

public partial class SearchPage : ContentPage
{
	public SearchPage()
	{
		InitializeComponent();
	}
    protected override void OnAppearing()
    {
        base.OnAppearing();
        NavigationPage.SetHasNavigationBar(this, false);
    }

    private void Searchpage_Clicked(object sender, EventArgs e)
    {

    }
}