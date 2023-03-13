using Ncqa.Cql.Runtime.Primitives;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Cql.Runtime
{
    public class CqlValueSetDictionary : IValueSetDictionary
    {
        private const string NullCodeSystem = "\0";
        private readonly CqlCodeHasher CodeHasher = new CqlCodeHasher();
        public void Add(string valueSetUri, CqlCode code)
        {
            if (string.IsNullOrEmpty(valueSetUri))
            {
                throw new ArgumentException($"'{nameof(valueSetUri)}' cannot be null or empty.", nameof(valueSetUri));
            }

            if (code is null)
            {
                throw new ArgumentNullException(nameof(code));
            }

            CodesByHash.Add(GetKey(valueSetUri, code.code, code.system), code);
            CodesByHash.Add(GetKey(valueSetUri, code.code, NullCodeSystem), code);
            if (!CodesInValueSet.TryGetValue(valueSetUri, out var codes))
            {
                codes = new HashSet<CqlCode>(CodeHasher);
                codes.Add(code);
                CodesInValueSet.Add(valueSetUri, codes);
            }
            else
                codes.Add(code);
        }
        public void Set(string valueSetUri, CqlCode code)
        {
            CodesByHash[GetKey(valueSetUri, code.code, code.system)] = code;
            CodesByHash[GetKey(valueSetUri, code.code, NullCodeSystem)] = code;
            if (!CodesInValueSet.TryGetValue(valueSetUri, out var codes))
            {
                codes = new HashSet<CqlCode>(CodeHasher);
                codes.Add(code);
                CodesInValueSet.Add(valueSetUri, codes);
            }
            else
                codes.Add(code);
        }

        public bool IsCodeInValueSet(string valueSetUri, string code) =>
            CodesByHash.ContainsKey(GetKey(valueSetUri, code, NullCodeSystem));
        public bool IsCodeInValueSet(string valueSetUri, string code, string? systemUri) =>
            CodesByHash.ContainsKey(GetKey(valueSetUri, code, systemUri));

        public bool TryGetCodesInValueSet(string valueSetUri, out IReadOnlyCollection<CqlCode> codings)
        {
            if (CodesInValueSet.TryGetValue(valueSetUri, out var codes))
            {
                codings = codes;
                return true;
            }
            codings = null!;
            return false;
        }

        public int Count => CodesByHash.Count / 2;

        private string GetKey(string valueSetUri, string? code, string? systemUri) =>
            $"{valueSetUri?.ToLowerInvariant()}\0{systemUri?.ToLowerInvariant() ?? ""}\0{code?.ToLowerInvariant() ?? ""}";

        private Dictionary<string, CqlCode> CodesByHash = new Dictionary<string, CqlCode>();
        private Dictionary<string, HashSet<CqlCode>> CodesInValueSet =
            new Dictionary<string, HashSet<CqlCode>>(StringComparer.OrdinalIgnoreCase);

        private class CqlCodeHasher : IEqualityComparer<CqlCode>
        {
            public bool Equals(CqlCode x, CqlCode y) => true;

            // we're using low ASCII values that are invalid in real codes
            public int GetHashCode(CqlCode obj) =>
                ($"{obj.code ?? "\x1"}\x1").GetHashCode()
                ^ ($"{obj.system ?? "\x2"}\x2").GetHashCode();

        }

    }
}
