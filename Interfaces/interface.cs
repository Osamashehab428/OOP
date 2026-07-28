using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal interface INotification
    {
        void Send(string message);

    }

    class EmailNotification
    {
        public void Send(string message) 
        {
            Console.WriteLine(message);
        }
    }

    class SMSNotification
    {
        public void Send(string message)
        {
            Console.WriteLine(message);
        }
    }
    class PushNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine(message);
        }
    }



}
