using System;
using Microsoft.Maui.Controls;

namespace BookFizz
{
    public partial class PersonalInfo : ContentPage
    {
        public PersonalInfo()
        {
            InitializeComponent();
            BindingContext = new PersonalInfoViewModel();
        }

        private void OnBackButtonClicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void OnSaveButtonClicked(object sender, EventArgs e)
        {
            // Save action logic here
            DisplayAlert("Success", "Personal Info saved successfully", "OK");
        }

        private void OnEditNameClicked(object sender, EventArgs e)
        {
            // Logic to edit the name field
        }

        private void OnEditEmailClicked(object sender, EventArgs e)
        {
            // Logic to edit the email field
        }

        private void OnEditPasswordClicked(object sender, EventArgs e)
        {
            // Logic to edit the password field
        }

        private void OnTogglePasswordVisibility(object sender, EventArgs e)
        {
            // Toggle password visibility logic
            Entry passwordEntry = (Entry)sender;
            passwordEntry.IsPassword = !passwordEntry.IsPassword;
        }
    }

    public class PersonalInfoViewModel
    {
        public string Bio { get; set; } = "Type here...";
        public string FullName { get; set; } = "Rita Palmera";
        public string Email { get; set; } = "rita.baby@example.com";
        public string Password { get; set; } = "mahalnaatakitababy95";
        public DateTime DateJoined { get; set; } = new DateTime(2024, 10, 9);
    }
}
