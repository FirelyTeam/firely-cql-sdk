using Hl7.Cql.Elm;
using Hl7.Cql.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text.RegularExpressions;

namespace Hl7.Cql.CqlToElm
{
    internal static class IModelProviderExtensions
    {
        internal static bool TryGetTypeSpecifierForQualifiedName(this IModelProvider provider,
            string qualifiedName,
            out Elm.NamedTypeSpecifier? type)
        {
            var (model, name) = splitTypeName(qualifiedName);
            if (string.IsNullOrEmpty(model))
                throw new InvalidOperationException("Type specifier must be qualified with a model name.");

            if (!provider.TryGetModelFromName(model, out var resolvingModel))
            {
                type = null;
                return false;
            }
            type = resolvingModel.MakeQualifiedTypeName(name).ToNamedType();
            return true;
        }

        internal static bool TryGetTypeForQualifiedName(this IModelProvider provider,
            string qualifiedName,
            [NotNullWhen(true)] out TypeInfo? type)
        {
            var (model, name) = splitTypeName(qualifiedName);
            if (string.IsNullOrEmpty(model))
                throw new InvalidOperationException("Type specifier must be qualified with a model name.");

            if (!provider.TryGetModelFromName(model, out var resolvingModel))
            {
                type = null;
                return false;
            }
            type = resolvingModel.FindTypeInfo(name);
            return type is not null;
        }

        // Split the typename on the first '.'.  If there is no '.', return ("", typename).
        private static (string modelPrefix, string typename) splitTypeName(string typename) => typename.Split('.', 2) switch
        {
            string[] parts when parts.Length == 2 => (parts[0], parts[1]),
            string[] parts when parts.Length == 1 => ("", parts[0]),
            _ => throw new ArgumentException($"Type name {typename} is not valid.")
        };
        public static IEnumerable<TypeInfo> GetBaseTypes(this IModelProvider provider, TypeInfo type)
        {
            yield return type;
            if (type.baseType != null)
            {
                if (TryGetTypeForQualifiedName(provider, type.baseType, out var baseType)
                    && baseType is not null)
                {
                    foreach (var t in GetBaseTypes(provider, baseType!))
                        yield return t;
                }
            }

        }

        /// <summary>
        /// Returns the definition information for an element in a class.
        /// </summary>
        /// <returns>True if the member was found, false otherwise.</returns>
        public static bool TryGetElement(this IModelProvider provider, ClassInfo ci, string elementName, out ClassInfoElement? element)
        {
            element = getElement(ci);
            if (element is not null)
                return true;
            else
            {
                var types = GetBaseTypes(provider, ci).OfType<ClassInfo>();
                foreach (var t in types)
                {
                    element = getElement(t);
                    if (element is not null)
                        return true;
                }
                return false;
            }
            ClassInfoElement? getElement(ClassInfo c) =>
                c.element?.SingleOrDefault(ele => ele.name == elementName);
        }
 
        private static readonly Regex UriPrefixedTypeName = new Regex("{(?'uri'\\S+)}(?'name'\\S+)", RegexOptions.Compiled);
        /// <summary>
        /// Gets the model from a qualified name, e.g. {http://hl7.org/fhir}Period
        /// </summary>
        /// <param name="provider">This model provider</param>
        /// <param name="namedType">The named type whose model to derive.</param>
        /// <param name="model">The located model.</param>
        /// <returns>True if found; false otherwise.</returns>
        public static bool TryGetModelFromNamedType(this IModelProvider provider, 
            Elm.NamedTypeSpecifier namedType,
            out ModelInfo? model)
        {
            var match = UriPrefixedTypeName.Match(namedType.name.Name);
            if (match.Success)
            {
                var uri = match.Groups["uri"].Value;
                return provider.TryGetModelFromUri(uri, out model);
            }
            model = null;
            return false;
        }

        public static bool TryMakeQualifiedNameFromType(this IModelProvider provider,
            Elm.NamedTypeSpecifier namedType,
            out string? qualifiedName)
        {
            var match = UriPrefixedTypeName.Match(namedType.name.Name);
            if (match.Success)
            {
                var uri = match.Groups["uri"].Value;
                var name = match.Groups["name"].Value;
                if (provider.TryGetModelFromUri(uri, out var model))
                {
                    qualifiedName = $"{model.name}.{name}";
                    return true;
                }
            }
            qualifiedName = null;
            return false;
        }

        public static bool TryGetModelFromType(this IModelProvider provider,
            TypeInfo type, [NotNullWhen(true)] out ModelInfo? model)
        {
            var tuple = splitTypeName(type.Name()!);
            return provider.TryGetModelFromName(tuple.modelPrefix, out model);
        }

        public static string? TryGetUrlPrefixedName(this IModelProvider provider,
            string qualifiedName)
        {
            if (provider.TryGetTypeForQualifiedName(qualifiedName, out var type)
                && TryGetModelFromType(provider, type, out var model)) 
            {
                var urlPrefixedName = qualifiedName.Replace($"{model.name}.", $"{{{model.url}}}");
                return urlPrefixedName;
            }
            return null;
        }
    }
}