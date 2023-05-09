using Ncqa.Cql.Comparers;
using Ncqa.Cql.Runtime.Conversion;
using Ncqa.Fhir.R4.Model;
using Ncqa.Iso8601;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Ncqa.Cql.Runtime.FhirR4.Comparers
{
    public static class FhirCqlComparersExtensions
    {

        public static CqlComparers AddFhirComparers(this CqlComparers comparers)
        {
            var resourceComparer = new ResourceCqlComparer(comparers);
            RegisterResourceComparers(comparers, typeof(Resource), resourceComparer);
            var stringElementComparer = new StringElementCqlComparer(comparers);
            comparers
                .Register(typeof(DecimalElement), new DecimalElementCqlComparer())
                .Register(typeof(PositiveIntElement), new PositiveIntElementCqlComparer())
                .Register(typeof(Coding), new CodingCqlComparer(StringComparer.OrdinalIgnoreCase))
                .Register(typeof(CodeableConcept), new CodeableConceptCqlComparer(comparers))
                .Register(typeof(Identifier), new IdentifierCqlComparer(comparers))
                .Register(typeof(CodeElement), stringElementComparer)
                .Register(typeof(StringElement), stringElementComparer)
                .Register(typeof(UriElement), stringElementComparer)
                .Register(typeof(IdElement), stringElementComparer)
                .Register(typeof(MarkdownElement), stringElementComparer);
            return comparers;
        }

        private static void RegisterResourceComparers(CqlComparers comparers, Type baseType, ICqlComparer resourceComparer, Assembly? assembly = null)
        {
            if (comparers is null)
            {
                throw new ArgumentNullException(nameof(comparers));
            }
            if (baseType is null)
            {
                throw new ArgumentNullException(nameof(baseType));
            }
            if (resourceComparer is null)
            {
                throw new ArgumentNullException(nameof(resourceComparer));
            }
            comparers.Register(baseType, resourceComparer);
            assembly ??= baseType.Assembly;
            var derived = assembly
                .GetTypes()
                .Where(t => baseType.IsAssignableFrom(t));
            foreach (var type in derived)
            {
                comparers.Register(type, resourceComparer);
            }

        }
    }


}
