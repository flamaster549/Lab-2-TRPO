using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    internal class Speciality
    {   
        private string name;
        private string abbreviation;
        private DateTime creationDate;
    
        public Speciality(string name, string abbreviation, DateTime creationDate)
        {
            this.name = name;
            this.abbreviation = abbreviation;
            this.creationDate = creationDate != default ? creationDate : DateTime.UtcNow;
        }

    }
}
