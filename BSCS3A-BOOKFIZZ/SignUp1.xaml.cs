using Microsoft.Maui.Storage;
using Microsoft.Maui.Controls;
using System;
using System.IO;

namespace BSCS3A_BOOKFIZZ;

public partial class SignUp1 : ContentPage
{
	public SignUp1()
	{
		InitializeComponent();
	}

        private async void NextBtn_Clicked(object sender, EventArgs e)
    {
        // Get user input from the form fields
        string firstName = FirstName.Text?.Trim();
        string middleName = MiddleName.Text?.Trim();
        string lastName = LastName.Text?.Trim();

        // Validate input
        if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
        {
            DisplayAlert("Error", "First Name and Last Name are required.", "OK");
            return;
        }

        // Create a temporary user object (can later be connected to a database)
        var user = new User
        {
            FirstName = firstName,
            MiddleName = middleName,
            LastName = lastName
        };

        // Simulate saving data or passing it to the next page
        await Navigation.PushModalAsync(new SignUp2(user));
    }

    private async void OnUploadButtonClicked(object sender, EventArgs e)
    {
        try
        {
            // Open the file picker to allow the user to select an image
            var result = await FilePicker.PickAsync(new PickOptions
            {
                FileTypes = FilePickerFileType.Images,
                PickerTitle = "Select a Picture"
            });

            if (result != null)
            {
                // Load the selected image and display it in an Image control
                var stream = await result.OpenReadAsync();

                // Set the source without disposing of the stream prematurely
                SelectedImage.Source = ImageSource.FromStream(() => stream);

                
            }
            else
            {
                // User canceled the file picker
                await DisplayAlert("Canceled", "No image was selected.", "OK");
            }
        }
        catch (Exception ex)
        {
            // Handle any exceptions that occur during file selection
            await DisplayAlert("Error", $"An error occurred while selecting the image: {ex.Message}", "OK");

            
        }
    }



    private async void backsign1_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
}

// Temporary User class to hold data (can be extended to support database)
public class User
{
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
}
