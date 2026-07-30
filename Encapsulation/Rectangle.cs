using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Rectangle
    {

        private double length;
        public double Length
        {
            get { return length; }
            set { if (value <= 0)
                {
                    Console.WriteLine("Please enter a positive value");
                }
                else { length = value; }
            }

        }

        private double width;
        public double Width
        {
            get { return width; }
            set { if (value <= 0) 
                {
                    Console.WriteLine("Please enter a positive value");
                }
                else {  width = value; }
            }
        }

        public double GetArea() 
        {
            return Width * Length;
        }
    }
}
