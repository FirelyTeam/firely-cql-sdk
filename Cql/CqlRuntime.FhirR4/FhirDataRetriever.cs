using Ncqa.Cql.Model;
using Ncqa.Cql.Runtime.Primitives;
using Ncqa.Fhir.R4.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace Ncqa.Cql.Runtime.FhirR4
{
    public abstract class FhirDataRetriever : IDataRetriever
    {
        protected FhirDataRetriever(FhirRuntimeContext context)
        {
            Context = context;
            FhirTypeResolver = context.Operators.TypeResolver as FhirTypeResolver ??
                throw new ArgumentException($"The context provided has an Operators property whose TypeResolver is not {nameof(FhirTypeResolver)} and must be.");
        }

        public FhirRuntimeContext Context { get; }
        public FhirTypeResolver FhirTypeResolver { get; }

        public abstract IEnumerable<T> RetrieveByCodes<T>(IEnumerable<CqlCode?>? codes, PropertyInfo? codeProperty)
            where T : class;
        public abstract IEnumerable<T> RetrieveByValueSet<T>(CqlValueSet? valueSet, PropertyInfo? codeProperty)
            where T : class;

        protected abstract IEnumerable<T> Retrieve<T>()
            where T : class;

        protected Func<T, IEnumerable<Coding>> FunctionForCodeProperty<T>(PropertyInfo property) where T : class
        {
            Func<T, IEnumerable<Coding>?>? getCoding = null;
            var type = property.PropertyType;
            if (type == typeof(Element))
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
                            case CodeElement codeElement:
                                return new[] { new Coding { code = codeElement } };
                            case CodeableConcept codeableConcept:
                                return codeableConcept.coding ?? Enumerable.Empty<Coding>();
                            case IEnumerable<CodeableConcept> codeableConcepts:
                                return codeableConcepts.SelectMany(c => c.coding ?? Enumerable.Empty<Coding>())
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
            else if (type == typeof(CodeElement))
            {
                getCoding = (t) =>
                {
                    var code = property.GetValue(t) as CodeElement;
                    return code != null
                        ? new[] { new Coding { code = code } }
                        : Array.Empty<Coding>();
                };
            }
            else if (type == typeof(CodeableConcept))
            {
                getCoding = (t) => (property.GetValue(t) as CodeableConcept)?.coding
                    ?? Enumerable.Empty<Coding>();
            }
            else if (typeof(IEnumerable<CodeableConcept>).IsAssignableFrom(type))
            {
                getCoding = (t) => (property.GetValue(t) as IEnumerable<CodeableConcept>)?
                    .SelectMany(c => c.coding ?? Enumerable.Empty<Coding>())
                    ?? Enumerable.Empty<Coding>();
            }
            else throw new NotImplementedException($"Property {property.Name} has type {type}, which is not a valid code type.");
            return getCoding!;
        }
    
    }
}
