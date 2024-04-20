﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ConsoleApp
{
    internal static class Fabric
    {
        public static Employee CreateEmployee()
        {
            Speciality speciality = CreateSpeciality();

            return new Employee("","","",speciality);
        }

        public static Discipline CreateDiscipline() 
        {
            return new Discipline("", "");
        }
        public static Speciality CreateSpeciality()
        {
            return null;
        }
    }
}
