public class ConsoleLogger : ILogger
{
    public void Looger(string messageToLog)
    {
        WriteLine(messageToLog);
    }
}