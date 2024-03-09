# Select Element

`SelectElement` class in selenium used to handle `<select>` tag webelement.

`<select>` tag in html is used to create dropdown in a web page.

```html
<select name ="select_name" id ="element_id" class ="quW3">
    <option index =1 value =1>Item 1</option>
    <option index =2 value =2>Item 2</option>
    <option index =3 value =3>Item 3</option>
    <option index =4 value =4>Item 4</option>
</select>
```

`<option>` tag is a child tag for `<select>` tag which contains the dropdown item.

Each `<option>` tag defines each dropdown item.

## Object Creation

Install **Selenium.Support** package to use SelectElement class in C#

`SelectElement` class constructor takes `IWebElement` as argument and the element's tag name in html should be `<select>`

```cs
using OpenQA.Selenium.Support.UI;
// select tag web element
IWebElement Element = Driver.FindElement(By.TagName("select"));
// object for select class
SelectElement Slct = new SelectElement(Element);
```

|METHODS|DEFINITION|SYNTAX|
|--------|----------|------|
|***SelectByValue(*** string ***)***|Select the dropdown with matching string value.|*Slct.SelectByValue( "value" );*|
|***SelectByIndex(*** int ***)***|Select the dropdown with matching index provided by index attribute in option tag.|*Slct.SelectByIndex( index );*|
|***SelectByText(*** string, *partialMatch = false* ***)***|Select the dropdown with text present in it.<br>*partialMatch* is an optional parameter can be used to select option with partial text|*Slct.SelectByText("txt");*|
|***DeselectByValue(*** string ***)***|De-Select the dropdown with matching string value.<br>Throw error, if the dropdown does not support multi-selection|*Slct.DeSelectByValue( "value" );*|
|***DeselectByIndex(*** int ***)***|De-Select the dropdown with matching index provided by index attribute in option tag.<br> Throw error, if the dropdown does not support multi-selection|*Slct.DeSelectByIndex( index );*|
|***DeselectByText(*** string ***)***|De-Select the dropdown with text present in it.<br>Throw error, if the dropdown does not support multi-selection|*Slct.DeSelectByText("txt");*|
|***DeselectAll()***|De-Select all the selected options.<br>Throw error, if the dropdown does not support multi-selection|*Slct.DeselectAll();*|

|PROPERTIES|DEFINITION|SYNTAX|
|--------|----------|------|
|***IsMultiple***|Indicates whether the dropdown supports muliple selection or not.<br>True, if multi selection allowed.|*bool SupportMultiOption = Slct.IsMultiple;*|
|***Options***|Returns all options in dropdown as webelement|*IList \<IWebElement> Options = Slct.Options;*|
|***SelectedOption***|Returns the selected option as webelement.<br>For multi-selection, it returns the first option|*IWebElement Selected = Slct.SelectedOption;*|
|***AllSelectedOptions***|Returns all selected options as webelement.|*IList \<IWebElement> AllOptions = Slct.AllSelectedOptions;*|
|***WrappedElement***|Returns the wrapped element of the object.|*IWebElement Wrapped = Slct.WrapedElement;*|
