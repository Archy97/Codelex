using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7
{
    public class SavingsAccount
    {
        private double _annualInterestRate;
        private double _balance;

        public SavingsAccount(double startingBalance)
        {
            _balance = startingBalance;
        }
        public void SetAnnualInterestRate(double interestRate)
        {
            _annualInterestRate = interestRate;
        } 

        public double GetBalance()
        {
            return _balance;
        }

        public void Withdraw(double amount)
        {
            _balance -= amount;
        }

        public double Deposit(double amount)
        {
            return _balance += amount;
        }

        public void AddMonthlyInterest()
        {
            var monthlyInterestRate = _balance * _annualInterestRate / 12;

            _balance += monthlyInterestRate;
        }

        public double CalculateMonthlyInterest()
        {
            return _balance * _annualInterestRate / 12;
        }
    }
}