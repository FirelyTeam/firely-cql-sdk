using Ncqa.Cql.Runtime.Primitives;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ncqa.Cql.Runtime
{
    public class ValueSetUnion: IValueSetFacade
    {
        public ValueSetUnion(ValueSetFacade[] facades, RuntimeContext context)
        {
            Facades = facades.ToArray();
            Context = context ?? throw new ArgumentNullException(nameof(context));
            Hasher = new CqlCodeEqualityHasher(Context);
            DistinctCodes = new Lazy<HashSet<CqlCode>>(() =>
            {
                var codes = new HashSet<CqlCode>(Hasher);
                foreach (var facade in Facades)
                {
                    if (Context.ValueSets.TryGetCodesInValueSet(facade.Id, out var cqlCodes))
                    {
                        foreach (var cqlCode in cqlCodes!)
                        {
                            if (!codes.Contains(cqlCode))
                                codes.Add(cqlCode);
                        }
                    }
                }
                return codes;
            }, true);
        }

        public ValueSetFacade[] Facades { get; }
        public RuntimeContext Context { get; }
        public IEqualityComparer<CqlCode> Hasher { get; }

        private Lazy<HashSet<CqlCode>> DistinctCodes;

        public IEnumerator<CqlCode> GetEnumerator() => DistinctCodes.Value.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public bool? IsCodeInValueSet(CqlCode? code)
        {
            if (code == null)
                return null;
            foreach (var facade in Facades)
                if (facade.IsCodeInValueSet(code) == true)
                    return true;
            return false;
        }
    }
}
