
using DependencyInjectionFuture.ConsoleApp;

var serviceProvider = new MyServiceProvider();

var consoleWriter = serviceProvider.GetService<IConsoleWriter>();

consoleWriter.WriteLine("Hi From Source Generated DI");
