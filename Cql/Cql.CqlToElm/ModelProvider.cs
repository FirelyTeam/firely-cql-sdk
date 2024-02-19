using Hl7.Cql.Elm;
using Hl7.Cql.Model;
using System;
using System.Linq;

namespace Hl7.Cql.CqlToElm
{
    /// <summary>
    /// Additional function built on top of the <see cref="IModelProvider"/> and <see cref="ModelInfo"/> classes.
    /// </summary>
    public static class ModelProvider
    {
        /// <summary>
        /// Returns the <see cref="ModelInfo"/> for a model, given the model's uri and version.
        /// </summary>
        /// <exception cref="ArgumentException">There is no model with the given uri.</exception>
        public static Model.ModelInfo GetModelFromUri(this IModelProvider provider, string uri, string? version = null) =>
            provider.TryGetModelFromUri(uri, out var model, version) ?
                model!
                : throw new InvalidOperationException($"Model {uri} {(version is not null ? $"version {version}" : "")} is not available.");

        /// <summary>
        /// Returns the <see cref="ModelInfo"/> for a model, given the model's name and version.
        /// </summary>
        /// <exception cref="ArgumentException">There is no model with the given uri.</exception>
        public static Model.ModelInfo GetModelFromName(this IModelProvider provider, string name, string? version = null) =>
            provider.TryGetModelFromName(name, out var model, version) ?
                model!
                : throw new InvalidOperationException($"Model {name} {(version is not null ? $"version {version}" : "")} is not available.");


        /// <summary>
        /// Creates a new <see cref="Elm.TypeSpecifier"/> based on a <see cref="Model.TypeSpecifier"/>.
        /// </summary>
        public static Elm.TypeSpecifier ToElm(this Model.TypeSpecifier ts, IModelProvider provider)
        {
            return ts switch
            {
                Model.ChoiceTypeSpecifier cts => cts.ToElm(provider),
                Model.ParameterTypeSpecifier pts => pts.ToElm(),
                Model.TupleTypeSpecifier tts => tts.ToElm(provider),
                Model.IntervalTypeSpecifier its => its.ToElm(provider),
                Model.NamedTypeSpecifier nts => nts.ToElm(provider),
                Model.ListTypeSpecifier lts => lts.ToElm(provider),
                _ => throw new ArgumentException($"Unknown type specifier type {ts.GetType()}.", nameof(ts))
            };
        }

        /// <summary>
        /// Creates a new <see cref="Elm.ChoiceTypeSpecifier"/> based on a <see cref="Model.ChoiceTypeSpecifier"/>.
        /// </summary>
        public static Elm.ChoiceTypeSpecifier ToElm(this Model.ChoiceTypeSpecifier cts, IModelProvider provider)
        {
            return new()
            {
                choice = cts.choice.Select(c => c.ToElm(provider)).ToArray(),
            };
        }

        /// <summary>
        /// Creates a new <see cref="Elm.ParameterTypeSpecifier"/> based on a <see cref="Model.ParameterTypeSpecifier"/>.
        /// </summary>
        public static Elm.ParameterTypeSpecifier ToElm(this Model.ParameterTypeSpecifier pts)
        {
            return new()
            {
                parameterName = pts.parameterName,
            };
        }

        /// <summary>
        /// Creates a new <see cref="Elm.TupleElementDefinition"/> based on a <see cref="Model.TupleTypeSpecifierElement"/>.
        /// </summary>
        public static Elm.TupleElementDefinition ToElm(this Model.TupleTypeSpecifierElement ttse, IModelProvider provider)
        {
            return new TupleElementDefinition
            {
                name = ttse.name,
                elementType = ttse.elementType?.ToElm(provider),
            };
        }

        /// <summary>
        /// Creates a new <see cref="Elm.TupleTypeSpecifier"/> based on a <see cref="Model.TupleTypeSpecifier"/>.
        /// </summary>
        public static Elm.TupleTypeSpecifier ToElm(this Model.TupleTypeSpecifier tts, IModelProvider provider)
        {
            return new()
            {
                element = tts.element.Select(e => e.ToElm(provider)).ToArray(),
            };
        }


        /// <summary>
        /// Creates a new <see cref="Elm.IntervalTypeSpecifier"/> based on a <see cref="Model.IntervalTypeSpecifier"/>.
        /// </summary>
        public static Elm.IntervalTypeSpecifier ToElm(this Model.IntervalTypeSpecifier its, IModelProvider provider)
        {
            var pts = its.pointTypeSpecifier?.ToElm(provider) ??
                TypeSpecifierForQualifiedName(provider, its.pointType);

            return new()
            {
                pointType = pts
            };
        }

        /// <summary>
        /// Creates a new <see cref="Elm.NamedTypeSpecifier"/> based on a <see cref="Model.NamedTypeSpecifier"/>.
        /// </summary>
        public static Elm.NamedTypeSpecifier ToElm(this Model.NamedTypeSpecifier nts, IModelProvider provider)
        {
            var model = provider.GetModelFromName(nts.@namespace);

            return new()
            {
                name = QualifiedName.MakeQualifiedTypeName(model.url, nts.name)
            };
        }


        /// <summary>
        /// Creates a new <see cref="Elm.ListTypeSpecifier"/> based on a <see cref="Model.ListTypeSpecifier"/>.
        /// </summary>
        public static Elm.ListTypeSpecifier ToElm(this Model.ListTypeSpecifier lts, IModelProvider provider)
        {
            var ets = lts.elementTypeSpecifier?.ToElm(provider) ??
                TypeSpecifierForQualifiedName(provider, lts.elementType);

            return new()
            {
                elementType = ets
            };
        }

        /// <summary>
        /// Gets the <see cref="TypeInfo"/> named <paramref name="name"/> in <paramref name="model"/>.
        /// </summary>
        /// <param name="model">The model to interrogate.</param>
        /// <param name="name">The name of the type, optionally prefixed with the name of the model.</param>
        /// <param name="result">The <see cref="TypeInfo"/>, if found.</param>
        /// <returns><see langword="true"/> if the info was found.</returns>
        public static bool TryGetTypeInfoFor(this ModelInfo model, string name, out TypeInfo? result)
        {
            var nonDottedName = name.StartsWith(model.name + ".") ?
                name[(model.name.Length + 1)..] : name;

            var typeInfo = from ti in model.typeInfo ?? Enumerable.Empty<TypeInfo>()
                           let n = ti.GetNameFromTypeInfo()
                           where n == nonDottedName
                           select ti;

            result = typeInfo.FirstOrDefault();
            return result is not null;
        }

        /// <summary>
        /// Uses the provider to resolve a type specified by a model's uri and a typename.
        /// </summary>
        /// <param name="provider">The model provider to resolve the type with.</param>
        /// <param name="uri">The uri for the model where the type can be found.</param>
        /// <param name="typeName">The name of the type to resolve.</param>
        /// <param name="model">The model, if the <paramref name="uri"/> could be resolved, otherwise <c>null</c>.</param>
        /// <param name="typeInfo">The type info, if both the model and the type could be resolved, otherwise <c>null</c></param>
        /// <returns>True if the type was found, false otherwise. In the latter case, <paramref name="model"/> might still be set if the
        /// model was found, but not the type.</returns>
        internal static bool TryFindTypeInfoByName(this IModelProvider provider, string uri,
            string typeName, out TypeInfo? typeInfo, out ModelInfo? model)
        {
            return provider.TryGetModelFromUri(uri, out model) &
                    model!.TryGetTypeInfoFor(typeName, out typeInfo);
        }

        /// <summary>
        /// Looks up the <see cref="ModelInfo"/> and <see cref="TypeInfo"/> for the type specified by <paramref name="type"/>.
        /// </summary>
        /// <exception cref="InvalidOperationException">When the named type could not be resolved.</exception>
        internal static ModelType FindTypeInfoByNamedType(this IModelProvider provider, Elm.NamedTypeSpecifier type)
        {
            var (uri, typeName) = type;
            if (!provider.TryFindTypeInfoByName(uri, typeName, out var typeInfo, out var model))
                throw new InvalidOperationException($"Type '{typeName}' was not found in model {model?.name ?? uri}.");

            return new(model!, typeInfo!);
        }

        internal static TypeInfo? FindTypeInfo(this ModelInfo model, string name) =>
            model.typeInfo?.SingleOrDefault(t => t.Name() == name);

        internal static string? Name(this TypeInfo t) => t switch
        {
            ClassInfo ci => ci.name,
            SimpleTypeInfo sti => sti.name,
            _ => null
        };

        internal static Elm.NamedTypeSpecifier TypeSpecifierForQualifiedName(IModelProvider provider, string qualifiedName)
        {
            var (model, name) = splitTypeName(qualifiedName);
            if (string.IsNullOrEmpty(model))
                throw new InvalidOperationException("Type specifier must be qualified with a model name.");

            if (!provider.TryGetModelFromName(model, out var resolvingModel))
                throw new InvalidOperationException($"Type {qualifiedName} references an unknown model {model}.");

            return resolvingModel.MakeQualifiedTypeName(name).ToNamedType();
        }

        internal static Elm.TypeSpecifier GetTypeSpecifierForElement(this ClassInfoElement element, IModelProvider provider)
        {
            if (element.elementTypeSpecifier is not null)
                return element.elementTypeSpecifier.ToElm(provider);
            else if (element.elementType is not null)
                return TypeSpecifierForQualifiedName(provider, element.elementType);
            else
                throw new InvalidOperationException($"Element {element.name} does not have a type specifier.");
        }

        // Split the typename on the first '.'.  If there is no '.', return ("", typename).
        private static (string modelPrefix, string typename) splitTypeName(string typename) => typename.Split('.', 2) switch
        {
            string[] parts when parts.Length == 2 => (parts[0], parts[1]),
            string[] parts when parts.Length == 1 => ("", parts[0]),
            _ => throw new ArgumentException($"Type name {typename} is not valid.")
        };

        /// <summary>
        /// Return the default profile URI for the type specified by <paramref name="type"/>, if any.
        /// </summary>
        /// <remarks>Not all models will have a "default" / unconstrained profile, so this function
        /// may return null.</remarks>
        internal static string? GetDefaultProfileUriForType(this IModelProvider provider, Elm.NamedTypeSpecifier type)
        {
            var (model, typeInfo) = provider.FindTypeInfoByNamedType(type);

            // this lookup isn't even necessary, but it's what we would do in a "real" implementation, if it ever exists.
            if (model!.url == "http://hl7.org/fhir")
            {
                var name = typeInfo!.GetNameFromTypeInfo();
                return $"http://hl7.org/fhir/StructureDefinition/{name}";
            }
            else
                return null;
        }


        /// <summary>
        /// Gets the basetype for the given type, or null if it is the root of the inheritance chain.
        /// </summary>
        /// <exception cref="InvalidOperationException">If the type could not be found.</exception>
        public static Elm.NamedTypeSpecifier? GetBaseType(IModelProvider provider, Elm.TypeSpecifier type)
        {
            if (type is Elm.NamedTypeSpecifier nts)
            {
                var (model, typeInfo) = provider.FindTypeInfoByNamedType(nts);

                var subtypeBaseTypeName = typeInfo!.baseType;

                if (subtypeBaseTypeName is not null)
                {
                    var subtypeBaseType = TypeSpecifierForQualifiedName(provider, subtypeBaseTypeName);
                    return subtypeBaseType;
                }
                else
                    return null;  // root of the inheritance chain.
            }
            else
            {
                // not a named type, so the knowledge about inheritance is not available in the modelinfo, and we
                // have some hard-coded choices here.
                return type switch
                {
                    Elm.ListTypeSpecifier => SystemTypes.AnyType,
                    Elm.IntervalTypeSpecifier => SystemTypes.AnyType,
                    Elm.ChoiceTypeSpecifier => SystemTypes.AnyType,
                    Elm.TupleTypeSpecifier => SystemTypes.AnyType,
                    _ => throw new InvalidOperationException($"Cannot determine the base type for unknown type specifier type '{type.GetType()}'.")
                };
            }
        }


        /// <summary>
        /// Determines whether instances of <paramref name="subType"/> can be used where a variables of type <paramref name="superType"/> is expected.
        /// </summary>
        /// <remarks>This function checks a subtyping relationship, not whether in- or explicit casts may exist between the types.
        /// See https://cql.hl7.org/03-developersguide.html#type-testing for more information.</remarks>
        internal static bool IsSubtypeOf(this Elm.TypeSpecifier subType, Elm.TypeSpecifier superType, IModelProvider provider)
        {
            if (subType is Elm.NamedTypeSpecifier subtypeNT && superType is Elm.NamedTypeSpecifier)
            {
                var baseType = GetBaseType(provider, subtypeNT);
                if (baseType is not null)
                {
                    if (baseType == superType) 
                        return true;
                    else 
                        return baseType.IsSubtypeOf(superType, provider);
                }
                else
                    return false;
            }
            else if (subType is Elm.ListTypeSpecifier subList && superType is Elm.ListTypeSpecifier superList)
            {
                // covariance on lists
                return subList.elementType.IsSubtypeOf(superList.elementType, provider);
            }
            else if (subType is Elm.IntervalTypeSpecifier intervalSub && superType is Elm.IntervalTypeSpecifier intervalSuper)
            {
                // covariance on intervals
                return intervalSub.pointType.IsSubtypeOf(intervalSuper.pointType, provider);
            }
            else if (subType is Elm.ChoiceTypeSpecifier && superType is Elm.ChoiceTypeSpecifier)
            {
                // The referred section on type testing does not mention choice types, so we'll take the easy
                // road and assume there is no subtype relationship defined for choices.
                return false;
            }
            else if (subType is Elm.TupleTypeSpecifier tupleSub && superType is Elm.TupleTypeSpecifier tupleSuper)
            {
                if (tupleSuper.element.Length == tupleSub.element.Length)
                {
                    return tupleSuper.element.Zip(tupleSub.element, (sup, sub) =>
                        sub.elementType.IsSubtypeOf(sup.elementType, provider) &&
                        sup.name == sub.name).All(b => b);
                }
                else
                    return false;
            }
            else
                return false;
        }
    }
}