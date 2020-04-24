using System;

namespace ex024
{
    // Encapsulation || used to hide information, protecting the class
    class BankAccount
    {
        private double balance = 0; // A private member can't be accessed from outside the class
        public void Deposit(double amount)
        {
            balance += amount;
            Console.WriteLine("{0}$ added to your account.", amount);
        }
        public void GetBalance()
        {
            Console.WriteLine("Account value: {0}$", balance);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount a1 = new BankAccount();
            // Now you can't access your account's balance directly because it is protected. So we use public methods.
            a1.GetBalance();
            a1.Deposit(50.32);
            a1.GetBalance();
        }
    }
}
