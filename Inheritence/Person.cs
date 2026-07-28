using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string Address { get; set; }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}  Age:{Age}  Address {Address}");
        }

        public Person(string Name,int Age,string Address) 
        {
            this.Name = Name;
            this.Age = Age;
            this.Address = Address;
        }

    }

    class Student : Person
    {
        public int StudentId { get; set; }
        public string Major { get; set; }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Student ID: {StudentId}   Major:{Major}");
        }

        public Student(string Name,int Age,string Address,int StudentID, string Major) : base(Name,Age,Address) 
        {
            base.Name = Name;
            base.Address = Address;
            base.Age = Age;
            this.StudentId = StudentID;
            this.Major = Major;
        }
    }

    class Teacher : Person
    {
        public string EmployeeId { get; set; }
        public string Subject { get; set; }
        public Teacher(string Name,int Age,string Address,string EmployeeID,string Subject) : base(Name, Age, Address)
        {
            base.Name=Name;
            base.Address = Address;
            base.Age = Age;
            this.EmployeeId = EmployeeId;
            this.Subject = Subject;


        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();

            Console.Write($"Teacher ID {EmployeeId}  Subject:  {Subject}");
            }
    
    }

}
