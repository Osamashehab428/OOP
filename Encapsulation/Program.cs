using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Rectangle Class
            Rectangle rectangle = new Rectangle();

            rectangle.Length = 10;
            rectangle.Width = 5;

            Console.WriteLine(rectangle.GetArea());
            Console.WriteLine("///////////////////////////////////////////////");

            ////Student Class
            Student student = new Student();

            student.Name = "Brock";
            student.Age = 50;
            student.DisplayInfoMethod();

            Console.WriteLine("****************************************");
            //////Temperature Class
            TemperatureConverter temperatureConverter = new TemperatureConverter();
            temperatureConverter.Celsius = 50;
            Console.WriteLine(temperatureConverter.ToFahrenheit());
            Console.WriteLine(temperatureConverter.ToCelsius());

            Console.WriteLine("------------------------------------------------------");

            //Product Class
            Product product = new Product();

            product.Price = 200;
            product.Quantity = 3;

            Console.WriteLine("Product Value:     "+product.GetTotalValue());

            Console.WriteLine("*/*/*/*/*/*/*/*/*/*/*/*/*//*/*/*");
            //Bank Account
            Console.ForegroundColor = ConsoleColor.Yellow;
            BankAccountClass bankAccountClass = new BankAccountClass();
            Console.WriteLine("Please enter the balance: ");
            bankAccountClass.Balance = double.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Please enter the amount you want to withdraw: ");
            Console.WriteLine(bankAccountClass.Withdraw(double.Parse(Console.ReadLine())));

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Please enter the amount you want to deposit: ");
            Console.Write("Your balance is: "+bankAccountClass.Deposit(double.Parse(Console.ReadLine())));
             
             
        }
    }
}
