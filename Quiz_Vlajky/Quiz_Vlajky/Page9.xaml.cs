﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Quiz_Vlajky
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page9 : ContentPage
    {
        public Page9()
        {
            InitializeComponent();
        }
        private void ImageButton_Clicked_37(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page10());
        }
        private void ImageButton_Clicked_38(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page10());
        }
        private void ImageButton_Clicked_39(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page10());
        }
        private void ImageButton_Clicked_40(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page10());
        }
    }
}