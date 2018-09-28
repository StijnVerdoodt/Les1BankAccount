using System;

namespace BankingA1.Models.Domain
{
    public class BankAccount
    {
        #region Fields
        //private string _accountNumber; 
        //Automatic property
        // public const decimal WithdrawCost = 0.10M; M van Decimal

        private decimal _balance;
        #endregion

        #region Comments
        //public decimal GetBalance()
        //{
        //    return _balance;
        //}

        //private void SetBalance(decimal value)
        //{
        //    _balance = value;
        //}

        //Onderstaande lijn is gelijk aan alle voorgaande code 
        //public decimal Balance { get; private set; }
        #endregion

        #region Properties
        public string AccountNumber { get; private set; }

        public decimal Balance
        {
            get
            {
                return _balance;
            }
            private set
            {
                if (value < 0)
                    throw new ArgumentException("No negative balance allowed");
                _balance = value;
            }
        }

        #endregion

        #region Constructors
        public BankAccount()
        {
            
        }
        public BankAccount(string accountNumber)
        {
            AccountNumber = accountNumber;
        }

        public BankAccount(string accountNumber, decimal balance) : this(accountNumber)
        {
            Balance = balance;
        }
        #endregion

        #region Methods
        public void Deposit(decimal amount)
        {
            Balance += amount;
        }
        //Kan ook met optionele parameter

        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        } 
        #endregion
    }
}