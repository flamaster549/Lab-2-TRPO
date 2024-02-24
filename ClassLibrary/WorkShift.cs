using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    internal class WorkShift
    {
                private string Name;
        private DateTime date;
        
        public WorkShift(string Name, DateTime? date = null)
        {
            this.Name = Name;
            this.date = date ?? DateTime.Now;
        }
    }
}
