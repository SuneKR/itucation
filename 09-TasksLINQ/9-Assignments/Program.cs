using System.Net.WebSockets;
using System.Text.Json.Serialization;
using System.Threading.Tasks.Dataflow;
using System.Xml.Linq;
using Newtonsoft.Json;

namespace _9_Assignments
{
    internal class Program
    {
        #region Exercise1
        static void Exercise1()
        {
            #region Assignment description
            /*
            --- Exercise 1: LINQ ---
            Included in the folder for today's exercises is the file movies.xml
            It contains a bit of information about some amazing films.

            a. Load the .xml file, and store the file in a variable.

            b. Query the file, and store information about the movies in a variable.

            c. Find a way to print some information about all the movies contained in the file.
               The output has to include:
               - Title of the movie.
               - Who directed the movie.
               - A list of actors.
            */
            #endregion

            Console.WriteLine("Exercise 1");

            XElement moviesXML = XElement.Load("movies.xml");

            var moviesQuery = from movies in moviesXML.Descendants("Movie").AsParallel() select movies;

            Console.WriteLine("\nExercise 1B");
            foreach ( var movie in moviesQuery ) { Console.WriteLine(movie); }

            Console.WriteLine("\nExercise 1C");
            foreach (var movie in moviesQuery)
            {
                var castQuery = from actors in movie.Descendants("Actor").AsParallel() select actors;
                List<string> castList = new List<string>();
                foreach ( var cast in castQuery ) { castList.Add(cast.Value); }
                Console.WriteLine($"\n{ movie.Element("Title").Value } by { movie.Element("Director").Value }");
                Console.Write("Actors: ");
                Console.WriteLine(String.Join(", ", castList));
            }
        }
        #endregion

        #region Exercise2
        static void Exercise2()
        {
            #region Assignment description
            /*
            --- Exercise 2: Task ---
            The following url returns some information about a character from a certain franchise:
            https://swapi.dev/api/people/1

            Create an async method, which can download some content from a specific url and return the result.
            Run your method with the provided url.
            Print the result, and see if you can make sense of the weird output!
            (feel free to test your method with different changes to the url - you might get some interesting results!)
            */
            #endregion

            Console.WriteLine("\nExercise 2");

            Character c = (Character) DownloadJSON("https://swapi.dev/api/people/1").Result;
            Console.WriteLine(c);
            
            Console.WriteLine("\nMore characters");
            for (int i = 2; i < 17; i++)
            {
                Console.WriteLine((Character) DownloadJSON($"https://swapi.dev/api/people/{i}").Result); 
            }

        }

        public class Character
        {
            public string name { get; set; }
            public string height { get; set; }
            public string mass { get; set; }
            private string hair;
            public string hair_color
            {
                get { return this.hair; }
                set
                {
                    if (value == "n/a" || value == "none") { this.hair = "no"; }
                    else { this.hair = value; }
                }
            }
            public string skin_color { get; set; }
            public string eye_color { get; set; }
            public string birth_year { get; set; }
            public string gender { get; set; }
            public string homeworld { get; set; }

            public override string ToString()
            {
                return $"\n{ name }\n{ height } cm with { hair_color } hair & { eye_color } eyes.\nBorn { birth_year } on { ((Character) DownloadJSON(homeworld).Result).name }";
            }
        }

        public static async Task<Character> DownloadJSON(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<Character>(json);
                }
                Console.WriteLine($"Error: { response.StatusCode }");
                Character emptyCharacter = new Character();
                return emptyCharacter;
            }
        }
        #endregion

        static void Main(string[] args)
        {
            #region Assignment description
            /*
            --- Exercise 1: LINQ ---
            Included in the folder for today's exercises is the file movies.xml
            It contains a bit of information about some amazing films.

            a. Load the .xml file, and store the file in a variable.

            b. Query the file, and store information about the movies in a variable.

            c. Find a way to print some information about all the movies contained in the file.
               The output has to include:
               - Title of the movie.
               - Who directed the movie.
               - A list of actors.



            --- Exercise 2: Task ---
            The following url returns some information about a character from a certain franchise:
            https://swapi.dev/api/people/1

            Create an async method, which can download some content from a specific url and return the result.
            Run your method with the provided url.
            Print the result, and see if you can make sense of the weird output!
            (feel free to test your method with different changes to the url - you might get some interesting results!)
            */
            #endregion

            #region Stagging Area
            Exercise1();
            Exercise2();
            #endregion

            Console.ReadLine();
        }
    }
}
