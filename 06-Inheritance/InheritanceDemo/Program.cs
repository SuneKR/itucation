namespace InheritanceDemo
{
    public class FarFar
    {
        //Access modifiers
        private int farfarsDankort; // only class itself
        public int alder; // all can access it
        protected int pt; // familiebeskyttet - klassen og dens nedarvinger
        internal int i; // namespace scope - in this context
        protected internal int pti; //protect OR internal
        private protected int prpt; //family procted within namespace

        public void FarFarsInfo()
        {
            farfarsDankort = 222222;
            Console.WriteLine("Farfars info metode");
        }
    }

    //sealed - no more children, can be a child of another class, but can be inheritant.
    //programming vasectomy 
    public class Far : FarFar
    {
        public int phone;
        
        protected void FarsInfo()
        {
            alder = 42;
            //farfarsDankort = 2222; //Kan ikke tilgås, fordi den er farfarsDankort er privat

            pt = 7;
            i = 9;
            pti = 10;
            prpt = 11;

            Console.WriteLine("Fars info metode");
        }

    }

    // C# no multiple class inheritance er ikke muligt.
    // Man kan dog implementere flere interfaces

    public class Person : Far
    {
        public void PersonInfo()
        {
            alder = 18;
            pti = 20;
            phone = 21;

            FarsInfo();
            Console.WriteLine("Person Info Method");
        }

    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            FarFar farFar = new FarFar();
            Person p1 = new Person();
            p1.FarFarsInfo();
            p1.PersonInfo();
            p1.i = 1;
            p1.pti = 20;

        }
    }
}
