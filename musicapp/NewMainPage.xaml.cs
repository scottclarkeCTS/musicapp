﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace musicapp
{
    public partial class NewMainPage : ContentPage
    {
        public NewMainPage()
        {
            InitializeComponent();
        }
        async void Continued(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
        async void ThirdContinued(object sender, EventArgs eventArgs)
        {
            await Navigation.PushAsync(new ThirdPage());
        }
    }
}
