/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using Hl7.Cql.Operators;
using Hl7.Cql.Runtime;
using Microsoft.Extensions.Logging;

namespace Hl7.Cql.Logging
{
    public static class RuntimeContextExtensions
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