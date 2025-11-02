using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfBank
{
    public class Account
    {
        private static uint accountCount = 0;

        private decimal _balance;

        public uint No
        { get; private set; }

        public decimal Balance
        {
            get { return _balance; }
            private set { 
                _balance = value;
            }
        }

        public Account()
        {
            accountCount++;
            No = accountCount;
            Balance = 0;
        }

        public virtual bool BalanceIsSufficient(decimal amount)
        { return Balance >= amount;  }

        public void DoTransaction(decimal amount,
            Account? otherAccount = null)
        {
            if (otherAccount != null)
            {
                // transfer money between accounts
                return;
            }
            else
            {
                if (amount > 0)
                    Deposit(amount);
                else
                    Withdraw(Math.Abs(amount));
            }
        }

        private bool Deposit(decimal amount)
        {
            Balance += amount;
            return true;
        }

        private bool Withdraw(decimal amount)
        {
            if(BalanceIsSufficient(amount))
            {
                Balance -= amount;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return No.ToString() +
                "\t(" + Balance.ToString() + ")";
        }
    }
}
