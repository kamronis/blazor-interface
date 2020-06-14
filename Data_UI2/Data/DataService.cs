using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data_UI2.Data
{
    public class DataService
    {
        private static List<Organization> organizations = new List<Organization> {
            new Organization("Институт математики"),
            new Organization("Институт систем информатики"),
            new Organization("Институт ядерной физики")
        };
        private static List<Person> persons = new List<Person> {
            new Person("Иван", organizations[1]),
            new Person("Андрей", organizations[0]),
            new Person("Владимир", organizations[0])
        };
        public Task<Organization[]> GetOrganizations()
        {
            return Task.FromResult(organizations.ToArray());
        }
        public Task<Organization> AddOrganization(Organization org)
        {
            organizations.Add(org);
            return Task.FromResult(org);
        }
        public Task<Organization> DeleteOrganization(Organization org)
        {
            organizations.Remove(org);
            return Task.FromResult(org);
        }
        public Task<Organization> EditOrganization(Organization org, String name)
        {
            organizations.Find(org.Equals).name = name;
            return Task.FromResult(org);
        }
        public Task<Person[]> GetPersons()
        {
            return Task.FromResult(persons.ToArray());
        }
        public Task<Person> AddPerson(Person person)
        {
            persons.Add(person);
            return Task.FromResult(person);
        }
        public Task<Person> DeletePerson(Person person)
        {
            persons.Remove(person);
            return Task.FromResult(person);
        }
        public Task<Person> EditPerson(Person person, String name, Organization org)
        {
            persons.Find(person.Equals).name = name;
            persons.Find(person.Equals).organization = org;
            return Task.FromResult(person);
        }
    }
}
