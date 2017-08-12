# Wabou.XamarinFormNavigation



### Load Your First Page From app.cs ( SplashScreanPage for Example )  ( ActionBar:Hidden )

```
NavigationService.LoadView(new SplashScreanPage(), new MenuGrid());
```
 
  -> SplashScreanPage : ContentPage
  -> MenuGrid         : Grid ( Navigation Menu )
  
  
### To Navigate to Any Page ( ActionBar:Hidden )
   
```
NavigationService.NavigateOut(new LoginPage());
```

### To Navigate to Any Page ( ActionBar:Visible + MenuButton:visible + BackButton:Hidden )

```
NavigationService.NavigateIn(new HomePage());
```

-------------------------------------------------------------
### to Change ActionBar Color
```
NavigationService.ActionBarColor= Color.FromHex("#d66631"); 
```
