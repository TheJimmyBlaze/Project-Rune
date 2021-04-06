﻿using ProjectRune.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace project_rune
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new SkillsPage();
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