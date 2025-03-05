using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_Inheritance_
{
    class Vehicle
    {
        public string Brand { get; set; }
        public int Speed { get; set; }
        public void displayInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Speed: {Speed}");
        }
    }
    
    class Car : Vehicle
    {
        
    }
    class Bike : Vehicle
    {
        
    }

    //public class Program1
    //{
    //    public static void Main()
    //    {
    //        Car c = new Car();
    //        c.Brand = "BMW";
    //        c.Speed = 200;
    //        c.displayInfo();
    //        Bike b = new Bike();
    //        b.Brand = "Yamaha";
    //        b.Speed = 150;
    //        b.displayInfo();
    //    }
    //}
}
