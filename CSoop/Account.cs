using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSoop
{
    /// <summary>
    /// This class represents a bank account which performs transactions
    /// in a way to keep its balance at zero or above.
    /// </summary>
    public class Account
    {
        /// <summary>
        /// The hidden static variable for the Account class
        /// to keep track of how many objects have been created.
        /// </summary>
        private static uint accountCount = 0;

        /// <summary>
        /// The hidden member variable which stores the account balance
        /// </summary>
        private decimal _balance;

        /// <summary>
        /// The public auto-property which will store the account number
        /// </summary>
        public uint No
        { get; private set; }

        /// <summary>
        /// The public property which prevents setting the balance from outside
        /// </summary>
        public decimal Balance
        {
            get { return _balance; }
            private set { 
                _balance = value;
            }
        }

        /// <summary>
        /// The default constructor which starts with zero balance
        /// but assigns an account number after incrementing the object count
        /// </summary>
        public Account()
        {
            accountCount++;
            No = accountCount;
            Balance = 0;
        }

        /// <summary>
        /// This member function helps an Account object to determine
        /// if the current balance is sufficient to cover the specified amount.
        /// In this base class, the rule if that balance be equal or greater than the amount.
        /// It is marked with the virtual keyword to let inherited class
        /// to override (replace) it with their own versions.
        /// </summary>
        /// <param name="amount">The transaction amount</param>
        /// <returns></returns>
        public virtual bool BalanceIsSufficient(decimal amount)
        { return Balance >= amount;  }

        /// <summary>
        /// This member function performs the transaction with the specified amount.
        /// </summary>
        /// <param name="amount"></param>
        public void DoTransaction(decimal amount)
        {// choose the right transaction by checking if the amount is positive or negative
            if (amount > 0)
                Deposit(amount);
            else
                Withdraw(Math.Abs(amount));
        }

        /// <summary>
        /// This hidden member function is executed for positive transaction amounts.
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        private bool Deposit(decimal amount)
        {
            Balance += amount;
            return true;
        }

        /// <summary>
        /// This hidden member function is executed for negative transaction amounts.
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        private bool Withdraw(decimal amount)
        {
            if(this.BalanceIsSufficient(amount))
            {
                Balance -= amount;
                return true;
            }
            return false;
        }
    }
}
