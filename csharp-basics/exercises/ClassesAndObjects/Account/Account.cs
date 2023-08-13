using System;

namespace Account
{
    class Account
    {
        public string BankAccount;
        public double Balance;

        public Account(string bankAccount, double balance)
        {
            BankAccount = bankAccount;
            Balance = balance;
        }

        public double Withdraw(double withdraw)
        {
            return Balance -= withdraw;
        }

        public double Deposit(double deposit)
        {
            return Balance += deposit;
        }

        public override string ToString()
        {
            return $"{BankAccount}: {Balance:C}";
        }
    }
}