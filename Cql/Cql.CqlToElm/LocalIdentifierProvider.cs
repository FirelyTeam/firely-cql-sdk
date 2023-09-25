namespace Hl7.Cql.CqlToElm
{
    internal class LocalIdentifierProvider
    {
        public string Next() => Extensions.NextId();
    }
}
