using Hl7.Cql.Primitives;
using Hl7.Cql.ValueSets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Hl7.Cql.Poco.Fhir.R4.Model;

namespace Hl7.Cql.Runtime.FhirR4
{
    public class BundleDataRetriever : FhirDataRetriever
    {
        public BundleDataRetriever(Bundle bundle, FhirTypeResolver fhirTypeResolver, 
            IValueSetDictionary valueSets) : base(fhirTypeResolver, valueSets, null)
        {
            Bundle = bundle ?? throw new ArgumentNullException(nameof(bundle));
        }

        public Bundle Bundle { get; }
        public override IEnumerable<T> RetrieveByCodes<T>(IEnumerable<CqlCode?>? codes, PropertyInfo? codeProperty)
            where T : class
        {
            if (codes != null)
            {
                if (codeProperty == null)
                {
                    if (FhirTypeResolver.TypeSpecifiers.TryGetValue(typeof(T), out var typeSpecifier))
                    {
                        codeProperty = FhirTypeResolver.GetPrimaryCodePath(typeSpecifier);
                        if (codeProperty == null)
                            throw new InvalidOperationException($"When retrieving with a code filter, a primary code path must exist for {typeSpecifier}.  None is defined.");

                    }
                    else
                        throw new InvalidOperationException($"When retrieving with a code filter, a primary code path must exist for {typeof(T).Name}.  None is defined.");
                }
                var source = Retrieve<T>();
                var getCode = FunctionForCodeProperty<T>(codeProperty!);
                if (codes is ValueSetFacade valueSet)
                {
                    foreach (var t in source)
                    {
                        var resourceCodings = getCode(t);
                        if (resourceCodings != null)
                        {
                            foreach (var resourceCoding in resourceCodings)
                            {
                                if (valueSet.IsCodeInValueSet(resourceCoding.code, resourceCoding.system) ?? false)
                                {
                                    yield return t;
                                    break;
                                }
                            }
                        }
                    }
                }
                else
                {
                    foreach (var t in source)
                    {
                        var resourceCodings = getCode(t);
                        if (resourceCodings != null)
                        {
                            var found = false;
                            foreach (var resourceCoding in resourceCodings)
                            {
                                foreach (var allowedCode in codes)
                                {
                                    if (resourceCoding != null 
                                        && allowedCode != null
                                        && CodeComparer.Equivalent(resourceCoding.code?.value!, allowedCode.code!, null)
                                        && SystemComparer.Equivalent(resourceCoding.system?.value!, allowedCode.system!, null))
                                    {
                                        found = true;
                                        break;
                                    }
                                }
                                if (found)
                                    break;
                            }
                            if (found)
                                yield return t;
                        }
                    }
                }
            }
            else
            {
                foreach (var t in Retrieve<T>())
                    yield return t;
            }
        }


        public override IEnumerable<T> RetrieveByValueSet<T>(CqlValueSet? valueSet, PropertyInfo? codeProperty)
        {
            if (valueSet != null && valueSet.id != null)
            {
                if (codeProperty == null)
                {
                    if (FhirTypeResolver.TypeSpecifiers.TryGetValue(typeof(T), out var typeSpecifier))
                    {
                        codeProperty = FhirTypeResolver.GetPrimaryCodePath(typeSpecifier);
                        if (codeProperty == null)
                            throw new InvalidOperationException($"When retrieving with a code filter, a primary code path must exist for {typeSpecifier}.  None is defined.");

                    }
                    else
                        throw new InvalidOperationException($"When retrieving with a code filter, a primary code path must exist for {typeof(T).Name}.  None is defined.");
                }
                var source = Retrieve<T>();
                var getCode = FunctionForCodeProperty<T>(codeProperty!);
                foreach (var t in source)
                {
                    var resourceCodings = getCode(t);
                    if (resourceCodings != null)
                    {
                        foreach (var resourceCoding in resourceCodings)
                        {
                            if (ValueSets.IsCodeInValueSet(valueSet.id, resourceCoding.code, resourceCoding.system)) 
                            {
                                yield return t;
                                break;
                            }
                        }
                    }
                }
            }
            else
            {
                foreach (var t in Retrieve<T>())
                    yield return t;
            }
        }
        protected override IEnumerable<T> Retrieve<T>() where T : class =>
            Bundle?.entry?.GetResourcesByType<T>() ?? Enumerable.Empty<T>();

    }
}
