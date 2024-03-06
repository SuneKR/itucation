namespace EmuPassTryDemo
{
    /*
     * About enum
     * 1. Enum is a set of integers constants
     * 2. human readable names are sugar-coatung over these integers
     * 3. Enum starts with 0 unless youy give a different number
     */
    public enum ImaginaryPlace
    {
        //numbers are defineable, but undefined just next number, from the one below
        Faerun = 55,
        Gurkhul = 9999,
        Earthsea = 57,
        Chicago
    }
    public class Traveler
    {
        public string Name{ get; set; }
        public ImaginaryPlace Place { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Casting
            //Console.WriteLine((int)44.9); // returns 44
            //Console.WriteLine((int)44.9999999999); // returns 45
            //Console.WriteLine((string)44); // not possible
            //Console.WriteLine((int)"44"); // not possible

            string strInt = "5";
            string strNotInt = "blabla_text";
            string strNull = null;

            //int x = int.Parse(strInt); //OK
            //int x = int.Parse(strNotInt); //returns error
            //int x = int.Parse(strNull); //returns error
            //Console.WriteLine(x);

            //try
            //{
            //    //int x = int.Parse(strInt);
            //    //int x = int.Parse(strNotInt);
            //    //int x = int.Parse(strNull);
            //}
            //catch (FormatException e)
            //{
            //    Console.WriteLine("kunne ikke formattere. Fejl: " + e);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Fejl: " + e);
            //}
            //finally
            //{
            //    Console.WriteLine("\nFinally always runs whether try or a catched worked");
            //}

            Traveler[] travelers = new Traveler[3];
            travelers[0] = new Traveler { Name = "Mark", Place = ImaginaryPlace.Earthsea };
            travelers[1] = new Traveler { Name = "Mia", Place = ImaginaryPlace.Chicago };
            travelers[2] = new Traveler { Name = "Jonas", Place = ImaginaryPlace.Faerun };

            foreach (var traveler in travelers) { Console.WriteLine($"{ traveler.Name } {traveler.Place }"); }

            Console.WriteLine(ImaginaryPlace.Chicago); //returns chicago
            Console.WriteLine((int)ImaginaryPlace.Chicago); //returns 3 if faerun = 0, and returns 58 after vi changed faerun = 55

            ImaginaryPlace ipByNum = (ImaginaryPlace)57;
            Console.WriteLine(ipByNum); //returns Earthsea if Faerun = 55
        }
    }
}
