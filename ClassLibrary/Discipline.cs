using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    internal class Discipline
    {
        private string name;
        private string shortName;

        public Discipline(string Name1, string ShortName1)
        {
            name = Name1;
            shortName = ShortName1;
        }

        //https://docs.google.com/document/d/1qCEMkbMRvvHP361IFDeWgSpHfVRUp6BV67nrsjl3fSw/edit?usp=drive_link
        
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
        public string Shname
        {
            get 
            { 
                return shortName; 
            }
            set 
            { 
                shortName = value; 
            }
        }
    }
}
