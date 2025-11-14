# SWE305 C# Programming

## Introduction
- This repository contains the instructor's project examples for the course.
- Students can also make use of many other tutotials found all over the web, such as:
  - [C# Tutorial on **W3Schools.com**](https://www.w3schools.com/cs/index.php)
  > This website may give the option to autotranslate the contents.
  - [C# Guide on **Microsoft.com**](https://learn.microsoft.com/dotnet/csharp/)
  >This website will directly open with translated content, depending on the viewer's language choices.

- C# is a programming language created by Microsoft.
- It is an object-oriented programming language built on C++, with the addition of some useful features from other popular languages.
- It is an easy-to-learn language useful for beginners, because it leaves out the unsafe features of C++, while it is not as restrictive as Java.
- C# itself does not require installation, but you will need install a current version of .NET on Windows (dotnet on Linux) to run the code you have written with C#.
- Also installing a code editor will help your development work easier.
  - You can install Visual Studio Community edition on Windows, which the instructor has used to create the example projects.
  
  > You will need to select the .NET Desktop Development workload option while installing Visual Studio, which comes selected by default.

  - or, you can install VS Code on Windows, Linux and MacOS.
  
  > On VS Code, you will need to install an extension which will help you code and compile with C#.

## About C# Programming Language
Let's start with some theoretical background.
In this introduction, there will only be single-line examples of C# syntax, not complete code blocks.

- C# code consists of *statements*, which are lines of code where a variable is declared or a command is executed.
  All those statements end with a semicolon.
- Anything between two semicolons is one statement, even if it extends over multiple lines.
- A C# code file may start with <code>using</code> statements which refer to <code>namespace</code>s,
  which are sort of libraries which contain definitions.
  <code>System</code> is the most common namespace, because it contains the basic definitions needed in .NET programs.
- C# code files belonging to the same project will be in the program's own namespace;
  those code files will contain a line like <code>namespace MyCsProject</code>
  with a pair of curly braces enclosing the statements belonging to that namespace.
  > Namespaces help distinguish definitions belonging to different .NET libraries,
  as well as multiple projects referred by the same application.
- As mentioned above, a pair of curly braces enclose a *code block*, which are collections of statements
  belonging to the same namespace, the same function, or the same class, etc.
  > Statements which will be executed together will also appear in one code block.
  We will see examples of that later.
- A *C# program* is a collection of statements which may appear in multiple code files.
  Those code files will be loaded and their statements will be executed, one after another,
  while the program "runs".
  > I won't explain what "run" means in the programming jargon.
- A C# program will contain  a class definition with its name,
  unless the developer chose not to use *top level statements*.
  > Again, we will see examples of that, later.
- The program class will contain the <code>Main</code> function,
  which contain the first statements to be executed while the program runs.
  > If you choose not to use top level statements, you won't see the <code>Main</code> function in the code file,
  but it will just be hidden.
- <code>Main</code> function's name will always be **Main**,
  because that's the only way .NET compiler will know where the program code starts.
- <code>Main</code> function's name will be followed with a pair of </code>( )</code> parantheses
  containing the list of its arguments.
  > The same is true for any other function which you may define in your code.
  We will see examples of that, later.
- Every line in C# code is a statement, unless it starts with <code>//</code> or <code>/*</code> which start comments.
  > A *comment* is a series of one or more lines which explain the intentions of the developer to later readers of the code.
  - Anything following a <code>//</code> is a single-line comment which ends where the code line ends.
  - Anything between a <code>/\*</code> and a <code>\*/</code> a C-style multi-line comment.
  > The compiler will ignore anything in single- or multi-line comments.

  ## About This Course

I am listing the projects in the order they were discussed in classes,
though the contents and explanations of them may be different
in this repository.
> *The contents and explanations of these projects
   may be updated from time to time.
   Students should clone this repository and synch it occasionally
   to follow the changes.*
- [CSIntro](CSIntro/README.md) is a console application project
  where I summarize the basic syntax of the C# programming language
  and show how to use the most important objects defined in .NET libraries.
- [CSoop](CSoop/README.md) is also a console application project
  where I summarize the basics of object-oriented programming with C#.
- [WpfGrid1](WpfGrid1/README.md) is the first visual programming
  project based on WPF framework. It simply introduces the common
  WPF container `<Grid>` which is used to produce a grid-like
  layout on application windows.
- [WpfCrudeApp1](WpfCrudeApp1/README.md) is a crude example
  where I show the old method of writing code to handle
  interactions with named controls.
- [WpfBank1](WpfBank1/README.md) is the project
  where I first demonstrate WPF data bindings,
  but it is still a crude example with serious drawbacks.
