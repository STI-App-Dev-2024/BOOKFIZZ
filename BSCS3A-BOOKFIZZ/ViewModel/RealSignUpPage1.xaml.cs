
using Microsoft.Maui.Controls;
using Microsoft.Maui.Media; // Import media-related namespaces
using System;
>>>>>>> c8088262794ced46510eec5250f02b616ae3de45
namespace BSCS3A_BOOKFIZZ
{

    public partial class RealSignUpPage1 : ContentPage
    {
        public RealSignUpPage1()
        {
            InitializeComponent();
        }


        private async void Backsign_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(".");
            {


            }
        }


        private async void NextBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new RealSignUpPage2());
        }

        private void addBtn_Clicked(object sender, EventArgs e)
        {

        private void OnEntryTextChanged(object sender, TextChangedEventArgs e)
        {
            // Check if all fields have text (are not empty or whitespace)
            bool isFirstNameFilled = !string.IsNullOrWhiteSpace(FirstName.Text);
            bool isMiddleNameFilled = !string.IsNullOrWhiteSpace(MiddleName.Text);
            bool isLastNameFilled = !string.IsNullOrWhiteSpace(LastName.Text);

            // Enable the Next button only if all fields are filled
            NextBtn.IsEnabled = isFirstNameFilled && isMiddleNameFilled && isLastNameFilled;
        }

      

        private async void addBtn_Clicked(object sender, EventArgs e)
        {
            try
            {
                // Check if the device supports picking photos
                if (MediaPicker.Default.IsCaptureSupported)
                {
                    // Open the photo gallery
                    var result = await MediaPicker.PickPhotoAsync(new MediaPickerOptions
                    {
                        Title = "Select Profile Picture"
                    });

                    // Check if a photo was picked
                    if (result != null)
                    {
                        // Load the selected image as a stream
                        var stream = await result.OpenReadAsync();

                        // Set the image source of an Image control
                        SelectedImage.Source = ImageSource.FromStream(() => stream);
                    }
                }
                else
                {
                    await DisplayAlert("Error", "Photo capture is not supported on this device.", "OK");
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"An error occurred: {ex.Message}", "OK");
            }
        }

       
       
        private async void NextBtn_Clicked(object sender, EventArgs e)
        {
            // Implement your Next button logic here
            if (string.IsNullOrWhiteSpace(FirstName.Text) || string.IsNullOrWhiteSpace(MiddleName.Text) || string.IsNullOrWhiteSpace(LastName.Text))
            {
                await DisplayAlert("Error", "Please fill in all fields.", "OK");
                return;
            }

            await Navigation.PushAsync(new homepage());
        }
        private async void Backsign_Clicked(object sender, EventArgs e)
        {
            // Navigate back to the previous page
            await Navigation.PopAsync();

        }
    }
}
