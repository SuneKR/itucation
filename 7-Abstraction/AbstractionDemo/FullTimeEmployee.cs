using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionDemo
{
    internal class FullTimeEmployee : Employee
    {
        public double AnnualSalary { get; set; }
        public override double MonthlySalary()
        {
            return AnnualSalary / 12;
        }
    }
}
