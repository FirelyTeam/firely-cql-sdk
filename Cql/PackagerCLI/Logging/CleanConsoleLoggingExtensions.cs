using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

namespace Hl7.Cql.Packager.Logging;

internal static class CleanConsoleLoggingExtensions
{
    public static void AddCleanConsole(
        this ILoggingBuilder logging,
        Action<CleanConsoleFormatterOptions> configure) =>
        logging
            .AddConsole(opt => opt.FormatterName = CleanConsoleFormatter.FormatterName)
            .AddConsoleFormatter<CleanConsoleFormatter, CleanConsoleFormatterOptionsInternal>(opt => configure.Invoke(opt.Options));

}