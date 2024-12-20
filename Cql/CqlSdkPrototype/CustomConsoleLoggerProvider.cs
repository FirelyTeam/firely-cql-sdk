using Microsoft.Extensions.Logging;

namespace CqlSdkPrototype;

public class CustomConsoleLoggerProvider : ILoggerProvider
{
    public ILogger CreateLogger(string categoryName)
    {
        return new CustomConsoleLogger(categoryName, this);
    }

    public void Dispose() { }
}