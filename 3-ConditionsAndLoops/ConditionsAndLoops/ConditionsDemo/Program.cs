namespace ConditionsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool boo = true;

            // == boolean check
            // = assignment
            // != different from not equal to

            // it's import which types you evaluate
            //Console.WriteLine(5==5);

            //String and int kan be compared - this way
            //Console.WriteLine("5"==5);

            //comparing int and double is possible
            //Console.WriteLine(5 == 5.0); //true
            //Console.WriteLine(5 == 5.1); //false

            // case string
            //Console.WriteLine("hej" == "hej"); //true
            //Console.WriteLine("hej" == "Hej"); //false

            //< and > (<= >=)
            //Console.WriteLine(10>5); //true
            //Console.WriteLine(9>= 9); //true


            // && means AND - both check must be true to return true
            //Console.WriteLine(9>7 && 3<1); //false

            // || means OR - only one check has to be true
            //Console.WriteLine(9>7 || 3<1); //true

            //if the code darkens, it's because the code have become unreachable
            //if(3 > 1)
            //{
            //    Console.WriteLine("if statement true");
            //}
            //Console.WriteLine("out of block");

            //int x = 88;
            //if (x > 80)
            //{
            //    Console.WriteLine("x is greather than 80");
            //}
            //else
            //{
            //    Console.WriteLine("x is less than 80");
            //}

            //int i = 6;
            //int j = 5;
            //if (i == j)
            //{
            //    Console.WriteLine("i and j are equal");
            //}
            //else if (i < j)
            //{
            //    Console.WriteLine("i is lower than j");
            //}
            //else
            //{
            //    Console.WriteLine("j is lower han i");
            //}

            //Console.Write("Please enter you age: ");
            //int age = int.Parse(Console.ReadLine());
            //if (age >= 18)
            //{
            //    if (age > 72)
            //    {
            //        Console.WriteLine("Hey, you are super old - go enjoy you life!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Hey, you age is OK for job - go make money!");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Hey, you probably need to go back to school...");
            //}

            //int x = 10;
            //string y = "hej";

            //compare if two varuables have same type
            //Console.WriteLine(x.GetType().Equals(y.GetType()));

            //Check if varuable has pecific type
            //Console.WriteLine(y.GetType().Equals(typeof(string)));

            //empty list constructor
            List<string> imaginaryPlaces = new List<string>();
            imaginaryPlaces.Add("Morder"); // index 0
            imaginaryPlaces.Add("Earthsea"); // index 1
            imaginaryPlaces.Add("Gurkhul"); // index 2
            imaginaryPlaces.Add("Westoeros"); // index 3
            imaginaryPlaces.Add("Chicago"); // index 4

            //Console.WriteLine(imaginaryPlaces); //prints data about the list, not the content
            //simple way to write the content of the list
            //imaginaryPlaces.ForEach(Console.WriteLine);
            //Console.WriteLine(imaginaryPlaces[3]); // prints at index 3
            //imaginaryPlaces[3] = "Faerun";
            //Console.WriteLine(imaginaryPlaces[3]);
            //imaginaryPlaces.Remove("Faerun");
            //Console.WriteLine(imaginaryPlaces[3]);
            imaginaryPlaces.Insert(1, "blabla");
            imaginaryPlaces.ForEach(Console.WriteLine);






        }
    }
}
