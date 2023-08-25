using System;

namespace Account
{
    class Program
    {
        static void Main(string[] args)
        {
            Account bartosAccount = new Account("Barto's account", 100.00);
            Account bartosSwissAccount = new Account("Barto's account in Switzerland", 1000000.00);
            Account matsAccount = new Account("Matt's account", 1000);
            Account myAccount = new Account("My account", 0);
            Account A = new Account("A", 100);
            Account B = new Account("B", 0);
            Account C = new Account("C", 0);

            Console.WriteLine("Initial state");
            Console.WriteLine(bartosAccount);
            Console.WriteLine(bartosSwissAccount);

            bartosAccount.Withdraw(20);
            Console.WriteLine("Barto's account balance is now: " + bartosAccount.Balance.ToString("F2"));

            bartosSwissAccount.Deposit(200);
            Console.WriteLine("Barto's Swiss account balance is now: " + bartosSwissAccount.Balance.ToString("F2"));

            Console.WriteLine("Final state");
            Console.WriteLine(bartosAccount);
            Console.WriteLine(bartosSwissAccount);

            matsAccount.Withdraw(100);
            myAccount.Deposit(100);
            Console.WriteLine(matsAccount);
            Console.WriteLine(myAccount);

            Transfer(A, B, 50);
            Transfer(B, C, 25);

            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(C);
        }

        public static void Transfer(Account from, Account to, double howMuch)
        {
            from.Withdraw(howMuch);
            to.Deposit(howMuch);
        }
    }
}