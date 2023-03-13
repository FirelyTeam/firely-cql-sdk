using System;

namespace Ncqa.Cql.Runtime
{
    public class MessageEventArgs: EventArgs
    {
        internal MessageEventArgs(object source, string code, string message, string severity)
        {
            Source = source;
            Code = code;
            Message = message;
            Severity = severity;
        }
        public object Source { get; }
        public string Code { get; }
        public string Message { get; }
        public string Severity { get; }
    }
}