﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MbataSports
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            Services.ProductService.LoadWishList();
        }

        protected override void OnSleep() 
        {
            Services.ProductService.SaveWishList();
        }

        protected override void OnResume()
        {
            Services.ProductService.LoadWishList();
        }
    }
}
