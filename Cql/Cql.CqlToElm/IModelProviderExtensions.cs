using Hl7.Cql.Elm;
using Hl7.Cql.Model;
using System;

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

        // Split the typename on the first '.'.  If there is no '.', return ("", typename).
        private static (string modelPrefix, string typename) splitTypeName(string typename) => typename.Split('.', 2) switch
        {
            string[] parts when parts.Length == 2 => (parts[0], parts[1]),
            string[] parts when parts.Length == 1 => ("", parts[0]),
            _ => throw new ArgumentException($"Type name {typename} is not valid.")
        };
    }
}