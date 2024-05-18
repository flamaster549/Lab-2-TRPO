using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /// <summary>
    ///     https://docs.google.com/document/d/1QSQdwb3s6IOh4avDr_-vpiYnII_80yUAVL3H_JkLNXQ/edit?usp=sharing
    /// </summary>
    public class WorkShift
    {
        private string name;
        public string Name
        { 
            get { return Name; } 
            set { Name = value; } 
        }


        private DateTime date;
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public WorkShift(string name, DateTime? date = null)
        {
            this.name = name;
            this.date = date ?? DateTime.Now;
        }
    }
}
