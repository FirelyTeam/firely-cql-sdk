using Hl7.Cql.Abstractions.Infrastructure;
using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using TypeSpecifier = Hl7.Cql.Model.TypeSpecifier;

namespace Hl7.Cql.Model.Xml
{
    internal class XmlModelLoader(IModelProvider modelProvider)
    {
        public IModelProvider ModelProvider { get; } = modelProvider;

        public ModelDefinition Load(ModelInfo modelInfo)
        {
            var models = new List<ModelDefinition>();

            if (modelInfo.requiredModelInfo is not null)
            {
                foreach (var required in modelInfo.requiredModelInfo)
                {
                    if (ModelProvider.TryGetModel(required.name, required.version, out var requiredModel))
                        models.Add(requiredModel);
                    else
                        throw new InvalidOperationException($"Required model {required.name} version {required.version} not found.");
                }
            }
            var model = new ModelDefinition(modelInfo.name, modelInfo.version, modelInfo.url);
            models.Add(model);
            var modelTypes = new Dictionary<string, TypeDefinition>();
            model.TypeDefinitions = modelTypes;
            // create the type stubs.  these will be populated later.
            foreach (var typeInfo in modelInfo.typeInfo)
            {
                if (typeInfo is SimpleTypeInfo simpleType)
                {
                    if (isQualified(simpleType.name, model))
                        modelTypes.Add(simpleType.name, new SimpleTypeDefinition(disqualify(simpleType.name, model),
                            model, AccessModifier.Public));
                    else
                        modelTypes.Add(qualify(simpleType.name, model),
                            new SimpleTypeDefinition(simpleType.name, model, AccessModifier.Public));
                }
                else if (typeInfo is ClassInfo classType)
                {
                    if (isQualified(classType.name, model))
                        modelTypes.Add(classType.name, new ClassTypeDefinition(disqualify(classType.name, model),
                            model, AccessModifier.Public));
                    else
                        modelTypes.Add(qualify(classType.name, model),
                            new ClassTypeDefinition(classType.name, model, AccessModifier.Public));
                }
                else throw new InvalidOperationException($"Unrecognized TypeInfo type {typeInfo.GetType().Name}");
            }
            if (tryGetType("System.Any", out var anyType))
            {
                var anyTs = anyType switch
                {
                    SimpleTypeDefinition st => st.ToTypeSpecifier(),
                    _ => throw new InvalidOperationException($"Expecting Any to be a simple type.")
                };
                if (modelInfo.name == "System")
                {
                    var listType = GenericTypeDefinition.CreateTemplate("List",
                        model,
                        [GenericArgumentSpecifier.T],
                        new Dictionary<Model.GenericArgumentSpecifier, Model.TypeSpecifier>() { { GenericArgumentSpecifier.T, anyTs } },
                        anyType,
                        AccessModifier.Public);

                    modelTypes.Add("System.List", listType);

                    Model.NamedTypeSpecifier[] intervalTypes = [
                        getNamedTypeSpecifierOrThrow("System.Integer"),
                        getNamedTypeSpecifierOrThrow("System.Long"),
                        getNamedTypeSpecifierOrThrow("System.Decimal"),
                        getNamedTypeSpecifierOrThrow("System.Quantity"),
                        getNamedTypeSpecifierOrThrow("System.Ratio"),
                        getNamedTypeSpecifierOrThrow("System.Date"),
                        getNamedTypeSpecifierOrThrow("System.Time"),
                        getNamedTypeSpecifierOrThrow("System.DateTime")
                    ];
                    var intervalChoiceType = new Model.ChoiceTypeSpecifier(intervalTypes);

                    var intervalType = GenericTypeDefinition.CreateTemplate("Interval",
                        model,
                        [GenericArgumentSpecifier.T],
                         new Dictionary<Model.GenericArgumentSpecifier, Model.TypeSpecifier>() { { GenericArgumentSpecifier.T, intervalChoiceType } },
                         anyType,
                         AccessModifier.Public);

                    intervalType.AddElement(new ClassTypeElementDefinition("low", GenericArgumentSpecifier.T, null));
                    intervalType.AddElement(new ClassTypeElementDefinition("high", GenericArgumentSpecifier.T, null));
                    intervalType.AddElement(new ClassTypeElementDefinition("lowClosed", getNamedTypeSpecifierOrThrow("System.Boolean"), null));
                    intervalType.AddElement(new ClassTypeElementDefinition("highClosed", getNamedTypeSpecifierOrThrow("System.Boolean"), null));

                    modelTypes.Add("System.Interval", intervalType);
                }
            }
            // populate types now that they exist.
            foreach (var typeInfo in modelInfo.typeInfo)
            {
                if (typeInfo is SimpleTypeInfo simpleTypeInfo)
                {
                    var name = qualify(simpleTypeInfo.name, model);
                    var typeDefinition = modelTypes[name];
                    if (typeDefinition is SimpleTypeDefinition simpleTypeDef)
                    {
                        if (!string.IsNullOrWhiteSpace(simpleTypeInfo.baseType))
                        {
                            if (tryGetType(simpleTypeInfo.baseType, out var baseType))
                                simpleTypeDef.BaseType = baseType;
                            else throw new InvalidOperationException($"Type {simpleTypeInfo.baseType} not found.");
                        }
                    }
                    else throw new InvalidOperationException($"SimpleTypeInfo should translate to SimpleTypeDefinition.");

                }
                else if (typeInfo is ClassInfo classInfo)
                {
                    var name = qualify(classInfo.name, model);
                    var typeDefinition = modelTypes[name];
                    if (typeDefinition is ClassTypeDefinition classTypeDef)
                    {
                        if (tryGetType(classInfo.baseType, out var baseType))
                            classTypeDef.BaseType = baseType;
                        else throw new InvalidOperationException($"Type {classInfo.baseType} not found.");
                        if (classInfo.element is not null)
                        {
                            var elements = new List<ClassTypeElementDefinition>(classInfo.element.Length);
                            foreach (var elementInfo in classInfo.element)
                            {
                                var elementName = elementInfo.name;
                                var typeSpecifier = getElementTypeSpecifier(elementInfo.type ?? elementInfo.elementType,
                                    elementInfo.typeSpecifier ?? elementInfo.elementTypeSpecifier);
                                var target = elementInfo.target;
                                var element = new ClassTypeElementDefinition(elementName, typeSpecifier, target);
                                elements.Add(element);
                            }
                            foreach (var ele in elements)
                                classTypeDef.AddElement(ele);
                        }
                    }
                    else throw new InvalidOperationException($"ClassTypeInfo should translate to SimpleTypeDefinition.");

                }
                else throw new InvalidOperationException($"Unrecognized TypeInfo type {typeInfo.GetType().Name}");
            }

            if (modelInfo.contextInfo is not null)
            {
                foreach (var contextInfo in modelInfo.contextInfo)
                {
                    if (tryGetType($"{model.Name}.{contextInfo.contextType.name}", out var contextType))
                    {
                        var cd = new ContextDefinition(contextInfo.name, model, contextType);
                        model.Contexts.Add(cd.Name, cd);
                    }
                    else throw new InvalidOperationException($"Context type {contextInfo.contextType.name} doesn't exist.");
                }
            }

            if (modelInfo.conversionInfo is not null)
            {
                foreach (var conversion in modelInfo.conversionInfo)
                {
                    if (tryGetType(conversion.fromType, out var from) &&
                        tryGetType(conversion.toType, out var to))
                    {
                        var fromSpecifier = from.ToTypeSpecifier();
                        if (!model.ImplicitConversions.TryGetValue(fromSpecifier, out var conversionsFrom))
                        {
                            conversionsFrom = new(EqualityComparer<Model.TypeSpecifier>.Default);
                            model.ImplicitConversions.Add(fromSpecifier, conversionsFrom);
                        }
                        var toSpecifier = to.ToTypeSpecifier();
                        if (conversionsFrom.TryGetValue(toSpecifier, out var existing))
                            throw new InvalidOperationException($"Conversion from {conversion.fromType} to {conversion.toType} is already defined.");
                        else conversionsFrom.Add(toSpecifier, conversion.functionName);
                    }
                    else throw new InvalidOperationException($"onversion {conversion.fromType} to {conversion.toType} has types that cannot be resolved.");
                }
            }


            return model;

            Hl7.Cql.Model.TypeSpecifier getElementTypeSpecifier(string? name, Xml.TypeSpecifier? elementTypeSpecifier)
            {
                if (!string.IsNullOrWhiteSpace(name))
                {
                    if (tryGetType(name, out var elementType))
                    {
                        var ts = elementType switch
                        {
                            SimpleTypeDefinition std => std.ToTypeSpecifier(),
                            ClassTypeDefinition ctd => ctd.ToTypeSpecifier(),
                            _ => throw new InvalidOperationException()
                        };
                        return ts;
                    }
                    else throw new InvalidOperationException($"Type {name} not found.");
                }
                else if (elementTypeSpecifier is Xml.NamedTypeSpecifier nts)
                {
                    return getNamedTypeSpecifierOrThrow(qualify(nts.name, model));
                }
                else if (elementTypeSpecifier is Xml.ListTypeSpecifier lts)
                {
                    if (tryGetType("System.List", out var listType))
                    {
                        if (listType is GenericTypeDefinition gtd)
                        {
                            var elementTs = getElementTypeSpecifier(lts.elementType, lts.elementTypeSpecifier);
                            return gtd.MakeGenericType(elementTs).ToTypeSpecifier();
                        }
                        else throw new InvalidOperationException($"List type is not generic.");
                    }
                    else throw new InvalidOperationException("List type is not defined.");
                }
                else if (elementTypeSpecifier is Xml.IntervalTypeSpecifier its)
                {
                    if (tryGetType("System.Interval", out var intervalType))
                    {
                        if (intervalType is GenericTypeDefinition gtd)
                        {
                            var elementTs = getElementTypeSpecifier(its.pointType, its.pointTypeSpecifier);
                            return gtd.MakeGenericType(elementTs).ToTypeSpecifier();
                        }
                        else throw new InvalidOperationException($"List type is not generic.");
                    }
                    else throw new InvalidOperationException("Interval type is not defined.");
                }
                else if (elementTypeSpecifier is Xml.ChoiceTypeSpecifier cts)
                {
                    var choices = cts.choice
                        .Select(c => getElementTypeSpecifier(null, c))
                        .ToArray();
                    var choiceTs = new Model.ChoiceTypeSpecifier(choices);
                    return choiceTs;
                }
                else throw new NotSupportedException();
            }

            bool isQualified(string name, ModelDefinition model) => name.StartsWith($"{model.Name}.");
            string disqualify(string name, ModelDefinition model) => name.Substring(model.Name.Length + 1);
            string qualify(string name, ModelDefinition model) => name;
            //{
            //    var parts = name.Split('.');
            //    if (parts.Length == 1)
            //        return $"{model.Name}.{name}";
            //    else if (parts.Length > 1)
            //    {
            //        if (parts[0] != model.Name)
            //            return $"{model.Name}.{name}";
            //        else return name;
            //    }
            //    else throw new ArgumentException("Name must have at least one part", nameof(name));
            //}

            bool tryGetType(string name, [NotNullWhen(true)] out TypeDefinition? type)
            {
                type = getNamedType(name);
                return type is not null;
            }
            TypeDefinition? getNamedType(string? name)
            {
                if (name is null)
                    return null;
                string[] parts = name.Split('.');
                if (parts.Length == 1) // no model specified
                    return model.TryGetType(parts[0], out var type) ? type : null;
                else
                {
                    for (int i = parts.Length; i > 0; i--)
                    {
                        string modelName = string.Join(".", parts.Take(i));
                        ModelDefinition? model = getModel(modelName);
                        if (model != null)
                        {
                            string typeName = string.Join(".", parts.Skip(i));
                            if (model.TypeDefinitions.TryGetValue(typeName, out var type))
                                return type;
                        }
                    }
                }
                return null;
            }

            Model.NamedTypeSpecifier getNamedTypeSpecifierOrThrow(string qualifiedName)
            {
                if (tryGetType(qualifiedName, out var type))
                    return type switch
                    {
                        SimpleTypeDefinition std => (Model.NamedTypeSpecifier)std.ToTypeSpecifier(),
                        ClassTypeDefinition ctd => (Model.NamedTypeSpecifier)ctd.ToTypeSpecifier(),
                        _ => throw new InvalidOperationException($"Type's specifier will not be a named type specifier.")
                    };
                else throw new InvalidOperationException($"Type {qualifiedName} not found.");
            }

            ModelDefinition? getModel(string name)
            {
                if (name == model.Name)
                    return model;
                else if (model.RequiredModels.TryGetValue(name, out var requiredModel))
                    return requiredModel;
                else return null;
            }
        }
    }
}
