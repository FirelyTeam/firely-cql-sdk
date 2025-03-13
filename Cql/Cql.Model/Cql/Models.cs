using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.Model.Cql;
internal static class Models
{
    public static StreamReader System200 => GetStream("System200");

    public static IReadOnlyDictionary<string, StreamReader> All => new Dictionary<string, StreamReader>
        {
            { "System200", System200  }
        };

    private static StreamReader GetStream(string resourceName)
    {
        var stream = typeof(Models).Assembly.GetManifestResourceStream(resourceName)
            ?? throw new ArgumentException($"Manifest resource stream {resourceName} is not included in this assembly.");
        return new StreamReader(stream);
    }
}
