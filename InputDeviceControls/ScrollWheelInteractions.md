# Scroll Wheel

To do scrolls,

```cs
// webdriver instance
IWebDriver Driver = new ChromeDriver();
// element to do mouse action
IWebElement Element = Driver.FindElement(By.Id(""));
// actions class instance
// NOTE: Actions class constructor takes 'WebDriver' as argument.
Actions Act = new Actions(Driver);
```

|METHODS|DESCRIPTION|SYNTAX|
|-|-|-|
|***ScrollToElement(*** webElement ***)***|Scrolls the element to the view port.<br>If the element is below the view port, it scroll the bottom of the element to the bottom of the view port|*Act.ScrollToElement(Element).Perform();*|
|***ScrollByAmount(*** int x , int y ***)***|Scrolls the view port to given amount.<br>X is for scrolling left & right (negative x means scroll left)<br>Y is for scrolling right & left (negative y means scroll up)|*Act.ScrollByAmount(x, y).Perform();*|
|***ScrollFromOrigin(*** scrollOrigin, x, y ***)***|Scrolls to given amount from given scroll origin|*Act.ScrollByAmount(origin, x, y).Perform();*|

Note: `ScrollOrigin` used in `ScrollFromOrigin` has different combinations.
