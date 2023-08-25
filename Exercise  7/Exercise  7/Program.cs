using System;

namespace Exercise_7
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the starting balance: ");
            double startingBalance = double.Parse(Console.ReadLine());

            Console.Write("Enter the annual interest rate: ");
            double annualInterestRate = double.Parse(Console.ReadLine());

            Console.Write("How long has the account been opened? ");
            int NumbersOfMonths = int.Parse(Console.ReadLine());

            SavingsAccount account = new SavingsAccount(startingBalance);
            account.SetAnnualInterestRate(annualInterestRate);

            int totalDeposited = 0;
            int totalWithdrawn = 0;
            double totalInterest = 0;

            for (int i = 0; i < NumbersOfMonths; i++)
            {
                Console.Write($"Enter amount deposited for month {i + 1}: ");
                int deposited = int.Parse(Console.ReadLine());
                totalDeposited += deposited;
                account.Deposit(deposited);

                Console.Write($"Enter amount withdrawn for month {i + 1}: ");
                int withdrawn = int.Parse(Console.ReadLine());
                totalWithdrawn += withdrawn;
                account.Withdraw(withdrawn);

                totalInterest += account.CalculateMonthlyInterest();
                account.AddMonthlyInterest();
            }

            Console.WriteLine($"\nTotal deposited: {totalDeposited:C2}\n" +
                              $"Total withdrawn: {totalWithdrawn:C2}\n" +
                              $"Interest earned: {totalInterest:C2}\n" +
                              $"Ending balance: {account.GetBalance():C2}");
        }
    }
}


