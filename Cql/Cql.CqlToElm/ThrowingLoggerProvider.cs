using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm
{
    internal class ThrowingLoggerProvider : ILoggerProvider
    {
        private readonly LogLevel threshold;

        public ThrowingLoggerProvider(LogLevel threshold = LogLevel.Error)
        {
            this.threshold = threshold;
        }

        public ILogger CreateLogger(string categoryName) => new ThrowingLogger(categoryName, threshold);

        public void Dispose()
        {
        }
    }

    internal class ThrowingLogger: ILogger
    {
        private readonly string category;
        private readonly LogLevel threshold;

        public ThrowingLogger(string category,
            LogLevel threshold = LogLevel.Error)
        {
            this.category = category;
            this.threshold = threshold;
        }

        public IDisposable? BeginScope<TState>(TState state) where TState : notnull
        {
            return null;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return true;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
        {
            if (logLevel >= threshold)
            {
                if (exception == null)
                {
                    var message = $"[{category}] {formatter(state, null)}";
                    throw new InvalidOperationException(message);
                }
                else throw exception;
            }

        }
    }
}
