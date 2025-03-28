/*
 * Copyright (c) 2023, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Primitives;
using static System.StringComparer;

namespace Hl7.Cql.Comparers;

internal class CqlCodeCqlEquivalentComparer(IComparer<string> codeComparer) : CqlComparer<CqlCode>(
    CqlComparerEqualsMethod.Compare,
    CqlComparerNullComparisonStrategy.EitherNullReturnsNull)
{
    private IComparer<string> CodeComparer { get; } = codeComparer ?? throw new ArgumentNullException(nameof(codeComparer));

    protected internal override int? CompareValues(
        CqlCode left,
        CqlCode right,
        string? precision)
    {
        var result = CodeComparer.Compare(left.code, right.code);
        if (result != 0)
            return result;

        if ((left.system == null) ^ (right.system == null))
            return null;

        result = OrdinalIgnoreCase.Compare(left.system, right.system);
        return result;
    }

    protected override bool IsNull([NotNullWhen(false)] CqlCode? value)
    {
        return value?.code is null;
    }

    protected internal override bool EquivalentValues(
        CqlCode left,
        CqlCode right,
        string? precision)
    {
        var result = CodeComparer.Compare(left.code, right.code);
        if (result != 0)
            return false;

        if ((left.system == null) ^ (right.system == null))
            return false;

        var sc = OrdinalIgnoreCase.Compare(left.system, right.system);
        return sc == 0;
    }

    public override int GetHashCode(CqlCode? value) =>
        value == null
            ? GetHashCodeForNull()
            : OrdinalIgnoreCase.GetHashCode(value.code ?? string.Empty) ^
              OrdinalIgnoreCase.GetHashCode(value.system ?? string.Empty);
}
