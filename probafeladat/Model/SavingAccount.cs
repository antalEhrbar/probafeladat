using System;

namespace probafeladat
{
    public class SavingAccount : Account
    {

        public decimal rateOfInterest { get; set; }

        public SavingAccount()
        {
            TYPE = "saving";
        }

        public SavingAccount(string owner, string currency)
            : base(owner, currency)
        {
            TYPE = "deposit";
            rateOfInterest = 5;
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
            return balance >= amount;
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