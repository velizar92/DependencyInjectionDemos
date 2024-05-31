using System;

namespace _5._AutofacDI._1._Tight_Coupling
{
    public class DatabaseService
    {
        public void Save(string employeeName)
        {
            //Normally is not ok to depend on Console but for the simplicity of the example...
            Console.WriteLine($"Saving {employeeName} to DB");
        }
    }
}
