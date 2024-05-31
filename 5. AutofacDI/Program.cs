/*Case 1 -> Tight Coupling -> THE WRONG WAY*/
//----------------------------------------------------------------------
//Uncomment the code below to see the result

using _5._AutofacDI._1._Tight_Coupling;

EmployeeService employeeService = new EmployeeService();
employeeService.AddEmployee("Velizar");




/*Case 2 -> Loose Coupling -> POOR MAN DI -> Good but can be better*/
//----------------------------------------------------------------------
//Uncomment the code below to see the result

//using _5._AutofacDI._2._Loose_Coupling_without_DI_Container;

//EmployeeService employeeService =
//    new EmployeeService(
//        new EmailService(new SMTPService(new TCPPacketController())),
//        new SQLServerDatabaseService(),
//        new ConsoleLoggerService()
//        );

//employeeService.AddEmployee("Velizar");




/*Case 3 -> Loose Coupling -> Autofac DI Container  -> Perfect*/
//----------------------------------------------------------------------
//Uncomment the code below to see the result

//using _5._AutofacDI._3._Loose_Coupling_with_DI_Container;
//using _5._AutofacDI._3._Loose_Coupling_with_DI_Container.Interfaces;
//using Autofac;

//var builder = new ContainerBuilder();

//builder.RegisterType<EmployeeService>().AsSelf();
//builder.RegisterType<EmailService>().As<IEmailService>();
//builder.RegisterType<SMTPService>().As<ISMTPService>();
//builder.RegisterType<TCPPacketController>().As<ITCPPacketController>();
//builder.RegisterType<SQLServerDatabaseService>().As<IDatabaseService>();
//builder.RegisterType<ConsoleLoggerService>().As<ILoggerService>();

//var container = builder.Build();

//EmployeeService employeeService = container.Resolve<EmployeeService>();
//employeeService.AddEmployee("Velizar");
