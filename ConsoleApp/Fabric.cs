using System;
using System.Text.RegularExpressions;
using ClassLibrary;

namespace ConsoleApp
{
    internal static class Fabric
    {
        public static Lesson CreateLesson()
        {
            Console.WriteLine("Введите дату занятия:");

            DateTime date;
            while (!DateTime.TryParse(Console.ReadLine(), out date))
            {
                Console.WriteLine("Неверный формат данных");
            }


            return new Lesson(CreateDiscipline(), CreateEmployee(), CreateClassroom(), CreateGroup(), CreatePair(), date);
        }
        public static Pair CreatePair()
        {
            return null;
        }
        public static ClassLibrary.Group CreateGroup()
        {
            return null;
        }
        public static Classroom CreateClassroom()
        {
            return null;
        }
        public static Employee CreateEmployee()
        {
            return null;
        }
      
        public static Speciality CreateSpeciality()
        {
            return null;
        }
      
        public static Discipline CreateDiscipline() 
        {
            return null;
        }
        public static Student CreateStudent()
        {
            return null;
        }

        internal static Equipment CreateEquipment()
        {
            return null;
        }
    }
}
