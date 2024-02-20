using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace _2_assignments
{
    internal class Student
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
        private string Name { get; set; }
        private int TestScore { get; set; }
        #endregion

        #region constructors
        public Student()
        {
            Random rng = new Random();
            TestScore = rng.Next(1, 101);
            Name = GenerateName();
        }
        #endregion

        #region Methods
        public void AddTest(int score)
        {
            TestScore = score;
        }

        public string GetName()
        {
            return Name;
        }

        public int GetScore()
        {
            return TestScore;
        }

        public void ListStudent()
        {
            Console.WriteLine($"{ Name } got a score of { TestScore }.");
        }

        private string GenerateName()
        {
            Random rng = new Random();
            string[] fnames = File.ReadAllLines("../../../Ressources/first-names.txt");
            string fname = fnames[rng.Next(fnames.Length)];
            string Fname = fname.Substring(0, 1).ToUpper() + fname.Substring(1);

            string[] lnames = File.ReadAllLines("../../../Ressources/last-names.txt");
            string lname = lnames[rng.Next(lnames.Length)];
            string Lname = lname.Substring(0, 1).ToUpper() + lname.Substring(1);


            return $"{ Fname } { Lname }";
        }
        #endregion
    }
}
