﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppSorteioDados
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btPlay_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageDado());
        }
    }
}
