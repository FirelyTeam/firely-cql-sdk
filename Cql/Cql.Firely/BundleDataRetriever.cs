using Hl7.Cql.Comparers;
using Hl7.Cql.Operators;
using Hl7.Cql.Primitives;
using Hl7.Cql.ValueSets;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.Firely
{
    public class BundleDataRetriever : IDataRetriever
    {
        public BundleDataRetriever(Bundle bundle, 
            IValueSetDictionary valueSets,
            FirelyTypeResolver typeResolver,
            ICqlComparer? codeComparer = null, ICqlComparer? systemComparer = null)
        {
            Bundle = bundle ?? throw new ArgumentNullException(nameof(bundle));
            ValueSets = valueSets ?? throw new ArgumentNullException(nameof(valueSets));
            TypeResolver = typeResolver ?? throw new ArgumentNullException(nameof(typeResolver));
            CodeComparer = codeComparer ?? DefaultComparer.Value;
            SystemComparer = systemComparer ?? DefaultComparer.Value;
        }
        private static readonly Lazy<ICqlComparer> DefaultComparer = new Lazy<ICqlComparer>(() =>
            new StringCqlComparer(StringComparer.OrdinalIgnoreCase));

        public Bundle Bundle { get; init; }
        public IValueSetDictionary ValueSets { get; }
        public FirelyTypeResolver TypeResolver { get; }
        public ICqlComparer CodeComparer { get; protected set; }
        public ICqlComparer SystemComparer { get; protected set; }

        public IEnumerable<T> RetrieveByCodes<T>(IEnumerable<CqlCode?>? codes = null, PropertyInfo? codeProperty = null) where T : class
        {
            if (codes != null)
            {
                if (codeProperty == null)
                {
                    if (TypeResolver.TypeSpecifiers.TryGetValue(typeof(T), out var typeSpecifier))
                    {
                        codeProperty = TypeResolver.GetPrimaryCodePath(typeSpecifier);
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
                                if (valueSet.IsCodeInValueSet(resourceCoding.Code, resourceCoding.System) ?? false)
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
                                        && CodeComparer.Equivalent(resourceCoding.Code, allowedCode.code!, null)
                                        && SystemComparer.Equivalent(resourceCoding.System, allowedCode.system!, null))
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

        public IEnumerable<T> RetrieveByValueSet<T>(CqlValueSet? valueSet = null, PropertyInfo? codeProperty = null) where T : class
        {
            if (valueSet != null && valueSet.id != null)
            {
                if (codeProperty == null)
                {
                    if (TypeResolver.TypeSpecifiers.TryGetValue(typeof(T), out var typeSpecifier))
                    {
                        codeProperty = TypeResolver.GetPrimaryCodePath(typeSpecifier);
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
                            if (ValueSets.IsCodeInValueSet(valueSet.id, resourceCoding.Code, resourceCoding.System))
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

        // TODO: this needs to be highly optimized at the SDK level.
        // Bundle.entry should be a specialized collection that maintains a dictionary of entry by type
        protected IEnumerable<T> Retrieve<T>() where T : class =>
            Bundle?.Entry?
                .Select(entry => entry.Resource)
                .Where(resource => resource != null)
                .OfType<T>()
                ?? Enumerable.Empty<T>();


        protected Func<T, IEnumerable<Coding>> FunctionForCodeProperty<T>(PropertyInfo property) where T : class
        {
            Func<T, IEnumerable<Coding>?>? getCoding = null;
            var type = property.PropertyType;
            if (type == typeof(Element) || type == typeof(DataType))
            {
                getCoding = (resource) =>
                {
                    var t = property.GetValue(resource);
                    if (t == null)
                        return Enumerable.Empty<Coding>();
                    else switch (t)
                        {
                            case IEnumerable<Coding> codings:
                                return (property.GetValue(t) as IEnumerable<Coding>) ?? Enumerable.Empty<Coding>();
                            case Coding coding:
                                return new[] { coding };
                            case Code codeElement:
                                return new[] { new Coding(null, codeElement.Value) };
                            case CodeableConcept codeableConcept:
                                return codeableConcept.Coding ?? Enumerable.Empty<Coding>();
                            case IEnumerable<CodeableConcept> codeableConcepts:
                                return codeableConcepts.SelectMany(c => c.Coding ?? Enumerable.Empty<Coding>())
                                   ?? Enumerable.Empty<Coding>();
                            default:
                                throw new NotImplementedException($"Property {property.Name} has type {nameof(Element)}, and does not have a choice specifier of a compatible code type.");
                        }
                };
            }
            else if (typeof(IEnumerable<Coding>).IsAssignableFrom(type))
            {
                getCoding = (t) => (property.GetValue(t) as IEnumerable<Coding>) ?? Enumerable.Empty<Coding>();
            }
            else if (type == typeof(Coding))
            {
                getCoding = (t) =>
                {
                    var coding = property.GetValue(t) as Coding;
                    return coding != null
                        ? new[] { coding }
                        : Array.Empty<Coding>();
                };
            }
            else if (type == typeof(Code))
            {
                getCoding = (t) =>
                {
                    var code = property.GetValue(t) as Code;
                    return code != null
                        ? new[] { new Coding(null, code.Value) }
                        : Array.Empty<Coding>();
                };
            }
            else if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Code<>))
            {
                getCoding = (t) =>
                {
                    var code = property.GetValue(t) as PrimitiveType;
                    return code != null
                        ? new[] { new Coding(null, code.ObjectValue?.ToString() ?? string.Empty) }
                        : Array.Empty<Coding>();
                };
            }
            else if (type == typeof(CodeableConcept))
            {
                getCoding = (t) => (property.GetValue(t) as CodeableConcept)?.Coding
                    ?? Enumerable.Empty<Coding>();
            }
            else if (typeof(IEnumerable<CodeableConcept>).IsAssignableFrom(type))
            {
                getCoding = (t) => (property.GetValue(t) as IEnumerable<CodeableConcept>)?
                    .SelectMany(c => c.Coding ?? Enumerable.Empty<Coding>())
                    ?? Enumerable.Empty<Coding>();
            }
            else throw new NotImplementedException($"Property {property.Name} has type {type}, which is not a valid code type.");
            return getCoding!;
        }

    }
}
