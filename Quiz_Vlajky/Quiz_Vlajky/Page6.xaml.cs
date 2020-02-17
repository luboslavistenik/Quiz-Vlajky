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
    public partial class Page6 : ContentPage
    {
        public Page6()
        {
            InitializeComponent();
        }

        private void ImageButton_Clicked_25(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page7());
        }
        private void ImageButton_Clicked_26(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page7());
        }
        private void ImageButton_Clicked_27(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page7());
        }
        private void ImageButton_Clicked_28(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page7());
        }
    }
}