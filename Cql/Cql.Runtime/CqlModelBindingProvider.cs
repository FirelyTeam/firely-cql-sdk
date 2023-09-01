using Hl7.Cql.Runtime;
using Hl7.Cql.ValueSets;
using System;

namespace Hl7.Cql.Operators
{
    /// <summary>
    /// Provides the necessary binding information to enable the CQL engine to use
    /// a specific set of classes for the datamodel used by the engine.
    /// </summary>
    internal interface ICqlModelBindingProvider
    {
        CqlOperators NewOperators(
            IDataRetriever? retriever,
            IValueSetDictionary? valuesets,
            DateTimeOffset? now);
    }
}