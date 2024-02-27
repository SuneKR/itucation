using InheritanceDemo;
using System.Security.Authentication.ExtendedProtection; // right click current project -> Add -> Project Reference

namespace AnotherProject
{
    internal class Program
    {
        public class Datter : Person
        {
            public void DattersInfo()
            {
                alder = 21;
                pt = 8; // proctedted
                pti = 9; //protected or internal
                //prpt = 5; //private protected - not allowed because different namespace
                //i = 7;  //internal - not allowed because different namespace
            }

        }
        static void Main(string[] args)
        {
            Datter Maria = new Datter();
            Maria.FarFarsInfo();
            Maria.PersonInfo();
            Maria.DattersInfo();
        }
    }
}
