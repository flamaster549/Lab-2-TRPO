using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    //https://docs.google.com/document/d/1qZEaADy71rJCOuNSTpyhh-f-NhSL2a6DCm88EgFO20o/edit
    public class Group
    {
        private string name;
        private string shortName;
        private uint groupSize;
        private uint entranceYear;
        private Speciality speciality;
        private Employee employee;

        public Group(string name, string shortName, uint groupSize, uint entranceYear, Speciality speciality, Employee employee)
        {
            this.name = name;
            this.shortName = shortName;
            this.groupSize = groupSize;
            this.entranceYear = entranceYear;
            this.speciality = speciality;
            this.employee = employee;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string ShortNname
        {
            get { return shortName; }
            set { shortName = value; }
        }
        public uint GroupSize
        {
            get { return groupSize; }
            set { groupSize = value; }
        }
        public uint EntranceYear
        {
            get { return entranceYear;}
            set { entranceYear = value;}
        }
        public Speciality Speciality
        {
            get { return speciality; }
            set { speciality = value; }
        }
        public Employee Employee
        {
            get { return employee; }
            set { employee = value; }
        }
    }
}
