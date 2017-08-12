using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Wabou
{
    public static class NavigationService 
    {
        public static MasterDetailPage CurrentPage = new MasterDetailPage();

        private static Color _ActionBarColor = Color.FromHex("#d66631");
        public static Color ActionBarColor
        {
            get
            {
                return _ActionBarColor;
            }
            set
            {
                if (_ActionBarColor != value)
                {
                    _ActionBarColor = value;
                }
            }
        }
        /// <summary>
        /// Navigate to a new Page ( MenuButton:Visible ) ( BackButton=Hidden )
        /// </summary>
        public async static void NavigateIn(Page _Page)
        {
            NavigationService.CurrentPage.IsGestureEnabled = true;
            NavigationService.CurrentPage.Detail = new NavigationPage(_Page)
            {
                Title = "My App Name",
                BarBackgroundColor = _ActionBarColor, //Green
            };


        }
        /// <summary>
        /// Navigate to a new Page ( MenuButton:Hidden ) ( BackButton=Hidden )
        /// </summary>
        public async static void NavigateOut(Page _Page)
        {
            NavigationService.CurrentPage.Detail = new NavigationPage(_Page);
            NavigationService.CurrentPage.IsGestureEnabled = false;
            NavigationPage.SetHasNavigationBar(_Page, false);

        }

        /// <summary>
        ///initialise your App Views (Should be Called From App.cs)
        ///Example : _Page = SplashScrean or LoginPage ... 
        /// </summary>
        public async static void LoadView(Page _Page, Grid MenuGrid)
        {
            NavigationService.CurrentPage = new MasterDetailPage();
            NavigationService.CurrentPage.ToolbarItems.Add(new ToolbarItem() { Icon = "userIcon.png" });
            NavigationService.CurrentPage.ToolbarItems.Add(new ToolbarItem() { Icon = "settingsIcon.png" });
            NavigationService.CurrentPage.Title = "MyAppName";
            ContentPage Cont = new ContentPage() { Content = MenuGrid };
            NavigationPage.SetHasNavigationBar(Cont, false);
            NavigationPage.SetHasBackButton(Cont, false);
            var masterPage = new NavigationPage(Cont);
            masterPage.Title = "MyAppName";

            NavigationService.CurrentPage.Master = masterPage;
            NavigationService.CurrentPage.IsGestureEnabled = false;
            NavigationPage.SetHasNavigationBar(_Page, false);
            NavigationService.CurrentPage.Detail = new NavigationPage(_Page);
            Application.Current.MainPage = NavigationService.CurrentPage;
        }

    }

}
