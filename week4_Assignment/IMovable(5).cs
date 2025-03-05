using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_Inheritance_
{
    interface IMovable
    {
        public void Move();
    }

    public class Machine
    {
        public void start()
        {
            Console.WriteLine("Machine started");
        }
    }
    public class Robot:Machine,IMovable
    {
        public void Move()
        {
            Console.WriteLine("Robot is moving");
        }
    }
    //public class Program5
    //{
    //    public static void Main(string[] args)
    //    {
    //        Robot robo = new Robot();
    //        robo.start();
    //        robo.Move();
    //    }
    //}
}
