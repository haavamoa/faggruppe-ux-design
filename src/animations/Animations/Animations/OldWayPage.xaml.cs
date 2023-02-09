using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Animations
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OldWayPage : ContentPage
    {
        public OldWayPage()
        {
            InitializeComponent();
        }

        private void AgeEntry_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender is Entry entry)
            {
                Validate();
            }
        }

        private void Validate()
        {
            SendButton.Opacity = (CanSend) ? 1 : 0.5;
            
        }
        
        private bool CanSend =>  !string.IsNullOrEmpty(ageEntry.Text) && !string.IsNullOrEmpty(lastNameEntry.Text) &&
                                !string.IsNullOrEmpty(firstNameEntry.Text);

        private void SendButton_OnClicked(object sender, EventArgs e)
        {
            if (CanSend)
            {
                _ = Application.Current.MainPage.DisplayAlert("Takk", "Da vet vi hvem du er!", "Ok");
            }
        }
    }
}