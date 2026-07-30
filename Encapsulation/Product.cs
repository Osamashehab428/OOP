using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Product
    {
        private double price;
        public double Price
        {
            get { return price; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Please enter a valid positive value for price");
                }
                else
                {
                    price = value;
                }
            }
        }
        private int quantity;
        public int Quantity
        {
            get { return quantity; }
            set { if (value <= 0) { Console.WriteLine(""); } 
                else 
                {
                    quantity = value;
                }
            }

        }
    
         public double GetTotalValue()
        {
            return quantity * price;
        }
    
    
    }
}
