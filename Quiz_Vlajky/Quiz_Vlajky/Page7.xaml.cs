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
    public partial class Page7 : ContentPage
    {
        public Page7()
        {
            InitializeComponent();
        }
        private void ImageButton_Clicked_29(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page8());
        }
        private void ImageButton_Clicked_30(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page8());
        }
        private void ImageButton_Clicked_31(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page8());
        }
        private void ImageButton_Clicked_32(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page8());
        }
    }
}