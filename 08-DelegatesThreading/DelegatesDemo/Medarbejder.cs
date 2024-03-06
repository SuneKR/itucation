using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    public class Medarbejder
    {
        public string Navn { get; set; }
        public int Erfaring { get; set; }
        public double Løn { get; set; }

        //public static void Lønforhøjelse(List<Medarbejder> maList) //first implemation
        public static void Lønforhøjelse(List<Medarbejder> maList, LønforhøjelsesDelegate dele)
        {
            foreach (Medarbejder ma in maList)
            {
                if (dele(ma))
                {
                    Console.WriteLine($"{ ma.Navn }s gamle løn: { ma.Løn }");
                    ma.Løn += 2500;
                    Console.WriteLine($"{ ma.Navn }s nye løn: { ma.Løn }");
                }
            }
        }
    }
}
