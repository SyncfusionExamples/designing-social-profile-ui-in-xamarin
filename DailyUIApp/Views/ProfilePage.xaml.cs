using System;
using System.Collections.Generic;
using DailyUIApp.ViewModels;
using Xamarin.Forms;

namespace DailyUIApp.Views
{
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            InitializeComponent();
            BindingContext = new ProfileViewModel();
        }
    }
}
