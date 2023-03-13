using Hl7.Fhir.Model;
using Ncqa.Cql.Runtime.Comparers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Cql.Runtime.Firely.Comparers
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
            if (x.Code == null || y.Code == null)
                return null;
            else
            {
                var cc = CodeComparer.Compare(x.Code, y.Code);
                if (cc == 0)
                {
                    if ((x.System == null) ^ (y.System == null))
                        return null;
                    var sc = StringComparer.OrdinalIgnoreCase.Compare(x.System, y.System);
                    if (sc == 0)
                    {
                        if ((x.Version == null) ^ (y.Version == null))
                            return null;
                        var vc = StringComparer.OrdinalIgnoreCase.Compare(x.Version, y.Version);
                        if (vc == 0)
                        {
                            if ((x.Display == null) ^ (y.Display == null))
                                return null;
                            var dc = StringComparer.OrdinalIgnoreCase.Compare(x.Display, y.Display);
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
            if (x.Code == null || y.Code == null)
                return false;
            else
            {
                var cc = CodeComparer.Compare(x.Code, y.Code);
                if (cc == 0)
                {
                    if (x.System == null || y.System == null)
                        return false;
                    var sc = StringComparer.OrdinalIgnoreCase.Compare(x.System, y.System);
                    return sc == 0;
                }
                else return cc == 0;
            }
        }

        public override int GetHashCode(Coding? x) =>
            x == null
            ? typeof(Coding).GetHashCode()
            : $"{x.Code ?? "null"}\0{x.System ?? "null"}\0".GetHashCode();

        public override int GetHashCode(object x) => GetHashCode(x as Coding);
    }
}
