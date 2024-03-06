using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Assignments.Lasers
{
    internal class DeathStar : ILaser
    {
        public void FireLaser()
        {
            Console.WriteLine($"You feel a great disturbance in the Force as if milllions voices suddently cried out in terror, and were suddenly silenced. You fear something terrible has happened.");
        }
    }
}
