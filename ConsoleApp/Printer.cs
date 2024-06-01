using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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
            Console.WriteLine("Фамилия: {0}", employee.LastName);
            Console.WriteLine("Имя: {0}", employee.FirstName);
            Console.WriteLine("Отчество: {0}", employee.PatronymicName);
            PrintSpeciality(employee.Speciality);
        }


       
        public static void PrintSpeciality(Speciality speciality) 
        {
            Console.WriteLine(speciality.Name);
            Console.WriteLine(speciality.Abbreviation);
        }
       public static void PrintDiscipline(Discipline discipline)
        {
            Console.WriteLine(discipline.Name);
            Console.WriteLine(discipline.Shname);
        }

        public static void PrintClassroom(Classroom classroom)
        {
            Console.WriteLine(classroom.Name);
            PrintEmployee(classroom.Employee);
            Console.WriteLine(classroom.Places);
            Console.WriteLine(classroom.Windows);
            PrintEquipment(classroom.Equipment);
        }

        public static void PrintGroup(Group group)
        {
            Console.WriteLine(group.Name);
            Console.WriteLine(group.ShortNname);
            Console.WriteLine(group.GroupSize);
            Console.WriteLine(group.EntranceYear);
            PrintSpeciality(group.Speciality);
            PrintEmployee(group.Employee);
            
        }

        public static void PrintPair(Pair pair)
        {
            Console.WriteLine(pair.StartTime);
            Console.WriteLine(pair.EndTime);
            Console.WriteLine(pair.BreakStartTime);
            Console.WriteLine(pair.BreakEndTime);
            PrintWorkShift(pair.WorkShift);
        }

        public static void PrintEquipment(List<Equipment> equipment)
        {
            Console.WriteLine(equipment);
        }

        public static void PrintStudent(Student student)
        {
            Console.WriteLine(student.Surname);
            Console.WriteLine(student.Name);
            Console.WriteLine(student.Patronymic);
            PrintGroup(student.Group);
            Console.WriteLine(student.Date);
        }
        public static void PrintWorkShift(WorkShift workShift)
        {
            Console.WriteLine(workShift.Name);
        }

        public static void PrintDepartment(Department department)
        {
            Console.WriteLine(department.Name);
            PrintEmployee(department.Leader);
            PrintOrganization(department.OrganizationLink);
        }
        public static void PrintOrganization(Organization organization)
        {
            Console.WriteLine(organization);
        }
        public static void PrintPosition(Position position)
        {
            Console.WriteLine(position.Title);
            Console.WriteLine(position.Salary);
            PrintDepartment(position.Department);
        }
    }
}
