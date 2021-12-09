public class FakeLogger : ILogger
{
    public List<string> LoggerMessage { get; set; } = new List<string>();
    public void Looger(string messageToLog)
    {
        LoggerMessage.Add(messageToLog);
    }
}

