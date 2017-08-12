using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wabou;
using Xamarin.Forms;

namespace HelloWorld_App.Views
{
    public partial class SplashScreanPage : ContentPage
    {
        public SplashScreanPage()
        {
            InitializeComponent();
            NavigToLoginButton.Clicked += NavigToLoginButton_Clicked;
        }

        private void NavigToLoginButton_Clicked(object sender, EventArgs e)
        {
            NavigationService.NavigateOut(new LoginPage());
        }
    }
}
