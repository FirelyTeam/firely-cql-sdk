﻿#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Primitives;
using System;
using System.Collections.Generic;

namespace Hl7.Cql.Comparers
{
    internal class CqlCodeCqlEquivalentComparer : ICqlComparer<CqlCode>, ICqlComparer
    {
        public CqlCodeCqlEquivalentComparer(IComparer<string> codeComparer)
        {
            CodeComparer = codeComparer ?? throw new ArgumentNullException(nameof(codeComparer));
        }

        public IComparer<string> CodeComparer { get; }

        public int? Compare(CqlCode? x, CqlCode? y, string? precision)
        {
            if (x == null || y == null)
                return null;
            if (x.code == null || y.code == null)
                return null;
            else
            {
                var cc = CodeComparer.Compare(x.code, y.code);
                if (cc == 0)
                {
                    if ((x.system == null) ^ (y.system == null))
                        return null;

                    var sc = StringComparer.OrdinalIgnoreCase.Compare(x.system, y.system);
                    return sc;
                }

                return cc;
            }
        }

        public int? Compare(object? x, object? y, string? precision) => Compare(x as CqlCode, y as CqlCode, precision);

        public bool? Equals(CqlCode? x, CqlCode? y, string? precision)
        {
            if (x == null || y == null)
                return null;
            var compare = Compare(x, y, precision);
            if (compare == null)
                return null;
            else return compare == 0;
        }

        public bool? Equals(object? x, object? y, string? precision) => Equals(x as CqlCode, y as CqlCode, precision);

        public bool Equivalent(CqlCode x, CqlCode y, string? precision)
        {
            if (CqlComparers.EquivalentOnNullsOnly(x?.code, y?.code) is { } r)
                return r;

            var cc = CodeComparer.Compare(x!.code, y!.code);
            if (cc != 0)
                return false;

            if ((x.system == null) ^ (y.system == null))
                return false;

            var sc = StringComparer.OrdinalIgnoreCase.Compare(x.system, y.system);
            return sc == 0;
        }

        public bool Equivalent(object? x, object? y, string? precision) => Equivalent((x as CqlCode)!, (y as CqlCode)!, precision);

        public int GetHashCode(CqlCode? x) =>
            x == null
            ? typeof(CqlCode).GetHashCode()
            : $"{x.code ?? "null"}\0{x.system}\0".GetHashCode();

        public int GetHashCode(object? x) => GetHashCode(x as CqlCode);
    }
}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member