/*
 * Copyright (c) 2025, Firely and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
 
namespace Hl7.Cql.Packager.Logging;

/// <remarks>
/// This class is not part of the API. It is used internally by the prototype and the PackagerCLI.
/// It will be moved to the PackagerCLI once the prototype is complete,
/// and then it will move to the PackagerCLI and made internal.
/// </remarks>
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
