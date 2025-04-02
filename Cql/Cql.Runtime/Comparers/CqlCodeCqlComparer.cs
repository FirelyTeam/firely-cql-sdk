/*
 * Copyright (c) 2023, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Primitives;

namespace Hl7.Cql.Comparers;

/// <summary>
/// An CQL comparer that compares two <see cref="CqlCode"/> instances.
/// </summary>
internal class CqlCodeCqlComparer(StringComparer codeComparer) :
    CqlComparer<CqlCode>(CqlComparerEqualsMethod.Compare)
{
    /// <summary>
    /// The default comparer, which uses <see cref="StringComparer.OrdinalIgnoreCase"/>.
    /// </summary>
    public static readonly CqlCodeCqlComparer OrdinalIgnoreCase = new(StringComparer.OrdinalIgnoreCase);

    protected override int? CompareValues(
        CqlCode x,
        CqlCode y,
        string? precision)
    {
        var result = codeComparer.Compare(x.code, y.code);
        if (result != 0)
            return result;

        if ((x.system == null) ^ (y.system == null))
            return null;

        result = StringComparer.OrdinalIgnoreCase.Compare(x.system, y.system);
        if (result != 0)
            return result;

        if ((x.version == null) ^ (y.version == null))
            return null;

        result = StringComparer.OrdinalIgnoreCase.Compare(x.version, y.version);
        if (result != 0)
            return result;

        if ((x.display == null) ^ (y.display == null))
            return null;

        result = StringComparer.OrdinalIgnoreCase.Compare(x.display, y.display);
        return result;
    }

    protected override bool IsNull([NotNullWhen(false)] CqlCode? value)
    {
        return value?.code is null;
    }

    protected override bool EquivalentValues(
        CqlCode x,
        CqlCode y,
        string? precision)
    {
        var result = codeComparer.Compare(x.code, y.code);
        if (result != 0)
            return false;

        if ((x.system == null) ^ (y.system == null))
            return false;

        result = StringComparer.OrdinalIgnoreCase.Compare(x.system, y.system);
        return result == 0;
    }

    public override int GetHashCode(CqlCode? value) =>
        value == null
            ? GetHashCodeForNull()
            : StringComparer.OrdinalIgnoreCase.GetHashCode(value.code ?? string.Empty) ^
              StringComparer.OrdinalIgnoreCase.GetHashCode(value.system ?? string.Empty);
}