using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;
namespace Genel
{
    public partial class MainPage : ContentPage
    {
        IEnumerable<Locale> locales;
        public MainPage()
        {
            InitializeComponent();
            
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            locales = await TextToSpeech.GetLocalesAsync();
            foreach(var l in locales)
            {
                diller.Items.Add(l.Name);
            }
        }

        private void dinle_Clicked(object sender, EventArgs e)
        {
            if (diller.SelectedIndex > 0)
            {
                TextToSpeech.SpeakAsync(metin.Text, new SpeechOptions()
                {
                    Locale = locales.Single(l => l.Name == diller.SelectedItem.ToString())
                }); ;
            }
        }
    }
}
