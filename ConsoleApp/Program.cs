using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace ConsoleApp
{
    internal class Program
    {
        static void Main()
        {
            string command;
            //Тут будут жить твои переменные
            do
            {
                Console.Clear();
                Console.WriteLine("ClassClassroom. Выводит тип класса");
                Console.WriteLine("ClassDiscipline. Выводит тип класса");
                Console.WriteLine("ClassEmployee. Выводит тип класса");
                Console.WriteLine("ClassEquipment. Выводит тип класса");
                Console.WriteLine("ClassGroup. Выводит тип класса");
                Console.WriteLine("ClassLesson. Выводит тип класса");
                Console.WriteLine("ClassPair. Выводит тип класса");
                Console.WriteLine("ClassSpeciality. Выводит тип класса");
                Console.WriteLine("ClassStudent. Выводит тип класса");

                Console.WriteLine("Exit. Выход из программы");
                Console.WriteLine();
                Console.Write("Введите команду: ");
                command = Console.ReadLine();
                switch (command)
                {
                    /*
                    case "ClassClassroom":
                        {
                            Console.Clear();
                            Classroom classroom = Fabric.CreateEmployee();
                            Printer.PrintEmployee(classroom);
                            break;
                        }
                    case "ClassDiscipline":
                        {
                            Console.Clear();
                            Discipline discipline = Fabric.CreateDiscipline();
                            Printer.PrintEmployee(discipline);
                            break;
                        }
                    */
                    case "ClassEmployee":
                        {
                            Console.Clear();
                            Employee employee = Fabric.CreateEmployee();
                            Printer.PrintEmployee(employee);
                            break;
                        }
                    /* 
                    case "ClassEquipment":
                        {
                            Console.Clear();
                            Equipment equipment = Fabric.CreateEquipment();
                            Printer.PrintEmployee(equipment);
                            break;
                        }
                    case "ClassGroup":
                        {
                            Console.Clear();
                            Group group = Fabric.CreateGroup();
                            Printer.PrintEmployee(group);
                            break;
                        }
                    case "ClassLesson":
                        {
                            Console.Clear();
                            Lesson lesson = Fabric.CreateLesson();
                            Printer.PrintEmployee(lesson);
                            break;
                        }
                    case "ClassPair":
                        {
                            Console.Clear();
                            Pair pair = Fabric.CreatePair();
                            Printer.PrintEmployee(pair);
                            break;
                        }
                    case "ClassSpeciality":
                        {
                            Console.Clear();
                            Speciality speciality = Fabric.CreateSpeciality();
                            Printer.PrintEmployee(speciality);
                            break;
                        }
                    case "ClassStudent":
                        {
                            Console.Clear();
                            Student student = Fabric.CreateStudent();
                            Printer.PrintEmployee(student);
                            break;
                        }
                    */
                    default: break;
                }
                System.Threading.Thread.Sleep(2000);
            }
            while (command != "Exit");

        }
    }
}
