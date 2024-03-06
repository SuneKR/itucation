using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionDemo
{
    public abstract class Employee
    {
        /*
         * Rules for abstract classes
         * 1. You cannot create object/instance of an abstract class
         * 2. If at least one of its members is abstract, the whole class becomes abstract
         * 3. Abstract methods cannot have implementation
         * 4. Abstract class can have both abstract and non-abstract methods
         * 5. Derived class MUST implement abstract methods
         */

        protected Employee() { }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName()
        {
            return FirstName + " " + LastName;
        }
        public abstract double MonthlySalary();
    }
}
