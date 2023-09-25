using Hl7.Cql.Elm;
using Hl7.Cql.Model;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml;

namespace Hl7.Cql.CqlToElm
{
    /// <summary>
    /// Additional function built on top of the <see cref="IModelProvider"/> and <see cref="ModelInfo"/> classes.
    /// </summary>
    public static class ModelProviderHelpers
    {
        private static readonly Regex QualifiedNameExpression = new("{(?'uri'.*)}.*", RegexOptions.Compiled);


        /// <summary>
        /// Gets the model defined to use the alias "System" for <paramref name="library"/>.
        /// </summary>
        /// <param name="provider">The <see cref="IModelProvider"/> supplying the model information.</param>
        /// <param name="library">The library defining the System model.</param>
        /// <returns>The system model.</returns>
        public static ModelInfo GetSystemModel(this IModelProvider provider, Library library)
        {
            if (library?.usings != null)
            {
                foreach (var ud in library.usings)
                {
                    if (ud.localIdentifier == "System")
                        return provider.ModelFromUri(ud.uri, ud.version)
                            ?? throw new InvalidOperationException($"Model {ud.uri} version {ud.version} is not available.");
                }
            }

            throw new ArgumentException("No model in this library has a local identifier of System.", nameof(library));
        }


        /// <summary>
        /// Gets the <see cref="TypeInfo"/> named <paramref name="name"/> in <paramref name="model"/>.
        /// </summary>
        /// <param name="model">The model to interrogate.</param>
        /// <param name="name">The name of the type, optionally prefixed with the name of the model.</param>
        /// <returns>The <see cref="TypeInfo"/> for this named type if it exists; otherwise, <see langword="null"/></returns>
        public static TypeInfo? TypeInfoFor(this ModelInfo model, string name)
        {
            // Unfortunately, the @name attribute in the model sometimes starts with the model name and sometimes doesn't.
            var (nonDottedName, dottedName) = name.StartsWith(model.name + ".") ?
                (name[(model.name.Length + 1)..], name) :
                (name, model.name + "." + name);

            var typeInfo = from ti in model.typeInfo
                           let n = nameFromModelElement(ti)
                           where n == dottedName || n == nonDottedName
                           select ti;

            return typeInfo.FirstOrDefault();

            static string? nameFromModelElement(TypeInfo ti) => ti switch
            {
                SimpleTypeInfo sti => sti.name,
                ClassInfo c => c.name,
                _ => null
            };
        }

        /// <summary>
        /// Gets the <see cref="TypeInfo"/> named <paramref name="qualifiedName"/>.
        /// </summary>
        /// <param name="provider">The <see cref="IModelProvider"/> supplfying the models.</param>
        /// <param name="qualifiedName">The qname of the type, which includes the model uri.</param>
        /// <returns>The <see cref="TypeInfo"/> for this named type if it exists; otherwise, <see langword="null"/></returns>
        public static TypeInfo? TypeInfoFor(this IModelProvider provider, XmlQualifiedName qualifiedName)
        {
            var model = provider.ModelFromQualifiedTypeName(qualifiedName) ?? throw new ArgumentException($"Unknown model {GetModelUriFromQualifiedName(qualifiedName)}.");
            return model.TypeInfoFor(qualifiedName.Name);
        }


        /// <summary>
        /// Gets the model uri for the type specified by <paramref name="qName"/>.
        /// </summary>
        /// <param name="qName">The qualified type name in the form {uri}type</param>
        /// <returns>The uri for the model if it can be identified; otherwise, <see langword="null"/>.</returns>
        public static string? GetModelUriFromQualifiedName(this XmlQualifiedName qName)
        {
            var match = QualifiedNameExpression.Match(qName.Name);
            return match.Success ? (match.Groups["uri"]?.Value) : null;
        }

        //public static bool IsAssignableTo(XmlQualifiedName supertype, XmlQualifiedName subtype)
        //{
        //    if (subtype == supertype)
        //        return true;
        //    else
        //    {
        //        var baseType = TypeInfoFor(this, subtype).baseType
        //        return
        //    }

        //}

        /// <summary>
        /// Qualifies <paramref name="typeName"/> with the namespace in <paramref name="model"/>.
        /// </summary>
        /// <param name="model">The model containing <paramref name="typeName"/>.</param>
        /// <param name="typeName">The name to qualify.</param>
        /// <returns>A string in the form {<see cref="ModelInfo.url"/>}<paramref name="typeName"/></returns>
        public static XmlQualifiedName ToQualifiedTypeName(this ModelInfo model, string typeName) => new($"{{{model.url}}}{typeName}");


        /// <summary>
        /// Gets the model for the type specified by <paramref name="qName"/>.
        /// </summary>
        /// <param name="provider">The <see cref="IModelProvider"/> supplfying the models.</param>
        /// <param name="qName">The qualified type name in the form {uri}type</param>
        /// <returns>The corresponding model if it can be identified; otherwise, <see langword="null"/>.</returns>
        public static ModelInfo? ModelFromQualifiedTypeName(this IModelProvider provider, XmlQualifiedName qName)
        {
            if (qName.GetModelUriFromQualifiedName() is string uri)
            {
                if (provider.ModelFromUri(uri) is ModelInfo model)
                {
                    return model;
                }
            }

            return null;
        }
    }



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