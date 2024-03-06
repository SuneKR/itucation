using System.Threading.Channels;

namespace DelegatesDemo
{
    //Delegates always needs a parameter type and quantity
    //Delegates can be thought of as a list of methods
    //Delegates can have multiple methods
    //Delegates won't work, if you change parameter type of quantity
    public delegate void DelegateTest(string besked);
    public delegate int CalcDelegate(int x);
    public delegate bool LønforhøjelsesDelegate(Medarbejder ma);
    internal class Program
    {
        static void Show(string message)
        {
            Console.WriteLine("Show Method: " + message);
        }
        static void Vis(string message)
        {
            Console.WriteLine("Vis Method: " + message);
        }
        static void Info(string message)
        {
            Console.WriteLine("Info Method: " + message);
        }
        static void Display(string message)
        {
            Console.WriteLine("Display Method: " + message);
        }
        static int Kvadrat(int x)
        {
            return x * x;
        }
        static int Kubik(int x)
        {
            return x * x * x;
        }
        static void Main(string[] args)
        {
            //DelegateTest dt = new DelegateTest(Show);
            //dt("Goddag"); //returns Show Method: Goddag

            //dt += new DelegateTest(Vis);
            //dt("Goddag"); //returns Show Method: Goddag \n Vis Method: Goddag

            //Newer syntax for delegate
            //DelegateTest dt;
            //dt = Show;
            //dt += Vis;
            //dt += Info;
            //dt += Display;
            //dt("New syntax"); //returnShow Method: No Display \n Vis Method: No Display \n Info Method: No Display Show Method: New syntax \n Vis Method: New syntax \n Info Method: New syntax \n Display Method: New syntax

            //remove syntax
            //dt -= Display;
            //dt("No Display"); //returns Show Method: No Display \n Vis Method: No Display \n Info Method: No Display

            //See all methods in Delegate
            //foreach (Delegate d in dt.GetInvocationList())
            //{
            //    Console.WriteLine($"Method name: { d.Method.Name } \t return type: { d.Method.ReturnType }");
            //}

            // with return type
            //CalcDelegate cd = Kvadrat;
            //Console.WriteLine(cd(5)); //returns 25

            //cd += Kubik;
            //Console.WriteLine(cd(5));//returns 125

            //runs everything, but only returns last return
            //with DynamicInvoke() all can be 

            //foreach (Delegate d in cd.GetInvocationList())
            //{
            //    Console.WriteLine($"Method name: { d.Method.Name } \t returns: { d.Method.ReturnType }");
            //    Console.WriteLine(d.DynamicInvoke(5));
            //}

            //Console.WriteLine($"Kvadrat: { cd.GetInvocationList()[0].DynamicInvoke(9) }"); //aweful way of doing it, but works

            // Lambda Express
            //CalcDelegate cd2 = x => x * x;
            //Console.WriteLine(cd2(7)); //returns 49

            //cd2 += x => x * x * x;
            //Console.WriteLine(cd2(7)); //returns 343

            //Medarbejdere
            List<Medarbejder> medarbejderList = new List<Medarbejder>();
            medarbejderList.Add(new Medarbejder { Navn = "Cagnus Marlsen", Erfaring = 3, Løn = 22000 });
            medarbejderList.Add(new Medarbejder { Navn = "Ida", Erfaring = 7, Løn = 32000 });
            medarbejderList.Add(new Medarbejder { Navn = "Max Power", Erfaring = 2, Løn = 24000 });
            medarbejderList.Add(new Medarbejder { Navn = "Lisa", Erfaring = 8, Løn = 29000 });
            medarbejderList.Add(new Medarbejder { Navn = "Pelle", Erfaring = 9, Løn = 27000 });


            //run the static method from the class (first way)
            //Medarbejder.Lønforhøjelse(medarbejderList)

            //great LønforhøjelsesDelegate (second way)
            //LønforhøjelsesDelegate del = Berettiget;
            //Medarbejder.Lønforhøjelse(medarbejderList, del);

            LønforhøjelsesDelegate del = new LønforhøjelsesDelegate(m => m.Erfaring > 2);
            Medarbejder.Lønforhøjelse(medarbejderList, del);



            // Func (Prædefineret delegate med return værdig)
            Func<int, int> fd = x => x * x;
            Console.WriteLine(fd(5));

            // Action (Prædefineret delegate med uden return værdig)
            Action<int> myAction = doIt => Console.WriteLine(doIt);
            myAction(5);

            // Predicate (Prædefineret delegate med bool)
            Predicate<int> JegHarStemmeret = alder => alder >= 18;
            Console.WriteLine("Har jeg stemmeret? "+ JegHarStemmeret(35));

            Console.ReadLine();
        }

        private static bool Berettiget(Medarbejder ma)
        {
            if (ma.Erfaring > 2 || ma.Løn < 23000) { return true; }
            else return false;
        }
    }
}
