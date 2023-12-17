using ScrutorScanning.ConsoleApp.Attributes;
using ScrutorScanning.ConsoleApp.ServiceMarkers;

namespace ScrutorScanning.ConsoleApp.Services;

[Singleton]
[Transient]
public class ExampleBService : IExampleBService
{

}

public interface IExampleBService
{

}
