using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Assignments
{
    internal interface ILaser
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

        public void FireLaser();
    }
}
