# Locators

Locators are used to identify HTML elements on a webpage.

It is used to identify elements such as text-box, button, radio button, checkbox, etc.

In Selenium, before we are doing any interaction *( eg. button click)* with the web element, we need to find it first.

There are 7 Locators provide by selenium.

## By Class

By is a class in selenium, which provides mechanism used to locate elements within a html document

All the locators in selenium are placed inside the `by` class

`By` is a parameter for `FindElement`, `FindElements` methods

## Types of Locators

    • Id
    • Name
    • Class Name
    • Tag Name
    • Linked Text
    • Partial Linked Text
    • XPath
    • Css Selector    

## Syntax

=> By.locator("locatorValue")

```C#
        By.Id("id attribute value")
        By.Name("name attribute value")
        By.ClassName("class name attribute value")
        By.TagName("tag name")
        By.LinkedText("href attribute value")
        By.PartialLinkedText("href cropped value")
        By.Xpath("xml path to the element")
        By.CssSelector("css path to the element")
```
