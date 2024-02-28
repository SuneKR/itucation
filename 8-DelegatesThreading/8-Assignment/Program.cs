using System.Runtime.CompilerServices;

namespace _8_Assignment
{
    internal class Program
    {
        #region Exercise 1
        public static void Exercise1()
        {
            #region Relevant assignment description
            /*
            --- Exercise 1 ---
            Using two threads: 
            Make the first thread print the even numbers from 1 - 20, 
            and the second thread print the odd numbers.

            The way you solve this exercise is completely up to you, but some ideas include:
             - Two separate methods as targets for your threads
             - A single method with a single parameter
             - Using lambda expressions
             - Finding a way to use a method with multiple parameters (hint: new Thread(() => MethodGoesHere)
             */
            #endregion

            Console.WriteLine("Exercise 1");

            Thread t1 = new Thread( () => { for (int i = 1; i <= 20; i += 2) { ConsoleWriter(i); } });
            Thread t2 = new Thread( () => { for (int i = 2; i <= 20; i += 2) { ConsoleWriter(i); } });
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();

        }

        private static readonly object ConsoleWriterLock = new object ();
        private static bool oddTurn = true;

        public static void ConsoleWriter(int i)
        {
            lock(ConsoleWriterLock)
            {
                while ((i%2 != 0 && !oddTurn) || (i % 2 == 0 && oddTurn))
                {
                    Monitor.Wait(ConsoleWriterLock);
                }
                Console.WriteLine(i);
                oddTurn = !oddTurn;
                Monitor.PulseAll(ConsoleWriterLock);
            }
        }
        #endregion

        #region Exercise 2
        public static void Exercise2()
        {
            #region Relevant assignment description
            /*
            --- Exercise 2 ---
            Create a delegate that accepts two numbers.
            Now add 4 different methods to your delegate: Add, Subtract, Multiply, and Divide.
            You decide how to create the methods, but they should all accept 2 numbers as input. (or more if you're feeling up to it)
            Use a loop and the GetInvocationList method to write a message for each method, including the method name and result (using numbers of your choosing).
             */
            #endregion

            Console.WriteLine("\nExercise 2");

            SimpleAritmeticDelegate sad = Addition;
            sad += Substraction;
            sad += Multiplication;
            sad += Division;

            Random rng = new Random();

            double FirstNumber = rng.Next(1,100);
            double SecondNumber = rng.Next(1,100);

            foreach (Delegate del in sad.GetInvocationList())
            {
                Console.WriteLine($"{ del.Method.Name } of { FirstNumber } & { SecondNumber } equals { del.DynamicInvoke(FirstNumber, SecondNumber) }");

            }
        }
        public delegate double SimpleAritmeticDelegate(double x, double y);
        static double Addition(double x, double y) {  return x + y; }
        static double Substraction(double x, double y) { return x - y; }
        static double Multiplication(double x, double y) { return x * y; }
        static double Division(double x, double y) { return x / y; }
        #endregion

        static void Main(string[] args)
        {
            #region Assignment description
            /*
            --- Exercise 1 ---
            Using two threads: 
            Make the first thread print the even numbers from 1 - 20, 
            and the second thread print the odd numbers.

            The way you solve this exercise is completely up to you, but some ideas include:
             - Two separate methods as targets for your threads
             - A single method with a single parameter
             - Using lambda expressions
             - Finding a way to use a method with multiple parameters (hint: new Thread(() => MethodGoesHere)


            --- Exercise 2 ---
            Create a delegate that accepts two numbers.
            Now add 4 different methods to your delegate: Add, Subtract, Multiply, and Divide.
            You decide how to create the methods, but they should all accept 2 numbers as input. (or more if you're feeling up to it)
            Use a loop and the GetInvocationList method to write a message for each method, including the method name and result (using numbers of your choosing).
             */
            #endregion

            #region Stagging Area
            Exercise1();
            Exercise2();
            #endregion
        }
    }
}
