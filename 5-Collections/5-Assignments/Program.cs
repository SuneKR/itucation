using System.ComponentModel.Design;

namespace _5_Assignments
{
    internal class Program
    {
        #region Exercise1
        public static void Exercise1()
        {
            #region Relevant assignment description
            /*
            --- Exercise 1: Lists ---
            a. Store the names of a few of your friends in a list.
            Print each person's name one at a time.

            b. Think of a hobby of yours, and make a list that stores several examples of items from that hobby.
            Use your list to print a series of statements about these items, such as "Squirtle is a pretty cool dude."
            */
            #endregion

            Console.WriteLine("Excerice 1A: Friendslist");

            List<string> rpgGroup = new List<string>() { "Martin", "Bo", "Stiig", "Jeppe", "Mikkel", "Thomas", "Kenneth", "Lasse", "Mette", "Christian" };
            foreach(string friend in rpgGroup) { Console.WriteLine(friend); }

            Console.WriteLine("\nExcerice 1B: RPG systems");
            List<string> systemsPlayed = new List<string>() { "Savage Worlds", "Fusion", "gurps 4 ed", "Unknown Armies", "WFRP 2e", "WFRP 4e", "D&d 5e", "V5", "Fate Accelerated" };
            List<string> systemsEvaluated = new List<string>() { "fast, furious & played to death", "fun setting, outdated system", "gritty, a bit compucated and feeled \"realistic\"", "quite thematic",  "grimdark but slow", "nostaltic but not that grimdark", "fun fights but over the top epic", "nostaltic and way to gothic", "narritvely driven and abstact" };

            for(int i = 0; i < systemsPlayed.Count; i++)
            {
                Console.WriteLine($"{ systemsPlayed[i] } was { systemsEvaluated[i] }");
            }
        }
        #endregion

        #region Exercise2
        public static void Exercise2()
        {
            #region Relevant assignment description
            /*
            --- Exercise 2: Modifying Lists ---
            a. If you could invite anyone, living or otherwise, to dinner, who would you invite?
            Make a list that includes at least three people you'd like to invite to dinner.
            Use your list to print a message to each person, inviting them to dinner.

            b. You just heard that one of your guests can't make the dinner :(
            You'll have to think of someone else to invite. Modify your list, 
            replacing the name of the guest who can't make it with the name of a new person.
            Print an invitation for your new guest.

            c. You just found a bigger dinner table! Think of three more guests to invite.
            Add your new guests to the end of your list.

            d. Oh no! You just found out that your new dinner table won't arrive in time.
            Find a way to uninvite the new guests from 2-c.
            */
            #endregion

            List<string> dinnerGuests = new List<string>() { "Leo Tolstoy", "Kurt Vonnegut", "Ernest Hemmingway" };
            Console.WriteLine("\nExcerise2A:");
            foreach (string guest in dinnerGuests) { Console.WriteLine($"Dear { guest } you are cordially invited to dinnerparty!" ); }
            
            Console.WriteLine("\nExcerise2B:");
            dinnerGuests[2] = "Charles Bukowski";
            foreach (string guest in dinnerGuests) { Console.WriteLine($"Dear { guest } you are cordially invited to dinnerparty!"); }

            Console.WriteLine("\nExcerise2C:");
            dinnerGuests.Add("Art Spiegelmann");
            dinnerGuests.Add("Wu Cheng'en");
            dinnerGuests.Add("John Milton");

            foreach (string guest in dinnerGuests) { Console.WriteLine($"Dear { guest } you are cordially invited to dinnerparty!"); }

            Console.WriteLine("\nExcerise2D:");

            foreach (string guest in dinnerGuests)
            {
                if (dinnerGuests.IndexOf(guest) < 3) { Console.WriteLine($"Dear { guest } you are still cordially invited to dinnerparty!"); }
                else { Console.WriteLine($"Dear { guest } due to an unforseen table happenstance, you are cordially uninvited to dinnerparty"); }
                
            }
        }
        #endregion

        #region Exercise3
        public static void Exercise3()
        {
            #region Relevant assignment description
            /*
            --- Exercise 3: Dictionaries ---
            a. Use a dictionary to store information about a person you know.
            You decide the information, but classics include first name, age, and showers per week.
            Print a little message about your friend, using the stored information.

            b. Use a dictionary to store the names of a few people you know, along with their favourite numbers.
            Print some of the people in your dictionary, along with their favourite number.

            c. Let's use a dictionary as an actual dictionary (or you could call it a glossary to avoid confusion).
            Think of five programming words you've learned about, and store them along with their meanings.
            Print these words and their meanings as a neatly formatted output.
            */
            #endregion

            Console.WriteLine("\nExcerise3A:");
            Dictionary<string, string> MenWithoutHats = new Dictionary<string, string>();
            MenWithoutHats.Add("Ivan Doroschuk", "vocals, guitar, bass, keyboards, synths, drum programming");

            foreach (KeyValuePair<string, string> artist in MenWithoutHats)
            {
                Console.WriteLine($"{ artist.Key } you can { artist.Value } if you want to \n{ artist.Key } can leave you friends behind");
            }

            Console.WriteLine("\nExcerise3B:");
            Dictionary<string, int> PeopleWithFavoriteNumbers = new Dictionary<string, int>();
            Random rng = new Random();
            PeopleWithFavoriteNumbers.Add("Helen", rng.Next(100));
            PeopleWithFavoriteNumbers.Add("Magnus", rng.Next(100));
            PeopleWithFavoriteNumbers.Add("Carl", rng.Next(100));
            PeopleWithFavoriteNumbers.Add("Anders", rng.Next(100));
            PeopleWithFavoriteNumbers.Add("Caroline", rng.Next(100));

            foreach (KeyValuePair<string, int> Person in PeopleWithFavoriteNumbers) { Console.WriteLine($"{ Person.Key }'s favourite number is { Person.Value }"); }

            Console.WriteLine("\nExcerise3C:");
            Dictionary<string, string> SolidPrinciples = new Dictionary<string, string>();
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            SolidPrinciples.Add("Single-responsibility principle", "A module should be responsible to one, and only one, actor.");
            SolidPrinciples.Add("Open–closed principle", "Software entities should be open for extension, but closed for modification");
            SolidPrinciples.Add("Liskov substitution principle", "S≤T -> \u2c6fx:T.\u03C6(x) -> Ɐy:S.φ(y)");
            SolidPrinciples.Add("Interface segregation principle", "Clients should not be forced to depend upon interfaces that they do not use.");
            SolidPrinciples.Add("Dependency inversion principle", "Depend upon abstractions, [not] concretes");

            foreach (KeyValuePair<string, string> principle in SolidPrinciples) { Console.WriteLine($"{principle.Key}: {principle.Value}"); }


        }
        #endregion

        static void Main(string[] args)
        {
            #region assignment description
            /*
            --- Exercise 1: Lists ---
            a. Store the names of a few of your friends in a list.
            Print each person's name one at a time.

            b. Think of a hobby of yours, and make a list that stores several examples of items from that hobby.
            Use your list to print a series of statements about these items, such as "Squirtle is a pretty cool dude."

            --- Exercise 2: Modifying Lists ---
            a. If you could invite anyone, living or otherwise, to dinner, who would you invite?
            Make a list that includes at least three people you'd like to invite to dinner.
            Use your list to print a message to each person, inviting them to dinner.

            b. You just heard that one of your guests can't make the dinner :(
            You'll have to think of someone else to invite. Modify your list, 
            replacing the name of the guest who can't make it with the name of a new person.
            Print an invitation for your new guest.

            c. You just found a bigger dinner table! Think of three more guests to invite.
            Add your new guests to the end of your list.

            d. Oh no! You just found out that your new dinner table won't arrive in time.
            Find a way to uninvite the new guests from 2-c.

            --- Exercise 3: Dictionaries ---
            a. Use a dictionary to store information about a person you know.
            You decide the information, but classics include first name, age, and showers per week.
            Print a little message about your friend, using the stored information.

            b. Use a dictionary to store the names of a few people you know, along with their favourite numbers.
            Print some of the people in your dictionary, along with their favourite number.

            c. Let's use a dictionary as an actual dictionary (or you could call it a glossary to avoid confusion).
            Think of five programming words you've learned about, and store them along with their meanings.
            Print these words and their meanings as a neatly formatted output.
            */
            #endregion

            #region Staging area
            //Exercise1();
            //Exercise2();
            Exercise3();
            #endregion
        }
    }
}
