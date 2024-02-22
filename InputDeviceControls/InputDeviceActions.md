# Input Device Actions Control

A class *`Actions`* in selenium, provide methods to do external input device's actions.

To do so, we need to create an object for *`Actions`* class

*`Actions`* constructor takes webdriver object as parameter.

```CS
Actions Act = new Actions(Driver);
```

All usable methods in Action class returns its current object reference (self reference). (*i.e*, if you declare an object for Actions class as 'act' and call any method, the method returns the object 'act' you created). It is help full in method chaining.

Sometimes we may use shortcuts keyboard like `ctrl` + `a` to select all the text, this is a sequence of two actions, we need to press the `ctrl` key and `a` key together. For this kind of purpose *`Actions`* class has two implementations, *action builder* and *action executor*.

* *action builder* add the actions in a sequence.

* *action executor* execute all the added actions at once.

All actions class methods use *action builder*, they add its action to action builder *(in sequence)*.

`Perform()` method use *action executor*, it is used to execute actions from action builder and clear its sequence.

```cs
Act.Perform();
```

Calling the perform method after any method or sequence of method is mandatory.

## Types of Actions

* [Keyboard Actions](KeyboardInteractions.md)
* [Mouse Actions](KeyboardInteractions.md)
* [Scroll Wheel]
* [Pen Actions]