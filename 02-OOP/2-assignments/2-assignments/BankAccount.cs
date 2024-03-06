using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_assignments
{
    internal class BankAccount
    {
        #region Relevant assignment describtion
        /*
            --- Exercise 5 ---
            Class: BankAccount
            - Consider which fields/variables a bank account might need.
            - Consider what behaviour it needs to implement.
            - Now write the class! Both Constructor and a few required methods.
            Create an object to test the behaviour of your new class!
        */
        #endregion

        #region fields & properties
        public string AccountName { get; set; }
        public string AccountOwner { get; set; }
        private double Balance { get; set; }
        private string Currency { get; set; }
        #endregion

        #region constructors
        public BankAccount() 
        {
            Random rng = new Random();
            AccountName = "Savings";
            Balance = rng.Next(1000, 12000);
            Student Owner = new Student();
            AccountOwner = Owner.GetName();
            Currency = "DKK";
        }
        public BankAccount(string accountName, int balance)
        {
            this.AccountName = accountName;
            this.Balance = balance;
        }
        #endregion

        #region Methods
        private void AccountChange(string Process, int BalanceChange, int sign)
        {
            Console.WriteLine($"{ AccountOwner }'s { AccountName }account: { Process }ing { BalanceChange } { Currency }");
            Balance += (BalanceChange*sign);
            Status();
        }

        public void ChangeCurrency(string NewCurrencyName, double ExchangeRate)
        {
            Console.WriteLine($"Changing { AccountOwner }'s { AccountName }account From { Currency } to { NewCurrencyName }");
            Console.WriteLine($"1 { NewCurrencyName } equals { ExchangeRate } { NewCurrencyName }");
            Currency = NewCurrencyName;
            Balance /= ExchangeRate;
            Status();
        }

        public void Deposite(int amount)
        {
            AccountChange("deposit", amount, 1);
        }
        public void Status()
        {
            Console.WriteLine($"{ AccountOwner }'s { AccountName }account: Current balance { Balance.ToString("N2") } { Currency }.");
        }

        public void Withdrawal(int amount)
        {
            AccountChange("withdraw", amount, (-1));
        }
        #endregion
    }
}
