using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Security_Agency
{
    public class DBWork
    {
        private static DBWork instance = null;
        public static NpgsqlConnection _connection;

        public static DBWork CreateDBWork(string host, string port, string username,
            string password, string database, string sslMode = "Require",
            string trustServerCertificate = "true")
        {
            if (instance != null)
            {
                return instance;
            }

            string connection = String.Format("Host={0}; Port={1}; Username={2}; " +
                "Password={3}; Database={4}; SSL Mode={5}; Trust Server Certificate={6}",
                host, port, username, password, database, sslMode, trustServerCertificate);

            return new DBWork(connection);

        }

        public DBWork(string connectionString)
        {
            _connection = new NpgsqlConnection(connectionString);
            _connection.Open();
        }

        ~DBWork()
        {
            _connection.Close();
        }

        public static string SelectFam()
        {
            NpgsqlCommand com = new NpgsqlCommand("select \"Surname\" from public.\"Client\" where public.\"Client\".\"PK_Client\"=1", _connection);
            string result = com.ExecuteScalar().ToString(); ;
            return result;
        }
    }
}
