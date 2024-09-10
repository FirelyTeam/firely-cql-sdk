using Cql.WithBuildTasks;
using Hl7.Cql.Elm;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SystemTest;
internal class SystemLibrary : System_2_0_0
{
    public SystemLibrary(CqlContext context) : base(context)
    {
    }

    public override decimal? Add(decimal? left, decimal? right) => left + right;

    public override decimal? ChangeUnit(decimal? value, string fromUnit, string toUnit) =>
        (value, fromUnit, toUnit) switch
        {
            (null, _, _) => null,
            (_, null, _) => null,
            (_, _, null) => null,
            _ => throw new NotSupportedException($"No conversion between {fromUnit} and {toUnit} is defined.")
        };

    public override int? CompareUnit(string left, string right) =>
        (left, right) switch
        {
            (_, _) when left == right => 0,
            _ => throw new NotSupportedException("Unit granularity comparisons are not supported.")
        };

    public override decimal? Divide(decimal? left, decimal? right) => right == 0 ? null : left / right;

    public override string DivideUnit(string numerator, string denominator) =>
        (numerator, denominator) switch
        {
            (_, "1") => numerator,
            ("1", _) => denominator,
            (_, _) when numerator == denominator => "1",
            _ => throw new NotSupportedException($"No division between {numerator} and {denominator} is defined.")
        };

    public override string MultiplyUnit(string numerator, string denominator) =>
        (numerator, denominator) switch
        {
            (_, "1") => numerator,
            ("1", _) => denominator,
            (_, _) when numerator == denominator => "1",
            _ => throw new NotSupportedException($"No division between {numerator} and {denominator} is defined.")
        };


    public override bool? IsNegative(decimal? argument) => argument < 0;

    public override bool? IsZero(decimal? argument) => argument == 0;

    public override decimal? Multiply(decimal? left, decimal? right) => left * right;

    public override decimal? ToDecimal(int? argument) => argument;

    public override decimal? ToDecimal(long? argument) => argument;

    public override int? Truncate(decimal? argument) =>
        argument is null ? null : (int?)Math.Truncate(argument.Value);

    public override long? TruncateLong(decimal? argument) =>
       argument is null ? null : (int?) Math.Truncate(argument.Value);

    public override decimal? Exp(decimal? argument) =>
        argument is null ? null : (decimal?)Math.Exp((double)argument);

    public override IEnumerable<decimal?> Expand(CqlInterval<decimal?> argument, CqlQuantity per)
    {
        if (argument is null || argument.low is null || argument.high is null || per.value is null || per.unit != "1")
            return null!;
        var output = new List<decimal?>();
        for(decimal i = argument.low.Value; i <= argument.high.Value; i += per.value.Value)
            output.Add(i);
        return output;
    }

    public override int? Length(string argument) =>
        argument is null ? null : argument.Length;

    public override IEnumerable<string> SplitOnMatches(string stringToSplit, string separatorPattern) =>
        (stringToSplit, separatorPattern) switch
        {
            (null, _) => null,
            (_, null) => new[] { stringToSplit },
            _ => Regex.Split(stringToSplit, separatorPattern)
        };

    public override string ToString(decimal? argument) => argument?.ToString();

    public override bool? IsNull(object argument) => argument is null;
}

