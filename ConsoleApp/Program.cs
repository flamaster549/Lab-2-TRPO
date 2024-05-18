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
<<<<<<< HEAD
                case "emp":
                    {
                        Employee employee = Fabric.CreateEmployee();
                        Printer.PrintEmployee(employee);
                        break;
                    }

                case "discipline":
                    {
                        Discipline discipline = Fabric.CreateDiscipline();
                        Printer.PrintDiscipline(discipline);
                        break;
                    }
=======
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
                    
                    case "ClassClassroom":
                        {
                            Console.Clear();
                            Classroom classroom = Fabric.CreateClassroom();
                            Printer.PrintClassroom(classroom);
                            break;
                        }
                    case "ClassDiscipline":
                        {
                            Console.Clear();
                            Discipline discipline = Fabric.CreateDiscipline();
                            Printer.PrintDiscipline(discipline);
                            break;
                        }
                    
                    case "ClassEmployee":
                        {
                            Console.Clear();
                            Employee employee = Fabric.CreateEmployee();
                            Printer.PrintEmployee(employee);
                            break;
                        }
                    
                    case "ClassEquipment":
                        {
                            Console.Clear();
                            Equipment equipment = Fabric.CreateEquipment();
                            Printer.PrintEquipment(equipment);
                            break;
                        }
                    case "ClassGroup":
                        {
                            Console.Clear();
                            ClassLibrary.Group group = Fabric.CreateGroup();
                            Printer.PrintGroup(group);
                            break;
                        }
                    case "ClassLesson":
                        {
                            Console.Clear();
                            Lesson lesson = Fabric.CreateLesson();
                            Printer.PrintLesson(lesson);
                            break;
                        }
                    case "ClassPair":
                        {
                            Console.Clear();
                            Pair pair = Fabric.CreatePair();
                            Printer.PrintPair(pair);
                            break;
                        }
                    case "ClassSpeciality":
                        {
                            Console.Clear();
                            Speciality speciality = Fabric.CreateSpeciality();
                            Printer.PrintSpeciality(speciality);
                            break;
                        }
                    case "ClassStudent":
                        {
                            Console.Clear();
                            Student student = Fabric.CreateStudent();
                            Printer.PrintStudent(student);
                            break;
                        }
                    
                    default: break;
                }
                System.Threading.Thread.Sleep(2000);
>>>>>>> 61fa3403ad5c02149d0992316eda63f275e428e8
            }
            while (command != "Exit");

        }
    }
}
