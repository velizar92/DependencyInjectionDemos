using System;
using _5._AutofacDI._3._Loose_Coupling_with_DI_Container.Interfaces;

namespace _5._AutofacDI._3._Loose_Coupling_with_DI_Container
{
    public class SQLServerDatabaseService : IDatabaseService
    {
        public void Save(string employeeName)
        {
            Console.WriteLine($"Saving {employeeName} to DB");
        }
    }
}
