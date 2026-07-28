using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_3_Polymorphism
{
    internal class Payment
    {
        public virtual void ProcessPayment()
        {
            
        }
    }

    class CreditCardPayment : Payment
    {
        public override void ProcessPayment()
        {
            Console.WriteLine("Process Payment");
        }
    }
    class PayPalPayment : Payment
    {
        public override void ProcessPayment()
        {
            Console.WriteLine("PayPalPayment");
        }
    }

    class BankTransferPayment : Payment
    {
        public override void ProcessPayment()
        {
            Console.WriteLine("Bank Transfer Payment ");
        }
    }

}
