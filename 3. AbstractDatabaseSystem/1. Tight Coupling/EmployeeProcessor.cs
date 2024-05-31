using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.SqlClient;

namespace _3._AbstractDatabaseSystem._1._Tight_Coupling
{
    /*Here our class EmployeeProcessor is coupled to the Database system. This is bad!
    *It is not testable with unit tests! Our unit tests will depend from the Database System which
    *is incorrect. That means if we want to test this class with unit tests we have to send queries
    *to the real database which is absolutely incorrect. We should have an option for mocking)
    *(Please see the loose coupled example).*/
    public class EmployeeProcessor
    {
        private readonly string _connectionString;
        public EmployeeProcessor(string connectionString)
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
