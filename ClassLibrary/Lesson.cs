using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Lesson
    {
        private DateTime date;
        private Discipline discipline;
        private Employee employee;
        private Classroom classroom;
        private Group group;
        private Pair pair;

        public Lesson(Discipline discipline, Employee employee, Classroom classroom, Group group, Pair pair, DateTime date)
        {
            this.date = date.Date;
            this.discipline = discipline;
            this.employee = employee;
            this.classroom = classroom;
            this.group = group;
            this.pair = pair;
        }

        public Lesson(Discipline discipline, Employee employee, Classroom classroom, Group group, Pair pair)
            :this(discipline, employee, classroom, group, pair, DateTime.Today)
        {

        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public Discipline Discipline
        {
            get { return discipline; }
            set { discipline = value; }
        }

        public Employee Employee
        {
            get { return employee; }
            set { employee = value; }
        }

        public Classroom Classroom
        {
            get { return classroom; }
            set { classroom = value; }
        }

        public Group Group
        {
            get { return group; }
            set { group = value; }
        }

        public Pair Pair
        {
            get { return pair; }
            set { pair = value; }
        }


    }

}
