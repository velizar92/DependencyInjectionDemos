using System;
using _5._AutofacDI._3._Loose_Coupling_with_DI_Container.Interfaces;

namespace _5._AutofacDI._3._Loose_Coupling_with_DI_Container
{
    public class EmployeeService
    {
        private readonly IEmailService _emailService;
        private readonly IDatabaseService _databaseService;
        private readonly ILoggerService _loggerService;

        public EmployeeService(IEmailService emailService, IDatabaseService databaseService,
            ILoggerService loggerService)
        {
            _emailService = emailService;
            _databaseService = databaseService;
            _loggerService = loggerService;
        }

        public void AddEmployee(string name)
        {
            _loggerService.Log($"Employee {name} added");
            _databaseService.Save(name);
            _emailService.SendEmail();
        }
    }
}
