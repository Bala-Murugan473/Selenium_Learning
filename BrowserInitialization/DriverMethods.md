# Driver Methods

## 1. Close()

Used to close the currently focused window/tab.

If the browser has only one tab, it quits the browser

```c#
Driver.Close();
```

## 2. Quit()

It close every associated window for the driver.

Used to quits the browser.

```c#
Driver.Quit();
```

## 3. FindElement()

*Parameter*: `By`

*Return Type*: `IWebElement`

FindElement method is used to find the webelement by using the given By parameter.

It used to find the first occurence web element for the given locator.

```c#
IWebElement webElement = Driver.FindElement(By.Id("id_value"));
```

## 4. FindElements()

*Parameter*: `By`

*Return Type*: `ReadOnlyCollection<IWebElement>`

FindElement method is used to find the webelement by using the given By parameter.

It used to find the list of all webelements for the given locator.

```c#
ReadOnlyCollection<IWebElement> webElements = Driver.FindElements(By.Id("id_value"));
```

`Note:`
For a same locator, **FindElement** method finds the first matching webelement and **FindElements** method finds the all possible matching webelements.

##

Navigate(), Manage(), SwitchTo() methods explained separately.
