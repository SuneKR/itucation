using System.Collections;

namespace CollectionsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Diction har Key og Value
            //Dictionary<int, string> dictCities = new Dictionary<int, string>();
            //dictCities.Add(8000, "Aarhus");
            //dictCities.Add(6070, "Christiansfeld");
            //Console.WriteLine(dictCities[0]); //Nej nej nej, det må man ikke
            //Console.WriteLine(dictCities[6070]); //correct, bacause they uses key instead trying to index
            //dictCities[5000] = "Odense";
            //dictCities[7000] = "En by";


            //foreach (var c in dictCities)
            //{
            //    Console.WriteLine(c);
            //}

            //Stack stack = new Stack();
            //stack.Push(23);
            //stack.Push("Kaffekrus");
            //stack.Push(55.78);

            //foreach (var item in stack) { Console.WriteLine(item); }

            //Console.WriteLine(stack.Pop()); //remove item on top
            //Console.WriteLine(stack.Peek()); //list top item
            
            //FIFI
            //Queue queue = new Queue();
            //queue.Enqueue(23);
            //queue.Enqueue("Vandflaske");
            //queue.Enqueue(99.56);

            //foreach (var item in queue) { Console.WriteLine(item); }


            // ----- type-bestemt ---- generic collections
            //Stack<int> ints = new Stack<int>();
            //ints.Push(1);
            //ints.Push(2);
            //ints.Push("3"); //not right type therefor error

            //Queue<string> strings = new Queue<string>();
            //strings.Enqueue("a");
            //strings.Enqueue("b");
            //strings.Enqueue("c");

            // Hash Set --- Unique Values ---
            //HashSet<int> evenNumbers = new HashSet<int>();
            //HashSet<int> oddNumbers = new HashSet<int>();

            //for (int i = 0; i < 11; i++)
            //{
            //    evenNumbers.Add(i*2);
            //    oddNumbers.Add(i*2+1);
            //}
            //Console.WriteLine("even numbers");
            //foreach (int i in evenNumbers) { Console.WriteLine(i); }

            //Console.WriteLine("odd numbers");
            //foreach (int i in oddNumbers) { Console.WriteLine(i); }

            //HashSet<int> allNumbers = new HashSet<int>(evenNumbers);
            //allNumbers.UnionWith(oddNumbers);

            //foreach (int i in allNumbers) { Console.WriteLine(i); }

            //HashSet<string> byerList1 = new HashSet<string>() { "Valby", "Viby", "Rødby", "Tårnby" };
            //HashSet<string> byerList2 = new HashSet<string>() { "Valby", "Viby", "Roskilde", "Odense" };
            //HashSet<string> byer = new HashSet<string>();
            
            //Console.WriteLine("\n---- List 1 ----");
            //Console.WriteLine(String.Join(", ", byerList1)); // STring med stort er klassen, som holder styr på strings
            
            //Console.WriteLine("\n---- List 2 ----");
            //Console.WriteLine(String.Join(", ", byerList2));

            //Console.WriteLine("\n---- Alle byer ----");
            //byer.UnionWith(byerList1);
            //byer.UnionWith(byerList2);
            //Console.WriteLine(String.Join(", ", byer));

            //Console.WriteLine("\n---- Common in set 1 & 2 ----");
            //byerList2.IntersectWith(byerList1);
            //Console.WriteLine(String.Join(", ", byerList2));


            MyLinkedList llst = new MyLinkedList();
            llst.Add("AAA");
            llst.Add("BBB");
            llst.Add("CCC");
            llst.Add(1, "DDD");
            llst.Add(-1, "blabla");
            llst.Print();

            Console.WriteLine("----- After Remove -----");
            llst.RemoveAt(1);
            llst.Print();


            // build-in Linked List
            LinkedList<int> list1 = new LinkedList<int>();

        }
    }
}
