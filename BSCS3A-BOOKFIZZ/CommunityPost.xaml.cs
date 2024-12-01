namespace BSCS3A_BOOKFIZZ;

public partial class CommunityPost : ContentPage
{
	public CommunityPost()
	{
		InitializeComponent();
	}

    private async void postCommunity_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    
    }

    private async void PostBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }

    private void AddImagePost_Clicked(object sender, EventArgs e)
    {

    }
}