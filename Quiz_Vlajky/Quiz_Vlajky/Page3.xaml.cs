using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Quiz_Vlajky
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page3 : ContentPage
    {
        public Page3()
        {
            InitializeComponent();
        }
        private void ImageButton_Clicked_13(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page4());
        }
        private void ImageButton_Clicked_14(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page4());
        }
        private void ImageButton_Clicked_15(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page4());
        }
        private void ImageButton_Clicked_16(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page4());
        }
    }
}