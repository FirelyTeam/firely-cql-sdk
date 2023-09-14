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

        /// <summary>
        /// Gets the <see cref="TypeInfo"/> named <paramref name="name"/> in <paramref name="model"/>.
        /// </summary>
        /// <param name="model">The model to interrogate.</param>
        /// <param name="name">The name of the type.</param>
        /// <returns>The <see cref="TypeInfo"/> for this named type if it exists; otherwise, <see langword="null"/></returns>
        TypeInfo? TypeInfoFor(ModelInfo model, string name);

        /// <summary>
        /// Qualifies <paramref name="typeName"/> with the namespace in <paramref name="model"/>.
        /// </summary>
        /// <param name="model">The model containing <paramref name="typeName"/>.</param>
        /// <param name="typeName">The name to qualify.</param>
        /// <returns>A string in the form {<see cref="ModelInfo.url"/>}<paramref name="typeName"/></returns>
        string QualifiedTypeName(ModelInfo model, string typeName);

        /// <summary>
        /// Gets the model defined to use the alias "System" for <paramref name="library"/>.
        /// </summary>
        /// <param name="library">The library defining the System model.</param>
        /// <returns>The system model.</returns>
        ModelInfo GetSystemModel(Elm.Library library);

        /// <summary>
        /// Gets the model for the type specified by <paramref name="qualifiedTypeName"/>.
        /// </summary>
        /// <param name="qualifiedTypeName">The qualified type name in the form {uri}type</param>
        /// <returns>The corresponding model if it can be identified; otherwise, <see langword="null"/>.</returns>
        ModelInfo? ModelFromQualifiedTypeName(string qualifiedTypeName);
    }
}