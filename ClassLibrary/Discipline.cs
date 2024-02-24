using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    internal class Discipline
    {
        private string Name;
        private string ShortName;

        public Discipline(string Name1, string ShortName1)
        {
            Name = Name1;
            ShortName = ShortName1;
        }

        //https://docs.google.com/document/d/1qCEMkbMRvvHP361IFDeWgSpHfVRUp6BV67nrsjl3fSw/edit?usp=drive_link
        
        public string name
        {
            get 
            { 
                return Name; 
            }
            set 
            { 
                Name = value; 
            }
        }
        public string shname
        {
            get 
            { 
                return ShortName; 
            }
            set 
            { 
                ShortName = value; 
            }
        }
    }
}
