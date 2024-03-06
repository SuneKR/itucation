using System.Runtime.Intrinsics.X86;
using System;
using System.Security.Cryptography.X509Certificates;

namespace _6_assignments
{
    internal class Program
    {
        #region Exercise 1
        public static void Exercise1() 
        {
            #region Assignment description
            /*
            --- Exercise 1: Class warmup ---
            Class: Employee
            This employee might want to change department at some point.
            - Necessary variables: name, salary, department
            - Implement a list of skills, and decide how to manage it in your class
            - Implement a way to get complete info of the employee
            - Add functionality to change department
            */
            #endregion

            Console.WriteLine("Exercise 1");

            Employee worker = new Employee();
            Console.WriteLine(worker);

            List<string> workerSkills = new List<string>() { "Solidaritet", "Klassekamp" };
            worker.AddSkills(workerSkills);
            Console.WriteLine(worker);

            worker.ChangeDepartment("The collective leadership commitee");
            Console.WriteLine(worker);
        }
        #endregion

        #region Exercise 2
        public static void Exercise2()
        {
            #region Assignment description
            /*
            ---Exercise 2: Inheritance-- -
            Implement a superclass Appointment and the following subclasses:
            Onetime, Daily, Monthly.
            An appointment has a description(for example: "see the dentist") and a date(feel free to use a simple string).
            Define a method AppointmentInfo that returns a description, date, and
            whether the appointment is daily, monthly or onetime.
            */
            #endregion

            Console.WriteLine("\nExercise 2");

            List<Appointment> appointments = new List<Appointment>() { new Daily("27/2", "Empty bins"), new Monthly("27/3", "Wash floors"), new OneTime("27/2", "Collect sent parcel") };

            foreach (Appointment appointment in appointments) { Console.WriteLine(appointment); }


        }

        internal class Appointment
        {
            protected string date = "";
            protected string description = "";
            protected string recurrence = "";

            public override string ToString()
            {
                return $"Appointment: { description } Date: { date } Recurrence: { recurrence }";
            }
        }

        internal class Daily : Appointment
        {
            public Daily(string date, string description)
            {
                this.date = date;
                this.description = description;
                this.recurrence = "Daily";
            }
        }
        internal class Monthly : Appointment
        {
            public Monthly(string date, string description)
            {
                this.date = date;
                this.description = description;
                this.recurrence = "Monthly";
            }
        }
        internal class OneTime : Appointment
        {
            public OneTime(string date, string description)
            {
                this.date = date;
                this.description = description;
                this.recurrence = "Never";
            }
        }
        #endregion

        #region Exercise 3
        public static void Exercise3() 
        {
            #region Assignment description
            /*
            --- Exercise 3: Polymorphism ---
            Create a list of objects from Exercise 2.
            Use a loop to print out all your AppointmentInfo!
            */
            #endregion

            Console.WriteLine("\nExercise 3");

            List<Appointment> appointments = new List<Appointment>() { new Daily("27/2", "Empty bins"), new Monthly("27/3", "Wash floors"), new OneTime("27/2", "Collect sent parcel") };

            foreach (Appointment appointment in appointments) { Console.WriteLine(appointment); }
        }
        #endregion

        #region Exercise 4
        public static void Exercise4() 
        {
            #region Assignment description
            /*
            --- Exercise 4: Overriding ---
            a. Create a class Artist. An artist has a name and a genre.
               Define a PlaySong method, which returns an informative string including the artist name and genre.

            b. Create a derived class Band which inherits from Artist.
               A band has their best song, in addition to all the information from the Artist super class.
               Override the PlaySong method, since you now have some more information to include!

            c. For this exercise, SoloArtist is a derived class of Band.
               They include no new attributes, but the PlaySong method has to reflect the artist going solo.

            d. Create 2 objects of each class, and add them all to a list.
               Use the list to play a little concert, by having all the musicians PlaySong()
            */
            #endregion

            Console.WriteLine("\nExercise 4");

            List<Artist> musicians = new List<Artist>()
            {
                new Artist{ Name = "Miles Davis", Genre = "Fusion jazz" },
                new Artist{ Name = "Immortal Technique", Genre = "Eastcoast Hiphop" },

                new Band{ Name = "Rolling Stones", Genre = "Hard Rock", BestSong = "Paint It Black" },
                new Band{ Name = "Dschinghis Khan", Genre = "Eurodisco pop", BestSong = "Dschinghis Khan" },

                new SoloArtist { Name = "Bob Dylan", Genre = "Folk Rock", BestSong = "The Times They Are a-Changin'" },
                new SoloArtist { Name = "Niel Young", Genre = "Folk Rock", BestSong = "Old Man" }
            };

            foreach (Artist musician in musicians) { musician.PlaySong(); }

        }

        public class Artist
        {
            public string Name = "";
            public string Genre = "";

            public virtual void PlaySong()
            {
                Console.WriteLine($"{ Name } plays their { Genre }-song"); ;
            }
        }

        public class Band : Artist
        {
            public string BestSong = "";

            public override void PlaySong()
            {
                Console.WriteLine($"{ Name } plays their { Genre }-song: { BestSong }"); ;
            }
        }

        public class SoloArtist : Band
        {
            public override void PlaySong()
            {
                Console.WriteLine($"The soloartist { Name } plays their { Genre }-song: {BestSong}"); ;
            }
        }
        #endregion

        static void Main(string[] args)
        {
            #region Assignment description
            /*
            --- Exercise 1: Class warmup ---
            Class: Employee
            This employee might want to change department at some point.
            - Necessary variables: name, salary, department
            - Implement a list of skills, and decide how to manage it in your class
            - Implement a way to get complete info of the employee
            - Add functionality to change department



            --- Exercise 2: Inheritance ---
            Implement a superclass Appointment and the following subclasses:
            Onetime, Daily, Monthly.
            An appointment has a description (for example: "see the dentist") and a date (feel free to use a simple string).
            Define a method AppointmentInfo that returns a description, date, and 
            whether the appointment is daily, monthly or onetime.



            --- Exercise 3: Polymorphism ---
            Create a list of objects from Exercise 2.
            Use a loop to print out all your AppointmentInfo!



            --- Exercise 4: Overriding ---
            a. Create a class Artist. An artist has a name and a genre.
               Define a PlaySong method, which returns an informative string including the artist name and genre.

            b. Create a derived class Band which inherits from Artist.
               A band has their best song, in addition to all the information from the Artist super class.
               Override the PlaySong method, since you now have some more information to include!

            c. For this exercise, SoloArtist is a derived class of Band.
               They include no new attributes, but the PlaySong method has to reflect the artist going solo.

            d. Create 2 objects of each class, and add them all to a list.
               Use the list to play a little concert, by having all the musicians PlaySong()
            */
            #endregion

            #region Stagging Area
            Exercise1();
            Exercise2();
            Exercise3();
            Exercise4();
            #endregion
        }
    }
}
