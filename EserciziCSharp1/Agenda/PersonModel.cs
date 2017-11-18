using Agenda.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    internal class PersonModel
    {
        
        public PersonModel(Person person)
        {
            Id = person.Id;
            Name = 
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string DateofBirth { get; set; }
        public string Nationality { get; set; }
    }
}
