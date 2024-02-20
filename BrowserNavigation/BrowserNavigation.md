# Browser Navigations

***`INavigation` interface helps to do navigation commands like back, forward, refresh, etc.***

It allow the user to access browser's history and navigate to a given Url. It instructs the driver to navigate the browser to another location.

We can use `INavigation` interface using `Navigate()` method from driver.

`Driver.Navigate()` returns `INavigation` interface

## INavigation Methods

4 Methods and 1 is overloaded method
|METHOD | SYNTAX|
|-------|-------|
|Back |Driver.Navigate().Back();|
|Forward |Driver.Navigate().Forward();|
|Refresh |Driver.Navigate().Refresh();|
|GoToUrl| Driver.Navigate().GoToUrl("string url");|
|GoToUrl |Driver.Navigate().GoToUrl(uri url);|

    Note:
     In Selenium we can launch an URL in two ways,
        * using Driver.Url property
        * using navigation command, Driver.Navigate().GoToUrl("");
