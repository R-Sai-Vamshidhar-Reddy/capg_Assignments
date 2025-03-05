using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_Inheritance_
{
    class Person
    {
        public string Name { get; set; }
        public void Display()
        {
            Console.WriteLine("Person Name: " + Name);

        }
    }
    class Student:Person
    {
        public string StdName { get; set; }
        public void Display2()
        {
            Console.WriteLine("Student Name " + StdName);
        }
    }
    //public class Program8
    //{
    //    public static void Main(string[] args)
    //    {
    //        Student student = new Student { StdName = "Sai", Name = "Vamshi" };
    //        Person person = student;
    //        person.Display();
    //        Student dstudent = (Student)person;
    //        dstudent.Display2();

    //    }
        
    //}
}
