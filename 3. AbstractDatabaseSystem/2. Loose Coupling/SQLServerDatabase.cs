using Microsoft.Data.SqlClient;
using System;

namespace _3._AbstractDatabaseSystem._2._Loose_Coupling
{
    public class SQLServerDatabase : IDatabase
    {
        private readonly string _connectionString;
        public SQLServerDatabase(string connectionString)
        {
            _connectionString = connectionString;
        }
        public void SaveData(string data)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO MyTable (MyColumn) VALUES (@data)";
                    command.Parameters.AddWithValue("@data", data);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
