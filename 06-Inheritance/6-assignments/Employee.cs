using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _6_assignments
{
    internal class Employee
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

        string Department;
        string Name;
        int Salary;
        List<string> skills = new List<string>();

        public Employee() : this("IT", "John Doe", 40000) { }

        public Employee(string department, string name, int salary)
        {
            this.Department = department;
            this.Name = name;
            this.Salary = salary;
        }

        public void AddSkills(List<string> newSkills)
        {
            foreach (string skill in newSkills)
            {
                skills.Add(skill);
            }
        }

        public void ChangeDepartment(string newDepartment)
        {
            this.Department = newDepartment;
        }

        public override string ToString()
        {
            string skillsString = string.Join(", ", skills);
            return $"{ Name } of { Department }. Salary: { Salary }. Known skills: " + skillsString;
        }
    }
}
