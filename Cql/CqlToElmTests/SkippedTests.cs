using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm.Test
{
    internal static class SkippedTests
    {
        internal static Dictionary<string, string> Map = new()
        {
            { "EquivEqCM1M01", "Mixed unit equivalence is not supported." },
            { "Power2ToNeg2", "Power returns integers, not decimals." },
            { "RoundNeg0D5", "This rounding test doesn't behave like the others." },
            { "RoundNeg1D5", "This rounding test doesn't behave like the others." },
        };
    }
}
