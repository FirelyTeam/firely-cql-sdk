using System.Collections.Generic;

namespace Ncqa.Fhir
{
    public interface IEntryCollection<TEntry> : ICollection<TEntry>
    {
        IEnumerable<TResource> GetResourcesByType<TResource>() where TResource : class;
        TResource? GetResourceById<TResource>(string id) where TResource : class;
        TResource? GetResourceByUrl<TResource>(string url) where TResource : class;

    }
}
