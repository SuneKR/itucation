namespace _4_assignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Assignment description
            /*
            --- Exercise 1: Recursion ---
            Included below is a list and a method signature:

            List<string> cities_list = new List<string> { "Oslo", "Aarhus", null, null, "St. Petersburg", null, "Reykjavik" };

            public static void InsertCity(string city, int index, List<string> citiesList)
            {
                // TODO: recursive function
            }

            To solve this exercise, you have to finish the method given the following:
             1. If there are no null values in the input list, the list is considered full, and your function should do nothing.
             2. If the index given, is bigger than the size of the list, your function should start over from index 0.
             3. If the input index matches a null value in the list, the input city should be inserted instead.
             4. If none of the above conditions are true, your method should run again (look out for infinite recursion!).

            No loops allowed in this exercise! (except to print the list outside the method)
            The Contains method is not considered a loop for the purpose of this exercise.
            Feel free to print helpful messages whenever you feel it is necessary.
            Remember to test your method.
            */
            #endregion

            #region cities_list & method calls
            List<string> cities_list = new List<string> { "Oslo", "Aarhus", null, null, "St. Petersburg", null, "Reykjavik" };
            Random rng = new Random();
            InsertCity("Athens", rng.Next(0,cities_list.Count), cities_list);
            InsertCity("Rome", rng.Next(0, cities_list.Count), cities_list);
            InsertCity("Mumbai", -1, cities_list);
            InsertCity("Babylon", rng.Next(0, cities_list.Count), cities_list);
            InsertCity("Karachi", rng.Next(0, cities_list.Count), cities_list);
            #endregion
        }

        #region InsertCity Method
        public static void InsertCity(string city, int index, List<string> citiesList)
        {
            Console.WriteLine($"Trying to add { city } to index { index } containing { PrintProcess(index, citiesList) }");
            if (!citiesList.Contains(null)) { Console.WriteLine($"List is full. { city } entry not accepted"); }
            else if (index >= citiesList.Count || index < 0) { InsertCity(city, 0, citiesList); }
            else if (citiesList[index] == null ) { citiesList[index] = city; Console.WriteLine($"{ city } added to index {index}"); }
            else { InsertCity(city, index+=1, citiesList); }
        }
        #endregion

        #region PrintProcess
        public static string PrintProcess(int index, List<string> citiesList)
        {
            if (index >= 0 && index < citiesList.Count) { return citiesList[index]; }
            return "Out of bounce";
        }
        #endregion
    }
}