using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Assignments
{
    abstract class BankAccount
    {
        #region Relevant Assignment Description
        /*
        --- Exercise 1: Abstract Class ---
        a. Create an abstract class named BankAccount. The class has an attribute called balance.
           You decide whether a bank account has an initial balance of 0 or uses a number parameter in its constructor.
           A bank account has two required abstract methods: Deposit and Withdraw. Both can be either void methods or return balance.
           For testing purposes, you might want a way to check your balance between Deposit/Withdraw calls as well.

        b. Create a derived class called CheckingAccount that implements the Withdraw and Deposit methods.
           When you use the withdraw method with a number higher than 3000, 
            the method should print a warning and do nothing else.
           Deposit just adds to your balance.

        c. Create a derived class called SavingsAccount that implements the Withdraw and Deposit methods.
           When you use the deposit method, the amount is automatically increased by .1%
            before the amount is added to your balance.
           Withdraw just subtracts from your balance.
        */
        #endregion

        protected double Balance = 0;

        public abstract void CheckBalance();
        public abstract void Deposit(double deposite);
        public abstract void Withdraw(double withdrawal);
    }
}
