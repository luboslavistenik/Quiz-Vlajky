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
    public partial class Page8 : ContentPage
    {
        public Page8()
        {
            InitializeComponent();
        }
        private void ImageButton_Clicked_33(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page9());
        }
        private void ImageButton_Clicked_34(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page9());
        }
        private void ImageButton_Clicked_35(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page9());
        }
        private void ImageButton_Clicked_36(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page9());
        }
    }
}