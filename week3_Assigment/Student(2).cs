using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessmentc_
{
    class Student
    {
        private string name;
        private int rollNo;

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty.");
                }
                name = value;
            }
        }

        public int RollNo
        {
            get { return rollNo; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("RollNo cannot be negative.");
                }
                rollNo = value;
            }
        }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}, RollNo: {RollNo}");
        }
    }
}
