using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.Elm
{
    [DebuggerDisplay("{message}")]
    partial class CqlToElmError
    {
    }

    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    partial class Interval
    {
        private string GetDebuggerDisplay()
        {
            var lcChar = lowClosed ? '[' : '(';
            var hcChar = highClosed ? ']' : ')';
            return $"Interval{lcChar}{low}, {high}{hcChar}";
        }
    }

    [DebuggerDisplay("{value}")]
    partial class Literal
    {
    }

    partial class DateTime
    {
        /// <inheritdoc/>
        public override string ToString()
        {
            var sb = new StringBuilder(year is Literal y ? format(y.value, 4) : year.ToString());
            if (month is not null)
                sb.Append("-").Append(month is Literal mo ? format(mo.value, 2) : month.ToString());
            if (day is not null)
                sb.Append("-").Append(day is Literal d ? format(d.value, 2) : day.ToString());
            if (hour is not null)
                sb.Append("T").Append(hour is Literal h ? format(h.value, 2) : hour.ToString());
            if (minute is not null)
                sb.Append(":").Append(minute is Literal min ? format(min.value, 2) : minute.ToString());
            if (second is not null)
                sb.Append(":").Append(second is Literal s ? format(s.value, 2) : second.ToString());
            if (millisecond is not null)
                sb.Append(".").Append(millisecond is Literal ms ? format(ms.value, 3) : millisecond.ToString());
            return sb.ToString();

            string format(string value, int digits) =>
                int.Parse(value, CultureInfo.InvariantCulture).ToString($"D{digits}", CultureInfo.InvariantCulture);
        }

        
    }


    [DebuggerDisplay("null, type={resultTypeSpecifier}")]
    partial class Null
    {
    }


    [DebuggerDisplay("{GetDebuggerDisplay(),nq}")]
    partial class FunctionDef
    {
        private string GetDebuggerDisplay() =>
            $"{name}({string.Join(", ", operand?.Select(o => o.resultTypeSpecifier) ?? Enumerable.Empty<TypeSpecifier>())})";

    }
}
