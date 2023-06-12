using Hl7.Cql.ValueSets;

namespace Hl7.Cql.ValueSetLoaders
{
    public interface IValueSetLoader
    {
        IValueSetDictionary Load();
        void Load(IValueSetDictionary dictionary);
    }
}
