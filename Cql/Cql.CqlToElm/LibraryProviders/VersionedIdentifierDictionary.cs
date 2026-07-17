/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Elm;

namespace Hl7.Cql.CqlToElm.LibraryProviders
{
    internal class VersionedIdentifierDictionary<T>
    {
        internal VersionedIdentifierDictionary(StringComparer? idComparer = null)
        {
            // CQL is a case-sensitive language (spec/condensed/03-developersguide.md SS3.4.1),
            // so library identifiers must be matched case-sensitively - matching
            // CqlLibrarySemantics.CompareIds, used everywhere else for the same comparison.
            Versions = new(idComparer ?? StringComparer.Ordinal);
        }

        internal Dictionary<string, SortedList<string, List<T>>> Versions;

        public bool TryGetLatest(string id, out string? version, out T? t)
        {
            if (Versions.TryGetValue(id, out var versions))
            {
                // versions is sorted ascending by VersionComparer, so the latest is the last entry.
                var ts = versions.Last();
                if (ts.Value.Count == 1)
                {
                    version = ts.Key;
                    t = ts.Value[0];
                    return true;
                }
            }
            version = null;
            t = default;
            return false;
        }

        public bool TryGet(string id, string? version, [NotNullWhen(true)] out T? t)
        {
            if (Versions.TryGetValue(id, out var versions))
            {
                if (versions.TryGetValue(version ?? string.Empty, out var ts))
                {
                    if (ts.Count == 1)
                    {
                        t = ts[0]!;
                        return true;
                    }
                }
            }
            version = null;
            t = default;
            return false;
        }

        public bool HasUnambiguousLatestVersion(string id)
        {
            if (Versions.TryGetValue(id, out var versions))
            {
                // versions is sorted ascending by VersionComparer, so the latest is the last entry.
                var ts = versions.Last();
                if (ts.Value.Count == 1)
                    return true;
            }
            return false;
        }

        public void Add(string id, string? version, T t)
        {
            version ??= string.Empty;
            if (!Versions.TryGetValue(id, out var versions))
            {
                versions = new(VersionComparer.Instance);
                Versions.Add(id, versions);
            }
            if (!versions.TryGetValue(version, out var ts))
            {
                ts = new();
                versions.Add(version, ts);
            }
            ts.Add(t);
        }

    }
}
