using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class InsufficientBalanceException : ApplicationException
    {
        public InsufficientBalanceException(string message) : base(message) { }
    }
   

    class BankAccount
        {
            private decimal balance;

            public BankAccount(decimal initialBalance)
            {
                balance = initialBalance;
            }

            public void Deposit(decimal amount)
            {
                balance += amount;
                Console.WriteLine("Deposited: " + amount);
            }

            public void Withdraw(decimal amount)
            {
                if (amount > balance)
                {
                    throw new InsufficientBalanceException("Not enough balance!");
                }

                balance -= amount;
                Console.WriteLine("Withdrawn: " + amount);
            }

            public void ShowBalance()
            {
                Console.WriteLine("Current Balance: " + balance);
            }
        }
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                BankAccount acc = new BankAccount(1000);

                acc.Deposit(500);
                acc.Withdraw(200);
                acc.Withdraw(2000); // Exception here

                acc.ShowBalance();
            }
            catch (InsufficientBalanceException ex)
            {
                Console.WriteLine("Custom Exception: " + ex.Message);
            }
        }
    }
}
