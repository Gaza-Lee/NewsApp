﻿using NewsApp.Pages;

namespace NewsApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new NewPage1());
        }
    }
}