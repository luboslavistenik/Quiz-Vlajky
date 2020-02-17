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
    public partial class Page4 : ContentPage
    {
        public Page4()
        {
            InitializeComponent();
        }
        private void ImageButton_Clicked_17(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page5());
        }
        private void ImageButton_Clicked_18(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page5());
        }
        private void ImageButton_Clicked_19(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page5());
        }
        private void ImageButton_Clicked_20(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page5());
        }
    }
}