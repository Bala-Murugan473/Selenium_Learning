# Frame Handling

Generally frames are used to split the window into many sections, where each can load separately.

A html doc file containing a frame tag \<frame> can enclose a separate hmtl doc file in it.

A frame can have sub frames also.

Elements in frame is in a separate html doc, so we need to switch the driver control, before working with elements inside frame.

*`ITargetLocator`* is an interface, which provided method to enter and exit frame.

## To enter the frame

|METHOD|DEFINITION|SYNTAX|
|--------|----------|------|
|**Frame(** *int* **)**| Select a frame by its index|*Driver.SwitchTo().Frame(index);*|
|**Frame(** *string* **)**| Select a frame by its name|*Driver.SwitchTo().Frame(name);*|
|**Frame(** *webElement* **)**| Select a frame by passing it as a webelement|*Driver.SwitchTo().Frame(webElement);*|

## To exit the frame

|METHOD|DEFINITION|SYNTAX|
|--------|----------|------|
|**ParentFrame()**| Switch the control to the parent frame of the currently selected frame.|*Driver.SwitchTo().ParentFrame();*|
|**DefaultContext()**| Switch the driver control to the top html |*Driver.SwitchTo().DefaultContext();*|
