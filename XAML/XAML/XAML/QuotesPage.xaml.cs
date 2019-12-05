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
    public partial class QuotesPage : ContentPage
    {
        string[] Quotes = { "quotes1", "quotes2", "quotes3" };
        int count = 0;
        public QuotesPage()
        {
            InitializeComponent();
            slider.Value = 16;
            label1.Text = "Font Size:" + slider.Value;
            label2.Text = Quotes[0];
            label2.FontSize = slider.Value;
        }

        

        private void button_Clicked(object sender, EventArgs e)
        {
            if (count < 2)
            {
                count++;
            }
            else
            {
                count = 0;
            }
            label2.Text = Quotes[count];
        }

        private void slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            label1.Text = "Font Size: " + slider.Value;
            label2.FontSize = slider.Value;
        }
    }
}