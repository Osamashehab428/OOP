using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal interface IPaymentGateway
    {
         void Pay(decimal amount);

    }

    class PayPal : IPaymentGateway
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine(amount);
        }
    }

    class Stripe : IPaymentGateway
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine(amount);
        }
    }
    class BankTransfer : IPaymentGateway
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine(amount);
        }
    }
}
