using Ncqa.Cql.Runtime.Primitives;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Cql.Runtime
{
    public interface IValueSetDictionary
    {
        void Add(string valueSetUri, CqlCode code);
        void Set(string valueSetUri, CqlCode code);
        bool IsCodeInValueSet(string valueSetUri, string code);
        bool IsCodeInValueSet(string valueSetUri, string code, string? systemUriOrOid);
        bool TryGetCodesInValueSet(string valueSetUri, out IReadOnlyCollection<CqlCode> codings);
        int Count { get; }
    }

}
