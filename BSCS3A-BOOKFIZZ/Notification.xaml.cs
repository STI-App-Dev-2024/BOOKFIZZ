

namespace BSCS3A_BOOKFIZZ;

public partial class Notification : ContentPage
{
	public Notification()
	{
		InitializeComponent();
	}

    private async void backnotif_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }

    private void NotifSetting_Clicked(object sender, EventArgs e)
    {

    }
}