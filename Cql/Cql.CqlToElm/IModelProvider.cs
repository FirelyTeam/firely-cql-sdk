using Hl7.Cql.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Hl7.Cql.CqlToElm
{
    /// <summary>
    /// Defines methods for managing the models available during conversion.
    /// </summary>
    public interface IModelProvider
    {
        /// <summary>
        /// Adds the model to this provider.
        /// </summary>
        /// <param name="model">The model to add.</param>
        /// <returns><see langword="this"/></returns>
        /// <exception cref="System.ArgumentException">When a model with the same URI and a conflicting version specifier is already provided</exception>
        IModelProvider Add(ModelInfo model);

        /// <summary>
        /// Gets the model with URI <paramref name="uri"/>, and optionally with the specified
        /// <paramref name="version"/>
        /// </summary>
        /// <param name="uri">The uri of the model</param>
        /// <param name="version">An optional version.</param>
        /// <param name="model">The model, if found.</param>
        /// <returns>True if the model was found.</returns>
        /// <exception cref="ArgumentException">If two models with the same name and different versions are available,
        /// and <paramref name="version"/> is <see langword="null" /> or white space.</exception>
        bool TryGetModelFromUri(string uri, [NotNullWhen(true)] out ModelInfo? model, string? version = null);

        /// <summary>
        /// Gets the model with name <paramref name="name"/>, and optionally with the specified
        /// <paramref name="version"/>
        /// </summary>
        /// <param name="name">The name of the model</param>
        /// <param name="version">An optional version.</param>
        /// <param name="model">The model, if found.</param>
        /// <returns>True if the model was found.</returns>
        /// <exception cref="ArgumentException">If two models with the same name and different versions are available,
        /// and <paramref name="version"/> is <see langword="null" /> or white space.</exception>
        bool TryGetModelFromName(string name, [NotNullWhen(true)] out ModelInfo? model, string? version = null);

        /// <summary>
        /// Gets the conversion info from one qualified type name to another.
        /// </summary>
        /// <param name="fromQualifiedTypeName">The type to convert from</param>
        /// <param name="toQualifiedTypeName">The type to convert to</param>
        /// <param name="conversionFunctionName">The resulting function</param>
        /// <returns>True if a function is defined; otherwise, false.</returns>
        bool TryGetConversionFunctionName(string fromQualifiedTypeName, string toQualifiedTypeName, [NotNullWhen(true)] out string? conversionFunctionName);

        /// <summary>
        /// Gets all conversions from <paramref name="fromQualifiedTypeName"/>.
        /// </summary>
        /// <param name="fromQualifiedTypeName">The type to convert from</param>
        /// <param name="conversions">Tuples containing target types and their corresponding conversion functions.</param>
        /// <returns>True if at least one function is defined; otherwise, false.</returns>
        bool TryGetConversionFunctions(string fromQualifiedTypeName, [NotNullWhen(true)] out (string To, string Function)[]? conversions);

        /// <summary>
        /// Ges all types known across all models.
        /// </summary>
        IEnumerable<TypeInfo> AllTypes { get; }
    }
}