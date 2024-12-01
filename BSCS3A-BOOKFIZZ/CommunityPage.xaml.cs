namespace BSCS3A_BOOKFIZZ;

public partial class CommunityPage : ContentPage
{
	public CommunityPage()
	{
		InitializeComponent();
	}

    private async void Communityback_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }

    private async void PostCommunity_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new CommunityPost());
    }
}