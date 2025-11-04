# CSIntro
- This first example is a console application project.
  Here, we summarize the basic syntax of C# programming language.
- The program output will be displayed in a console window,
an old-style terminal window which will pop up
when the application is run.
- In real-life, users interact with visual interfaces,
so a console application will not have any use beyond
running simple tests.
- However, console applications are a useful starting step
in learning the basics of programming, because they do not
require understanding the complex steps of constructing
visual interfaces.

## Project Development
- This project is based on the **Console Application** template.
- When I chose this template, I unchecked the option
  'Do not use top-level statements', so it does not display
  a project namespace, a program class and a **Main** function.
- This kind of project is for writing simple blocks of code,
  and it is especially useful for starter projects for learning C#.
- We are starting with variable declarations:<br>
  `short i; int j; long k;`
- A variable declaration consists of a data type and a variable name.
- A variable represents a value which can *vary*, i.e. change.
- A variable is actually a block of memory which will store
  the value which it will represent.
- Data type specifies how much memory is allocated for the variable.
  - We use ten-based numerical notation in our writing systems
    and put as many digits as we can write to specify a value,
    but a computer cannot allocate infinite memory to store each value.
  - Besides, a computer does not store a numerical value
    as a sequence of digits. Instead, it stores the binary equivalent
    of the numerical value.
  - For example, an integer value which we write as 35
    will be stored as 100011 in memory.
  - However, a computer can not and should not reserve
    arbitrary numbers of bits to represent numerical values.
    Instead, it stores values in bytes, blocks of memory
    with specific number of bits.
  - One byte is 8 bytes and it can store integer values up to 255.
  - `short` type has two bytes (16 bits) and can store up to 65535 for **unsigned** version.
  - `int` type has four bytes (32 bits) and can store up to 4294967295 for **unsigned** version.
  - `long` type has eight bytes (64 bits) and can store up to 18446744073709551615 for **unsigned** version.<br><br>
  *NOTE: Actually, the first bit of each numerical data type is reserved as the sign bit,
   so the data limits for the above types are actually  between minus and plus half of the `unsigned` limits*
 
 - Next, we see assignment operations.
   - In C#, an assignment operation is for transferring the value on the right side
      to the memory block represented by variable on the left side, like in:
      `i = 24;`
   - If a variable name appears on the right side, the value of that variable
      is transferred to the variable on the left side, like in:
      `j = i;`
   - If an arithmetic operation or a math function call appears on the right side,
      the value of the result is transferred to the variable on the left side, like in:
      `k = i * j;`
- In a console application, we use `Console.Write()` function
  to get values written on the same line, and `Console.WriteLine()` function
  to write values on a separate line.
  - In both these function calls, whatever characters appear in quotation marks, 
    they are written exactly as they appear, like in:<br>
    `Console.Write("This will be WRITTEN    exactly (as it appears)");`
  - If values of variables must be written, placeholders
    `{0}`, `{1}`, `{2}`, ... must be used within quotation marks,
    while the variable names appear after the quotation marks, separated by commas:<br>
    `Console.WriteLine("i = {0} j = {1} k = {2}", i, j, k);`<br>
    Remember, in C#, the first element has index 0, so the first variable
    `i`'s value will appear where the placeholder `{0}` appears, and so on.
  
- For numbers with decimal parts, we use floating-point types.
  - Computers can store only integer-type numeric values.<br>
    Floating-point types are also integers, but one or more bytes are reserved
    to store the position of the decimal point.
  - `float` type is accurate to 6 to 9 digits, with a magnitude range up to 10<sup>38</sup>.
  - `double` type is accurate to 15 to 17 digits, with a magnitude range up to 10<sup>308</sup>.
  - `decimal` type is accurate to 28 to 29 digits, with a magnitude range up to 10<sup>28</sup>.
  - `decimal` type seems to be limited in magnitude range, but more accurate
    in terms of the digits it can hold, so it is the preferred type
    for handling money-related calculations.
- In `Console.Write` statements, placeholders can have formatted statements.
  - For example, with `{0:N}`, we have the value of `i` written in number notation,
    with 2 decimal digits by default. This formatting also puts groups separators between
  - 3-digit groups, as in thousands, millions, and billions, etc.
  - On the other hand, with `{1:N4}`, we have the value of `j`
    written with four decimal digits. 
  - `{2:G}` gets the value of `k` written as a plain number or
    in exponential notation. the choice depends on how big the value is.
  - `F` formatting writes a value with decimal places specified by the number
    next to **F**, but without group separators.
  - `E` is for exponential formatting, with the value following **E**
    being the exponent of 10.
  - `C` is for currency formatting with the currency symbol for whetever country
    is set for the operating system.
- In C#, we declare an array with a statement like `int[] intArray` or `double[] dblArray`.
  - <u>Declaring an array variable will not create the array.</u><br>
    That happens by calling the `new` operator, with the number of elements
    specified between square brackets, as in `new int[5]`.
  - While creating the array, <u>we must specify the number of elements</u> on the right-hand side.<br>
    The element count can be any positive integer written by hand or any integer variable
    or the value of any variable converted to integer.<br>
    *The rule of a positive element count still holds, but it will be enforced at runtime,
     meaning that, if the integer value turns out to be 0 or negative
     at the moment the array is being created, a runtime error will occur.*
  - For numerical data types like `int`, <double`, etc.
    creating an array will also create the elements directly.
    Then we can access array elements by their index numbers,
    usually in a counting loop like `for`.
  - Once an array and its elements are created, we can access elements in order
    (without needing indices) in a `foreach` loop.
- To use mathematical functions like `sqrt`, `pow`,
  `sin`, `cos`, `Log` (natural logarithm), `Log10`(10-based logarithm) etc. we use `Math` class.
- .NET provides a library of generic collection, expandable lists and other interesting collections
  which can take in values of the type specified within the `<>` pair in declaration.
  - Among the generic collections, `List<>` can be used just like an array,
    with access to elements with index numbers.
  - However, there is an important difference:<br>
    When an array is created by specifying the element count,
    that number of elements are created.<br>
    A generic collection like `List<>` will require
    adding the elements one by one, by using its member function `Add()`.