using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data_UI2.Data
{
    public class Person
    {
        public string name { get; set; }

        public Organization organization { get; set; }

        public Person(string name, Organization org)
        {
            this.name = name;
            this.organization = org;
        }
    }
}
