using System;

namespace probafeladat
{
    public class DepositAccount : Account
    {
        public decimal creditLimit { get; set; } = 50000;

        public DepositAccount()
        {
            TYPE = "deposit";
        }

        public DepositAccount(string owner, string currency)
            : base(owner, currency)
        {
            TYPE = "deposit";
        }

        public override void withdraw(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("You can't pass negative amount of money");
            }
            if (!isAmountWithdrawable(amount))
            {
                throw new ArgumentException(String.Format($"{0} isn't withdrawable from account : {1}", amount.ToString(), accountNumber));
            }
            balance -= amount;
        }

        public override bool isAmountWithdrawable(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("You can't pass negative amount of money");
            }
            return balance + creditLimit >= amount;
        }

        public override void uploadMoney(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("You can't upload negative amount");
            }
            balance += amount;
        }
    }
}