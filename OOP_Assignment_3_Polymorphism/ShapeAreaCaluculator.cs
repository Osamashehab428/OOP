using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_3_Polymorphism
{
    internal abstract class ShapeAreaCalculator
    {
        public virtual double GetArea()
        {
            return 0;
        }
    }


    class Circle:ShapeAreaCalculator
    {
        public float radius { get; set; }
        public override double GetArea()
        {
            return Math.PI * Math.Pow(radius,2);
        }
    }


    class Rectangle : ShapeAreaCalculator
    {
        public float width { get; set; }
        public float height { get; set; }
        public override double GetArea()
        {
            return width * height;
        }
    }

    class Triangle: ShapeAreaCalculator
    {
        public float width { get; set; }
        public float height { get; set; }

        public override double GetArea()
        {
            return height * (0.5 * width);
        }
        

    }

}
