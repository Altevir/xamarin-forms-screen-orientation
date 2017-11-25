using System;
using Xamarin.Forms;
using XFOrientation.Interfaces;

namespace XFOrientation
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnRetrato_Clicked(object sender, EventArgs e)
        {
            DependencyService.Get<IAndroidOrientation>().RotateToPortrait();
        }

        private void btnPaisagem_Clicked(object sender, EventArgs e)
        {
            DependencyService.Get<IAndroidOrientation>().RotateToLandscape();
        }
    }
}
