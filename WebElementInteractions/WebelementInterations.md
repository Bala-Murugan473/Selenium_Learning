# Element Interactions

As explained earlier, using *`Driver.FindElement`* method we can obtain the webelement to interact.

```CS
IWebElement Element = Driver.FindElement(By.Id("q"));
```

The *`Driver.FindElement`* method returns the webelement as an interface named *`IWebElement`*.

## IWebElement

*`IWebElement`* is an interface through which the user can interact with the web element

*`IWebElement`* interface also implements *`ISearchContext`*. *(earlier we saw `IWebDriver` implements `ISearchContext`)*

|PROPERTY|DEFINITION|SYNTAX|
|--------|----------|------|
|**TagName**| Returns the tag name of the element|*string Ele_TagName = Element.TagName;*|
|**Text**| Returns the text present in the element(including sub-element text)|*string Ele_Text = Element.Text;*|
|**Size**|Returns the size of the element|*Size Ele_Size = Element.Size;*|
|**Location**|Returns the position of the element| *Point Ele_Position = Element.Location;*|
|**Displayed**|Indicates weather the element is displayed or not | *bool IsDisplayed = Element.Displayed;*|
|**Enabled**|Indicates weather the element is enabled or not|*bool IsEnabled = Element.Enabled;*|
|**Selected**|Indicates weather the element is selected or not <br>(*applicable to input elements such as checkbox, radio button, select option*)|*bool IsSelected = Element.Selected;*|
|**Click()**|Used to click the webelement|*Element.Click();*|
|**SendKeys()**|Used to enter text to webelement.<br> Used to enter Keystrokes to the webelement.|*Element.Sendkeys("Text to type");*|
|**Clear()**|Clears the text present in the text element (\<input>,<\textarea>)<br>*No impact on other elements* |*Element.Clear();*|
|**Submit()**|Used to click the webelements of form, (not recommended after selenium 4.0)|*Element.Submit();*|
|**GetAttribute()**|Returns the specified attribute value of the element|*string attribute_value = Element.GetAttribute("");*|
|**GetDomAttrbute()**|Returns the attribute value of declared attributes of the element|*string attribute_value = Element.GetDomAttrbute("");*|
|**GetDomProperty()**|Returns the value of the javascript property, passed as parameter|*string dom_value = Element.GetDomProperty("");*|
|**GetCssValue()**|Returns the value of the CSS property, passed as parameter|*string css_value = Element.GetCssValue("");*|
|**GetShadowRoot()**|Returns the shadow DOM|*ISearchContext Ele_ShadowDOM = Element.GetShadowRoot();*|

Note: all the webelement methods are used only to retrieve data related to webelement.(*except SendKeys()*)
