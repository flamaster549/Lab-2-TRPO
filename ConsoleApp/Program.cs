﻿using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace ConsoleApp
{
    public class Program
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
                Console.WriteLine("ClassDepartment. Выводит тип класса");
                Console.WriteLine("ClassPosition. Выводит тип класса");
                Console.WriteLine("ClassWorkShift. Выводит тип класса");

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
                            List<Equipment> equipment = Fabric.CreateEquipment();
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
                    case "ClassDepartment":
                        {
                            Console.Clear();
                            Department department = Fabric.CreateDepartment();
                            Printer.PrintDepartment(department);
                            break;
                        }
                    case "ClassPosition":
                        {
                            Console.Clear();
                            Position position = Fabric.CreatePosition();
                            Printer.PrintPosition(position);
                            break;
                        }
                    case "ClassWorkShift":
                        {
                            Console.Clear();
                            WorkShift workShift = Fabric.CreateWorkShift();
                            Printer.PrintWorkShift(workShift);
                            break;
                        }
                    default: break;
                }
                System.Threading.Thread.Sleep(2000);

            }
            while (command != "Exit");

        }
    }
}
