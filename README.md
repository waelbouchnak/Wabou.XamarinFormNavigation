# Wabou.XamarinFormNavigation



## Load Your First Page From app.cs ( SplashScreanPage for Example )  ( ActionBar:Hidden )

```
NavigationService.LoadView(new SplashScreanPage(), new MenuGrid());
```
 
  -> SplashScreanPage : ContentPage
  
  -> MenuGrid         : Grid ( Navigation Menu )
  
  <img src="https://github.com/waelbouchnak/Wabou.XamarinFormNavigation/blob/master/Screanshots/SplashScrean.PNG?raw=true" width="256"/>
  
## To Navigate to Any Page ( ActionBar:Hidden )
 
```
NavigationService.NavigateOut(new LoginPage());
```

## To Navigate to Any Page ( ActionBar:Visible + MenuButton:visible + BackButton:Hidden )

```
NavigationService.NavigateIn(new HomePage());
```

 <img src="https://github.com/waelbouchnak/Wabou.XamarinFormNavigation/blob/master/Screanshots/SearchPage.PNG?raw=true" width="256"/>
  <img src="https://github.com/waelbouchnak/Wabou.XamarinFormNavigation/blob/master/Screanshots/HomePage.PNG?raw=true" width="256"/>
-------------------------------------------------------------
### to Change ActionBar Color
```
NavigationService.ActionBarColor= Color.FromHex("#d66631"); 
```
