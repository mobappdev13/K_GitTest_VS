using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDataAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            //using interface for connection a db

            using (IDbConnection conn = CreateConnection())
            {
                conn.Open();
                ExecuteScalar(conn); //count
                ExecuteReader(conn); //select
                ExecuteNonQuery(conn); //update
            }

            Console.ReadKey(true);
        }

        private static void ExecuteScalar(IDbConnection conn)
        {
            IDbCommand cmd = //new SqlCommand("select count(*) from CorsiPerStudente", (SqlConnection)conn);
                            conn.CreateCommand();

            //count scalar
            string sql = "select count(*) from CorsiPerStudente";

            cmd.CommandText = sql;

            //casting
            int result = (int)cmd.ExecuteScalar();

            Console.WriteLine($"{ sql } --> { result }");
        }

        private static void ExecuteNonQuery(IDbConnection conn)
        {
            //dati di input
            int idAula = 4; //poi idAula
            string cfDocente = "GJKDWT25F2382D"; //poi @cfDocente
            int idCorso = 2;  //poi @idCorso

            // Inizia una transazione di database con il livello di isolamento specificato
            //identico per insert and delete
            using (IDbTransaction tran = conn.BeginTransaction(IsolationLevel.RepeatableRead))
            {
                //string sql = $"update Corso set Id_aula={ idAula }, CF_Docente='{ cfDocente }' where id={ idCorso }";
                //modalità update:
                //UPDATE table-name SET column-name = value, column-name = value, ...WHERE condition
                // [Id], [Nome], [Id_Aula],[CF_Docente]

                //1
                string sql = "UPDATE Corso SET Id_aula = @idAula, CF_Docente = @cfDocente WHERE id = @idCorso";

                // RETURNS COMAND OBJECT ASSOCIATED WITH CONNECTION
                var cmdObject = conn.CreateCommand();
                //set properties of command object
                cmdObject.Transaction = tran;
                cmdObject.CommandText = sql;

                //create parameters (fondamentale per la sicurezza) un per idAula altro per cfDocente e infine pe idCorso
                //2
                var idAulaParam = cmdObject.CreateParameter();
                //idAulaParam.DbType = DbType.Int32;
                //idAulaParam.Direction = ParameterDirection.Input;
                idAulaParam.ParameterName = "idAula";
                idAulaParam.Value = idAula;
                cmdObject.Parameters.Add(idAulaParam);

                //per cfDocente
                var cfDocenteParam = cmdObject.CreateParameter();
                cfDocenteParam.ParameterName = "cfDocente";
                cfDocenteParam.Value = cfDocente;
                cmdObject.Parameters.Add(cfDocenteParam);

                //PER idCorso
                var idCorsoParam = cmdObject.CreateParameter();
                idCorsoParam.ParameterName = "idCorso";
                idCorsoParam.Value = idCorso;
                cmdObject.Parameters.Add(idCorsoParam);

                int rows = cmdObject.ExecuteNonQuery();

                tran.Commit(); //anche no
            }//using
        }


        private static void ExecuteReader(IDbConnection conn)
        {
            string sql = "select * from CorsiPerStudente";
            var cmd = conn.CreateCommand();
            cmd.CommandText = sql;

            StringBuilder sb = new StringBuilder();
            using (IDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        sb.AppendFormat("col[{0}]={1} | ", i, reader.GetValue(i));
                    }

                    sb.AppendLine();
                }
            }

            Console.WriteLine(sb.ToString());
        }

        private static IDbConnection CreateConnection()
        {
            return new SqlConnection("Server=192.168.9.219;Database=Corsi;User Id=corso;Password = corso;");
        }
    }
}

