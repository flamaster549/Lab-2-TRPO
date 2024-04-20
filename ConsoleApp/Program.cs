using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp
{
    internal class Program
    {
        static void Main()
        {

            Console.WriteLine("меню");
            string step = Console.ReadLine();
            switch (step)
            {
                case "emp":
                    {
                        Employee employee = Fabric.CreateEmployee();
                        Printer.PrintEmployee(employee);
                        break;
                    }
            }

        }
    }
}
