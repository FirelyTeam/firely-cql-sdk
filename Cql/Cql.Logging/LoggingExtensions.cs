/* 
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Operators;
using Hl7.Cql.Runtime;
using JetBrains.Annotations;
using Microsoft.Extensions.Logging;

namespace Hl7.Cql.Logging
{
    /// <summary>
    /// An extension class for adding logging on a <see cref="CqlContext"/>
    /// </summary>
    [UsedImplicitly]
    public static class LoggingExtensions
    {
        /// <summary>
        /// Adds functionality to a context to direct log messages to the given logger.
        /// </summary>
        [UsedImplicitly]
        public static CqlContext AddMessageLogging(this CqlContext ctx, ILogger logger)
        {
            ctx.MessageReceived += (sender, args) =>
            {
                var level = Level(args);
                logger.Log(level, new EventId(default, args.Code), args.Message, args.Source);
            };

            return ctx;
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