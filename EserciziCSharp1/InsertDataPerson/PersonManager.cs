using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertPersonData
{
    class PersonManager
    {
        readonly IStorage _storage;

        public PersonManager(IStorage storage)
        {
            //if (storageType == "file")
            //    _storage = new FileStorage();
            //else if (storageType == "memory")
            //    _storage = new MemoryStorage();
            //else
            //    _storage = new DatabaseStorage();

            _storage = storage;

            PersonList = new List<Person>();
        }
        //List<Person> PersonList = new List<Person>();
        public List<Person> PersonList { get; private set; }
        //public PersonManager(string nome, string cognome, string birthday, int id) : base(nome, cognome, birthday,id)
        //{

        //}


        internal void AddPerson(string nome, string cognome, string birthday, int id)
        {
            Person user = new Person(nome, cognome, birthday, id);
            try
            {
                _storage.Add(user);
            }
            catch (Exception ex)
            {
                var myEx = new Exception($"messaggio: non riesco ad inserire la Persona in PersonManager {ex} { ex.Message} {ex.GetType()} ");
                throw myEx;
            }
            //finally
            
        }

       

        internal static int CreaId(List<Person> idList)
        {
            //Person user = new Person(nome, cognome, birthday, id);
            return idList.Count;

                

        }
        internal void DelPerson(string nome, string cognome, string birthday, int id)
        {
            Person user = new Person(nome, cognome, birthday, id);

            if(PersonList.Count!=0) PersonList.RemoveAt(id);
            else Console.WriteLine("La lista è vuota");

        }
        internal void ListPerson(string nome, string cognome, string birthday, int id)
        {
            //Person user = new Person(nome, cognome, birthday, id);
            //MonitorConsole consolewrite = new MonitorConsole();

            if (PersonList.Count == 0)
            {
                Console.WriteLine(" La Lista è vuota");
            }
            else
            {
                foreach (Person user in PersonList)
                {
                    Console.WriteLine($"Le persone registrate sono: {user.Id}, {user.Nome}, {user.Cognome}, {user.Birthday} ");
                }
            }
        }


    }
}
