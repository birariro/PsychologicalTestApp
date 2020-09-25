﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PsychologicalTest
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Welcome : ContentPage
    {
        public Welcome()
        {
            
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            Application.Current.MainPage = new NavigationPage(new MainPage());
            await WelcomeImg.ScaleTo(1, 1000);
            await WelcomeImg.ScaleTo(0.9, 300);
            await WelcomeImg.ScaleTo(1.1, 300);
            await WelcomeImg.ScaleTo(0.9, 300);
            await WelcomeImg.ScaleTo(1.1, 300);
        }

    }
}