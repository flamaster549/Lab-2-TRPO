using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    ///https://docs.google.com/document/d/10XwtkjNB6-lRehWP_7qbgWC1nn_oIpa28ezyPXX3B28/edit?usp=drive_link
    internal class Classroom
    {

        private string name;
        private Employee employee;
        private int places;
        private int windows;
        private Equipment[] equipment;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public Employee EEmployee
        {
            get
            {
                return employee;
            }
            set
            {
                employee = value;
            }
        }

        public int Places
        {
            get
            {
                return places;
            }
            set
            {
                places = value;
            }
        }

        public int Windows
        {
            get
            {
                return windows;
            }
            set
            {
                windows = value;
            }
        }

        public Equipment[] EEquipment
        {
            get
            {
                return equipment;
            }
            set
            {
                equipment = value;
            }
        }

        public Classroom(string name, Employee EmpLink, int places, int windows, Equipment[] EquLink)
        {
            this.Name = name;
            this.EEmployee = EmpLink;
            this.Places = places;
            this.Windows = windows;
            this.EEquipment = EquLink;
        }
    }
}
