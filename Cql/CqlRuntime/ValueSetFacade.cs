using Ncqa.Cql.Runtime.Primitives;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Ncqa.Cql.Runtime
{
    [DebuggerDisplay("{Uri}")]
    public class ValueSetFacade : IValueSetFacade
    {
        public ValueSetFacade(CqlValueSet valueSet, RuntimeContext context)
        {
            if (valueSet is null)
                throw new ArgumentNullException(nameof(valueSet));
            Id = valueSet.id ?? throw new ArgumentException("Value set is missing an ID", nameof(valueSet));
            Context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public string Id { get; }
        public RuntimeContext Context { get; }

        public bool? IsCodeInValueSet(CqlCode? code)
        {
            if (code == null || code.code == null)
                return null;
            var @in = Context.ValueSets.IsCodeInValueSet(Id, code.code, code.system);
            return @in;
        }

        public bool? IsCodeInValueSet(string code, string system) =>
            Context.ValueSets.IsCodeInValueSet(Id, code, system);


        public IEnumerator<CqlCode> GetEnumerator()
        {
            if (Context.ValueSets.TryGetCodesInValueSet(Id, out var cqlCodes))
            {
                return cqlCodes!.GetEnumerator();
            }
            else return Enumerable.Empty<CqlCode>().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
