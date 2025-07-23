/*
 * Copyright (c) 2025, Firely and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

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
            $"{name}({string.Join(", ", operand?.Select(o => o.operandTypeSpecifier) ?? Enumerable.Empty<TypeSpecifier>())})";
    }

    [DebuggerDisplay($"{{{nameof(name)}}} {{{nameof(operandTypeSpecifier)}}}")]
    partial class OperandDef;
}
