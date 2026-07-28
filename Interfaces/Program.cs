using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Email Notifications
            EmailNotification emailNotification = new EmailNotification();
            emailNotification.Send("Email Notification");

            SMSNotification sMSNotification = new SMSNotification();
            sMSNotification.Send("SMS Notification");

            PushNotification pushNotification = new PushNotification();
            pushNotification.Send("Push Notification");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("****************************************");

            //Document Printer

            Invoice invoice = new Invoice();
            invoice.Print();

            Resume resume = new Resume();
            resume.Print();

            Report report = new Report();
            report.Print();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("**********************************************");

            PayPal payPal = new PayPal();
            payPal.Pay(100.5501M);


            Stripe stripe = new Stripe();
            stripe.Pay(150.5569M);

            BankTransfer bankTransfer = new BankTransfer();
            bankTransfer.Pay(200.003M);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("****************************************************");

            Car car =new Car();
            car.Start();
            car.Stop();

            Drone drone = new Drone();
            drone.Start();
            drone.Stop();

            Bicycle bicycle = new Bicycle();
            bicycle.Start();
            bicycle.Stop();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("*********************************************************");

            Circle circle = new Circle();
            circle.Draw();

            Triangle triangle = new Triangle();
            triangle.Draw();

            Rectangle rectangle = new Rectangle();
            rectangle.Draw();



        }
    }
}
