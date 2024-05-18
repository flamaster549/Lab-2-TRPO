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
        public static void PrintLesson(Lesson lesson)
        {
            Console.WriteLine("Дата занятия: {0}", lesson.Date);
            PrintDiscipline(lesson.Discipline);
            PrintEmployee(lesson.Employee);
            PrintClassroom(lesson.Classroom);
            PrintGroup(lesson.Group);
            PrintPair(lesson.Pair);

            
        }

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

        public static void PrintClassroom(Classroom classroom)
        {
            Console.WriteLine(classroom);
        }

        public static void PrintGroup(Group group)
        {
            Console.WriteLine(group);
        }

        public static void PrintPair(Pair pair)
        {
            Console.WriteLine(pair);
        }

        internal static void PrintEquipment(Equipment equipment)
        {
            Console.WriteLine(equipment);
        }

        internal static void PrintStudent(Student student)
        {
            Console.WriteLine(student);
        }
    }
}
