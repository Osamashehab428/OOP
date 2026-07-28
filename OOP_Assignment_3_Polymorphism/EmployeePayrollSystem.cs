using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_3_Polymorphism
{
    internal class Employee
    {
        
        public virtual int  CalculateSalary()
        {
            return 0;
        }

    }

    class FullTimeEmployee : Employee
    {
        public int FixedSalary { get; set; }
        public override int  CalculateSalary()
        {
            Console.Write("Full Time Salary: ");
            return FixedSalary;
        }
    }

    class PartTimeEmployee : Employee
    {
        public int HoursWorked { get; set; }
        public int HourlyWage { get; set; }
        public override int CalculateSalary()
        {
            Console.Write("Part time Salary: ");
            return HourlyWage * HoursWorked;
        }
    }

    class Intern : Employee
    {
        public int Stipend { get; set; }

        public override int CalculateSalary()
        {
            Console.Write("Intern Salary: ");
            return Stipend;
            
        }


    }

}
