using System;

namespace Bank
{
    public class BankAccount
    {
        private double balance;

        public BankAccount()
        {
        }

        public BankAccount(double balance)
        {
            this.balance = balance;
        }

        public double Balance
        {
            get { return balance; }
        }
        
        public void Add(double amaount)
        {
            if (amaount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amaount));
            }

            balance += amaount;
        }

        public void Withdraw(double amount)
        {
            if (amount > balance)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }

            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof (amount));
            }

            balance -= amount;
        }

        public void TransferFundsTo(BankAccount otherAccount,double amount)
        {
            if (otherAccount is null)
            {
                throw new ArgumentNullException(nameof(otherAccount));
            }

            Withdraw(amount);
            otherAccount.Add(amount);
        }
    }
}