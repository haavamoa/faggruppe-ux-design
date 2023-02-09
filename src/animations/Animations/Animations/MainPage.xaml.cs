using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Animations
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnOldWayClicked(object sender, EventArgs e)
        {
            App.Current.MainPage.Navigation.PushAsync(new OldWayPage());
        }

        private void OnNewWayClicked(object sender, EventArgs e)
        {
            App.Current.MainPage.Navigation.PushAsync(new NewWayPage());
        }
    }
}