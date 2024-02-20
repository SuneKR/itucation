using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    internal class Kursist
    {
        #region attributes
        public string name;
        private string city; // private is the default access modifiers
        int phone;

        /*
         * 7 rules of thumb forconstructors
         * 1. Constructor is a special Method - it's runs at special time which is predefined
         * 2. Every class has a constructor - maybe be invisible or empty/parameterless, but it's always there
         * 3. constructor allways have the same name as class
         * 4. No return type
         * 5. Overloading allowed - having multiple methods with same name but deferent parameters
         * 6. It is invoked implicitly when a new instance/object is created
         * 7. Constructors can't be invcoked explicitly
         */
        #endregion

        #region constructors
        public Kursist() //if no parameters given, it's called an empty constructor
        {
            Console.WriteLine("Kursist oprettet!");
        }

        public Kursist(string name, string city) : this() //constructor chaining
        {
            this.name = name;
            this.city = city;
        }

        public Kursist(string name, string city, int phone) : this(name, city)
        {
            this.phone = phone;
        }
        #endregion

        #region Static Method
        public static void StaticMethodForFun() //køres af klassen og ikke object
        {
            Console.WriteLine("Hej fra Static Method");
        }
        #endregion

        #region methods
        //coid means no return type
        public void Introduction()
        {
            Console.WriteLine($"Hej mit navn er { name }, jeg bor i { city }. Mit nummer er { phone }.");
        }

        //getter method
        //or more technically accessor
        public string GetCity()
        {
            return city;
        }

        //Setter method
        //or more correctly mutator
        public void SetCity(string city)
        {
            this.city = city;
        }
        #endregion
    }
}
