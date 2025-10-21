## CSoop
- This is a Console Application project which summarizes the basics
  of object-oriented programming with C# programmin language.
- In this project, I checked the option
  'Do not use top-level statements',
  so the main code file **Program.cs** displays the project namespace,
  **Program** class and **Main** function which is the entry point
  of the application.
  - You can think of a `namespace` as a library of definitions.
    It contains the definitions specific to a project and prevents
    *name collisions* (problems arising from using class or function names
    in more than one project).
- In this project, we will create our own class definitions.
  - To add a class definition, we right click on the project name
    and open the shortcut menu.
  - From the shortcut menu, we click on the **Add** command
    and choose the option **Class** from the submenu.\
    
    ![Adding Class](AddingClass.png)
    
  - On the upcoming dialog form, we name the class.
    
    ![Naming Class](NamingClass.png)

- A class is basically a code package representing a real-world object.
  - For example, our `Fraction` class represents a math fraction like 
    1/2
  - A class definition starts with a header, the term `class`
    followed by the class name:<br>
    `class Fraction`
  - That much is enough for a class header.
    The class definition consists of this header and the code block
    surrounded by curly braces **\{ \}**.
  - The class header may also contain an accessibility label.
    - The label **internal** means the class definition can only be
      used in this project.<br>
      *If there is no label, the class definition will be internal.*
    - The label public is for class definitions which can be used
      from other projects.<br>
      *Such class definitions are for class libraries shared with
       other developers. For our simple class projects, class's
       accessibility label will not matter.*
  - The name of a class can be anything which can be used for a
    variable or a function. However, it is customary to use
    the name of the real-world object represented by the class,
    like `Fraction`, `Vector`, `Employee`, etc.<br>
    *It is also customary that the class name starts with a capital letter.*
- Following the class header, we have the class definition code block
  surrounded by curly braces **\{ \}**.
  - The class definition contains definitions of fields (member variables);
    they store the values which make up the object represented
    by the class definiton.
  - For example, our `Fraction` class contains two integer fields:
    ```
        // These two are field (member variable) definitions:
        private int _num;   // numerator (pay) value
        private int _denum; // denominator (payda) value
    ```
    *Don't forget; in C# code, // are for inline comments.*