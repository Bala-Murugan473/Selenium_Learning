# Driver Properties

## 1.  Url

Used to get or set url to currently displaying browser.

### **Set Url:**

It is used to launch the given url to the browser.

```C# >
Driver.Url = "url to launch";
```

The "url to launch" should be a proper url, otherwise `OpenQA.Selenium.WebDriverArgumentException` will be thrown

*protocol* : // *domainname*/  eg: <https://www.selenium.dev/>

### **Get Url:**

It is used to get the current url from the browser.

In testing, this method can be used for validation purpose

```C# >
string current_url = Driver.Url;
```

## 2. Title

Used to get the current displaying browser's title.

```C# >
string current_title = Driver.Title;
```

## 3. PageSource

It retuns the lastly loaded page-source(DOM).

This method return the entire DOM strcuture.

```C# >
string page_source = Driver.PageSource;
```

## 4. CurrentWindowHandle

In Selenium, tab and window are considered as same(considered as window only).

Each window in a browser will have an unique id

Some action in website may leads to open a new tab or window and its unique id will store in driver instance.

*CurrentWindowHandle is used to retrieve the unique id of the currently focused window.*

The browser may have any number of tabs/ windows opened, this method returns the id of the tab/window, which the driver is controling.

```C# >
string current_window_id = Driver.CurrentWindowHandle;
```

## 5. WindowHandles

Same like CurrentWindowHandle, But instead of retrieving currently focused window, it return the Id's of all windows(or tabs) present in the browser.

```C# >
ReadOnlyCollection<string> windows_ids = Driver.WindowHandles;
```

## Points to remember

* Only Driver.Url having set & get property, remaining all are get property only.

* Return type of all properties are string, except WindowHandles(it returns ReadOnlyCollection\<string>).
