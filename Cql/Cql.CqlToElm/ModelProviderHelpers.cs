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

        /// <inheritdoc cref="TryFindTypeInfoByName(IModelProvider, Elm.NamedTypeSpecifier, out TypeInfo?, out ModelInfo?)"/>
        internal static bool TryFindTypeInfoByName(this IModelProvider provider, string uri, string typeName, out TypeInfo? typeInfo, out ModelInfo? model)
        {
            if (provider.ModelFromUri(uri) is ModelInfo mi)
            {
                model = mi;
                typeInfo = model.TryGetTypeInfoFor(typeName, out var ti) ? ti : null;
            }
            else
            {
                model = null;
                typeInfo = null;
            }

            return typeInfo is not null && model is not null;
        }

        /// <summary>
        /// Uses the provider to resolve a type specified by a <see cref="Elm.NamedTypeSpecifier"/> .
        /// </summary>
        /// <param name="provider">The <see cref="IModelProvider"/> supplying the models.</param>
        /// <param name="nt">A <see cref="Elm.NamedTypeSpecifier"/>.</param>
        /// <param name="model">The <see cref="ModelInfo"/>, if it was found based on the uri in the named type.</param>
        /// <param name="typeInfo">The <see cref="TypeInfo"/>, if it was found within the model.</param>
        /// <returns>True is the type was found, false otherwise.</returns>
        internal static bool TryFindTypeInfoByName(this IModelProvider provider, Elm.NamedTypeSpecifier nt, out TypeInfo? typeInfo, out ModelInfo? model)
        {
            var (uri, typeName) = nt;
            return provider.TryFindTypeInfoByName(uri, typeName, out typeInfo, out model);
        }

        private static Elm.NamedTypeSpecifier typeSpecifierForQualifiedName(IModelProvider provider, ModelInfo local, string qualifiedName)
        {
            var (model, name) = splitTypeName(qualifiedName);

            var resolvingModel = model switch
            {
                null => local,
                string when model == local.name => local,
                string => provider.ModelFromName(model) ?? throw new InvalidOperationException($"Type {qualifiedName} references an unknown model {model}.")
            };

            return resolvingModel.MakeQualifiedTypeName(name).ToNamedType();
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
            if (!provider.TryFindTypeInfoByName(type, out var typeInfo, out var model)) return null;

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
                if (!provider.TryFindTypeInfoByName(nts, out var typeInfo, out var model))
                    throw new InvalidOperationException($"Type '{type}' was not found in model {model?.name}.");

                var subtypeBaseTypeName = typeInfo!.baseType;

                if (subtypeBaseTypeName is not null)
                {
                    var localModel = model!;
                    var subtypeBaseType = typeSpecifierForQualifiedName(provider, localModel, subtypeBaseTypeName);
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
        public static bool IsSubtypeOf(this Elm.TypeSpecifier subType, Elm.TypeSpecifier superType, IModelProvider provider)
        {
            if (superType == subType || superType == SystemTypes.AnyType)
                return true;
            else if (subType is Elm.NamedTypeSpecifier subtypeNT && superType is Elm.NamedTypeSpecifier)
            {
                var baseType = GetBaseType(provider, subtypeNT);
                if (baseType is not null)
                    return baseType.IsSubtypeOf(superType, provider);
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