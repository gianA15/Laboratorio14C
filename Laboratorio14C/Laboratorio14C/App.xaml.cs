﻿using Laboratorio14C.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Laboratorio14C
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ListCourse();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
