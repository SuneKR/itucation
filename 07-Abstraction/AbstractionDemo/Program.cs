using System.Globalization;

namespace AbstractionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee emp = new Employee(); //not allowed because it's abstract
            //Employee emp = new FullTimeEmployee() {  }; //this is allowed because of polymorphism, and it juist a strange way of creating a FullTimeEmployee
            
            Console.WriteLine("Fulltime employee");
            //This is newer way to create objects.
            FullTimeEmployee fe = new FullTimeEmployee { FirstName = "Mark", LastName = "Marksen", AnnualSalary = 400000 };
            Console.WriteLine($"{ fe.FullName() } \t Salary: { fe.MonthlySalary() }");

            Console.WriteLine("Parttime employee");
            PartTimeEmployee pe = new PartTimeEmployee { FirstName = "Freja", LastName = "Frejsen", HourlyPay = 250, MonthlyPay = 98 };
            Console.WriteLine($"{ pe.FullName() } \t Salary: { pe.MonthlySalary() }");
        }
    }
}
