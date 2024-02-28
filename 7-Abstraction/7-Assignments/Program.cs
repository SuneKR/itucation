using System.Security.AccessControl;
using _7_Assignments.Accounts;
using _7_Assignments.Lasers;

namespace _7_Assignments
{
    internal class Program
    {
        #region Exercise1
        public static void Exercise1()
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

            Console.WriteLine("Exercise 1");

            Console.WriteLine("\nCheckingsaccount shenanigans");
            CheckingAccount ca = new CheckingAccount();
            ca.Deposit(1000);
            ca.Deposit(5000);
            ca.Withdraw(500);
            ca.Withdraw(4000);

            Console.WriteLine("\nSavingsaccount hijinks");
            SavingsAccount sa = new SavingsAccount();
            sa.Deposit(1000);
            sa.Deposit(4000);
            sa.Withdraw(500);
            sa.Withdraw(4000);
        }
        #endregion

        #region Exercise2
        public static void Exercise2()
        {
            #region Relevant Assignment Description
            /*
            --- Exercise 2: Interface ---
            a. Create an interface named ILaser.
               The interface contains the method FireLaser.

            b. Create a class called DeathStar that implements the ILaser interface.
               You decide what the FireLaser method does. If you can't think of anything, just make it write/return "Pew pew".

            c. Fire your lasers! (test your class/interface)
             */
            #endregion

            Console.WriteLine("\nExercise 2");

            DeathStar ds = new DeathStar();
            ds.FireLaser();
        }
        #endregion

        #region Exercise3

        public enum Face
        {
            ace, two, three, four, five,
            six, seven, eight, nine, ten,
            jack, queen, king
        }

        public enum Suit
        {
            clubs,
            diamonds,
            hearts,
            spades
        }
        public static void Exercise3()
        {
            #region Relevant Assignment Description
            /*
            --- Exercise 3: Enum ---
            For this exercise you are making a random card picker!
            a. Create two enums:
               Face, which contains all of the 13 face values of playing cards (from ace to king).
               Suit, which contains the four suits (spades, hearts, diamonds, clubs).

            b. Use an object of the Random class to select two suitable random numbers (use the Next method):
               - Use one random number to get the face value of a card.
               - Use the other random number to get the suit value of a card.

            c. Print the card (face and suit)!
             */
            #endregion

            Console.WriteLine("\nExercise 3");

            Console.WriteLine("Pick a card");
            Random rng = new Random();
            Console.WriteLine($"You picked the { (Face)rng.Next(0, Enum.GetValues(typeof(Face)).Length) } of { (Suit)rng.Next(0, Enum.GetValues(typeof(Suit)).Length) }");

        }
        #endregion

        static void Main(string[] args)
        {
            #region Assignment Description
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


            --- Exercise 2: Interface ---
            a. Create an interface named ILaser.
               The interface contains the method FireLaser.

            b. Create a class called DeathStar that implements the ILaser interface.
               You decide what the FireLaser method does. If you can't think of anything, just make it write/return "Pew pew".

            c. Fire your lasers! (test your class/interface)


            --- Exercise 3: Enum ---
            For this exercise you are making a random card picker!
            a. Create two enums:
               Face, which contains all of the 13 face values of playing cards (from ace to king).
               Suit, which contains the four suits (spades, hearts, diamonds, clubs).

            b. Use an object of the Random class to select two suitable random numbers (use the Next method):
               - Use one random number to get the face value of a card.
               - Use the other random number to get the suit value of a card.

            c. Print the card (face and suit)!
             */
            #endregion

            #region Stagging Area
            Exercise1();
            Exercise2();
            Exercise3();
            #endregion
        }
    }
}