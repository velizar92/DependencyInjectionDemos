using System;

namespace _3._AbstractDatabaseSystem._2._Loose_Coupling
{
    public class MySqlDatabase : IDatabase
    {
        private readonly string _connectionString;
        public MySqlDatabase(string connectionString)
        {
            _connectionString = connectionString;
        }
        public void SaveData(string data)
        {
           //TODO MySql logic for saving in the database...
        }
    }
}
