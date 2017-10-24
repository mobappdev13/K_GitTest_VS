using System;
using System.Collections.Generic;

namespace PersonProject
{
    public class FileAgenda : Agenda
    {


        public override Person GetPersonById(int id)
        {
            throw new NotImplementedException();
        }

        public override string GetPersonListDescription()
        {
            throw new NotImplementedException();
        }

        public override bool PersonIdExist(int id)
        {
            throw new NotImplementedException();
        }

        public override bool RemovePersonById(int id)
        {
            throw new NotImplementedException();
        }

        public override bool AddPerson(string nameInputString, string surnameInputString, DateTime dobDateTime, PersonState nationality)
        {
            throw new NotImplementedException();
        }

        public override List<Person> GetPeopleList()
        {
            throw new NotImplementedException();
        }
    }
}