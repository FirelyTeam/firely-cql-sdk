namespace CqlSdkPrototype.Logging;

public sealed class ColorConsoleLoggerProvider : ILoggerProvider
{
    private readonly Func<string, string> _updateCategoryName;

    public ColorConsoleLoggerProvider(Func<string,string>? updateCategoryName = null)
    {
        _updateCategoryName = updateCategoryName ?? MakeShortCategory;
        Console.OutputEncoding = System.Text.Encoding.Default;
    }

    private static string MakeShortCategory(string cat)
    {
        return cat.Split(separator: '.').Last();
    }

    public ILogger CreateLogger(string categoryName)
    {
        categoryName = _updateCategoryName(categoryName);
        return new ColorConsoleLogger(categoryName, this);
    }

    void IDisposable.Dispose() { }
}