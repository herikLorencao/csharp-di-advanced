namespace TheDependencyProblem;

public class Greeter
{
    private readonly IDateTimeProvider _dateTimeProvider;

    public Greeter(IDateTimeProvider dateTimeProvider)
    {
        _dateTimeProvider = dateTimeProvider;
    }

    public string CreateGreetMessage()
    {
        var dateTimeNow = _dateTimeProvider.DateTimeNow;
        return dateTimeNow.Hour switch
        {
            >= 5 and < 12 => "Good morning",
            >= 12 and < 18 => "Good afternoon",
            _ => "Good evening"
        };
    }
}

public interface IDateTimeProvider
{
    public DateTime DateTimeNow { get; }
}

public class SystemDateTimeProvider : IDateTimeProvider
{
    public DateTime DateTimeNow => DateTime.Now;
}
