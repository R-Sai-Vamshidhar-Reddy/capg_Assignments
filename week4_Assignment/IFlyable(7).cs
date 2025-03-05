using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_Inheritance_
{
    interface IFlyable
    {
        public void fly();
    }
    interface ISwimable
    {
        public void swim();
    }
    public class Duck
    {
        public void fly()
        {
            Console.WriteLine("Duck can fly");
        }
        public void swim()
        {
            Console.WriteLine("Duck can swim");
        }
    }
    //public class Program7
    //{
    //    public static void Main(string[] args)
    //    {
    //        Duck duck = new Duck();
    //        duck.fly();
    //        duck.swim();
    //    }
    //}
}
