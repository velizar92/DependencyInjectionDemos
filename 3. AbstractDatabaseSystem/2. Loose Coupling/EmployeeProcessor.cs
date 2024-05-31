using System;
using System.Collections.Generic;

namespace _3._AbstractDatabaseSystem._2._Loose_Coupling
{
    /*Here our EmployeeProcessor class is decoupled from the Database system.
    * It depends from an abstraction interface IDatabase. That means now this class
    * is fully testable and we can create mock and simulate the behavior of its dependency
    * (IDatabase) in our unit tests. Also we can swap the real databases very easily without 
    * to touch the EmployeeProcessor class. EmployeeProcessor class just works via abstraction,
    * and not concreate implementation. It is decoupled.
    */
    public class EmployeeProcessor
    {
        private readonly IDatabase _database;

        public EmployeeProcessor(IDatabase database)
        {
            if (database == null)
            {
                throw new ArgumentNullException(nameof(database));
            }

            _database = database;
        }

        public void SaveEmployee(string employeeName)
        {
            _database.SaveData(employeeName);
        }
    }
}
