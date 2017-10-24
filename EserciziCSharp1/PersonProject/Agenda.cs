using System;
using System.Collections.Generic;

namespace PersonProject
{


    public abstract class Agenda
    {
        public abstract bool RemovePersonById(int id);
        public abstract string GetPersonListDescription();
        public abstract bool PersonIdExist(int id);
        public abstract Person GetPersonById(int id);
        public abstract bool AddPerson(string nameInputString, string surnameInputString, DateTime dobDateTime,PersonState nationality);

        public abstract List<Person> GetPeopleList();
    }
}