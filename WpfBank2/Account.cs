using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfBank2
{
    public partial class Account : ObservableObject
    {
        /// <summary>
        /// This static variable helps the class know
        /// how many objects of this kind has been created.
        /// </summary>
        private static uint accountCount = 0;

        /// <summary>
        /// This property lets others know the account number
        /// but only lets the Account object assign itself a number.
        /// </summary>
        public uint No
        { get; private set; }

        /// <summary>
        /// This private variable is the basis for the observable property
        /// which will be defined by MVVM Toolkit.
        /// </summary>
        [ObservableProperty]
        private decimal _balance;

        /// <summary>
        /// This default constructor creates a new Account object
        /// with 0 balance and assigns the incremented number of objects
        /// as the account number.
        /// </summary>
        public Account()
        {
            accountCount++;
            No = accountCount;
            Balance = 0;
        }

        /// <summary>
        /// This member function lets an account object check its balance.
        /// The label "virtual" will let a derived class override it,
        /// such as CreditAccount which can have a negative balance.
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public virtual bool BalanceIsSufficient(decimal amount)
        { return Balance >= amount;  }

        /// <summary>
        /// This member function performs a monetary transaction
        /// on the account balance.
        /// </summary>
        /// <param name="parameter">The cxommand parameter (the transaction amount)</param>
        [RelayCommand]
        public void DoTransaction(object parameter)
        {
            try
            {// We try to check if a valid parameter has been passed
                decimal amount = Convert.ToDecimal(parameter);
                if (amount > 0) // A positive amount means a money deposit.
                    Deposit(amount);
                else // A negative amount means money withdrawal.
                    Withdraw(Math.Abs(amount));
            }
            catch { } // We do nothing about an invalid parameter
        }

        /// <summary>
        /// This member function is private, meaning that only the
        /// Account object can invoke it in its own code.
        /// </summary>
        /// <param name="amount">The amount to be deposited</param>
        /// <returns>The success status</returns>
        private bool Deposit(decimal amount)
        {
            Balance += amount;
            return true;
        }

        /// <summary>
        /// This member function is private, meaning that only the
        /// Account object can invoke it in its own code.
        /// </summary>
        /// <param name="amount">The amount to be withdrawn</param>
        /// <returns>The success status</returns>
        private bool Withdraw(decimal amount)
        {
            if(BalanceIsSufficient(amount))
            {
                Balance -= amount;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Account object provides its own string equivalent
        /// by overriding ToString() function
        /// which it has inherited from the object class.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Account(" + No + ")";
        }
    }
}
