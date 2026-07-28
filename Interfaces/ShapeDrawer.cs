using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal interface ShapeDrawer
    {
        void Draw();
    }

    class Circle : ShapeDrawer
    {
        public void Draw()
        {
            Console.WriteLine("draw circle");
        }
    }

    class Rectangle : ShapeDrawer
    {
        public void Draw()
        {
            Console.WriteLine("Rectangle");
        }
    }
    class Triangle : ShapeDrawer
    {
        public void Draw()
        {
            Console.WriteLine("Triangle");
       
        }
        
    }
}
