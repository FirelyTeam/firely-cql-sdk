using Hl7.Fhir.Model;
using Ncqa.Cql.Runtime;
using Ncqa.Cql.Runtime.Firely;
using Ncqa.Cql.Runtime.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ncqa.Cql.Runtime.Firely
{
    public class BundleRetriever : FirelyDataRetriever
    {
        public BundleRetriever(FirelyRuntimeContext context, Bundle bundle) : base(context)
        {
            Bundle = bundle;
        }

        public Bundle Bundle { get; }

        public override IEnumerable<T> RetrieveByCodes<T>(IEnumerable<CqlCode?>? codes = null, PropertyInfo? codeProperty = null) where T : class
        {
            var resources = Retrieve<T>();
            if (codes != null)
            {
                if (codeProperty == null)
                {
                    if (FirelyTypeResolver.ResourceTypeSpecifiers.TryGetValue(typeof(T), out var typeSpecifier))
                    {
                        codeProperty = FirelyTypeResolver.GetPrimaryCodePath(typeSpecifier);
                        if (codeProperty == null)
                            throw new InvalidOperationException($"When retrieving with a code filter, a primary code path must exist for {typeSpecifier}.  None is defined.");

                    }
                    else
                        throw new InvalidOperationException($"When retrieving with a code filter, a primary code path must exist for {typeof(T).Name}.  None is defined.");
                }
                var getCoding = FunctionForCodeProperty<T>(codeProperty!);
                foreach (var resource in resources)
                {
                    var resourceCodings = getCoding(resource);
                    if (resourceCodings != null)
                    {
                        foreach (var resourceCoding in resourceCodings)
                        {
                            foreach (var allowedCode in codes)
                            {
                                if (resourceCoding != null
                                    && Context.Comparers.Equivalent(resourceCoding.Code, allowedCode.code!, null)
                                    && Context.Comparers.Equivalent(resourceCoding.System, allowedCode.system!, null))
                                {
                                    yield return resource;
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                foreach (var resource in resources)
                {
                    yield return resource;
                }
            }
        }

        public override IEnumerable<T> RetrieveByValueSet<T>(CqlValueSet? valueSet = null, PropertyInfo? codeProperty = null) where T : class
        {
            var resources = Retrieve<T>();
            if (valueSet != null)
            {
                if (codeProperty == null)
                {
                    if (FirelyTypeResolver.ResourceTypeSpecifiers.TryGetValue(typeof(T), out var typeSpecifier))
                    {
                        codeProperty = FirelyTypeResolver.GetPrimaryCodePath(typeSpecifier);
                        if (codeProperty == null)
                            throw new InvalidOperationException($"When retrieving with a code filter, a primary code path must exist for {typeSpecifier}.  None is defined.");

                    }
                    else
                        throw new InvalidOperationException($"When retrieving with a code filter, a primary code path must exist for {typeof(T).Name}.  None is defined.");
                }
                var getCoding = FunctionForCodeProperty<T>(codeProperty!);
                foreach (var resource in resources)
                {
                    var codings = getCoding(resource);
                    if (codings != null)
                    {
                        foreach (var coding in codings)
                        {
                            if (coding != null
                                && coding.Code != null
                                && Context.ValueSets.IsCodeInValueSet(valueSet.id!, coding.Code, coding.System))
                                yield return resource;
                        }
                    }
                }
            }
            else
            {
                foreach (var resource in resources)
                {
                    yield return resource;
                }
            }
        }

        private IEnumerable<T> Retrieve<T>() =>
             Bundle.Entry
                .Where(e => e.Resource != null)
                .Select(e => e.Resource)
                .OfType<T>();
    }

}

