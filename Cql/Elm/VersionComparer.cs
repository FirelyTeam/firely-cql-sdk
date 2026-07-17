/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Runtime;

namespace Hl7.Cql.Elm
{
    /// <summary>
    /// Orders version strings numerically (so "1.10" sorts after "1.9") for "most appropriate
    /// version" selection when no version is specified - an implementation choice the CQL spec
    /// explicitly leaves open (spec/condensed/03-developersguide.md &#167;Libraries).
    /// </summary>
    /// <remarks>
    /// Distinct version strings are never considered equal here, even when numerically
    /// equivalent (e.g. "1.0" vs "1.0.0"): per spec, referencing a version specifier that
    /// wasn't registered exactly is an error, not a fuzzy match, so this must not collapse
    /// them into the same key when used as a dictionary/SortedList comparer.
    /// </remarks>
    internal class VersionComparer : IComparer<string>
    {
        public static VersionComparer Instance = new VersionComparer();
        private VersionComparer() { }

        public int Compare(string? x, string? y)
        {
            var exact = CqlLibrarySemantics.CompareVersions(x, y);
            if (exact == 0)
                return 0;

            // A null/empty version has no numeric segments to compare - CompareVersions
            // already ordered it (sorts before any real version), so trust that directly.
            if (string.IsNullOrEmpty(x) || string.IsNullOrEmpty(y))
                return exact;

            var versionX = x.Split('.').Select(int.Parse).ToArray();
            var versionY = y!.Split('.').Select(int.Parse).ToArray();
            for (int i = 0; i < Math.Max(versionX.Length, versionY.Length); i++)
            {
                int partX = i < versionX.Length ? versionX[i] : 0;
                int partY = i < versionY.Length ? versionY[i] : 0;

                if (partX < partY)
                {
                    return -1;
                }

                if (partX > partY)
                {
                    return 1;
                }
            }

            // Numerically equivalent but textually different (e.g. "1.0" vs "1.0.0") - fall
            // back to the exact ordinal order, guaranteed non-zero since exact != 0 above, so
            // these never collide as the same key.
            return exact;
        }
    }
}
