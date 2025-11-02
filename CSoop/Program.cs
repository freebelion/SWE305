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
            Console.WriteLine("Fraction{0} = {1}", (string)k1, (double)k1); // in string form and also as a numerical value.

            // Here we define another Fraction type reference variable and also create a Fraction object with initial values:
            Fraction k2 = new Fraction(2,5);
            // Here we write the Fraction object represented by k2
            Console.WriteLine("Fraction{0} = {1}", (string)k2, (double)k2); // in string form and also as a numerical value.

            Point p1 = new Point(3, 4);
            Console.WriteLine("Point{0} distance to the origin: {1}", p1, p1.Distance());

            Point p2 = new Point(4, 3);
            Console.WriteLine("Distance between Point{0} and Point{1}: {2}", p1, p2, p1.Distance(p2));

            Console.WriteLine();
            Account acct1 = new Account();
            Console.WriteLine("The following transactions are performed on a regular Account object:");
            Console.Write("Account[{0}] Balance = {1:C2} ", acct1.No, acct1.Balance);
            decimal amount = 25000; acct1.DoTransaction(amount);
            Console.Write("Transaction = {0:C2} Balance = {1:C2}", amount, acct1.Balance);
            Console.WriteLine();
            amount = -50000; acct1.DoTransaction(amount);
            Console.Write("Transaction = {0:C2} Balance = {1:C2}", amount, acct1.Balance);
            Console.WriteLine();
            Console.WriteLine("\tNote that Account[{0}] does not allow an overdraft, so its balance remains the same.", acct1.No);
            Console.WriteLine();
            Account acct2 = new CreditAccount();
            Console.WriteLine("The following transactions are performed on CreditAccount object\naccessed through a reference variable of Account type:");
            Console.Write("Account[{0}] Balance = {1:C2} ", acct2.No, acct2.Balance);
            amount = 25000; acct2.DoTransaction(amount);
            Console.Write("Transaction = {0:C2} Balance = {1:C2}", amount, acct2.Balance);
            Console.WriteLine();
            amount = -50000; acct2.DoTransaction(amount);
            Console.Write("Transaction = {0:C2} Balance = {1:C2}", amount, acct2.Balance);
            Console.WriteLine();
            Console.WriteLine("\tNote that Account[{0}] allows an overdraft.", acct2.No);
            amount = -100000; acct2.DoTransaction(amount);
            Console.Write("Transaction = {0:C2} Balance = {1:C2}", amount, acct2.Balance);
            Console.WriteLine();
            Console.WriteLine("\tbut not below its overdraft limit.", acct2.No);
        }
    }
}
