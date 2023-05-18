# Unity Menu Manager
A menu manager built in Unity for efficient handling of a collection of menus and provides methods to show, hide, and navigate between them. Intentionally designed to be simple to expand upon in other projects.

MenuManager.cs
- Contains a serialized field `menus` which is a list of `Menu` objects.
- There are private fields `currentMenu` of type `Menu` and `history` of type `Stack<Menu>`.
- In the `Start` method, each menu is initialized, hidden, and the first menu in the list is shown. This bit of code can be modified to any menu of your choosing.
- In the `Update` method, if the backspace key is pressed, the `Back` method is called.
- The `Show` method is used to show a specific menu. It hides the current menu (if any) and shows the new menu. If the `remember` parameter is `true`, the current menu is added to the `history` stack before hiding it.
- The `Show<T>` method is a generic version of the above method that accepts a type parameter `T`. It finds the first menu in the list that matches the specified type `T` and shows it.
- The `Back` method is used to return to the previously shown menu. It pops the last menu from the `history` stack, then shows it.
- The `GetMenu<T>` method returns the first menu in the list that matches the specified type `T`.
- The `GetCurrentMenu` method returns the currently shown menu.

Menu.cs
- The `Menu` class has a protected field `menuManager` of type `MenuManager`, which is used to reference the `MenuManager` set at the `Start.
- The `SetMenuManager` method is used to set the `menuManager` field with a reference to the `MenuManager` instance.
- The `Initialize` method is an abstract method meant to be implemented in derived classes. It serves as a placeholder for any initialization code specific to the menu.
- The `Show` and `Hide` methods are a virtual methods that can be overridden in derived classes. By default, they set the `gameObject` to active or inactive, depending on which of the two methods is used.
