using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dumpify;

/// <summary>
/// The Dumpify Nuget package is problematic because it does not have a strong name.
/// To keep the current code intact after removing the Dumpify package,
/// we can create a dummy class with the same extension methods.
/// </summary>
internal static class DumpifyExtensions
{
    public static T DumpConsole<T>(this T obj, string? header = null) => obj;
}
