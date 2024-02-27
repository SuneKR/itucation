using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionDemo
{
    internal class PartTimeEmployee : Employee
    {
        public double HourlyPay { get; set; }
        public double MonthlyPay { get; set; }

        public override double MonthlySalary()
        {
            return HourlyPay * MonthlyPay;
        }
    }
}
