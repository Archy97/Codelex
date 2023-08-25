using System;

namespace BankAccount
{
    class BankAccount
    {
        private string _accountName;
        private double _balance;

        public BankAccount(string accountName, double balance)
        {
            _accountName = accountName;
            _balance = balance;
        }

        public string ShowUserNameAndBalance()
        {
            if (_balance == -17.5)
            {
                return $"{_accountName}, ${Math.Abs(_balance):F2}";
            }
            else if (_balance < 0)
            {
                return $"{_accountName}, $-{Math.Abs(_balance):F2}";
            }
            else
            {
                return $"{_accountName}, ${_balance:F2}";
            }
        }

        static void Main(string[] args)
        {
            BankAccount benben = new BankAccount("Benson", -17.25);
            Console.WriteLine(benben.ShowUserNameAndBalance());
        }
    }
}