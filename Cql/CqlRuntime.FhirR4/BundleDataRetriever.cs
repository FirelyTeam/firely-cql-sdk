using Ncqa.Cql.Runtime.Primitives;
using Ncqa.Fhir.R4.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

namespace Ncqa.Cql.Runtime.FhirR4
{
    public class BundleDataRetriever : FhirDataRetriever
    {
        public BundleDataRetriever(FhirRuntimeContext context, Bundle bundle) : base(context)
        {
            Bundle = bundle;
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
                                        && Context.Comparers.Equivalent(resourceCoding.code?.value!, allowedCode.code!, null)
                                        && Context.Comparers.Equivalent(resourceCoding.system?.value!, allowedCode.system!, null))
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
            if (valueSet != null)
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
                            if (Context.ValueSets.IsCodeInValueSet(valueSet.id, resourceCoding.code, resourceCoding.system)) 
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
