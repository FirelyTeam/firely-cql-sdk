using Hl7.Cql.Operators;
using Hl7.Cql.ValueSets;
using System;

namespace Hl7.Cql.Runtime
{
    /// <summary>
    /// Provides the necessary binding information to enable the CQL engine to use
    /// a specific set of classes for the datamodel used by the engine.
    /// </summary>
    internal interface ICqlModelBindingProvider
    {
        ICqlOperators NewOperators(
            IDataRetriever? retriever,
            IValueSetDictionary? valuesets,
            DateTimeOffset? now);
    }
}