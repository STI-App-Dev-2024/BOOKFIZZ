namespace BSCS3A_BOOKFIZZ;

public partial class NotificationSettings : ContentPage
{
	public NotificationSettings()
	{
		InitializeComponent();
	}

    private async void backnotifSetting_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }

    private void friendreqToggle_Toggled(object sender, ToggledEventArgs e)
    {

    }

    private void NewBookToggle_Toggled(object sender, ToggledEventArgs e)
    {

    }

    private void NewRecoToggle_Toggled(object sender, ToggledEventArgs e)
    {

    }

    private void AuthorUpdateToggle_Toggled(object sender, ToggledEventArgs e)
    {

    }

    private void CommentsToggle_Toggled(object sender, ToggledEventArgs e)
    {

    }
}