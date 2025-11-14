## WpfBank1

- With this project, I am showing properly binding
  WPF controls to data handled by the application.
- However, it is still a crude application,
  because
  - it uses the application window as the data source,
  - it relies on event handler functions for interactions,
  - it does not automatically reflect the changes
    in the selected object.

Let me summarize the development steps:

- I wanted to create a window with fixed dimensions,
  just like the screen of a real-world ATM machine,
  so I set the **ResizeMode** property value
  to "NoResize".
  - I also set **WindowStyle** property to "ToolWindow".
    This window style has a less prominent title bar
    with just the close button, and it does not allow
    the user to resize it.
  
    ![Application Window](AppWindow.png)

- I divided the window grid into two columns;
  - I placed an inner grid on the left column
    which contained a `ListBox` for displaying a list of accounts
    and a button for creating new accounts.
  - I placed another inner grid on the right column
    which contained a `TextBlock` for displaying
    the balance of the account selected on the ListBox
    and buttons to perform transactions on that selected account.

- The columns of the outer grid does not have width values;
  they simply share the window width equally.
- In the right inner grid, the top row's height
  is set to "Auto"; that row will be only as high as
  the TextBlock it contains.
  - The bottom row on the right has a height "\*",
    meaning that, that row will take up the rest of the
    window height.
- You can figure out the same thing happening
  on the left inner grid, with the bottom row
  sizing itself to the + button it contains.

- In this project, I made use of data binding
  to let controls display the application data automatically.
- For example, I bound the **ItemsSource** property
  to **Accounts**, which would be a list of `Account` objects.
- I bound the **Text** content of the `TextBlock` on the right
  to **Balance** property of **SelectedAccount**.
- In WPF, **Binding**s only work with properties;
  in this project, **Accounts** and **SelectedAccount**
  are properties of the application window.
  - This is actually a drawback, because it means
    the data communications are still handled
    on the visual interface.
  - I am doing things this way for now, just as an intermediate
    step before demonstrating the proper way to make visual interface
    independent from the data-handling operations.
  - In a properly designed WPF application,
    or in any modern visual application,
    data bindings would work with a separate entity
    (usually called a ViewModel or a Visual Controller),
    or even better, with a database interface.
- With the statement in its constructor function\
  `this.DataContext = this;`\
  the window specifies itself as the source of data bindings.
  > Yes, `DataContext` means the source of data bindings.\
    *Remember it, we will use it again.*

- Notice that **SelectedItem** property of the `ListBox`
  is bound to the **SelectedAccount** property of the window,
  which represents the currently active account object
  in the **Accounts** list.
  - However, at least initially, no item may be selected
    on the `ListBox`, meaning that the active account may be none of them.
  - Since .NET now doesn't allow an object reference point to nothing,
    I had to specify this poperty as a "nullable" reference.
    > A question mark after the class type means it is a reference
      variable which may point to null (i.e. contain a zero address).
- The idea was that, the user was going to choose an account listed
  on the `ListBox` in the left column and see its balance on the 
  `TextBlock` control in the right column.
- The user could then click on transaction buttons on the right side
  and see the balance of the selected account change.
  > There are some details I left out; see the comment lines
    to figure them out.
- However, if you run the application, you will notice that
  no account balance is displayed, even after depositing and
  withdrawing any of the accounts bunch of times.
  - If you are familiar with Visual Studio development environment,
    you can set a breakpoint and debug the application
    right when a transaction button is clicked.
    ![Debugging Click Event](DebuggingClickEvent.png)
  - You will see that **SelectedAccount** indeed points to
    the account you selected on the `ListBox`
    and its balance has indeed changed.
  - The problem is that, the selected account object
    is not sending any message about the change in its balance;
    that's why we don't see the current balance
    in the `TextBlock` control.
  - Implementing the `INotifyPropertyChanged` interface
    in `Account` class would inform the data-bound
    `TextBlock` of the changes in **Balance** property.
    - However, that would not solve the problem completely,
      because we would also have to implement the same interface
      on the window itself, so the controls on the right
      would know when the selected account changed on the left.
    - Implementing that interface with hand-written code
      is impractical and error-prone. In the next project,
      I will show how to use a package to automate
      that part of the work.
  - Another major problem is that, transactions on the selected
    account are performed by a function handling the **Click**
    events of the buttons on the right.
    - While this may seem fine, it is not,
      because if we change the way the controls take actions,
      we would have to rewrite the event handling code.
  - The ultimate solution to these problems is relying
    on Model-View-ViewModel (MVVM) architecture,
    which I will also demonstrate on the next project.