using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_3_Polymorphism
{
    internal abstract class Animal
    {
        public virtual void Speak()
        {

        }
    }

    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Dog Barks");
        }
    }
    class Duck : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Duck Quacks");
        }
    }

    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Cat Meows");
        }
    
    }
}
