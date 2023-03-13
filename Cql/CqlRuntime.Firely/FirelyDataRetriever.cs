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
    public abstract class FirelyDataRetriever : IDataRetriever
    {
        protected FirelyDataRetriever(FirelyRuntimeContext context)
        {
            Context = context;
            FirelyTypeResolver = context.Operators.TypeResolver as FirelyTypeResolver ??
                throw new ArgumentException($"The context provided has an Operators property whose TypeResolver is not {nameof(FirelyTypeResolver)} and must be.");
        }

        public FirelyRuntimeContext Context { get; }
        public FirelyTypeResolver FirelyTypeResolver { get; }

        public abstract IEnumerable<T> RetrieveByCodes<T>(IEnumerable<CqlCode?>? codes = null, PropertyInfo? codeProperty = null) where T : class;

        public abstract IEnumerable<T> RetrieveByValueSet<T>(CqlValueSet? valueSet = null, PropertyInfo? codeProperty = null) where T : class;

        protected Func<T, IEnumerable<Coding>> FunctionForCodeProperty<T>(PropertyInfo property) where T : class
        {

            Func<T, IEnumerable<Coding>?>? getCoding = null;
            var type = property.PropertyType;
            if (type == typeof(Element))
            {
                getCoding = (t) =>
                {
                    if (t == null)
                        return Enumerable.Empty<Coding>();
                    else switch (t)
                        {
                            case IEnumerable<Coding> codings:
                                return (property.GetValue(t) as IEnumerable<Coding>) ?? Enumerable.Empty<Coding>();
                            case Coding coding:
                                return coding != null
                                    ? new[] { coding }
                                    : Array.Empty<Coding>();
                            case Code codeElement:
                                return codeElement != null
                                    ? new[] { new Coding { Code = codeElement.Value } }
                                    : Array.Empty<Coding>();
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
                        ? new[] { new Coding { Code = code.Value } }
                        : Array.Empty<Coding>();
                };
            }
            else if (type == typeof(CodeableConcept) || type == typeof(DataType))
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
