using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _2_assignments
{
    internal class Die
    {
        #region Relevant assignment describtion
        /*
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
        */
        #endregion

        #region fields & properties
        private int Eyes { get; set; }
        private int DieSides { get; set; }
        private Guid Id { get; set; }
        public int Value { get => Eyes; }
        #endregion

        #region constructors
        public Die(int sides)
        {
            DieSides = sides;
            Id = Guid.NewGuid();
            Roll();
        }

        public Die(): this(6) { }

        #endregion

        #region Methods
        public void Roll()
        {
            Random rnd = new Random();
            Eyes = rnd.Next(1, DieSides + 1);
        }

        public void Look()
        {
            Console.WriteLine($"Die { Id } with { DieSides } sides rolled { Eyes }.");
        }
        #endregion
    }
}
