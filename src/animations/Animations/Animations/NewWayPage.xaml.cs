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
    public partial class NewWayPage : ContentPage
    {
        public NewWayPage()
        {
            InitializeComponent();
        }

        private async void ValidateEntries(object sender, EventArgs e)
        {
            var allEmptyEntries = new List<Entry>();
            var allEntries = new List<Entry>()
            {
                firstNameEntry, lastNameEntry, ageEntry
            };
            foreach (var childView in allEntries)
            {
                if (childView is Entry entry)
                {
                    if (string.IsNullOrEmpty(entry.Text))
                    {
                        allEmptyEntries.Add(entry);
                    }
                }
            }

            if (!allEmptyEntries.Any())
            {
                await Application.Current.MainPage.DisplayAlert("Takk", "Da vet vi hvem du er!", "Ok");
            }

            var firstEmptyEntry = allEmptyEntries.FirstOrDefault();
            if (firstEmptyEntry != null)
            {
                await firstEmptyEntry.Shake();
                firstEmptyEntry.Focus();
            }
        }
    }
}