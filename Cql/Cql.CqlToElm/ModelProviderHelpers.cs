using Hl7.Cql.Elm;
using Hl7.Cql.Model;
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Hl7.Cql.CqlToElm
{
    /// <summary>
    /// Additional function built on top of the <see cref="IModelProvider"/> and <see cref="ModelInfo"/> classes.
    /// </summary>
    public static class ModelProviderHelpers
    {
        private static readonly Regex QualifiedNameExpression = new("{(?'uri'.*)}(?'name'.*)", RegexOptions.Compiled);

        /// <summary>
        /// Gets the <see cref="TypeInfo"/> named <paramref name="name"/> in <paramref name="model"/>.
        /// </summary>
        /// <param name="model">The model to interrogate.</param>
        /// <param name="name">The name of the type, optionally prefixed with the name of the model.</param>
        /// <param name="result">The <see cref="TypeInfo"/>, if found.</param>
        /// <returns><see langword="true"/> if the info was found.</returns>
        public static bool TryGetTypeInfoFor(this ModelInfo model, string name, out TypeInfo? result)
        {
            var (nonDottedName, dottedName) = name.StartsWith(model.name + ".") ?
                (name[(model.name.Length + 1)..], name) :
                (name, model.name + "." + name);

            // Unfortunately, the typeInfo.name property will sometimes be qualified, sometimes not,
            // so check for both variations.
            var typeInfo = from ti in model.typeInfo
                           let n = nameFromModelElement(ti)
                           where n == dottedName || n == nonDottedName
                           select ti;

            result = typeInfo.FirstOrDefault();
            return result is not null;

            static string? nameFromModelElement(TypeInfo ti) => ti switch
            {
                SimpleTypeInfo sti => sti.name,
                ClassInfo c => c.name,
                _ => null
            };
        }

        /// <summary>
        /// Gets the <see cref="TypeInfo"/> named <paramref name="name"/> in <paramref name="model"/>.
        /// </summary>
        /// <param name="model">The model to interrogate.</param>
        /// <param name="name">The name of the type, optionally prefixed with the name of the model.</param>
        /// <exception cref="InvalidOperationException">If the info for the type was not found in the model.</exception>
        public static TypeInfo TypeInfoFor(this ModelInfo model, string name)
        {
            if (model.TryGetTypeInfoFor(name, out var typeInfo))
                return typeInfo!;
            else
                throw new InvalidOperationException($"Type {name} not found in model {model.name}.");
        }


        /// <summary>
        /// Gets the model uri and name for the type specified by <paramref name="nt"/>.
        /// </summary>
        /// <param name="nt">A <see cref="Elm.NamedTypeSpecifier"/> with a name in the form <c>{uri}type</c>.</param>
        /// <returns>The uri and the type parts of the name in the specifier.</returns>
        /// <exception cref="ArgumentException">If the name does not match the expected pattern.</exception>
        public static (string uri, string name) GetNamedTypeComponents(this Elm.NamedTypeSpecifier nt) =>
            GetNamedTypeComponents(nt.name.Name);

        /// <summary>
        /// Gets the model uri and name for the type specified by <paramref name="qualifiedName"/>.
        /// </summary>
        /// <param name="qualifiedName">A qualified type name string n the form <c>{uri}type</c>.</param>
        /// <returns>The uri and the type parts of the name in the specifier.</returns>
        /// <exception cref="ArgumentException">If the name does not match the expected pattern.</exception>
        public static (string uri, string name) GetNamedTypeComponents(this string qualifiedName)
        {
            var match = QualifiedNameExpression.Match(qualifiedName);
            return match.Success ? (match.Groups["uri"].Value, match.Groups["name"].Value) :
                throw new ArgumentException("NamedTypeSpecifier name does not match the expected pattern {uri}name.", nameof(qualifiedName));
        }

        /// <summary>
        /// Gets the model for the type specified by <paramref name="nt"/>.
        /// </summary>
        /// <param name="provider">The <see cref="IModelProvider"/> supplfying the models.</param>
        /// <param name="nt">A <see cref="Elm.NamedTypeSpecifier"/> with a name in the form {uri}type.</param>
        /// <exception cref="InvalidOperationException">If the model is not found.</exception>
        public static ModelInfo ModelFromNamedType(this IModelProvider provider, Elm.NamedTypeSpecifier nt)
        {
            var (uri, _) = nt.GetNamedTypeComponents();
            if (provider.ModelFromUri(uri) is ModelInfo model)
                return model;
            else
                throw new InvalidOperationException($"Type {nt} uses unknown model {uri}.");
        }

        /// <summary>
        /// Gets the model for the type specified by <paramref name="qualifiedTypeName"/>.
        /// </summary>
        /// <param name="provider">The <see cref="IModelProvider"/> supplfying the models.</param>
        /// <param name="qualifiedTypeName">The type's URI.</param>
        public static ModelInfo ModelFromUri(this IModelProvider provider, string qualifiedTypeName)
        {
            var (uri, _) = qualifiedTypeName.GetNamedTypeComponents();
            if (provider.ModelFromUri(uri) is ModelInfo model)
                return model;
            else
                throw new InvalidOperationException($"Type {qualifiedTypeName} uses unknown model {uri}.");
        }


        /// <summary>
        /// Returns the <see cref="TypeInfo"/> for the type specified by <paramref name="nt"/>.
        /// </summary>
        /// <param name="provider">The <see cref="IModelProvider"/> supplfying the models.</param>
        /// <param name="nt">A <see cref="Elm.NamedTypeSpecifier"/> with a name in the form {uri}type.</param>
        /// <exception cref="InvalidOperationException">If the type was not found.</exception>
        public static TypeInfo TypeInfoForNamedType(this IModelProvider provider, Elm.NamedTypeSpecifier nt)
        {
            var (_, name) = nt.GetNamedTypeComponents();
            var model = provider.ModelFromNamedType(nt);

            return model.TypeInfoFor(name);
        }

        private static Elm.NamedTypeSpecifier typeSpecifierForQualifiedName(IModelProvider provider, ModelInfo local, string qualifiedName)
        {
            var (model, name) = splitTypeName(qualifiedName);

            var resolvingModel = model switch
            {
                null => local,
                string when qualifiedName == local.name => local,
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
        public static string? GetDefaultProfileUriForType(this IModelProvider provider, Elm.NamedTypeSpecifier type)
        {
            var model = provider.ModelFromNamedType(type);

            // this lookup isn't even necessary, but it's what we would do in a "real" implementation, if it ever exists.
            if (model.url == "http://hl7.org/fhir")
            {
                var (_, name) = GetNamedTypeComponents(type);
                return $"http://hl7.org/fhir/StructureDefinition/{name}";
            }
            else
                return null;
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
                var subtypeBaseTypeName = provider.TypeInfoForNamedType(subtypeNT).baseType;

                if (subtypeBaseTypeName is not null)
                {
                    var localModel = provider.ModelFromNamedType(subtypeNT);
                    var subtypeBaseType = typeSpecifierForQualifiedName(provider, localModel, subtypeBaseTypeName);
                    return subtypeBaseType.IsSubtypeOf(superType, provider);
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