using System.Text.RegularExpressions;

namespace _1_Assignments
{
    internal class Program
    {
        static void ExerciseOne()
        {
            Console.WriteLine("Start of Exercise 1");

            /*
            --- Exercise 1 ---
            a. Assign a message to a variable and then print that message.

            b. Assign a message to a variable, and print that message. 
               Then change the value of the variable to a new message, and print the new message.
             */

            string ExerOneA = "I have created a mesasge for exercise 1A";
            Console.WriteLine(ExerOneA);

            string ExerOneB = "I have created a mesasge for exercise 1B";
            Console.WriteLine(ExerOneB);
            ExerOneB = "I have changed the mesasge for exercise 1B";
            Console.WriteLine(ExerOneB);
        }

        static void ExerciseTwo()
        {
            Console.WriteLine("Start of Exercise 2");

            /*
            --- Exercise 2 ---
            a. Use a variable to represent a person's name, and print a message to that person. 
               Your message should just be something simple, such as "Greetings name, are you ready for an adventure?"

            b. Use a variable to represent a person's name, and then print that person's name in
               lowercase and uppercase

            c. Find a cool quote you like. Print the quote and the name of its author.
               The output has to include quotation marks!

            d. Repeat 2-c, but this time represent the famous person's name using a variable called famous_person.
               Then compose your message, and represent it with a new variable called message. Print your message!

            e. Use a variable to represent a person's name, but include some whitespace in the beginning and the end of the name.
               Print the name once with the whitespace, then three more times stripping the left, right, and total whitespace.
             */

            string NamedPerson = "[Authentic Human Name]";
            string ExerTwoA = $"I have created a greating to { NamedPerson } for exercise 2A";
            Console.WriteLine(ExerTwoA);

            Console.WriteLine("Printing name in lower and upper case for exercise 2B");
            Console.WriteLine(NamedPerson.ToLower());
            Console.WriteLine(NamedPerson.ToUpper());

            Console.Write("Exercise 2C:");
            Console.WriteLine("\"Help me, Obi-Wan Kenobi. You’re my only hope.\" - Captain Picard");

            Console.Write("Exercise 2D:");
            string DifferentWrongPerson = "Second-class technician Rimmer";
            Console.WriteLine($"\"Help me, Obi-Wan Kenobi. You’re my only hope.\" - { DifferentWrongPerson }");

            Console.WriteLine("Exercise 2E: Different trims of Name with whitespace (none, left, right, both)");
            string WhitespaceName = "   Paul Atreides   ";
            Console.WriteLine($"[{ WhitespaceName }]");
            Console.WriteLine($"[{ WhitespaceName.TrimStart() }]");
            Console.WriteLine($"[{ WhitespaceName.TrimEnd() }]");
            Console.WriteLine($"[{ WhitespaceName.Trim() }]");
        }

        static void ExerciseThree()
        {
            Console.WriteLine("Start of Exercise 3");

            /*
            --- Exercise 3 ---
            a. Write addition, subtraction, multiplication, and division that each result in the number 26.
               Print four lines to show the results.

            b. Use a variable to represent your favourite number.
               Then, using that variable, create a message that reveals your favourite number - print it!

            c. One kilometer is approximately 0.62 miles.
               Use a variable to represent your daily travel distance in kilometers.
               Write code to print your daily travel distance in miles.
             */

            Console.WriteLine("Exercise 3A:");
            Console.WriteLine($"7 + 19 = { 7 + 19 }");
            Console.WriteLine($"48 - 22 = { 48 - 22 }");
            Console.WriteLine($"2 * 13 = { 2 * 13 }");
            Console.WriteLine($"78 / 3 = { 78 / 3}");

            Console.WriteLine("Exercise 3B:");
            int FavouriteNumber = 13;
            Console.WriteLine($"People might think it's unlucky, but { FavouriteNumber } is my favourite number.");

            Console.WriteLine("Exercise 3C:");
            double dailyTravelInKm = 5.78;
            Console.WriteLine($"Daily travel in kilometers: { dailyTravelInKm } km.");
            Console.WriteLine($"Daily travel in miles: { (dailyTravelInKm * 0.62).ToString("G3") } miles.");
            //Console.WriteLine($"Daily travel in miles: { dailyTravelInKm * 0.62 } miles.");

        }

        static void Main(string[] args)
        {
            /*
            --- Exercise 1 ---
            a. Assign a message to a variable and then print that message.

            b. Assign a message to a variable, and print that message. 
               Then change the value of the variable to a new message, and print the new message.


            --- Exercise 2 ---
            a. Use a variable to represent a person's name, and print a message to that person. 
               Your message should just be something simple, such as "Greetings name, are you ready for an adventure?"

            b. Use a variable to represent a person's name, and then print that person's name in
               lowercase and uppercase

            c. Find a cool quote you like. Print the quote and the name of its author.
               The output has to include quotation marks!

            d. Repeat 2-c, but this time represent the famous person's name using a variable called famous_person.
               Then compose your message, and represent it with a new variable called message. Print your message!

            e. Use a variable to represent a person's name, but include some whitespace in the beginning and the end of the name.
               Print the name once with the whitespace, then three more times stripping the left, right, and total whitespace.


            --- Exercise 3 ---
            a. Write addition, subtraction, multiplication, and division that each result in the number 26.
               Print four lines to show the results.

            b. Use a variable to represent your favourite number.
               Then, using that variable, create a message that reveals your favourite number - print it!

            c. One kilometer is approximately 0.62 miles.
               Use a variable to represent your daily travel distance in kilometers.
               Write code to print your daily travel distance in miles.
             */


            ExerciseOne();
            Console.WriteLine("");
            ExerciseTwo();
            Console.WriteLine("");
            ExerciseThree();

            Console.ReadKey();
        }
    }
}
