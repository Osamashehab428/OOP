using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Osama",37,"Tanta",123,"Chemistry");
            student.DisplayInfo();
            
            
            Teacher teacher = new Teacher("Sokary", 26, "Cairo", "111", "Computer");
            teacher.DisplayInfo();
             
           


        }
    }


}
