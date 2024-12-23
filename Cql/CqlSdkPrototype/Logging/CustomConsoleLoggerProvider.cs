using Microsoft.Extensions.Logging;

namespace CqlSdkPrototype.Logging;

public class CustomConsoleLoggerProvider : ILoggerProvider
{
    private readonly Func<string, string> _updateCategoryName;

    public CustomConsoleLoggerProvider(Func<string,string> updateCategoryName)
    {
        _updateCategoryName = updateCategoryName;
        Console.OutputEncoding = System.Text.Encoding.Default;
    }

    public ILogger CreateLogger(string categoryName)
    {
        categoryName = _updateCategoryName(categoryName);
        return new CustomConsoleLogger(categoryName, this);
    }

    void IDisposable.Dispose() { }
}