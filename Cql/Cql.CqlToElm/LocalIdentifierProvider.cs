using Hl7.Cql.Elm;

namespace Hl7.Cql.CqlToElm
{
    internal class LocalIdentifierProvider
    {
        public string Next() => Initializers.NextId();
    }
}
