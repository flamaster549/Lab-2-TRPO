using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ClassLibrary;

namespace ConsoleApp
{
    internal static class Fabric
    {
        







        public static Classroom CreateClassroom()
        {
            Employee employee = CreateEmployee();
            Equipment[] equipment = CreateEquipment();
            return new Classroom("", employee, 0, 0, equipment);
        }
        public static Discipline CreateDiscipline()
        {
            return new Discipline("", "");
        }








        public static Employee CreateEmployee()
        {
            Speciality speciality = CreateSpeciality();
            return new Employee("", "", "", speciality);
        }
        public static Equipment CreateEquipment()
        {
            return null;
        }
        public static Group CreateGroup()
        {
            Speciality speciality = CreateSpeciality();
            Employee employee = CreateEmployee();
            return new Group("", "", 0, 0, speciality, employee);
        }
        public static Lesson CreateLesson()
        {
            DateTime datetime;
            Discipline discipline = CreateDiscipline();
            Employee employee = CreateEmployee();
            Classroom classroom = CreateClassroom();
            Group group = CreateGroup();
            Pair pair = CreatePair();
            return new Lesson(datetime, discipline, employee, classroom, group, pair);
        }
        public static Pair CreatePair()
        {
            DateTime startTime;
            DateTime endTime;
            DateTime breakStartTime;
            DateTime breakEndTime;
            return new Employee(startTime, endTime, breakStartTime, breakEndTime, "");
        }
        public static Speciality CreateSpeciality()
        {
            DateTime creationDate;
            return new Speciality("", "", creationDate);
        }
        public static Student CreateStudent()
        {
            Group group = CreateGroup();
            DateTime date;  
            return new Employee("", "", "", date, group);
        }
    }
}
