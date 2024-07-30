using Microsoft.Build.Utilities;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.Tools.BuildTasks
{
    internal static class TaskLogger
    {
        public static ILoggingBuilder AddTaskLogger(this ILoggingBuilder builder, TaskLoggingHelper taskLoggingHelper)
        {
            builder.AddProvider(new TaskLoggerProvider(taskLoggingHelper));
            return builder;
        }

        private class TaskLoggerProvider : ILoggerProvider
        {
            public TaskLoggerProvider(TaskLoggingHelper taskLoggingHelper)
            {
                TaskLoggingHelper = taskLoggingHelper;
            }

            public TaskLoggingHelper TaskLoggingHelper { get; }

            public ILogger CreateLogger(string categoryName) => new TaskLogger(categoryName, TaskLoggingHelper);

            public void Dispose() { }

            private class TaskLogger: ILogger
            {
                public TaskLogger(string category, TaskLoggingHelper taskLoggingHelper)
                {
                    TaskLoggingHelper = taskLoggingHelper;
                }

                public TaskLoggingHelper TaskLoggingHelper { get; }

                public IDisposable BeginScope<TState>(TState state) where TState : notnull =>
                    new DisposableScope();
                private class DisposableScope : IDisposable
                {
                    public void Dispose()
                    {
                    }
                }

                public bool IsEnabled(LogLevel logLevel) => true;

                public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
                {
                    switch(logLevel) { 
                        case LogLevel.Trace:
                            TaskLoggingHelper.LogMessage(Microsoft.Build.Framework.MessageImportance.Low, formatter(state, exception));
                            break;
                        case LogLevel.Debug:
                            TaskLoggingHelper.LogMessage(Microsoft.Build.Framework.MessageImportance.Normal, formatter(state, exception));
                            break;
                        case LogLevel.Information:
                            TaskLoggingHelper.LogMessage(Microsoft.Build.Framework.MessageImportance.High, formatter(state, exception));
                            break;
                        case LogLevel.Warning:
                            TaskLoggingHelper.LogWarning(null, null, null, null, 0, 0, 0, 0, formatter(state, exception));
                            break;
                        case LogLevel.Error:
                            TaskLoggingHelper.LogError(null, null, null, null, 0, 0, 0, 0, formatter(state, exception));
                            break;
                        case LogLevel.Critical:
                            TaskLoggingHelper.LogCriticalMessage(null, null, null, null, 0, 0, 0, 0, formatter(state, exception));
                            break;
                    }
                }
            }
        }

    }
}
