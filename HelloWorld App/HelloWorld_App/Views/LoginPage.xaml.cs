using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wabou;
using Xamarin.Forms;

namespace HelloWorld_App.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            NavigToHomePageButton.Clicked += NavigToHomePageButton_Clicked;
        }

        private void NavigToHomePageButton_Clicked(object sender, EventArgs e)
        {
            NavigationService.NavigateIn(new HomePage());
        }
    }
}
