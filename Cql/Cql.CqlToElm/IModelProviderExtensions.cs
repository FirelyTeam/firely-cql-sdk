using Hl7.Cql.Elm;
using Hl7.Cql.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

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
            out TypeInfo? type)
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
            var types = GetBaseTypes(provider, ci);
            var allElements = types.OfType<ClassInfo>().SelectMany(ci => ci.element ?? Array.Empty<ClassInfoElement>());
            element = allElements.SingleOrDefault(ele => ele.name == elementName);

            return element is not null;
        }
    }
}