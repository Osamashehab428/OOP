using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal interface IPrintable
    {
        void Print();
        
    }

    class Invoice : IPrintable
    {
        public void Print() 
        {
            Console.WriteLine("Invoice");
        }
    }

    class Resume : IPrintable
    {
        public void Print()
        {
            Console.WriteLine("Resume");
        }
    }

    class Report : IPrintable
    {
        public void Print() 
        {
            Console.WriteLine("Report");
        }

}
