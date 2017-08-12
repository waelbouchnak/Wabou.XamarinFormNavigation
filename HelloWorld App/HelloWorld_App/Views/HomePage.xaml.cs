using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wabou;
using Xamarin.Forms;

namespace HelloWorld_App.Views
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            Navigto3.Clicked += Navigto3_Clicked;
        }

        private void Navigto3_Clicked(object sender, EventArgs e)
        {
            NavigationService.NavigateIn(new thirdPage());
        }
    }
}
