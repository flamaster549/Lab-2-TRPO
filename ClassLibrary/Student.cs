using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Student
    {
        private string surname;
        private string name;
        private string patronymic;
        private Group group;
        private DateTime date;
        public Student(string surname1, string name1, string patronymic1, DateTime date1, Group group1)
        {
            surname = surname1;
            name = name1;
            patronymic = patronymic1; 
            date = date1;
            group = group1;
        }
        public string Surname
        {
            set { this.surname = value; }
            get { return surname; }
        }
        public string Name
        {
            set { this.name = value; }
            get { return name; }
        }
        public string Patronymic
        {
            get { return patronymic; }
            set { patronymic = value; }
        }
        public Group Group
        {
            get { return group; }
            set {  group = value; }
        }
        public DateTime Date
        { 
            get { return date; } 
            set {  date = value; } 
        }
    }
}
