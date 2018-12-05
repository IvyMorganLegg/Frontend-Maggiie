using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Maggi.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OpeningPage : ContentPage
    {
        public OpeningPage()
        {
           InitializeComponent();  
        }

        async void ArtistButton(object sender, EventArgs e)
        {
            (sender as Button).Text = "I am an artist";
        }

        async void EnthuButton(object sender, EventArgs e)
        {
            (sender as Button).Text = "I am an enthusiast";
        }

        private void LoginClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginPage());

        }
    }
}