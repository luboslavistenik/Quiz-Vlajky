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
    public partial class Page5 : ContentPage
    {
        public Page5()
        {
            InitializeComponent();
        }
        private void ImageButton_Clicked_21(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page6());
        }
        private void ImageButton_Clicked_22(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page6());
        }
        private void ImageButton_Clicked_23(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page6());
        }
        private void ImageButton_Clicked_24(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page6());
        }
    }
}