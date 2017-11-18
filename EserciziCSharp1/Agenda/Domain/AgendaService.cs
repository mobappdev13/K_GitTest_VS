using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Domain
{
    public class AgendaService
    {
        string _connectioString;

        //string conn
        //"Server=192.168.9.219;Database=Corsi;User Id=corso;Password=corso;")
        public AgendaService(string conn)
        {
            _connectioString = conn;
        }
        //
        private IDbConnection CreateConnection()
        {
            return new SqlConnection(_connectioString);
        }

        public List<Person> GetPeople()
        {
            List<Person> listPerson = new List<Person>();
            string sql = "select p.ID, p.Name, p.Surname, DateOfBirth, NationalityId, n.Name " +
                         "from Person p Join Nationality n on p.NationalityId = n.Id";

            var conn = CreateConnection();
            //need try catch
            var cmd = conn.CreateCommand();
            conn.Open();

            cmd.CommandText = sql;


            using (IDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Person localPerson = new Person();
                    Nationality localNationality = new Nationality();

                    //for (int i = 0; i < reader.FieldCount; i++)
                    //{
                    //
                    localPerson.Id = reader.GetInt32(0);
                    localPerson.Name = reader.GetString(1);
                    localPerson.Surname = reader.GetString(2);
                    localPerson.DateOfBirth = reader.GetDateTime(3);
                    localNationality.Id = reader.GetInt32(4);
                    localNationality.Name = reader.GetString(5);
                    //dopo avere creato la nationality !!!!
                    localPerson.Nationality = localNationality;
                    //
                    listPerson.Add(localPerson);
                }//endwhile

               
            }
            return listPerson;

            //Console.WriteLine(sb.ToString());
        }
        //AddPerson..
        //DeletePerson(...)
    }
}
