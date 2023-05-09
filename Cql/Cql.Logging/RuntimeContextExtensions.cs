using Microsoft.Extensions.Logging;
using Ncqa.Cql.Operators;
using Ncqa.Cql.Runtime;

namespace Ncqa.Cql.Runtime.Logging
{
    public static class RuntimeContextExtensions
    {
        public static RuntimeContext AddMessageLogging(this RuntimeContext context,
            ILogger<RuntimeContext> logger)
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