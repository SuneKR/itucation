using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    internal class Barn : Far, IMor, IOneInterface
    {
        public void Experience()
        {
            Console.WriteLine("My experiences are my own");
        }

        public void Intelligence()
        {
            Console.WriteLine("I have inherited my intelligence from my mother");
        }

        public void ShowOne()
        {
            Console.WriteLine("Show one made my barn");
        }
    }
}
