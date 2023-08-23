using System;

namespace Account
{
    class Account
    {
        private string _bankAccount;
        private double _balance;

        public Account(string bankAccount, double balance)
        {
            _bankAccount = bankAccount;
            _balance = balance;
        }

        public double Withdraw(double withdraw)
        {
            return _balance -= withdraw;
        }

        public double Deposit(double deposit)
        {
            return _balance += deposit;
        }

        public override string ToString()
        {
            return $"{_bankAccount}: {_balance:C}";
        }
    }
}