using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSoop
{
    /// <summary>
    /// This class (derived from the Account class)
    /// represents a bank account which lets the balance
    /// to drop down to an overdraft limit
    /// because it replaces the base class'
    /// BalanceIsSufficient function
    /// with its own version.
    /// </summary>
    public class CreditAccount : Account // The : symbol indicates NewCreditAccount is derived from Account class
    {
        /// <summary>
        /// This hidden static variable belongs to this new class.
        /// </summary>
        private static decimal OVERDRAFT_LIMIT = 100000;

        /*
         * Since this class is derived from Account class,
         * it inherits (already possesses) any member variable,
         * property, member function of Account class
         * unless it redefines one with a new or override keyword.
         */

        /// <summary>
        /// This class defines a new version of BalanceIsSufficient
        /// so that it can allow the balance go negative, down to
        /// the OVERDRAFT_LIMIT.
        /// Since it redefines the function with the override keyword,
        /// it will allow overdraft even if it is accessed
        /// through a reference variable of Account type.
        /// </summary>
        /// <param name="amount">The transaction amount</param>
        /// <returns></returns>
        public override bool BalanceIsSufficient(decimal amount)
        { return (Balance + OVERDRAFT_LIMIT) >= amount; }
    }
}
