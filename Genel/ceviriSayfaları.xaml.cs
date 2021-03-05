using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Connectivity;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Genel
{//#2196f3
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ceviriSayfaları : ContentPage
    {
        
        public ceviriSayfaları()
        {
            InitializeComponent();
            if (CrossConnectivity.Current.IsConnected)
            {
                MessagingCenter.Subscribe<buton, int>(this, "deger", (sender, value) =>
                {

                    if (value == 0)
                    {
                        link.Source = "https://translate.google.com/";

                    }
                    if (value == 1)
                    {
                        link.Source = "https://ceviri.yandex.com.tr/";

                    }

                    if (value == 2)
                    {
                        link.Source = "https://tureng.com/tr/turkce-ingilizce";

                    }
                    if (value == 3)
                    {
                        link.Source = "https://dictionary.cambridge.org/tr/translate/";

                    }

                    if (value == 4)
                    {
                        link.Source = "https://www.bing.com/translator?utm_source=webtekno";

                    }
                    if (value == 5)
                    {
                        link.Source = "https://www.reverso.net/text_translation.aspx?lang=EN";

                    }
                    if (value == 6)
                    {
                        link.Source = "https://www.translate.com/";

                    }
                    MessagingCenter.Unsubscribe<buton, string>(this, "deger");
                });
            }
            else
            {
                DisplayAlert("Warning", "Please open the internet", "Ok");
            }

            //link.Source = "https://translate.google.com/";
            //link.Source = "https://ceviri.yandex.com.tr/";
            //link.Source = "https://tureng.com/tr/turkce-ingilizce";
            //link.Source = "https://dictionary.cambridge.org/tr/translate/";
            //link.Source = "https://www.bing.com/translator?utm_source=webtekno";
            //link.Source = "https://www.reverso.net/text_translation.aspx?lang=EN";
            //link.Source = "https://www.translate.com/";


        }

      
    }
}