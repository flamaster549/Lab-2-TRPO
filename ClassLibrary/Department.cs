using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class Department
    {
        private string Name { get; set; }
        private Employee Leader { get; set; }
        private Organization OrganizationLink { get; set; }

        public Department(string name, Employee leader, Organization organizationlink)
        {
            Name = name;
            Leader = leader;
            OrganizationLink = organizationlink;
        }
    }
}
