using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /// <summary>
    /// https://docs.google.com/document/d/1yBWzXRuxmOQiPQs9TyNx8tNgq6nWF42Sjn-mgT_-5nY/edit?usp=sharing
    /// </summary>
    

    public class Position
    {
        private string title;
        private decimal salary;
        private Department department;

        public Position(string title, decimal salary, Department department)
        {
            this.title = title;
            this.salary = salary;
            this.department = department;
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public Department Department
        {
            get { return department; }
            set { department = value; }
        }
    }

}
