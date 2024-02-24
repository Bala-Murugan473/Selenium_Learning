# Timeouts

`ITimeouts` is an interface in selenium, which is implemented by webdriver.

It is an interface used to define timeouts.

```cs
// Manage() method of IWebDriver, returns the IOptions interface
IOptions Options = Driver.Manage();
// Timeouts() method of IOption, returns the ITimeouts interface
ITimeouts Timeouts = Options.Timeouts();
```

Mostly we use this interface by method chaining only. !! Not like above !!

This  interface provides three timeout proerties as below,

## 1.ImplicitWait

* *It is used to tell the web driver to wait for certain time before throwing NoSuchElementException*.
* Gets or sets the implicit wait timeout, which is the amount of time the driver should wait when searching for an element if it is not immediately present

```cs
    // To set
    Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
    // To get
    TimeSpan ImpWait = Driver.Manage().Timeouts().ImplicitWait;
```

## 2. PageLoad

* The amount of time the driver should wait for a page to load when setting the `Driver.Url` property.

```cs
    // To set
    Driver.Manage().Timeouts().PageLoad= TimeSpan.FromSeconds(100);
    // To get
    TimeSpan PgLoad= Driver.Manage().Timeouts().PageLoad;
```

## 3. AsynchronousJavaScript

* The amount of time the driver should wait when executing JavaScript asynchronously.
* This timeout only affects IJavaScriptExecutor.ExecuteAsyncScript() method.

```cs
    // To set
    Driver.Manage().Timeouts().AsynchronousJavaScript= TimeSpan.FromSeconds(20);
    // To get
    TimeSpan AsyncWait= Driver.Manage().Timeouts().AsynchronousJavaScript;
```

## Properites

|PROPERTY|GET|SET|
|--------|---|---|
|**ImplicitWait**|*TimeSpan ImpWait = Driver.Manage().Timeouts().ImplicitWait;*|*Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);*|
|**PageLoad**|*TimeSpan PgLoad= Driver.Manage().Timeouts().PageLoad;*|*Driver.Manage().Timeouts().PageLoad= TimeSpan.FromSeconds(100);*|
|**AsynchronousJavaScript**|*TimeSpan AsyncWait= Driver.Manage().Timeouts().AsynchronousJavaScript;*|*Driver.Manage().Timeouts().AsynchronousJavaScript= TimeSpan.FromSeconds(20);*|

Note : `TimeSpan` is a struct from `System` namespace. It is used to define time durations.
