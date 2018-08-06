using System;

namespace probafeladat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program started");
            DepositAccount depositAccount = new DepositAccount("AA", "USD");
            SavingAccount savingAccount = new SavingAccount("AB", "HUF");
            Console.WriteLine(depositAccount.ToString());
            Console.WriteLine(savingAccount.ToString());
            //new ClusterCOnnect();
            Console.ReadLine();
        }
    }
}
