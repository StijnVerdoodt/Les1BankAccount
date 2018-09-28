using BankingA1.Models.Domain;
using System;

namespace BankingA1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Object Initializer
            //BankAccount anotherBA = new BankAccount()
            //{
            //    AccountNumber = "123-12312334-99",
            //    Balance = 200
            //};


            BankAccount myBA = new BankAccount("123-12312312-99", 50);
            Console.WriteLine($"Account number is {myBA.AccountNumber}");
            Console.WriteLine($"Balance is {myBA.Balance} Euro");
            myBA.Deposit(200);
            Console.WriteLine($"Balance is {myBA.Balance} Euro");
            myBA.Withdraw(50);
            Console.WriteLine($"Balance is {myBA.Balance} Euro");
            Console.ReadKey();
            
        }
    }
}
