using System.Diagnostics;

namespace ValueVsReferenceDemo
{
    internal class Program
    {
        class Person()
        {
            public int ID;
            public string Name;
        }

        class ClassCustomer
        {
            public int ID;
            public string Name;

            public ClassCustomer(int ID, string Name)
            { 
                this.ID = ID;
                this.Name = Name;
            }
            public void ClassCustomerInfo()
            {
                Console.WriteLine($"Info inside Class: { ID }\t Name: { Name }");
            }
        }

        struct StructCustomer
        {
            public int ID;
            public string Name;
            
            public StructCustomer(int ID, string Name)
            {
                this.ID = ID;
                this.Name = Name;
            }
            public void StructCustomerInfo()
            {
                Console.WriteLine($"Info inside Class: { ID }\t Name: { Name }");
            }
        }

        static void Main(string[] args)
        {
            //int x = 5;
            //int y = x;

            // \n: new line
            // \t: new tab
            //Console.WriteLine($"\n x: { x } \t y: { y }");
            //x = 7;
            //Console.WriteLine($"\n x: { x } \t y: { y }");

            //Console.WriteLine("------------");
            //Person p1 = new Person();
            //p1.ID = 1;
            //p1.Name = "Ole Olsen";

            //Person p2 = p1;
            //Console.WriteLine($"p1.Name: { p1.Name }\t p2.Name { p2.Name }");
            //p2.Name = "Niels Nielsen";
            //Console.WriteLine($"p1.Name: { p1.Name }\t p2.Name { p2.Name }");

            //Person p3 = new Person();
            //p3.ID = 3;
            //p3.Name = "Ole Olesen";
            //Console.WriteLine($"p1.Name: { p1.Name }\t p2.Name { p2.Name }\t p3.Name { p3.Name }");
            //p3.Name = "Peter Petersen";
            //Console.WriteLine($"p1.Name: { p1.Name }\t p2.Name { p2.Name }\t p3.Name { p3.Name }");

            //Console.WriteLine("\n---- Class ---");          
            //ClassCustomer cc = new ClassCustomer(1, "Kim");
            //cc.ClassCustomerInfo();
            //ModifyClassCustomer(cc);
            //cc.ClassCustomerInfo();

            //Console.WriteLine("\n---- Struct ---");
            //StructCustomer sc = new StructCustomer();
            //sc.ID = 2;
            //sc.Name = "Mia";

            //sc.StructCustomerInfo();
            //ModifyStructCustomers(ref sc);
            //sc.StructCustomerInfo();

            // Array with items
            // array minder om liste, men har den den størrelse, som den har.
            //int[] arr = new int[] { 4, 5, 6, 7, 8 };
            //Console.WriteLine(arr[2]);

            //array of specific size with no predetermined values
            //string[] arr2 = new string[5];
            //arr2[1] = "Valby";
            //arr2[3] = "Maja";

            //foreach(string item in arr2)
            //{
            //    Console.WriteLine(item);
            //}
            //empty values where not defined.

            //array can be multi dimensional like matrices.
            //int[,] matrix = new int[3, 4]
            //{
            //    { 1, 2, 3, 4 },
            //    { 1, 2, 3, 4 },
            //    { 5, 6, 7, 9 }
            //};
            //Console.WriteLine(matrix[0,1]);

            //three dimensional array
            //int[,,] matirx = new int[2, 2, 2]
            //{
            //    {  { 1, 2 }, { 3, 4 } },
            //    {  { 5, 6 }, { 7, 8 } }
            //};

            //ClassCustomer c1 = new ClassCustomer(1, "Mark");
            //ClassCustomer c2 = new ClassCustomer(2, "Maja");
            //ClassCustomer c3 = new ClassCustomer(3, "Lisa");

            //ClassCustomer[] classCustomers = { c1, c2, c3 };
            //foreach (ClassCustomer customer in classCustomers)
            //{
            //    //Console.WriteLine(customer.Name);
            //    customer.ClassCustomerInfo();
            //}

            //object[] mixedArray = new object[5];
            //mixedArray[0] = 27;
            //mixedArray[1] = "hej";
            //mixedArray[2] = new Person { ID = 1, Name = "Mark" };
            //foreach ( var o in mixedArray )
            //{
            //    Console.WriteLine(o);
            //}

            //SigGoddag();

            //Fibonacci
            // 1 1 2 3 5 8 13 21 34 55
            Console.WriteLine(Fibonacci(3));

        }

        public static int Fibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return Fibonacci(n-1) + Fibonacci(n-2);
            }
        }

        public static void SigGoddag()
        {
            Console.WriteLine("Goddag, Lasse");
            SigGoddag();
        }

            //private static void ModifyStructCustomers(in StructCustomer sc) //gør metoden til ReadOnly
            //private static void ModifyStructCustomers(ref StructCustomer sc) //tvinger systemet til parse by reference instead of value
        private static void ModifyStructCustomers(ref StructCustomer sc)
        {
            sc.ID = 111111111;
            sc.Name = "Mona";
            Console.WriteLine($"Info inside MODIFY method: ID: { sc.ID }\t Name: { sc.Name }");
        }


        //private static void ModifyClassCustomer(ref ClassCustomer cc) // allows new reference assignment
        private static void ModifyClassCustomer(ClassCustomer cc)
        {
            cc.ID = 874356;
            cc.Name = "Ib";
            Console.WriteLine($"Info inside MODIFY method: ID: { cc.ID }\t Name: { cc.Name }");
        }
    }
}
