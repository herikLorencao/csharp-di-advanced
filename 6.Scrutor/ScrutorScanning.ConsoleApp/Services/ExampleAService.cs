using Microsoft.Extensions.DependencyInjection;
using Scrutor;
using ScrutorScanning.ConsoleApp.Attributes;
using ScrutorScanning.ConsoleApp.ServiceMarkers;

namespace ScrutorScanning.ConsoleApp.Services;

[Singleton]
public class ExampleAService : IExampleAService
{

}

public interface IExampleAService
{

}
