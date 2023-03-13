using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Cql.Runtime.Primitives
{
    [CqlPrimitiveType(CqlPrimitiveType.Code)]
    public class CqlCode
    {
        public CqlCode(string? code, string? system, string? version, string? display)
        {
            this.code = code;
            this.system = system;
            this.version = version;
            this.display = display;
        }

        public string? code { get; }
        public string? display { get; }
        public string? system { get; }
        public string? version { get; }

    }

    public class CqlCodeEquivalentHasher : IEqualityComparer<CqlCode>
    {
        public RuntimeContext Context { get; }

        public CqlCodeEquivalentHasher(RuntimeContext context)
        {
            Context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public bool Equals(CqlCode x, CqlCode y) => Context.Equivalent(x, y, null);

        public int GetHashCode(CqlCode obj) => 
            (obj.code ?? "code").GetHashCode() ^ (obj.system ?? "system").GetHashCode();
    }

    public class CqlCodeEqualityHasher : IEqualityComparer<CqlCode>
    {
        public RuntimeContext Context { get; }

        public CqlCodeEqualityHasher(RuntimeContext context)
        {
            Context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public bool Equals(CqlCode x, CqlCode y) => Context.Compare(x, y, null) == 0;

        public int GetHashCode(CqlCode obj) =>
            (obj.code ?? "code").GetHashCode()
            ^ (obj.system ?? "system").GetHashCode()
            ^ (obj.display ?? "display").GetHashCode()
            ^ (obj.version ?? "version").GetHashCode();

    }

}
