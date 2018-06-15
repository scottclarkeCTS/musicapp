using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace musicapp
{
    public partial class ThirdPage : ContentPage
    {
        public ThirdPage()
        {
            InitializeComponent();
        }
        async void ThirdMainPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}