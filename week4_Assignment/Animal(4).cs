using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_Inheritance_
{
    
    public abstract class Animal
    {
        public abstract void MakeSound();

        
    }
    public class Cat:Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow Meow");
        }
    }
    public class Dog:Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bow Bow");
        }
    }

    //public class Program4
    //{
    //    public static void Main(string[] args)
    //    {
    //        Dog d = new Dog();
    //        d.MakeSound();
    //        Cat c = new Cat();
    //        c.MakeSound();
    //    }
    //}
}
