using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{
    class Student
    {
       private String name;
        public String Name
        {
            get { return name; }
            set { name = value; }
        }

    }
    internal class PropertiesEx
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "John Doe";
            Console.WriteLine("Student Name: " + student.Name);
        }
    }
}
