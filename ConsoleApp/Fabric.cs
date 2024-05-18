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
            Console.WriteLine("Введите время начала пары:");
            DateTime startTime;
            while (!DateTime.TryParse(Console.ReadLine(), out startTime))
            { Console.WriteLine("Неверный формат данных"); }

            Console.WriteLine("Введите время окончания пары:");
            DateTime endTime;
            while (!DateTime.TryParse(Console.ReadLine(), out endTime))
            { Console.WriteLine("Неверный формат данных"); }

            Console.WriteLine("Введите время начала перерыва:");
            DateTime breakStartTime;
            while (!DateTime.TryParse(Console.ReadLine(), out breakStartTime))
            { Console.WriteLine("Неверный формат данных"); }

            Console.WriteLine("Введите время окончания перерыва:");
            DateTime breakEndTime;
            while (!DateTime.TryParse(Console.ReadLine(), out breakEndTime))
            { Console.WriteLine("Неверный формат данных"); }

            string otherClass = "";

            return new Pair(startTime, endTime, breakStartTime, breakEndTime, otherClass);
        }
        public static ClassLibrary.Group CreateGroup()
        {
            Console.WriteLine("Введите название группы:");
            string name = Console.ReadLine();

            Console.WriteLine("Введите короткое название группы:");
            string shortName = Console.ReadLine();

            Console.WriteLine("Введите количество человек в группе:");
            uint groupSize;
            while (!uint.TryParse(Console.ReadLine(), out groupSize))
            { Console.WriteLine("Неверный формат данных"); }

            Console.WriteLine("Введите год создание (поступления) группы:");
            uint entranceYear;
            while (!uint.TryParse(Console.ReadLine(), out entranceYear))
            { Console.WriteLine("Неверный формат данных"); }

            return new ClassLibrary.Group(name, shortName, groupSize, entranceYear, CreateSpeciality(), CreateEmployee());
        }
        public static Classroom CreateClassroom()
        {
            Console.WriteLine("Введите название аудитории:");
            string name = Console.ReadLine();

            Console.WriteLine("Введите количество посадочных мест:");
            int places;
            while (!int.TryParse(Console.ReadLine(), out places))
            { Console.WriteLine("Неверный формат данных"); }

            Console.WriteLine("Введите количество окон:");
            int windows;
            while (!int.TryParse(Console.ReadLine(), out windows))
            { Console.WriteLine("Неверный формат данных"); }

            return new Classroom(name, CreateEmployee(), places, windows, null);
            //return new Classroom(name, CreateEmployee(), places, windows, CreateEquipment());
        }
        public static Employee CreateEmployee()
        {
            Console.WriteLine("Введите фамилию сотрудника:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Введите имя сотрудника:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Введите отчество сотрудника:");
            string patronypicName = Console.ReadLine();

            return new Employee(lastName, firstName, patronypicName, CreateSpeciality());
        }
        public static Speciality CreateSpeciality()
        {
            Console.WriteLine("Введите название специальности:");
            string name = Console.ReadLine();

            Console.WriteLine("Введите сокращенное название специальности:");
            string abberviation = Console.ReadLine();

            Console.WriteLine("Введите дату создания:");
            DateTime creationDate;
            while (!DateTime.TryParse(Console.ReadLine(), out creationDate))
            { Console.WriteLine("Неверный формат данных"); }

            return new Speciality(name, abberviation, creationDate);
        }
        public static Discipline CreateDiscipline() 
        {
            Console.WriteLine("Введите название дисциплины:");
            string name = Console.ReadLine();

            Console.WriteLine("Введите сокращенное название дисциплины:");
            string shortName = Console.ReadLine();

            return new Discipline(name, shortName);
        }
        public static Student CreateStudent()
        {
            Console.WriteLine("Введите фамилию студента:");
            string name1 = Console.ReadLine();

            Console.WriteLine("Введите имя студента:");
            string name2 = Console.ReadLine();

            Console.WriteLine("Введите отчество студента:");
            string name3 = Console.ReadLine();

            Console.WriteLine("Введите дату рождения студента:");
            DateTime date;
            while (!DateTime.TryParse(Console.ReadLine(), out date))
            { Console.WriteLine("Неверный формат данных"); }

            return new Student(name1, name2, name3, date, CreateGroup());
        }
        internal static Equipment CreateEquipment()
        {
            return new Equipment();
        }
    }
}
