using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XAML
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class listPage : ContentPage
    {
        public listPage()
        {
            InitializeComponent();
            var rfids = new List<rfid>
            {
                new rfid("Mert","01","is awesome","http://placekitten.com/300/100"),
                new rfid("Harika","02","is magneficent","http://placekitten.com/200/100"),
                new rfid("Ertan","03","is project manager","http://placekitten.com/100/100"),
                new rfid("Zatur","04","is Zatur","http://placekitten.com/100/100"),
                new rfid("Sinem","04","is Beautiful","http://placekitten.com/100/100"),
                new rfid("Yaren","04","is intern","http://placekitten.com/100/100")
            };
            var names = new List<string>
            {
                "Barış",
                "Batuhan",
                "Batur",
                "Begüm",
                "Bengü",
                "Cem",
                "Deniz",
                "Ebru",
                "Gökhan",
                "Harika",
                "Işıl",
                "Kürşat",
                "Mehmet",
                "Mert",
                "II.Mert",
                "Naz",
                "Selim",
                "Sinem",
                "Yaren",
                "Zatur"
            };
            listview.ItemsSource = rfids;
        }
    }
}