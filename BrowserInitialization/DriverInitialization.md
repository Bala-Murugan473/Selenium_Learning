# Driver Initialization

The first step to do automation testing with selenium is to launch the web browser.

It is done with the help of `IWebDriver`

## IWebDriver

* IWebDriver is an interface, through which user can control the browser.

* It is the main interface used for testing.

* It implements `ISearchContext` and `IDisposable` interfaces
Package Detail: OpenQA.Selenium.WebDriver

## Creating Object for IWebDriver

We know that, we cannot create object for an interface, hence we need a class which implement the `IWebDriver` interface.

In Selenium, each browser will have individual Driver class. These classes implements `IWebDriver` and they can be used to create object for `IWebDriver` interface.

Based on our browser requirement we need to use the respective driver class

For Chrome browser => `ChromeDriver` class

The browser will launch when an instance for a driver class is created.

```C# >
// to launch chrome browser
IWebDriver Driver = new ChromeDriver();
// to launch edge browser
IWebDriver Driver = new EdgeDriver();
// to launch firefox browser
IWebDriver Driver = new FirefoxDriver();
// to launch safari browser
IWebDriver Driver = new SafariDriver();
```

*IWebDriver interface has 5 properties & 5 methods,*

|METHODS | RETURN TYPE  | DEFINITION |
|--------|---------------|-----------|
|***Close()*** | void | Close the current window, Quits the browser if it is the last window currently |
|***Quit()*** |void | Quits this driver, closing every associated window|
|***Navigate***() | INavigation | Instructs the driver to navigate the browser to another location |
| ***SwitchTo()***| ITargetLocator | Instructs the driver to send future commands to a different frame or window |
| ***Manage()***| IOptions | Instructs the driver to change its settings |

In the above table we can see last three methods returning an Interface, those Interfaces will have further more methods.

|PROPERTIES | RETURN TYPE | DEFINITION |
|--------|---------------|-------------|
|    ***Url*** | string | Gets or sets the URL to currently displaying browser |
|    ***Title*** | string | Gets the title of the current browser  |
|***PageSource*** | string | Gets the source of the page last loaded by the browser |
|    ***CurrentWindowHandle*** | string | Gets the unique Id of the current window/tab |
|    ***WindowHandles*** | ReadOnlyCollection\<string> | Gets the window handles(list of id's) of open browser windows. |

Since the IWebDriver interface implemented ISearchContext, it can access its methods. The ISearchContext has only two methods as below,

|METHODS | RETURN TYPE  | DEFINITION |
|--------|---------------|-------------|
| ***FindElement***(*by*) (from ISearchContext)| IWebElement |Used to find the web element by using the given By locator. Returns the first match when finding in DOM |
| ***FindElements***(*by*)     (from ISearchContext) | ReadOnlyCollection\<IWebElement> | Used to find the web element by using the given By locator. Returns all matches when finding in DOM If there is no match found using given By mechanism, it returns an empty list. |

> Note: In C# coding standard, the interfaces are prefixed with `I`, example `IWebDriver`, `ISearchContext`.
