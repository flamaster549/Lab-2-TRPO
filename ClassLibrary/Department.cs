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
        public string Name { get; set; }
        public Employee Leader { get; set; }
        public Organization OrganizationLink { get; set; }

        public Department(string name, Employee leader, Organization organizationlink)
        {
            this.name = name;
            this.leader = leader;
            this.organizationLink = organizationlink;
        }
    }
}
