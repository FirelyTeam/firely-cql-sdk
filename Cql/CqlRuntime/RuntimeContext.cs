
using Ncqa.Cql.Runtime.Comparers;
using Ncqa.Cql.Runtime.Conversion;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Ncqa.Cql.Runtime
{
    public abstract class RuntimeContext : ICqlComparer, ICqlComparer<object>
    {
        public RuntimeOptions Options { get; protected set; } = new RuntimeOptions();
        public abstract ICqlOperators Operators { get; }
        public abstract IDataRetriever DataRetriever { get; }
        public abstract CqlComparers Comparers { get; }
        public DefinitionDictionary<Delegate> Definitions { get; protected set; }
        public ConcurrentDictionary<string, object> Extensions { get; protected set; } = new ConcurrentDictionary<string, object>();
        /// <summary>
        /// Stores information about the current execution state of this RuntimeContext.
        /// </summary>
        public Stack<CallStack> CallStack { get; protected set; }

        public DateTimeOffset Now { get; } = DateTimeOffset.UtcNow;
        public TimeSpan TimeZone => Now.Offset;
        public IDictionary<string, object> Parameters { get; protected set; } = new Dictionary<string, object>();
        public IValueSetDictionary ValueSets { get; protected set; }

        public IComparer<object> IComparer { get; protected set; }
        public IEqualityComparer<object> IEqualityComparer { get; protected set; }
        public IUnitConverter UnitConverter => Comparers.UnitConverter;

        public event EventHandler<MessageEventArgs>? MessageReceived;

        protected internal void Message(object source, string code, string severity, string message)
        {
            var handler = MessageReceived;
            if (handler != null)
            {
                var args = new MessageEventArgs(source, code, message, severity);
                handler(this, args);
            }
        }

        protected RuntimeContext(DefinitionDictionary<Delegate> definitions,
            IDictionary<string, object> parameters,
            IValueSetDictionary valueSetDictionary,
            DateTimeOffset now,
            RuntimeOptions? options)
        {
            Now = now;
            CallStack = new Stack<CallStack>();
            Definitions = definitions ?? throw new ArgumentNullException(nameof(definitions));
            Parameters = parameters ?? throw new ArgumentNullException(nameof(parameters));
            ValueSets = valueSetDictionary ?? throw new ArgumentNullException(nameof(valueSetDictionary));
            var bridge = new CqlComparerBridge<object>(this);
            IComparer = bridge;
            IEqualityComparer = bridge;
            if (options != null)
                Options = options;
        }

        public abstract RuntimeContext Clone();
        protected void PopulateClone<T>(T clone) where T : RuntimeContext
        {
            clone.Definitions = Definitions;
            clone.Extensions = Extensions;
            clone.Parameters = Parameters;
            clone.Options = Options;
            clone.ValueSets = ValueSets;
        }


        public RuntimeContext Deeper(CallStack callStack)
        {
            var existingStack = CallStack ?? new Stack<CallStack>();
            var newStack = new Stack<CallStack>(existingStack);
            newStack.Push(callStack);

            var clone = Clone();
            clone.Extensions = Extensions;
            clone.CallStack = newStack;
            return clone;
        }

        public const string ParameterDelimiter = ".";

        public object? ResolveParameter(string libraryNameAndVersion, string parameterName)
        {
            var fullyQualified = $"{libraryNameAndVersion}{ParameterDelimiter}{parameterName}";
            if (this.Parameters.ContainsKey(fullyQualified))
                return this.Parameters[fullyQualified];

            if (this.Parameters.ContainsKey(parameterName))
                return this.Parameters[parameterName];

            return null;
        }

        public bool? Equals(object x, object y, string? precision) => Comparers.Equals(x, y, precision);

        public int? Compare(object x, object y, string? precision) => Comparers.Compare(x, y, precision);

        public bool Equivalent(object x, object y, string? precision) => Comparers.Equivalent(x, y, precision);

        public int GetHashCode(object x) => Comparers.GetHashCode(x);
    }
}
