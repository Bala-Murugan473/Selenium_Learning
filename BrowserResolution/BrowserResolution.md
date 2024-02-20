# Browser Resolution

***`IWindow` interface used to get & set the size and position of the browser.***

```c#
IWindow window = Driver.Manage().Window;
```

`Driver.Manage()` returns `IOptions` interface, which has `Window` property and this `Window` property returns `IWindow` interface.

|METHOD| DEFINITION| SYNTAX|
|------|---------------|-------|
|**Maximize()**| Maximizes the current window if it is not already maximized| *Driver.Manage().Window.Maximize();*|
|**Minimize()**| Minimizes the current window if it is not already minimized |*Driver.Manage().Window.Minimize();*|
|**FullScreen()** |Sets the current window to full screen if it is not already in that state |*Driver.Manage().Window.FullScreen();*|
|**Size**| Gets or sets the size of the outer browser window, including title bars and window borders.| *Driver.Manage().Window.Size = new Size(x,y); <br>**Size** s = Driver.Manage().Window.Size;*|
|**Position**| Gets or sets the position of the browser window relative to the upper-left corner of the screen.| *Driver.Manage().Window.Position = new Point(x,y);<br>**Point** p = Driver.Manage().Window.Position;*|

```\
"Size" and "Position" are *truct from `System.Drawing` package.

Top left corner is the zero offset for `Position`

left to right(→) positive `x`
top to bottom(↓) positive `y`
```
