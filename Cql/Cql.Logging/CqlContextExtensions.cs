using Microsoft.Extensions.Logging;
using Hl7.Cql.Operators;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.Logging
{
    public static class CqlContextExtensions
    {
        public static CqlContext AddMessageLogging(this CqlContext context,
            ILogger<CqlContext> logger)
        {
            context.Operators.MessageReceived += (sender, args) =>
            {
                var level = Level(args);
                logger.Log(level, new EventId(default, args.Code), args.Message, args.Source);
            };
            return context;
        }

        private static LogLevel Level(MessageEventArgs args) =>
            args.Severity switch
            {
                "error" => LogLevel.Error,
                "warning" => LogLevel.Warning,
                "information" => LogLevel.Information,
                "debug" => LogLevel.Debug,
                "trace" => LogLevel.Trace,
                _ => LogLevel.None,
            };

    }
}