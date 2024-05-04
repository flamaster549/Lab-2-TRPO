using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    internal class Group
    {
        private string Name;
        private string ShortName;
        private uint GroupSize;
        private uint EntranceYear;
        private Speciality speciality;
        private Employee employee;

        public Group(string Name1, string ShortName1, uint GroupSize1, uint EntranceYear1, Speciality speciality1, Employee employe1e1)
        {
            Name = Name1;
            ShortName = ShortName1;
            GroupSize = GroupSize1;
            EntranceYear = EntranceYear1;
            speciality = speciality1;
            employee = employee1;
        }
        public string name
        {
            get { return Name; }
            set { Name = value; }
        }
        public string shname
        {
            get { return ShortName; }
            set { ShortName = value; }
        }
        public uint groupSize
        {
            get { return GroupSize; }
            set { GroupSize = value; }
        }
        public Speciality spec
        {
            get { return speciality; }
            set { speciality = value; }
        }
        public Employee empl
        {
            get { return employee; }
            set { employee = value; }
        }
    }
}
