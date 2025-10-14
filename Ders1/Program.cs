// See https://aka.ms/new-console-template for more information

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
float f = 709.045F; // A 4-byte System.Single type variable with an initial value
double d = 903.603E68; // An 8-byte System.Double type variable with an initial value in exponential notation
decimal c = 1902989070089900; // A 16-byte System.Decimal type variable which is better than double for accuracy

// A statement for writing the values
Console.WriteLine("f = {0} d = {1} c = {2}", f, d, c);

// A statement for writing the values in various formats
Console.WriteLine("f = {0:F2} d = {1:E6} c = {2:C}", f, d, c);

Console.WriteLine(); // this is for leaving a line blank

// An integer array of 5 elements:
int[] array = new int[5];
// Assigning incremental values to array elements:
for(int n=0; n<5; n++) array[n] = n; // this loop has a single statement; so it does not need a code block
// A for-each loop is useful for handling array elements without changing them, like in writing them one by one:
foreach(int n in array)
{// it is good practice to enclose looping statements in a code block, even when there is only one line
    Console.WriteLine("{0}", n);
}

Console.WriteLine(); // this is for leaving a line blank

// An array of floating-point numbers:
double[] doubles = new double[5];
// Assigning random numercial values to array elements:
Random rnd = new Random(); // We should have a random-number generator to begin with
for (int n = 0; n < doubles.Length; n++) // It is better to refer to the array's number of elements with the Length property
{ doubles[n] = 100 * rnd.NextDouble(); }
// We can use mathematical functions on numerical values by using the Math class:
for (int n = 0; n < 5; n++)
{// We can declare a new variable within a loop; it won't be valid outside this code block
    double sqrt = Math.Sqrt(doubles[n]);
    Console.WriteLine("SQRT({0:E}) = {1:F3}", doubles[n], sqrt);
}