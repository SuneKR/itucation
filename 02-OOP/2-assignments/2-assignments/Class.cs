using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_assignments
{
    internal class Class
    {
        #region Relevant assignment describtion
        /*
            --- Exercise 4 ---
            Class: Student
            For the purpose of this exercise, a student has a name and a test score based on the tests they've taken.
            - 'AddTest(score)'
            - 'GetTotalScore()'
            - 'GetAverageScore()'
            Which variables does your class need when you construct it?
            Implement the class and create an object to test it!
        */
        #endregion

        #region fields & properties
        private List<Student> students = new List<Student>();
        private int TotalScore { get; set; }
        #endregion

        #region constructors
        public Class()
        {
            Random rng = new Random();
            for (int i = 0; i < rng.Next(20, 51); i++)
            {
                students.Add(new Student());
            }

            int ScoreTally = 0;
            foreach (var student in students)
            {
                ScoreTally += student.GetScore();
            }
            TotalScore = ScoreTally;
        }
        #endregion

        #region Methods
        public void ListStudents()
        {
            Console.WriteLine($"List of all { students.Count } Students and their scores:");

            foreach (var student in students)
            {
                student.ListStudent();
            }
        }

        public void GetTotalScore()
        {
            Console.WriteLine($"The total score of all { students.Count } students was { TotalScore }.");
        }

        public void GetAverageScore()
        {
            Console.WriteLine($"The average score of the { students.Count } students was { TotalScore / students.Count }.");
        }
        #endregion
    }
}
