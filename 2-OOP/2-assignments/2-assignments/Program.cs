using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace _2_assignments
{
    internal class Program
    {
        #region Exercise1
        /*
            --- Exercise 1 ---
            Create the class with the following functionality:
            - 'Empty' constructor (no arguments required)
            - 'value' variable
            - 'Click()' method
            - 'Reset()' method
            Decide how to display your current value: After each function call? Only when asked?
            Create an object and test your class!
        */

        static void Exercise1()
        {
            ClickCounter cc = new ClickCounter();
            Console.WriteLine(cc.Count);

            for (int i = 0; i < 10; i++)
            {
                cc.Click();
            }

            Console.WriteLine(cc.Count);
            cc.Reset();
            Console.WriteLine(cc.Count);
        }
        #endregion

        #region Exercise2
        /*
            --- Exercise 2 ---
            Class: Die
            A 6-sided die that can be rolled!
            - Consider how/if to keep track of your 6 sides.
            - Implement a 'Roll()' method, which returns a random integer (1 - 6)
            hint: The Random class is very helpful
        */
        static void Exercise2()
        {
            Die d1 = new Die();
            d1.Look();
            d1.Roll();
            d1.Look();
        }
        #endregion

        #region Exercise3
        /*
        --- Exercise 3 ---
        Class: Die
        An n-sided die that can be rolled!
        (If you want to keep your old class intact, you can create this one with a different name.)
        - This time, every die you create takes an int (sides) as a parameter.
        - Consider which changes you have to make compared to your old die.
        - Implement the 'Roll()' method.
        */
        static void Exercise3()
        {
            Die d2 = new Die(32);
            Die d3 = new Die(54);
            d2.Look();
            d3.Look();
            d2.Roll();
            d3.Roll();
            d2.Look();
            d3.Look();

        }
        #endregion

        #region Exercise4
        static void Exercise4()
        {
            //Student s1 = new Student();
            //s1.ListStudent();
            Class c1 = new Class();
            c1.ListStudents();
            c1.GetTotalScore();
            c1.GetAverageScore();

        }
        #endregion

        #region Exercise5
        /*
            --- Exercise 5 ---
            Class: BankAccount
            - Consider which fields/variables a bank account might need.
            - Consider what behaviour it needs to implement.
            - Now write the class! Both Constructor and a few required methods.
            Create an object to test the behaviour of your new class!
        */
        static void Exercise5()
        {
            BankAccount b1 = new BankAccount();
            b1.Status();
            b1.Withdrawal(100);
            b1.Deposite(50);
            b1.ChangeCurrency("USD", 6.92);
        }
        #endregion

        static void Main(string[] args)
        {
            #region Assignment describtion
            /*
            --- Exercise 1 ---
            Create the class with the following functionality:
            - 'Empty' constructor (no arguments required)
            - 'value' variable
            - 'Click()' method
            - 'Reset()' method
            Decide how to display your current value: After each function call? Only when asked?
            Create an object and test your class!


            --- Exercise 2 ---
            Class: Die
            A 6-sided die that can be rolled!
            - Consider how/if to keep track of your 6 sides.
            - Implement a 'Roll()' method, which returns a random integer (1 - 6)
            hint: The Random class is very helpful


            --- Exercise 3 ---
            Class: Die
            An n-sided die that can be rolled!
            (If you want to keep your old class intact, you can create this one with a different name.)
            - This time, every die you create takes an int (sides) as a parameter.
            - Consider which changes you have to make compared to your old die.
            - Implement the 'Roll()' method.


            --- Exercise 4 ---
            Class: Student
            For the purpose of this exercise, a student has a name and a test score based on the tests they've taken.
            - 'AddTest(score)'
            - 'GetTotalScore()'
            - 'GetAverageScore()'
            Which variables does your class need when you construct it?
            Implement the class and create an object to test it!


            --- Exercise 5 ---
            Class: BankAccount
            - Consider which fields/variables a bank account might need.
            - Consider what behaviour it needs to implement.
            - Now write the class! Both Constructor and a few required methods.
            Create an object to test the behaviour of your new class!
             */
            #endregion

            #region Staging Area
            Exercise1();
            Exercise2();
            Exercise3();
            Exercise4();
            Exercise5();
            #endregion
        }
    }
}
