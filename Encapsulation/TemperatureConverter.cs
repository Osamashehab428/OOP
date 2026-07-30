using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class TemperatureConverter
    {

        private double celsius;
        public double Celsius
        {
            get { return celsius; }
            set
            {
                if (value < -200 || value > 1000) { Console.WriteLine("Please use reasonable temperatures"); }
                else { celsius = value; }
            }
        }

        public double ToFahrenheit()
        {
             return   (Celsius*1.8)+32;
        }

        public double ToCelsius()
        {

            return (ToFahrenheit() -32 )/1.8;
        }
    }
}
