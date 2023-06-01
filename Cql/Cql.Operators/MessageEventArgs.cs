using System;

namespace Hl7.Cql.Operators
{
    /// <summary>
    /// Provides data for <see cref="ICqlOperators.MessageReceived"/>.
    /// </summary>
    /// <seealso href="https://cql.hl7.org/09-b-cqlreference.html#message"/>
    public class MessageEventArgs: EventArgs
    {
        internal MessageEventArgs(object? source, string? code, string? message, string? severity)
        {
            Source = source;
            Code = code;
            Message = message;
            Severity = severity;
        }
        /// <summary>
        /// The source parameter to the CQL Message function.
        /// </summary>
        public object? Source { get; }
        /// <summary>
        /// The code parameter to the CQL Message function.
        /// </summary>
        public string? Code { get; }
        /// <summary>
        /// The message parameter to the CQL Message function.
        /// </summary>
        public string? Message { get; }
        /// <summary>
        /// The severity parameter to the CQL Message function.
        /// </summary>
        public string? Severity { get; }
    }
}