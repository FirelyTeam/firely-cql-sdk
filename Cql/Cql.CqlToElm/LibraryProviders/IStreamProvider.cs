namespace Hl7.Cql.CqlToElm.LibraryProviders
{
    internal interface IStreamProvider
    {
        bool TryGet(string id, string? version, out Stream? stream);
    }
}
