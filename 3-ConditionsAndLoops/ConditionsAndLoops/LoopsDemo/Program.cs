using System.Reflection.Metadata.Ecma335;

namespace LoopsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string myString = "Hej med dig!";
            //Console.WriteLine(myString.Length);
            //for (int i = 0; i < myString.Length; i++)
            //{
            //    Console.WriteLine(myString[i]);
            //}

            //List<string> magicians = new List<string>();
            //magicians.Add("Blackstone");
            //magicians.Add("Copperfield");
            //magicians.Add("Dresden");
            //magicians.Add("Houdini");

            //for (int i= 0; i < magicians.Count; i++)
            //{
            //    Console.WriteLine(magicians[i]);
            //}

            //foreach (string magician in magicians)
            //{
            //    Console.WriteLine("Magician name: " + magician);
            //}

            //foreach (string magician in magicians)
            //{ 
            //    if (magician == "Dresden")
            //    {
            //        Console.WriteLine("Kaboom!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No kablamo!");
            //    }
            //}

            //dictionary
            //key and value pairs - Dictionary
            //Dictionary<string, string> dictMagicians = new Dictionary<string, string>();
            //dictMagicians.Add("Blackstone", "Disappearing");
            //dictMagicians.Add("Copperfield", "Card");
            //dictMagicians.Add("Dresden", "Explosion");

            //foreach (var magician in dictMagicians)
            //{
            //    Console.WriteLine($"{ magician.Key } performs { magician.Value } tricks!");
            //    Console.WriteLine(magician);
            //}

            //List<int> years = new List<int> { 2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019, 2020 };

            //foreach (int year in years)
            //{
            //    //modulo / remainder
            //    if (year % 4 == 0)
            //    {
            //        Console.WriteLine($"{ year } is a leap year");
            //    }
            //}

            //List<int> numbers = new List<int> { 4, 5, 6 };
            //List<string> chars = new List<string> { "A", "B", "C" };

            //foreach (string c in chars)
            //{
            //    foreach (int i in numbers)
            //    {
            //        Console.WriteLine(c + " " + i);
            //    }
            //}

            // --- while loops ---

            //int num = 10;
            //while (num > 0)
            //{
            //    Console.WriteLine("Hej");
            //    num--;
            //}

            //Console.Write("Enter password: ");
            //string password = Console.ReadLine();
            //while (password != "secret")
            //{
            //    Console.WriteLine("Wrong password");
            //    Console.Write("Enter password: ");
            //    password = Console.ReadLine();
            //}
            //Console.WriteLine("Correct password!");

            int dagnr;

            do
            {
                Console.WriteLine("Enter number from 1-7, get day name back: ");
                dagnr = int.TryParse(Console.ReadLine(), out dagnr) ? dagnr : 9;

                switch (dagnr)
                {
                    case 1:
                        Console.WriteLine("Mandag");
                        break;
                    case 2:
                        Console.WriteLine("Tirsdag");
                        break;
                    case 3:
                        Console.WriteLine("Onsdag");
                        break;
                    case 4:
                        Console.WriteLine("Torsdag");
                        break;
                    case 5:
                        Console.WriteLine("Fredag");
                        break;
                    case 6:
                        Console.WriteLine("Lørdag");
                        break;
                    case 7:
                        Console.WriteLine("Søndag");
                        break;
                    default:
                        if (dagnr != 0)
                        {
                            Console.WriteLine("Det kunne man ikke læse. Prøv igen");
                        }
                        break;
                }
            } while (dagnr != 0);
            //forskellen på while og do while.
            //while tjekker før hver kørsel
            //do while tjekker efter hver kørsel


        }
    }
}
