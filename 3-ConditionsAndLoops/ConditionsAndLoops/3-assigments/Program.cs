using System.Security.Cryptography.X509Certificates;

namespace _3_assigments
{
    internal class Program
    {
        #region Exercise 1
        static void Exercise1()
        {
            #region Assignment
            /*
            ---Exercise 1-- -
            Use a for loop to print each odd number from 1 to 20.
            */
            #endregion

            Console.WriteLine("Write odd natural numbers below 20");

            for (int i = 1;  i <= 20; i+=2) 
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("");
        }
        #endregion

        #region Exercise 2
        static void Exercise2()
        {
            #region Assignment description 
            /*
            -- - Exercise 2-- -
            Write code that accepts an input until the user guesses a magic word.
            Give them a reasonable amount of guesses until the loop ends by itself.
            Print a message and break the loop when their guess is correct.
            */
            #endregion
            bool magicWordFound = false;
            int guesses = 0;

            
            do
            {
                Console.WriteLine("Guess the magic word in less than three guesses");
                Console.WriteLine("or be forever locked out till next program run");
                Console.WriteLine("write exit() to exit");
                string magicWord = Console.ReadLine();
                switch (magicWord)
                {
                    case "the magic word":
                        Console.WriteLine("Correct");
                        magicWordFound = true;
                        break;
                    case "exit()":
                        Console.WriteLine("exiting");
                        guesses = 3;
                        break;
                    default:
                        guesses++;
                        if (guesses < 3) { Console.WriteLine($"Wrong guess you have {3 - guesses} guesses"); }
                        else { Console.WriteLine("You have guessed wrong. Your are locked out!"); }
                        break;
                }

            } while (!magicWordFound && guesses < 3);
        }
        #endregion

        #region Exercise 3
        static void Exercise3()
        {
            /*
            ---Exercise 3-- -
            A movie theater charges different ticket prices depending on a peron's age.
            If a person is under the age of 3, the ticket is free; if they are between 3 and 12, the ticket is $10;
            and if they are over age 12, the ticket is $15.Write code in which you ask the users for an age, and then
            tell them the cost of a movie ticket.
            */

            int age;
            do
            {
                Console.WriteLine("Write you age to get ticket price");
                age = int.TryParse(Console.ReadLine(), out age) ? age : -1;
                if (age < 0) { Console.WriteLine("Det forstod jeg ikke. Prøv at skrive det igen med tal."); }

            } while (age <= 0);
            if(age > 12) { Console.WriteLine($"At the age { age } your price will be $15"); }
            else if(age < 3) { Console.WriteLine($"At the age { age } your price will be $0"); }
            else { Console.WriteLine($"At the age { age } your price will be $10"); }

        }
        #endregion

        #region Exercise 4
        static void Exercise4() 
        {
            /*
            -- - Exercise 4-- -
            a.Write a loop that prompts the user to enter a series of pizza toppings until they break the loop.
                As they enter each topping, print a message saying you'll add that topping to their pizza.

            b.Modify your pizza program to include a list of the toppings the user enters.
                When the loop breaks, print a message confirming their order has been saved, along with a list of their desired toppings.

            c.Before adding a topping to the list of desired toppings, check whether the topping is already added.
                Tell the user that that topping already exists in their order.
            */
            

            List<string> toppings = new List<string>() { "basil", "bellpeper", "cheese", "garlic", "mushrooms", "pineapple", "potatoes", "tomatosauce" };
            List<string> chooosenToppings = new List<string>();
            bool doneSelecting = false;

            while (!doneSelecting)
            {
                Console.WriteLine("Write Done or press enter finish selecting topping");
                for (int i = 0; i < toppings.Count; i++)
                {
                    Console.WriteLine($"press { i } to add { toppings[i] } to you pizza");
                }
                string input = Console.ReadLine();

                switch (input)
                {
                    case "Done" or "done" or "" or "enter" or "Enter":
                        Console.WriteLine("You are done selecting toppings");
                        doneSelecting = !doneSelecting;
                        break;
                    case "0":
                        chooosenToppings = ToppingAdder(toppings[int.Parse(input)], chooosenToppings);
                        break;
                    case "1":
                        chooosenToppings = ToppingAdder(toppings[int.Parse(input)], chooosenToppings);
                        break;
                    case "2":
                        chooosenToppings = ToppingAdder(toppings[int.Parse(input)], chooosenToppings);
                        break;
                    case "3":
                        chooosenToppings = ToppingAdder(toppings[int.Parse(input)], chooosenToppings);
                        break;
                    case "4":
                        chooosenToppings = ToppingAdder(toppings[int.Parse(input)], chooosenToppings);
                        break;
                    case "5":
                        chooosenToppings = ToppingAdder(toppings[int.Parse(input)], chooosenToppings);
                        break;
                    case "6":
                        chooosenToppings = ToppingAdder(toppings[int.Parse(input)], chooosenToppings);
                        break;
                    case "7":
                        chooosenToppings = ToppingAdder(toppings[int.Parse(input)], chooosenToppings);
                        break;
                    case "exit()" or "exit" or "Exit()" or "Exit":
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine("You have choosen the following toppings");
            foreach (string topping in chooosenToppings)
            {
                Console.WriteLine(topping);
            }
        }
        
        static List<string> ToppingAdder(string toppingNew, List<string> toppingsList)
        {
            if (!toppingsList.Contains(toppingNew))
            {
                toppingsList.Add(toppingNew);
                Console.WriteLine($"{ toppingNew } is added to the pizzatopping!");
                Console.WriteLine("");
                return toppingsList;
            }
            Console.WriteLine($"{ toppingNew } already was on pizzatopping!");
            Console.WriteLine("");
            return toppingsList;
        }
        #endregion

        static void Main(string[] args)
        {
            #region Assignment description
            /*
            ---Exercise 1-- -
            Use a for loop to print each odd number from 1 to 20.

            -- - Exercise 2-- -
            Write code that accepts an input until the user guesses a magic word.
            Give them a reasonable amount of guesses until the loop ends by itself.
            Print a message and break the loop when their guess is correct.

            ---Exercise 3-- -
            A movie theater charges different ticket prices depending on a peron's age.
            If a person is under the age of 3, the ticket is free; if they are between 3 and 12, the ticket is $10;
            and if they are over age 12, the ticket is $15.Write code in which you ask the users for an age, and then
            tell them the cost of a movie ticket.
            

            -- - Exercise 4-- -
            a.Write a loop that prompts the user to enter a series of pizza toppings until they break the loop.
                As they enter each topping, print a message saying you'll add that topping to their pizza.

            b.Modify your pizza program to include a list of the toppings the user enters.
                When the loop breaks, print a message confirming their order has been saved, along with a list of their desired toppings.

            c.Before adding a topping to the list of desired toppings, check whether the topping is already added.
                Tell the user that that topping already exists in their order.
            */
            #endregion

            #region Staging area
            //Exercise1();
            //Exercise2();
            //Exercise3();
            //Exercise4();
            #endregion
        }
    }
}
