using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal static class Printer
    {
        public static void PrintEmployee(Employee employee)
        {
            PrintSpeciality(employee.Speciality);
        }

       
        public static void PrintSpeciality(Speciality speciality) 
        {
            Console.WriteLine(speciality);
        }
       public static void PrintDiscipline(Discipline discipline)
        {
            Console.WriteLine(discipline.Name);
        }


    }
}
