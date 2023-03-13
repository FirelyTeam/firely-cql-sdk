using Ncqa.Cql.Runtime.Comparers;
using Ncqa.Fhir.R4.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Cql.Runtime.FhirR4.Comparers
{
    public class CodingCqlComparer : CqlComparerBase<Coding>
    {
        public CodingCqlComparer(IComparer<string> codeComparer)
        {
            CodeComparer = codeComparer ?? throw new ArgumentNullException(nameof(codeComparer));
        }

        public IComparer<string> CodeComparer { get; }

        public override int? Compare(Coding x, Coding y, string? precision)
        {
            if (x == null || y == null)
                return null;
            if (x.code == null || y.code == null)
                return null;
            else
            {
                var cc = CodeComparer.Compare(x.code.value, y.code.value);
                if (cc == 0)
                {
                    if ((x.system == null) ^ (y.system == null))
                        return null;
                    var sc = StringComparer.OrdinalIgnoreCase.Compare(x.system?.value, y.system?.value);
                    if (sc == 0)
                    {
                        if ((x.version == null) ^ (y.version == null))
                            return null;
                        var vc = StringComparer.OrdinalIgnoreCase.Compare(x.version?.value, y.version?.value);
                        if (vc == 0)
                        {
                            if ((x.display == null) ^ (y.display == null))
                                return null;
                            var dc = StringComparer.OrdinalIgnoreCase.Compare(x.display?.value, y.display?.value);
                            return dc;
                        }
                        else return vc;
                    }
                    else return sc;
                }
                else return cc;
            }
        }

        public override bool? Equals(Coding x, Coding y, string? precision)
        {
            if (x == null || y == null)
                return null;
            var compare = Compare(x, y, precision);
            if (compare == null)
                return null;
            else return compare == 0;
        }

        public override bool Equivalent(Coding x, Coding y, string? precision)
        {
            if (x == null || y == null)
                return false;
            if (x.code == null || y.code == null)
                return false;
            else
            {
                var cc = CodeComparer.Compare(x.code.value, y.code.value);
                if (cc == 0)
                {
                    if (x.system == null || y.system == null)
                        return false;
                    var sc = StringComparer.OrdinalIgnoreCase.Compare(x.system?.value, y.system?.value);
                    return sc == 0;
                }
                else return cc == 0;
            }
        }

        public override int GetHashCode(Coding? x) =>
            x == null
            ? typeof(Coding).GetHashCode()
            : $"{x.code?.value ?? "null"}\0{x.system?.value ?? "null"}\0".GetHashCode();

        public override int GetHashCode(object x) => GetHashCode(x as Coding);
    }
}
