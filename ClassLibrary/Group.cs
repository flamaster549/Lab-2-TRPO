using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    internal class Group
    {
        private string name;
        private string shortName;
        private uint groupSize;
        private uint entranceYear;
        private Speciality speciality;
        private Employee employee;

        public Group(string Name1, string ShortName1, uint GroupSize1, uint EntranceYear1, Speciality Speciality1, Employee Employee1)
        {
            name = Name1;
            shortName = ShortName1;
            groupSize = GroupSize1;
            entranceYear = EntranceYear1;
            speciality = Speciality1;
            employee = Employee1;
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
        public Speciality Spec
        {
            get { return speciality; }
            set { speciality = value; }
        }
        public Employee Empl
        {
            get { return employee; }
            set { employee = value; }
        }
    }
}
