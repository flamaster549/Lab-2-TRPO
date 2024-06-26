﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Speciality
    {
        private string name;
        private string abbreviation;
        private DateTime creationDate;
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
        public string Abbreviation
        {
            get
            {
                return abbreviation;
            }
            set
            {
                abbreviation = value;
            }
        }

        public DateTime CreationDate
        {
            get
            {
                return creationDate;
            }
            set
            {
                creationDate = value;
            }
        }

        public Speciality(string name, string abbreviation, DateTime creationDate)
        {
            this.name = name;
            this.abbreviation = abbreviation;
            this.creationDate = creationDate != default ? creationDate : DateTime.UtcNow;
        }
        

    }
}

