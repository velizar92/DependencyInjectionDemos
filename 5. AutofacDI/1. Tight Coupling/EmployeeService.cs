using System;

namespace _5._AutofacDI._1._Tight_Coupling
{
    public class EmployeeService
    {
        private readonly EmailService _emailService;
        private readonly ConsoleLoggerService _loggerService;
        private readonly DatabaseService _databaseService;

        public EmployeeService()
        {
            _emailService = new EmailService();
            _loggerService = new ConsoleLoggerService();
            _databaseService = new DatabaseService();
        }

        public void AddEmployee(string name)
        {
            _loggerService.Log($"Employee {name} added");
            _databaseService.Save(name);
            _emailService.SendEmail();
        }
    }
}
