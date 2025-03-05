using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_Inheritance_
{
    class Vehicle2
    {
        public string Brand { get; set; }
        public int Speed { get; set; }
        public virtual void displayInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Speed: {Speed}");
        }
    }

    class Car2 : Vehicle2
    {
        public int Wheels { get; internal set; }
        public override void displayInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Speed: {Speed}, Wheels: {Wheels}");
        }
    }
    class Bike2 : Vehicle2
    {
        public int Wheels { get; internal set; }
        public override void displayInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Speed: {Speed}, Wheels: {Wheels}");
        }

    }

    //public class Program2
    //{
    //    public static void Main()
    //    {   
    //        Vehicle2 v = new Vehicle2();
    //        v.Brand = "Toyota";
    //        v.Speed = 100;
    //        v.displayInfo();
    //        Car2 c = new Car2();
    //        c.Brand = "BMW";
    //        c.Speed = 200;
    //        c.Wheels = 4;
    //        c.displayInfo();
    //        Bike2 b = new Bike2();
    //        b.Brand = "Yamaha";
    //        b.Speed = 150;
    //        b.Wheels = 2;
    //        b.displayInfo();
    //    }
    //}
}
