# Ders1
- This first example is a console application project.
Its output will be displayed in a console window,
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
  <code>short i; int j; long k;</code>
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
  - <code>short</code> type has two bytes (16 bits) and can store up to 65535 for **unsigned** version.
  - <code>int</code> type has four bytes (32 bits) and can store up to 4294967295 for **unsigned** version.
  - <code>long</code> type has eight bytes (64 bits) and can store up to 18446744073709551615 for **unsigned** version.<br><br>
  *NOTE: Actually, the first bit of each numerical data type is reserved as the sign bit,
   so the data limits for the above types are actually  between minus and plus half of the <code>unsigned</code> limits*
 
 - Next, we see assignment operations.
   - In C#, an assignment operation is for transferring the value on the right side
      to the memory block represented by variable on the left side, like in:
      <code>i = 24;</code>
   - If a variable name appears on the right side, the value of that variable
      is transferred to the variable on the left side, like in:
      <code>j = i;</code>
   - If an arithmetic operation or a math function call appears on the right side,
      the value of the result is transferred to the variable on the left side, like in:
      <code>k = i * j;</code>
- In a console application, we use <code>Console.Write()</code> function
  to get values written on the same line, and <code>Console.WriteLine()</code> function
  to write values on a separate line.
  - In both these function calls, whatever characters appear in quotation marks, 
    they are written exactly as they appear, like in:<br>
    <code>Console.Write("This will be WRITTEN    exactly (as it appears)");</code>
  - If values of variables must be written, placeholders
    <code>{0}</code>, <code>{1}</code>, <code>{2}</code>, ... must be used within quotation marks,
    while the variable names appear after the quotation marks, separated by commas:<br>
    <code>Console.WriteLine("i = {0} j = {1} k = {2}", i, j, k);</code><br>
    Remember, in C#, the first element has index 0, so the first variable
    <code>i</code>'s value will appear where the placeholder <code>{0}</code> appears, and so on.
  
- For numbers with decimal parts, we use floating-point types.
  - Computers can store only integer-type numeric values.<br>
    Floating-point types are also integers, but one or more bytes are reserved
    to store the position of the decimal point.
  - <code>float</code> type is accurate to 6 to 9 digits, with a magnitude range up to 10<sup>38</sup>.
  - <code>double</code> type is accurate to 15 to 17 digits, with a magnitude range up to 10<sup>308</sup>.
  - <code>decimal</code> type is accurate to 28 to 29 digits, with a magnitude range up to 10<sup>28</sup>.
  - <code>decimal</code> type seems to be limited in magnitude range, but more accurate
    in terms of the digits it can hold, so it is the preferred type
    for handling money-related calculations.
- In <code>Console.Write</code> statements, placeholders can have formatted statements.
  - For example, with <code>{0:N}</code>, we have the value of <code>i</code> written in number notation,
    with 2 decimal digits by default. This formatting also puts groups separators between
  - 3-digit groups, as in thousands, millions, and billions, etc.
  - On the other hand, with <code>{1:N4}</code>, we have the value of <code>j</code>
    written with four decimal digits. 
  - <code>{2:G}</code> gets the value of <code>k</code> written as a plain number or
    in exponential notation. the choice depends on how big the value is.
  - <code>F</code> formatting writes a value with decimal places specified by the number
    next to **F**, but without group separators.
  - <code>E</code> is for exponential formatting, with the value following **E**
    being the exponent of 10.
  - <code>C</code> is for currency formatting with the currency symbol for whetever country
    is set for the operating system.
- In C#, we declare an array with a statement like <code>data_type[] variable_name</code>.
  - Declaring an array variable will not create the array.<br>
    That happens by calling the <code>new</code> operator, with the number of elements
    specified between square brackets, as in <code>new int[5]</code>.
  - For numerical data types like <code>int</code>, <double</code>, etc.
    creating an array will also create the elements directly.
    Then we can access array elements by their index numbers,
    usually in a counting loop like <code>for</code>.
  - Once an array and its elements are created, we can access elements in order
    (without needing indices) in a <code>foreach</code> loop.
- To use mathematical functions like <code>sqrt</code>, <code>pow</code>,
  <code>sin</code>, <code>cos</code>, etc. we use <code>Math</code> class.