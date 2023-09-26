using Hl7.Cql.Model;
using System;

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
        /// <param name="uri">The URI of the model</param>
        /// <param name="version">The version, if specified.</param>
        /// <returns>The matching model.</returns>
        /// <exception cref="ArgumentException">
        /// if two models with the same URI and different versions are available,
        /// and <paramref name="version"/> is <see langword="null" /> or white space.
        /// </exception>
        ModelInfo? ModelFromUri(string uri, string? version = null);

        /// <summary>
        /// Gets the model with name <paramref name="name"/>, and optionally with the specified
        /// <paramref name="version"/>
        /// </summary>
        /// <param name="name">The name of the model</param>
        /// <param name="version">The version, if specified.</param>
        /// <returns>The matching model.</returns>
        /// <exception cref="ArgumentException">
        /// if two models with the same name and different versions are available,
        /// and <paramref name="version"/> is <see langword="null" /> or white space.
        /// </exception>
        ModelInfo? ModelFromName(string name, string? version = null);
    }
}