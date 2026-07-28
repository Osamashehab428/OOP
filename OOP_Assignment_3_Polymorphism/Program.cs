using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_3_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Animal Sound Classes
            Dog dog = new Dog();
            Cat cat = new Cat();
            Duck duck = new Duck();

            dog.Speak();
            cat.Speak();
            duck.Speak();
            Console.WriteLine("*************************************************");
            Console.WriteLine();
            Console.WriteLine();
            //Payment Classes
            PayPalPayment payPalPayment = new PayPalPayment();
            payPalPayment.ProcessPayment();

            BankTransferPayment bankTransferPayment = new BankTransferPayment();
            bankTransferPayment.ProcessPayment();

            CreditCardPayment creditCardPayment = new CreditCardPayment();
                
            List<Payment> payments = new List<Payment>();

            payments.Add(bankTransferPayment);
            payments.Add(creditCardPayment);
            payments.Add(payPalPayment);

            foreach (var payment in payments)
            {
                payment.ProcessPayment();
                     
            }
            Console.WriteLine("************************************************");
            Console.WriteLine();
            Console.WriteLine();
            //Shape classes
            Circle circle = new Circle();
            circle.radius = 10;
            circle.GetArea();

            Rectangle rectangle = new Rectangle();
            rectangle.width = 5;
            rectangle.height = 5;
            rectangle.GetArea();

            Triangle triangle = new Triangle();
            triangle.width = 5;
            triangle.height = 5;
            triangle.GetArea();


            List<ShapeAreaCalculator> listOfShapes = new List<ShapeAreaCalculator>();

            
            listOfShapes.Add(circle);
            listOfShapes.Add(rectangle);
            listOfShapes.Add(triangle);
            string[] shapes = new string[3];

            shapes[0] = "Circle";
            shapes[1] = "Rectangle";
            shapes[2] = "Triangle";
             
                
                for (int i = 0; i < shapes.Length; i++)
                {
                Console.WriteLine(shapes[i] +" "+  listOfShapes[i].GetArea());
                }

            Console.WriteLine("*****************************************************");
            Console.WriteLine();
            Console.WriteLine();
            //Employee Payment System

            FullTimeEmployee fullTimeEmployee = new FullTimeEmployee();
                fullTimeEmployee.FixedSalary = 10000;

                PartTimeEmployee partTimeEmployee = new PartTimeEmployee();
                 partTimeEmployee.HoursWorked = 90;
                 partTimeEmployee.HourlyWage = 60;


            Intern internEmployee = new Intern();
            internEmployee.Stipend = 1000;

            List<Employee> employeeList = new List<Employee>();

            employeeList.Add(fullTimeEmployee);
            employeeList.Add(partTimeEmployee);
            employeeList.Add(internEmployee);

            foreach (Employee employee in employeeList) 
            {
                Console.WriteLine(employee.CalculateSalary());
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("*********************************************************");

            //Notification System

            EmailNotification emailNotification = new EmailNotification();
            emailNotification.Email = "osamashehab7878@gmail.com";

            SMSNotification smsNotification = new SMSNotification();
            smsNotification.Number = "+2001003072130";

            PushNotification pushNotification = new PushNotification();


            List<NotificationSystem> notificationSystemList = new List<NotificationSystem>();

            notificationSystemList.Add(emailNotification);
            notificationSystemList.Add(smsNotification);
            notificationSystemList.Add(pushNotification);
            
            foreach(NotificationSystem notificationSystem in notificationSystemList)
            {
                notificationSystem.Send();
            }


        }
    }
}
