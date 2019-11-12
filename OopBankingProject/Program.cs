using System;

namespace OopBankingProject {

    class Program {

        static void Main(string[] args) {

            var dummy = new IDummy();
            var acct1 = new Account();

            Savings sav1 = new Savings();
            sav1.Number = "SAV001";
            sav1.Name = "My savings account";
            sav1.ChangeRate(0.02);

            MoneyMarket mm = new MoneyMarket();
            mm.Number = "MM001";
            mm.Name = "My money market account";
            mm.Deposit(100);
            mm.MMRate = 0.05;
            mm.PayInterest(12);

            Checking chk = new Checking();
            chk.Number = "CHK001";
            chk.Name = "My checking account";
            chk.Deposit(100);
            chk.Pay(100, 20);

            Account[] accounts = new Account[] { sav1, mm, chk };

            foreach(Account acct in accounts) {
                Console.WriteLine(acct.Print());
            }


/*
            bool ItWorked = mm.TransferTo(sav1, 150);
            Console.WriteLine($"Money Market balance is {mm.GetBalance()}");
            Console.WriteLine($"Saving1 balance is {sav1.GetBalance()}");

            Savings sav = new Savings();
            sav.Number = "1002";
            sav.Name = "Savings 1";
            sav.IntRate = 0.1;

            sav.Deposit(200);
            sav.Withdraw(100);
            decimal interestToBePaid = sav.CalcInterest(12);
            sav.PayInterest(interestToBePaid);
            decimal savbal = sav.GetBalance();
            Console.WriteLine($"Savings balance is {savbal}");
/*
            Account acct = new Account();
            acct.Number = "1001";
            acct.Name = "Test Account";

            acct.Deposit(20);
            acct.Withdraw(10);
            decimal balance = acct.GetBalance();
            Console.WriteLine($"Account balance is {balance} (should be 10)");

            acct.Deposit(-10);
            balance = acct.GetBalance();
            Console.WriteLine($"Account balance is {balance} (should be 10)");

            acct.Withdraw(-10);
            balance = acct.GetBalance();
            Console.WriteLine($"Account balance is {balance} (should be 10)");

            acct.Withdraw(20);
            balance = acct.GetBalance();
            Console.WriteLine($"Account balance is {balance} (should be 10)");
*/
        }
    }
}
