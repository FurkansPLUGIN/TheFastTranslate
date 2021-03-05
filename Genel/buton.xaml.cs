using Plugin.Connectivity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Genel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class buton : ContentPage
    {
        public buton()
        {
            InitializeComponent();
            
        }
        int giden;
        async void pageBaglanti()
        {
            if (CrossConnectivity.Current.IsConnected)
            {
                await Navigation.PushModalAsync(new ceviriSayfaları());
                MessagingCenter.Send<buton, int>(this, "deger", giden);
            }
            else
            {
                await DisplayAlert("Warning", "Please open the internet", "Ok");
            }
           
        }
        private void googleFor_Clicked(object sender, EventArgs e)
        {
            giden = 0;
            pageBaglanti();
        }

        private void yandexFor_Clicked(object sender, EventArgs e)
        {
            giden = 1;
            pageBaglanti();
        }

        private void turengFor_Clicked(object sender, EventArgs e)
        {
            giden = 2;
            pageBaglanti();
        }

        private void cambridge_Clicked(object sender, EventArgs e)
        {
            giden = 3;
            pageBaglanti();
        }

        private void bing_Clicked(object sender, EventArgs e)
        {
            giden = 4;
            pageBaglanti();
        }

        private void reverso_Clicked(object sender, EventArgs e)
        {
            giden = 5;
            pageBaglanti();
        }

        private async void TextToSpech_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage());
        }

        private void translate_Clicked(object sender, EventArgs e)
        {
            giden = 6;
            pageBaglanti();
        }
    }
}