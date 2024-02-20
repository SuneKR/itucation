using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_assignments
{
    internal class ClickCounter
    {
        #region Relevant Assignment describtion
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
        #endregion

        #region fields & properties
        public string Count { get => $"Current count is {value}."; }
        private int value;
        #endregion

        #region constructors
        public ClickCounter() { }
        #endregion

        #region Methods
        public void Click()
        {
            value++;
            Console.WriteLine("Click!");
        }

        public void Reset() 
        {
            value = 0;
            Console.WriteLine("Counter reset");
        }
        #endregion
    }
}
