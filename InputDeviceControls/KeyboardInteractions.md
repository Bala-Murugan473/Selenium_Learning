# Keyboard Interaction

We can do all the keyboard actions with the *`Actions`* class.

There is a static class named *`Keys`* in selenium, which provides all the special keys in keyboard ( *control,shift,etc*).

|METHODS|DESCRIPTION|SYNTAX|
|-|-|-|
|***KeyDown(*** *string* ***)***|Used to press any keyboard keys to the **active element**, can pass any ASCII characters and special keys from Key class| *Act.KeyDown(Keys.Control).Perform();*|
|***KeyUp(*** *string* ***)***|Used to release any keyboard keys to the **active element**, can pass any ASCII characters and special keys from Key class| *Act.KeyUp(Keys.Control).Perform();*|
|***SendKyes(*** *string* ***)***|Used to send sequence of ASCII characters to the **active element**| *Act.SendKeys("text").Perform();*|

All three above methods have overloaded methods, which takes webelement as a parameter. The parameter webelemet will become the active element for interaction.

|METHODS|DESCRIPTION|Ex. SYNTAX|
|-|-|-|
|***KeyDown(*** *webelement*,*string* ***)***|Used to press any keyboard keys to the **given webelement**, can pass any ASCII characters and special keys from Key class| *Act.KeyDown(Element, Keys.Control).Perform();*|
|***KeyUp(*** *webelement*,*string*  ***)***|Used to release any keyboard keys to the **given webelement**, can pass any ASCII characters and special keys from Key class| *Act.KeyUp(Element, Keys.Control).Perform();*|
|***SendKyes(*** *webelement*,*string* ***)***|Used to send sequence of ASCII characters to the **given webelement**| *Act.SendKeys(Element, "text").Perform();*|

If string passed for KeyDown & KeyUp is a multi-character, it takes only the first character

```
Note:

IWebElement.Sendkeys() is only applicable for Text fields.
Actions.Sendkeys() can be used in many cases like filering dropdown by typing letters( dynamic dropdowns)
```
