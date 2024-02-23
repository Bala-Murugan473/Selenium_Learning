# Mouse Interaction

We can do all the mouse actions with the *`Actions`* class.

```cs
// webdriver instance
IWebDriver Driver = new ChromeDriver();
// element to do mouse action
IWebElement Element = Driver.FindElement(By.Id(""));
// actions class instance
// NOTE: Actions class constructor takes 'WebDriver' as argument.
Actions Act = new Actions(Driver);
```

## Mouse Hover Methods

|METHODS|DESCRIPTION|SYNTAX|
|-|-|-|
|***MoveToElement(webElement)***|Used to do mouse hover on the given element|*Act.MoveToElement(Element).Perform();*|
|***MoveToElement(webElement,x_offset,y_offset)***|Used to do mouse hover on the given element with offset. center of the element is zero offset|*Act.MoveToElement(Element, x, y).Perform();*|
|***MoveByOffset(*** int x, int y ***)***|Move the cursor (mouse hover) to given offset from last mouse coordinates|*Act.MoveByOffset(x, y).Perform();*|
|***MoveToLocation(*** int x, int y ***)***|Move the cursor (mouse hover) to given offset from the top left corner of current view screen|*Act.MoveToLocation(x, y).Perform();*|

## Click Methods

|METHODS|DESCRIPTION|SYNTAX|
|-|-|-|
|***Click()***|Left Click the **active element**|*Act.Click().Perform();*|
|***DoubleClick()***|Double click at last mouse coordinates|*Act.DoubleClick().Perform();*|
|***ContextClick()***|Right click at last mouse coordinates|*Act.ContextClick().Perform();*|
|***ClickAndHold()***|Click and hold the **active element**|*Act.ClickAndHold().Perform();*|
|***Release()***|Release the mouse button at last mouse coordiates|*Act.Release().Perform();*|

All the above methods have overloaded methods, which takes webelement as argument.
||||
|----|----|----|
|***Click(*** webelement ***)***|Move to the given element, <br> Left Click the given element|*Act.Click(Element).Perform();*|
|***DoubleClick(*** webelement ***)***|Move to the given element, <br>Double click the given element.|*Act.DoubleClick(Element).Perform();*|
|***ContextClick(*** webelement ***)***|Move to the given element, <br>Right click the given element.|*Act.ContextClick(Element).Perform();*|
|***ClickAndHold(*** webelement ***)***|Move to the given element, <br>Click and hold the given element|*Act.ClickAndHold(Element).Perform();*|
|***Release(*** webelement ***)***|Move to the given element, <br>Release the mouse button at given element|*Act.Release(Element).Perform();*|

## Drag And Drop Methods

|METHODS|DESCRIPTION|SYNTAX|
|-|-|-|
|***DragAndDrop(*** source_element, target_element ***)***|Used to do drag from one element and drop to another element|*Act.DragAndDrop(source, target).Perform();*|
|***DragAndDropToOffset(*** source_element, int x, int y ***)***|Used to do drag from one element and drop on the given offset|*Act.DragAndDropToOffset(source, x, y).Perform();*|
