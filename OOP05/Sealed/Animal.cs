using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05.Sealed
{
    internal sealed  class Animal
    {
        public static void Hello() 
        {
            Console.WriteLine("Welcome to seald class");
        }

    }

    public class Human 
    {
         public virtual void PrintName() 
        {
            Console.WriteLine("My name is ebrahem");
        }
    }

   class American : Human 
    {
        sealed public override void PrintName() { }
    }



    //class Dog : Animal ///Invalid
    //{

    //}
}
