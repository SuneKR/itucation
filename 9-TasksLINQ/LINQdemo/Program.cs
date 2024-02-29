using System.Net.WebSockets;
using System.Xml.Linq;

namespace LINQdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] arr =
            //{
            //    34, 56, 78, 98, 87, 76, 65, 54, 43, 32, 24, 54, 75, 86, 96, 85, 84, 73, 79,
            //    34, 56, 78, 98, 87, 76, 65, 54, 43, 32, 24, 54, 75, 86, 96, 85, 84, 73, 79,
            //    34, 56, 78, 98, 87, 76, 65, 54, 43, 32, 24, 54, 75, 86, 96, 85, 84, 73, 79,
            //    34, 56, 78, 98, 87, 76, 65, 54, 43, 32, 24, 54, 75, 86, 96, 85, 84, 73, 79
            //};
            //IEnumerable<int> qryResylt = from someVal in arr orderby someVal ascending where someVal > 70 select someVal;

            //Console.WriteLine(qryResult);
            //foreach (var item in qryResylt) { Console.WriteLine(item); }

            //xml
            XElement empFile = XElement.Load("employees.xml");

            var XMLQueryResult = from emp in empFile.Descendants("Employee")
                                 orderby emp.Element("Department").Value
                                 select emp;

            foreach (var e in XMLQueryResult)
            {
                Console.WriteLine($"Employee -> {e.Element("FirstName").Value} " +
                    $"{e.Element("LastName").Value} works in {e.Element("Department").Value} " +
                    $"in the city of: {e.Element("Location").Value}"
                    );
            }
        }
    }
}
