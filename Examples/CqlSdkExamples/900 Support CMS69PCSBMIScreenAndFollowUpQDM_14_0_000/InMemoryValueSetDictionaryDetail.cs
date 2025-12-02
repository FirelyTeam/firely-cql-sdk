using Hl7.Cql.Operators;
using Hl7.Cql.Primitives;
using Hl7.Cql.ValueSets;

namespace CqlSdkExamples
{
    #region In Memory
    public interface IValueSetDictionaryDetail : Hl7.Cql.ValueSets.IValueSetDictionary
    {
        bool TryGetValue(CqlValueSet valueSet, out IEnumerable<CqlCode?>? codes);
    }


    public sealed class InMemoryValueSetDictionary : IValueSetDictionaryDetail
    {
        // Key: (id, version)
        private readonly Dictionary<(string Id, string? Version), IReadOnlyList<CqlCode>> _store
         = new();

        public void Add(string id, string? version, IEnumerable<CqlCode> codes)
        {
            _store[(id, version)] = codes.ToList();
        }
        public IEnumerable<T> Retrieve<T>(RetrieveParameters parameters)
        {
            return _store.OfType<T>(); // simplistic, but enough for testing
        }
        public bool TryGetValue(CqlValueSet valueSet, out IEnumerable<CqlCode?>? codes)
        {
            if (_store.TryGetValue((valueSet.id, valueSet.version), out var list))
            {
                codes = list;
                return true;
            }

            codes = null;
            return false;
        }

        bool IValueSetDictionary.IsCodeInValueSet(string valueSetUri, CqlCode code)
        {
            throw new NotImplementedException();
        }

        bool IValueSetDictionary.IsCodeInValueSet(string valueSetUri, string code)
        {
            throw new NotImplementedException();
        }

        bool IValueSetDictionary.IsCodeInValueSet(string valueSetUri, string code, string system)
        {
            throw new NotImplementedException();
        }

        bool IValueSetDictionary.TryGetCodesInValueSet(string valueSetUri, out IEnumerable<CqlCode> codes)
        {
            throw new NotImplementedException();
        }

        bool IValueSetDictionaryDetail.TryGetValue(CqlValueSet valueSet, out IEnumerable<CqlCode> codes)
        {
            throw new NotImplementedException();
        }
    }

    #endregion
}
