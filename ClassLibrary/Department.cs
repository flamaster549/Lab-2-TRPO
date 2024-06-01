using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Department
    {
        private string name;
        private Employee leader;
        private Organization organizationLink;
        public string Name { get { return name; } set { name = value; } }
        public Employee Leader { get { return leader; } set { leader = value; } }
        public Organization OrganizationLink { get { return organizationLink; } set { organizationLink = value; } }

        public Department(string name, Employee leader, Organization organizationlink)
        {
            this.name = name;
            this.leader = leader;
            this.organizationLink = organizationlink;
        }
    }
}
