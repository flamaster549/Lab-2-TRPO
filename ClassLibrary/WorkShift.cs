using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class WorkShift
    {
        public string Name;
        public DateTime date;

        public WorkShift(string Name, DateTime? date = null)
        {
            this.Name = Name;
            this.date = date ?? DateTime.Now;
        }
    }
}
