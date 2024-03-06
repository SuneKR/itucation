using System.Net.WebSockets;

namespace OurFirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //19 + 7;
            //Console.WriteLine("Hello, World!");

            // "cw" + tab er en genvej til Console.WriteLine();
            //Console.WriteLine(19+7);

            // sjov med varialer
            // Varable is defined as a named place in memory
            int x = 19 + 7;
            // microsoft kalder int er en indbygget type
            Console.WriteLine(x);

            string name = "Sunam!";
            Console.WriteLine(name);

            string y = "12";
            x = 14;
            Console.WriteLine(y);
            //Dette virker ikke. Så får man blot en adere string (concatenation)
            Console.WriteLine(y+x);

            // bool shorthand for Boolean. Men per tradition, så kalder vi bool i c#
            bool b = false;
            bool c = true;

            Console.WriteLine(12 < 3);
            // resultere i en bool.

            // != ikke ens
            // == ens
            Console.WriteLine(b != c);
            Console.WriteLine(b == c);

            //Allowed variable names
            //lowerCamelCase
            //SnakeCasing
            // starting with underscore
            //include nummbers (don't start with it)


            // Not allowed variable names
            // to start with number
            // no white space in variables names

            // Variabler skal gerne give mening.
            // Gerne, korte men sigende navne
            // 'name' er bedre end 'n'
            // 'student_name' er bedre end 's_n'
            // 'name_length' er bedre end 'length_of_persons_name'

            // type conversion
            int i = 18;
            string nan = "26";

            string new_var = i.ToString();
            int new_int = int.Parse(nan);


            string navn = "Mark";
            int alder = 34;
            Console.WriteLine(navn + " er " + alder + " år gammel.");
            Console.WriteLine($"{ navn } er { alder } år gammel");
            Console.WriteLine("Her er et citat: \"Noget klogt\"");

            string my_string = "Mark bor i Mordor";
            //printer den 6. karakter fr astarten af.
            Console.WriteLine(my_string[5]); //indeksering starter på 0
            Console.WriteLine(my_string.ToLower());
            Console.WriteLine(my_string.ToUpper());

            Console.Write("Giv mig navnet på din by -> "); //skifter ikke linje
            string place = Console.ReadLine();
            Console.WriteLine($"Du har intastet: { place }");
            Console.WriteLine(!place.StartsWith("m"));
            // all boolean chaecks kan negeres (tjekke efter falsk) ved at tilføje !

            string new_place = " Aarhus ";
            Console.WriteLine(place == new_place);
            Console.WriteLine(place == new_place.Trim());
            // der findes også TrimEnd() og TrimStart(), som kun beskærer henholdsvis slutningen og starten

            // der findes mange indbyggede typer
            // vi har gennem int, string og bool

            double tal = 2.62;
            Console.WriteLine(tal);

            Console.ReadKey();
        }
    }
}
