using System;
using System.ComponentModel.DataAnnotations;

namespace probafeladat
{
    public abstract class Account
    {

        public static Int32 idCounter { get; private set; } = 1;
        public static Int32 accountCounter { get; set; } = 10;

        public static decimal baseMoney = 5000;

        [Key]
        public Int32 id { get; set; }

        public string TYPE { get; set; }
        public string accountNumber { get; set; }
        public string ownerName { get; set; }
        public decimal balance { get; set; }
        public string currency { get; set; }


        public abstract bool isAmountWithdrawable(decimal amount);
        public abstract void uploadMoney(decimal amount);
        public abstract void withdraw(decimal amount);

        protected Account(string ownerName, string currency)
        {
            id = idCounter;
            idCounter++;
            accountNumber = "010-" + accountCounter.ToString();
            accountCounter += 6191;
            this.ownerName = ownerName;
            balance = Account.baseMoney;
            this.currency = currency;
        }

        protected Account() { }
    }
}