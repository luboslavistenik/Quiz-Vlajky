using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Quiz_Vlajky
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ImageButton_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page1());
        }
        private void ImageButton_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page1());
        }
        private void ImageButton_Clicked_3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page1());
        }
        private void ImageButton_Clicked_4(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page1());
        }
    }
}
