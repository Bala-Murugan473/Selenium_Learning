# Alert Handing

Alert is a popup which appeared in browser to show information. It is necessary to handle the alert, since it blocks any other user interaction.

## Types of Alert

* Simple Alert
  * a simple message with *OK* button
* Confirmation Alert
  * message with *OK* and *Cancel* button
* Prompt Alert
  * message with *Ok*,*Cancel* button and *Text Field* to enter.

## Alert Interface

In Selenium alert are handled using methods provided by ***`Alert`*** interface.

We can use ***Alert*** interface using,

```CS
//Switch() to method from driver, returns targetlocator interface
ITargetLocator TargetLocator = Driver.SwitchTo();

// Alert() method from targetlocator interface, returns alert interface
IAlert alert_interface = TargetLocator.Alert();
```

same code using method chaining,

```cs
IAlert alert_interface = Driver.SwitchTo().Alert();
```

|METHOD|DEFINITION|SYNTAX|
|--------|----------|------|
|**Accept()**| Accept the alert (Ok)|*Driver.SwitchTo().Alert().Accept();*|
|**Dismiss()**| Dismiss the alert(Cancel)|*Driver.SwitchTo().Alert().Dismiss();*|
|**SendKeys()**| Send keys to the alert text field|*Driver.SwitchTo().Alert().SendKeys("txt");*|
|**Text**| Gets the alert text(alert message)|*string txt = Driver.SwitchTo().Alert().Text;*|

**Note:** Since alert is a pop up which appear infront of the current window, it is mandatory to switch the driver control (*Driver.SwichTo()*)
