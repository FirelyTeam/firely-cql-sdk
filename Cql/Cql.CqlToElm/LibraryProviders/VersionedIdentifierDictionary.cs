﻿using Hl7.Cql.Elm;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm.LibraryProviders
{
    internal class VersionedIdentifierDictionary<T> : IEnumerable<KeyValuePair<VersionedIdentifier, IEnumerable<T>>>
    {
        internal VersionedIdentifierDictionary(StringComparer? idComparer = null)
        {
            Versions = new(idComparer ?? StringComparer.OrdinalIgnoreCase);
        }

        internal Dictionary<string, SortedList<string, List<T>>> Versions;

        public bool TryGetLatest(string id, out string? version, out T? t)
        {
            if (Versions.TryGetValue(id, out var versions))
            {
                var ts = versions.First();
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
                var ts = versions.First();
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

        public IEnumerator<KeyValuePair<VersionedIdentifier, IEnumerable<T>>> GetEnumerator() => Enumerate().GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => Enumerate().GetEnumerator();

        private IEnumerable<KeyValuePair<VersionedIdentifier, IEnumerable<T>>> Enumerate()
        {
            foreach (var kvp1 in Versions)
            {
                foreach (var kvp2 in kvp1.Value)
                {
                    var vi = new VersionedIdentifier { id = kvp1.Key, version = kvp2.Key };
                    yield return KeyValuePair.Create(vi, kvp2.Value as IEnumerable<T>);
                }
            }
        }

    }
}
