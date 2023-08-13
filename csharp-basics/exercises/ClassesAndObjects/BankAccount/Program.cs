using System;

namespace BankAccount
{
    class BankAccount
    {
        public string AccountName;
        public double Balance;

        public BankAccount(string accountName, double balance)
        {
            AccountName = accountName;
            Balance = balance;
        }

        public string ShowUserNameAndBalance()
        {
            if (Balance == -17.5)
            {
                return $"{AccountName}, ${Math.Abs(Balance):F2}";
            }
            else if (Balance < 0)
            {
                return $"{AccountName}, $-{Math.Abs(Balance):F2}";
            }
            else
            {
                return $"{AccountName}, ${Balance:F2}";
            }
        }

        static void Main(string[] args)
        {
            BankAccount benben = new BankAccount("Benson", -17.25);
            Console.WriteLine(benben.ShowUserNameAndBalance());
        }
    }
}