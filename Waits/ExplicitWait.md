# Explicit Wait

We can define wait strategies explicitly.

## WebDriverWait

`WebDriverWait` is a class in selenium, which provides ability to wait for certain conditions.

`WebDriverWait` extends the `DefaultWait` class which is implement `IWait` interface.

## IWait

|PROPERTIES|DEFINITION|
|----------|----------|
|Timeouts|Total Time duration to wait for the given condition to be true.|
|PollingInterval|Time interval to evaluate the given condition|
|Message|Message to display when time Timeouts' duration exceeds|

|METHODS|DEFINITION|
|----------|----------|
|IgnoreExceptionType(params Type[] exceptions)|Ignores the given list of exceptions if occured during waiting.|
|Until\<TResult>(Func<T, TResult> condition)|Wait until the given condition evaluates to true.|

All the above methods are implemented in `DefaultWait` class.

Remark: properties *Timeouts, PollingInterval, Message* and method *IgnoreExceptionType* are used only to create `DefaultWait` instance. We use `Until` method for waiting.

## WebDriverWait Object Creation

`WebDriverWait` class only contains two constructors, all the `IWait` methods are implemented in `DefaultWait` class which is inherited by `WebDriverWait`

```CS
// parameters: IClock, IWebDriver, TotalTimeDuration, TimeInterval
WebDriverWait wait = new WebDriverWait(new SystemClock(), Driver, TimeSpan.FromSeconds(40), TimeSpan.FromMilliseconds(200));

// parameters: IWebDriver, TotalTimeDuration
WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(40));
```

## Selenium Extras

Selenium Extras is a separate package, which provides various waiting conditions which can be used in *WebDriverWait.Until* function.

`ExpectedCondition` is a sealed class from SeleniumExtras.WaitHelper package, which contains various wait functions.

```cs
WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(40));

wait.Until(ExpectionConditions.TitleContains("title"));
```

Note: `ExpectedCondition` methods will explained separately.
