using System;
using System.Collections.Generic;

namespace Pair_Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student> 
            {
                new Student("Justin", 6),
                new Student("Kristen", 6)
            };
           
            foreach(Student student in students)
            {
                Console.WriteLine("The students name is " + student.Name + " and they are in " + student.Grade + " grade");
            }
        }
    }
}
