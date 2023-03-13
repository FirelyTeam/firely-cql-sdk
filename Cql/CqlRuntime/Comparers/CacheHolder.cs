using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Cql.Runtime.Comparers
{
    public static class CacheHolder
    {
        public static ConcurrentDictionary<string, int?> CompareCache { get; set; } = new ConcurrentDictionary<string, int?>();
        public static ConcurrentDictionary<string, IEnumerable<object>> CodeInValueCache { get; set; } = new ConcurrentDictionary<string, IEnumerable<object>>();
    }
}
