using Hl7.Cql.CqlToElm2;

namespace CqlToElm2Tests;

internal class MockLibraryProvider : ICqlProvider
{
    private Dictionary<(string, Version?), string> Cql = new();

    public void Add(string id, Version version, string cql) => Cql.Add((id, version), cql);

    public TextReader? GetCql(string libraryName, Version? version)
    {
        if (Cql.TryGetValue((libraryName, version), out var cql))
        {
            return new StringReader(cql);
        }
        else return null;
    }
}

