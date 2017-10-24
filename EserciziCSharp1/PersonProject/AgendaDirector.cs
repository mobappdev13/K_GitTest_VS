using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonProject
{
    public enum AgendaType
    {
        Memory,
        File
    }
    public class AgendaDirector
    {
        private readonly Agenda _agenda;

        public AgendaDirector(AgendaType agendaType)
        {
            switch (agendaType)
            {
                case AgendaType.Memory:
                    _agenda = new MemoryAgenda();
                    break;
                case AgendaType.File:
                    _agenda = new FileAgenda();
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        public bool AddPerson(string name, string surname, DateTime dob,PersonState nationality)
        {
            return _agenda.AddPerson(name, surname, dob, nationality);
        }

        public bool RemovePersonById(int id)
        {
            return _agenda.RemovePersonById(id);
        }

        public string GetPeopleDescription()
        {
            return _agenda.GetPersonListDescription();
        }

        public Person GetPersonById(int id)
        {
            return _agenda.GetPersonById(id);
        }

        public bool PersonIdExist(int id)
        {
            return _agenda.PersonIdExist(id);
        }

        public List<Person> GetPersonList()
        {
            return _agenda.GetPeopleList();
        }

        #region Validation Function

        public bool IsMonthValid(int month)
        {
            return month > 0 && month <= 12;
        }

        public bool IsYearValid(int year)
        {
            return year > 1900 && year < 2017;
        }

        public bool IsDayValid(int day, int month,int year)
        {
            var maxDayValue = DateTime.DaysInMonth(year, month);
            return day > 0 && day < maxDayValue;
        }
        //un nome e' valido se e' lungo meno di 35 caratteri, se contiene un valore numerico o se e' vuota
        public bool IsNameValid(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return false;
            if (name.Length > 35)
                return false;
            if (name.Any(c => char.IsDigit(c)))
                return false;
            return true;
        }
        //un cognome e' valido se e' lungo meno di 35 caratteri, se contiene un valore numerico o se e' vuota
        public bool IsSurnameValid(string surname)
        {
            if (string.IsNullOrWhiteSpace(surname))
                return false;
            if (surname.Length > 35)
                return false;
            if (surname.Any(c => char.IsDigit(c)))
                return false;
            return true;
        }

        #endregion

    }
}