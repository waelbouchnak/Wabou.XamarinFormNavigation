using HelloWorld_App.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wabou;
using Xamarin.Forms;

namespace HelloWorld_App
{
    public class App : Application
    {
        public App()
        {
            //NavigationService.ActionBarColor= Color.FromHex("#d66631"); 
            NavigationService.LoadView(new SplashScreanPage(), new MenuGrid());

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
