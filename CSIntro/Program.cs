// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;

short i; int j; long k; // Three different integer-type variable declarations

i = 24; // asignment operation
j = i; // assigning the value of i to variable j
k = i * j; // arithmetic operation; multiplying i and j and assigning the result to k
// A statement for writing the values
Console.WriteLine("i = {0} j = {1} k = {2}", i, j, k);

i += 5; // adding 5 to the value of i and assigning the result back to i
j *= 2; // j multipled by 2 assigned back into j
k = i / j; // check the output to see the result of this division operation
Console.WriteLine("i = {0} j = {1} k = {2}", i, j, k);

// A statement for writing the values in various formats
Console.WriteLine("i = {0:N} j = {1:N4} k = {2:G}", i, j, k);

Console.WriteLine(); // this is for leaving a line blank

// Below, we see three different floating-point variable declarations.
float flt = 709.045F; // A 4-byte System.Single type variable with an initial value
double dbl = 903.603E68; // An 8-byte System.Double type variable with an initial value in exponential notation
decimal cur = 1902989070089900; // A 16-byte System.Decimal type variable which is better than double for accuracy

// A statement for writing the values
Console.WriteLine("flt = {0} dbl = {1} cur = {2}", flt, dbl, cur);

// A statement for writing the values in various formats
Console.WriteLine("flt = {0:F2} dbl = {1:E6} cur = {2:C}", flt, dbl, cur);

Console.WriteLine(); // this is for leaving a line blank

// An integer array of 5 elements:
int[] intArray = new int[5];
// Assigning incremental values to array elements:
for (int n = 0; n < 5; n++) intArray[n] = n; // this loop has a single statement; so it does not need a code block
// A for-each loop is useful for handling array elements without changing them, like in writing them one by one:
foreach (int n in intArray)
{// it is good practice to enclose looping statements in a code block, even when there is only one line
    Console.WriteLine("intArray element = {0}", n);
}

Console.WriteLine(); // this is for leaving a line blank

// An array of floating-point numbers:
double[] doubles = new double[5];
// Array dimension must appear on the right-hand side,
// but it can be any nonzero and positive integer value
// even the value of an (prefereably const) integer variable:
const int N = 10;
doubles = new double[N]; // yes, we can recreate the array (but the old elements will be lost)

// Assigning random numercial values to array elements:
Random rnd = new Random(); // We should have a random-number generator to begin with
for (int n = 0; n < doubles.Length; n++) // It is better to refer to the array's number of elements with the Length property
{ doubles[n] = 100 * rnd.NextDouble(); }

// We can use mathematical functions on numerical values by using the Math class:
for (int n = 0; n < doubles.Length; n++)
{// We can declare a new variable within a loop; it won't be valid outside this code block
    double sqrt = Math.Sqrt(doubles[n]);
    Console.WriteLine("SQRT({0:E}) = {1:F3}", doubles[n], sqrt);
}
Console.WriteLine();
// foreach loop is another way of accessing array elements in order,
// without using an index number or the element count:
foreach (double d in doubles)
{// Here, d is the iterator variable, a temporary variable which will take the values of array elements, one by one
    Console.WriteLine("LOG10({0}) = {1}", d, Math.Log10(d));
}
Console.WriteLine();
// .NET provides a library of expandable generic collections,
// like List<> which can take in elements of the type specified within <>
List<string> names = new List<string>(); // This is how we create a List<> which starts out as an empty list
names.Add("Recai"); // which can grow
names.Add("Sezai"); // one by one
names.Add("Mesai"); // by adding
names.Add("Nevai"); // new elements
names.Add("Envai"); // of the specified type.
Console.WriteLine();
// We can use a List<> with elements like an array;
// for example, we can access elements with their index numbers:
for (int n=0; n<names.Count; n++)
{// The difference is that, the element count is learned through the Count property
    Console.WriteLine("names[{0}] : {1}", n, names[n]);
}

//This is the simplified .NET way of creating a collection
List<double> dblist = [];
// However, we still need to add elements, maybe by reading in values input by the user:
const int DBLCOUNT = 10;
Console.WriteLine("Please enter {0} double values, one on each line:", DBLCOUNT);
for(int n=0; n<DBLCOUNT; n++)
{ dblist.Add(double.Parse(Console.ReadLine())); }

// We can also use a foreach loop to access the list elements:
foreach (double d in dblist)
{// Here, d is the iterator variable, a temporary variable which will take the values of array elements, one by one
    Console.WriteLine("SIN({0}) = {1}", d, Math.Sin(d));
}