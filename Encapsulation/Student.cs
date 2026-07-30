using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Student
    {

        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { if (name == "") 
                {
                    Console.WriteLine("Please enter a name");
                        } 
                else { name = value; }  }  
        }

        public int Age
        {
            get { return age; }
            set { if (value <= 0) 
                { Console.WriteLine("Please enter a positive value for age"); }
                else { age = value; }
            }
        }

        public void DisplayInfoMethod() 
        {
            Console.WriteLine($"Student Name: {Name}  Student Age:{Age}");
        }
    
    }
}
