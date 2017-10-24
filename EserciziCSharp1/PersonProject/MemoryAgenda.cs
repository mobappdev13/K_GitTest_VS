using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonProject
{
    public class MemoryAgenda : Agenda
    {
        private readonly List<Person> _peopleList;

        private int _lastIdInserted;

        public MemoryAgenda()
        {
            _peopleList = new List<Person>();
            _lastIdInserted = 0;
        }

        public override Person GetPersonById(int id)
        {
            foreach (var p in _peopleList)
                if (p.Id == id) return p;
            return null;
        }

        public override bool AddPerson(string nameInputString, string surnameInputString, DateTime dobDateTime,PersonState nationality)
        {
            var p = new Person(++_lastIdInserted,nameInputString,surnameInputString,dobDateTime, nationality);
            _peopleList.Add(p);
            return true;
        }

        public override string GetPersonListDescription()
        {
            if (_peopleList.Any())
            {
                var sb = new StringBuilder();
                foreach (var p in _peopleList)
                    sb.AppendLine(p.ToString());
                return sb.ToString();
            }
            else
            {
                return "Agenda vuota";
            }
        }

        public override bool PersonIdExist(int id)
        {
            foreach (var p in _peopleList)
                if (p.Id == id) return true;
            return false;
        }

        public override bool RemovePersonById(int id)
        {
            if (!PersonIdExist(id)) return false;
            var personToRemove = GetPersonById(id);
            _peopleList.Remove(personToRemove);
            return true;
        }

        public override List<Person> GetPeopleList()
        {
            return _peopleList;
        }
    }
}