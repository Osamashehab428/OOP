using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_3_Polymorphism
{
    internal class NotificationSystem
    {
       public virtual void Send()
        {

        }     


    }

    class EmailNotification : NotificationSystem
    {
        public string Email { get; set; }
        public override void Send()
        {
            Console.WriteLine($"Sending Email to {Email}");
        }
    }
    class SMSNotification : NotificationSystem
    {
        public string Number { get; set; }

        public override void Send()
        {
            Console.WriteLine($"Sending SMS to {Number}");
        }
    }
    class PushNotification : NotificationSystem
    {
        public override void Send()
        {
            Console.WriteLine("Sending push Notification ......");

        }
    }


}
