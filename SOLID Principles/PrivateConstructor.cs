using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{
    class Student1
    {
        static int Sid = 1;
        private Student1()
        {
            // Private constructor to prevent instantiation from outside the class
        }
        public static void DisplayStudent()
        {
            Console.WriteLine("Student ID: " + Sid);
        }
    }
    internal class PrivateConstructor
    {
        static void Main(string[] args)
        {
            // Student student = new Student(); // This will cause a compile-time error due to the private constructor
            Student1.DisplayStudent(); // Accessing the static method to display student details
        }
    }
}
