```Markdown
<style>
  code {
    font-family: "Courier New", monospace;
    background-color: #f4f4f4;
    color: #333;
    padding: 2px 4px;
    border-radius: 4px;
  }
  pre {
    background-color: #f4f4f4;
    padding: 10px;
    border-radius: 4px;
    overflow-x: auto;
  }
</style>
```
## CSoop
- This is a Console Application project which summarizes the basics
  of object-oriented programming with C# programming language.
- While creating this project, I checked the option
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
### `Fraction` Class

- A class is basically a code package representing a real-world object.
  With a code package like that, we enclose the attributes
  (private properties) of the object together
  and provide controlled access to them through public property definitions.
  We can also add function definitions to imitate the real-world
  behavior of the object.<br>
  >*This is the first principle of object-oriented programming;
   class definitions encapsulate the properties and behaviors of
   real-world objects.*
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
      >*If there is no label, the class definition will be internal.*
    - The label **public** is for class definitions which can be used
      from other projects.<br>
      >*Such class definitions are for class libraries shared with
       other developers. For our simple class projects, class's
       accessibility label will not matter.*
  - The name of a class can be anything which can be used for a
    variable or a function. However, it is customary to use
    the name of the real-world object represented by the class,
    like `Fraction`, `Vector`, `Employee`, etc.<br>
    >*It is also customary that the class name starts with a capital letter.*
- Following the class header, we have the class definition code block
  surrounded by curly braces **\{ \}**.
- The class definition contains definitions of fields (member variables);
  they store the values which make up the object represented
  by the class definiton.
  - For example, our `Fraction` class contains two integer fields
    which will store the values of its numerator and denominator
    (**pay** and **payda** in Turkish):
    ```
        // These two are field (member variable) definitions:
        private int _num;   // numerator (pay) value
        private int _denum; // denominator (payda) value
    ```
    >*Don't forget; in C# code, // are for inline comments.*
  - There is a custom of giving member variables names
    which start with underscore **\_** and a lowercase letter.
    This is not mandatory, but especially programmers
    working together in the same development team
    will stick to certain naming rules like that.
  - The field labels **private** means that these variables
    packaged in the class definition cannot be directly accessed
    from outside.
 
    >*If a field definition doesn't have a label, it will be assumed to be
      **private**.*
  
    >*Hiding the internal properties of the real object in **private**
      fields is known as **data hiding**. This is the second principle
      of object-oriented programming.*

- **private** fields help hide the attributes of an object,
  but we can provide controlled access to them through
  *property* definitions.
  - For example, the following property definition enables access to
    numerator value:
    ```
        public int Num
        {
            get { return _num; }
            set { _num = value; }
        }
    ```
    - The **get** block will give out the value stored in the field.
    - The **set** block will help assign a value to the field.
  - A property does not have to enable total access. For example,
    this property definition helps learn the value of denominator
    through its **get** block, but its **set** block does not assign
    the given value directly:
    ```
        public int Denum
        {
            get { return _denum; }
            set {
                if(value > 0) { _denum = value; }
                else if(value < 0)
                {
                    _num = -_num;
                    _denum = -value;
                }
                // An exception stops the program execution with an error message.
                else throw new ArgumentException("Denominator value cannot be zero!");
            }
        }
    ```
    >*Note that a property definition looks similar to a field definition,
      but it has a code block with inner get and set blocks.*
  
    >*By custom, property names start with capital letters,
      but this is not mandatory.*

- A class definition is simply a code package for a new data type;
  it is written by a *designer programmer* who knows how a code object
  representing a real-world object should behave in code.
- A *client programmer* will take a class definition from the designer programmer
  and create code objects of that type.
- The client programmer can define a variable of that class type, like:<br>
  `Fraction k1;`
- A class-type variable like the one above is a *reference variable*.
  It is basically an integer variable which can store the address of a code object.
  > *A reference variable is not an object! It merely is a name representing the object*
- The client programmer must use the new operator to create a code object of the class:<br>
  `k1 = new Fraction();`
  - The statement above will create a code object in memory containing two integer variables
    `_num` and `_denum`. The address of this memory block will be stored in the reference
    variable `k1`.
- When a class object is created with new(), the default constructor of the class is called:
  ```
        public Fraction()
        {
            Num = 0;
            Denum = 1;
        }
  ```
  - The constructor is a special function which carries the same name as the class itself.
  - The default (empty) constructor runs when no initial values are provided
    for the member variables. It assigns best default values suitable for a
    real-world object represented by the class definition.
    > *Note that our default constructor for the `Fraction` class assigns values
       to properties, not directly to member variables.
       This is the preferred way, because it ensures controlled access.*
- A client programmer may want to pass on certain initial values
  for the private fields of the new object.
  In that case, the designer programmer should create another constructor
  function which accepts the initial values as parameters:
  ```
        public Fraction(int p, int q)
        { Num = p; Denum = q; }
  ```
  >*Again, by assigning values to properties, we are reusing our codes which provide controlled access.*
  - The client programmer can use this secondary constructor like this:<br>
    `Fraction k2 = new Fraction(2,5);`
- Since a `Fraction`-type object represents a mathematical fraction in real life,
  a client programmer may want to obtain its decimal equivalent in a program.<br>
  For that, the designer programmer can put the following conversion operator
  in the class definition:
  ```
        public static explicit operator double(Fraction k)
        { return (double)k.Num / k.Denum; }
  ```
- In case a client programmer wants to have a fraction written as a string,
  like **[1/2]**, he can use the following conversion operator:
  ```
        public static explicit operator string(Fraction k)
        { return "[" + k.Num + "/" + k.Denum + "]"; }
  ```
- The following `Console.WriteLine()` statements use those operators
  to get the fraction objects written as strings and numerical values:
```
...
Console.WriteLine("Fraction{0} = {1}", (string)k1, (double)k1);
...
Console.WriteLine("Fraction{0} = {1}", (string)k2, (double)k2);
```
These statements in the **Program** class produce the following output:
```
Fraction[-1/2] = -0,5
Fraction[2/5] = 0,4
```

### `Point` Class
- Our second class example is `Point`, which represents a point
  in a two-dimensional coordinate space.
- Since the two coordinates are going to be two `double` variables
  which can take any value, there is no need to create **private**
  fields with public properties providing controlled access.
- Therefore, `Point` class defines the coordinates as "auto-properties",
  two properties without code in their **get** and **set** blocks.
- `Point` class has a *member function* which calculates the distance
  between the point object and another point object.
  - This member function has a special feature.
    In order to explain how it works, I have created two separate versions
    described in a comment block.
  - The following version calculates the distance of the `Point` object to the origin:
    ```
    public double Distance()
    {
        return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
    }
    ```
  - This other version calculates the distance of the `Point` object another `Point` object:
    ```
    public double Distance(Point p)
    {
        return Math.Sqrt(Math.Pow(X - p.X, 2) + Math.Pow(Y - p.Y, 2));
    }
    ```
  - The final version which is active in the class definition combines these two versions.
    The idea is that, if a parameter is sent to the function `Distance`,
    it will calculate the distance of the `Point` object another `Point` object,
    but if no parameter is provided, it will calculate the distance to the origin.
  - The solution is to use a function parameter with a default value null.
    In .NET Core which we are using in our example, we do that with a nullable reference argument:<br>
    `public double Distance(Point? p = null)`
  - If the function is called without a paremeter, like in
    ```
    Point p1 = new Point(3,4);
    Console.WriteLine("Point{0} distance to the origin: {1}", p1, p1.Distance());
    ```
  - However, if the reference of another `Point` object is sent,
    then the member function will calculate the distance between the first point
    and the other point sent as the parameter:
    ```
    Point p2 = new Point(4,3);
    Console.WriteLine("Distance between Point{0} and Pont{1}: {2}", p1, p2, p1.Distance(p2));
    ```
    Those statements of the **Program** class produce the following output:
    ```
    Point(3 : 4) distance to the origin: 5
    Distance between Point(3 : 4) and Point(4 : 3): 1,4142135623730951
    ```
  - The `Console.WriteLine()` statements above write the `Point` objects
    on the console window by getting their string equivalents through
    the `ToString()` member function defined in the `Point` class.
    - `ToString()` member function is actually defined in the `object` class,
      which is the parent class of all classes.
    - If a class object has to specify how it should be written as a string,
      it should **override** this function that it has inherited from
      the `object` class.
    - `ToString()` provides a string equivalent of an object,
      but it is not the same as the `(string)` conversion operator
      that we defined in the `Fraction` class example.
    - `ToString()` is called automatically, whenever an object must appear
      as a string on a visual interface, especially in data-bound controls.<br>
      > *`(string)` conversion operator could not be called automatically.*