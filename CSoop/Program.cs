namespace CSoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction k1; // Here we declare a reference variable of type Fraction.
            // Here we create a Fraction object and store its address in reference variabvle k1.
            k1 = new Fraction();
            // Here we assign values to k1's numerator and denominator.
            k1.Num = 1; k1.Denum = -2; // Note that we deliberately assigned a negative value to the denominator.

            // Here we write the Fraction object represented by k1
            Console.WriteLine("{0} = {1}", (string)k1, (double)k1); // in string form and also as a numerical value.

            // Here we define another Fraction type reference variable and also create a Fraction object with initial values:
            Fraction k2 = new Fraction(2,5);
            // Here we write the Fraction object represented by k2
            Console.WriteLine("{0} = {1}", (string)k2, (double)k2); // in string form and also as a numerical value.
        }
    }
}
