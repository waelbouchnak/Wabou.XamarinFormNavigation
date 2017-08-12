# Wabou.XamarinFormNavigation



### Load Your SplashScreanPage for Example From app.cs 

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
