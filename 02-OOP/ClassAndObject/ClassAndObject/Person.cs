using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    internal class Person
    {
        #region proporties
        //Genvej til lave propoerties: prop + tab
        public string Name { get; set; }
        public string Info { get => $"{ Name } er navnet på personen."; }
        public int Id
        {
            get { return Id; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Vi acceptere ikke negative værdier!");
                }
                else
                {
                    
                }

            }
        }
        #endregion
    }
}
