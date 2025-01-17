using Hl7.Cql.Model;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm
{
    internal static class TypeBridge
    {

        public static Model.TypeSpecifier ToModelSpecifier(this Elm.TypeSpecifier elmSpecifier,
            IModelProvider provider,
            CqlToElmOptions options)
        {
            switch (elmSpecifier)
            {
                case Elm.NamedTypeSpecifier nts:
                    {
                        if (nts.name is null)
                            throw new ArgumentException($"Named type specifier does not have a name.");
                        var (modelUri, typeName) = extract(nts.name!.Name);
                        if (provider.TryGetModelFromUri(modelUri, out var model))
                        {
                            if (model.TryGetType($"{model.Name}.{typeName}", out var type))
                                return new Model.NamedTypeSpecifier(type);
                            else throw new ArgumentException($"Type name {typeName} is not found in model {model.Name} with uri {modelUri}.");
                        }
                        else throw new ArgumentException($"Model with uri {modelUri} is not found.");
                    }
                case Elm.IntervalTypeSpecifier its:
                    {
                        if (!provider.TryGetType(options.LiteralTypes.Interval, out var intervalType))
                            throw new ArgumentException($"{options.LiteralTypes.Interval} type is not available.");
                        if (intervalType is Model.GenericTypeDefinition gtd)
                        {
                            if (gtd.Constraints.Count != 1)
                                throw new ArgumentException($"{options.LiteralTypes.Interval} type does not have exactly 1 generic argument.");
                            var pointType = its.pointType.ToModelSpecifier(provider, options);
                            return new Model.GenericTypeSpecifier(gtd, [pointType]);
                        }
                        else
                            throw new ArgumentException($"{options.LiteralTypes.Interval} type is not a generic type.");
                    }
                case Elm.ListTypeSpecifier lts:
                    {
                        if (!provider.TryGetType(options.LiteralTypes.List, out var listType))
                            throw new ArgumentException($"{options.LiteralTypes.List} type is not available.");
                        if (listType is Model.GenericTypeDefinition gtd)
                        {
                            if (gtd.Constraints.Count != 1)
                                throw new ArgumentException($"{options.LiteralTypes.List} type does not have exactly 1 generic argument.");
                            var pointType = lts.elementType.ToModelSpecifier(provider, options);
                            return new Model.GenericTypeSpecifier(gtd, [pointType]);
                        }
                        else
                            throw new ArgumentException($"{options.LiteralTypes.List} type is not a generic type.");
                    }
                case Elm.ChoiceTypeSpecifier cts:
                    {
                        var cs = cts.choice.Select(c => c.ToModelSpecifier(provider, options)).ToArray();
                        return new Model.ChoiceTypeSpecifier(cs);
                    }
                case Elm.TupleTypeSpecifier tts:
                    {
                        throw new NotImplementedException();
                    }
                case Elm.ParameterTypeSpecifier pts:
                    {
                        return new Model.GenericArgumentSpecifier(pts.parameterName);
                    }
                default:
                    throw new ArgumentException($"Type specifier {elmSpecifier.GetType().Name} is unknown.");
            }
            // takes strings like {uri}name and returns uri
            (string uri, string name) extract(string name)
            {
                var fb = name.IndexOf('{');
                if (fb > -1)
                {
                    fb += 1;
                    var sb = name.IndexOf('}');
                    return (name.Substring(fb, sb - fb), name.Substring(sb + 1));
                }
                else throw new ArgumentException($"Name {name} is not in the right format.");
            }
        }

        public static Elm.TypeSpecifier ToElmSpecifier(this Model.TypeSpecifier modelSpecifier) =>
            modelSpecifier switch
            {
                Model.NamedTypeSpecifier nts =>
                    new Elm.NamedTypeSpecifier
                    {
                        name = new System.Xml.XmlQualifiedName($"{{{nts.Type.Model.Uri}}}{nts.Type.Name}")
                    },
                Model.GenericTypeSpecifier gts =>
                    new Elm.GenericTypeSpecifier
                    {
                        type = new Elm.NamedTypeSpecifier
                        {
                            name = new System.Xml.XmlQualifiedName($"{{{gts.Type.Model.Uri}}}{gts.Type.Name}"),
                        },
                        typeArgument = gts.Arguments.Select(ToElmSpecifier).ToArray(),
                    },
                Model.ChoiceTypeSpecifier cts =>
                    new Elm.ChoiceTypeSpecifier
                    {
                        choice = cts.Choices.Select(ToElmSpecifier).ToArray(),
                    },
                _ => throw new NotImplementedException()
            };
    }
}
