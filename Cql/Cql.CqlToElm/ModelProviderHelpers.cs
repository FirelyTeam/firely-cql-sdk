using Hl7.Cql.Model;
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
}