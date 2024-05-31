using System;

namespace _5._AutofacDI._2._Loose_Coupling_without_DI_Container
{
    public class SQLServerDatabaseService : IDatabaseService
    {
        public void Save(string employeeName)
        {
            Console.WriteLine($"Saving {employeeName} to DB");
        }
    }
}
