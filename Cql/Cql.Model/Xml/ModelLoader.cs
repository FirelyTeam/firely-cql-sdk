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
    internal class ModelLoader : IModelProvider
    {
        public ModelLoader(Func<string, string?, ModelInfo?> resolveByNameAndVersion,
            Func<string, ModelInfo?> resolveByUri)
        {
            ResolveByNameAndVersion = resolveByNameAndVersion;
            ResolveByUri = resolveByUri;
        }


        private Dictionary<string, Dictionary<string, ModelDefinition>> ByName = new();
        private Dictionary<string, ModelDefinition> ByUri = new();

        public Func<string, string?, ModelInfo?> ResolveByNameAndVersion { get; }
        public Func<string, ModelInfo?> ResolveByUri { get; }

        private void Add(ModelDefinition modelDefinition)
        {
            if (ByUri.ContainsKey(modelDefinition.Uri))
                throw new ArgumentException($"Model with URI {modelDefinition.Uri} is already loaded.");
            ByUri.Add(modelDefinition.Uri, modelDefinition);

            if (!ByName.TryGetValue(modelDefinition.Name, out var bnbv))
            {
                bnbv = new();
                ByName.Add(modelDefinition.Name, bnbv);
            }
            var version = modelDefinition.Version ?? "";
            if (bnbv.TryGetValue(version, out var existing))
                throw new InvalidOperationException($"Model {modelDefinition.Name} version {modelDefinition.Version} already loaded.");
            else bnbv.Add(version, modelDefinition);
        }

        public ModelDefinition Load(ModelInfo modelInfo)
        {
            if (ByUri.TryGetValue(modelInfo.url, out var md))
                return md;
            if (modelInfo.requiredModelInfo is not null)
            {
                foreach (var required in modelInfo.requiredModelInfo)
                {
                    if (!TryGetModel(required.name, required.version, out _))
                        throw new InvalidOperationException($"Required model {required.name} version {required.version} not found.");
                }
            }

            var modelDefinition = new ModelDefinition(modelInfo.name, modelInfo.version, modelInfo.url);
            var modelTypes = new Dictionary<string, TypeDefinition>();
            modelDefinition.TypeDefinitions = modelTypes;
            Add(modelDefinition);
            // create the type stubs.  these will be populated later.
            foreach (var typeInfo in modelInfo.typeInfo)
            {
                if (typeInfo is SimpleTypeInfo simpleType)
                {
                    if (isQualified(simpleType.name, modelDefinition))
                        modelTypes.Add(simpleType.name, new SimpleTypeDefinition(disqualify(simpleType.name, modelDefinition),
                            modelDefinition, AccessModifier.Public));
                    else
                        modelTypes.Add(qualify(simpleType.name, modelDefinition),
                            new SimpleTypeDefinition(simpleType.name, modelDefinition, AccessModifier.Public));
                }
                else if (typeInfo is ClassInfo classType)
                {
                    if (isQualified(classType.name, modelDefinition))
                        modelTypes.Add(classType.name, new ClassTypeDefinition(disqualify(classType.name, modelDefinition),
                            modelDefinition, AccessModifier.Public));
                    else
                        modelTypes.Add(qualify(classType.name, modelDefinition),
                            new ClassTypeDefinition(classType.name, modelDefinition, AccessModifier.Public));
                }
                else throw new InvalidOperationException($"Unrecognized TypeInfo type {typeInfo.GetType().Name}");
            }
            if (TryGetType("System.Any", out var anyType))
            {
                var anyTs = anyType switch
                {
                    SimpleTypeDefinition st => st.ToTypeSpecifier(),
                    _ => throw new InvalidOperationException($"Expecting Any to be a simple type.")
                };
                if (modelInfo.name == "System")
                {
                    var listType = GenericTypeDefinition.CreateTemplate("List",
                        modelDefinition,
                        [GenericArgumentSpecifier.T],
                        new Dictionary<Model.GenericArgumentSpecifier, Model.TypeSpecifier>() { { GenericArgumentSpecifier.T, anyTs } },
                        anyType,
                        AccessModifier.Public);

                    modelTypes.Add("System.List", listType);

                    Model.NamedTypeSpecifier[] intervalTypes = [
                        GetNamedTypeSpecifierOrThrow("System.Integer"),
                        GetNamedTypeSpecifierOrThrow("System.Long"),
                        GetNamedTypeSpecifierOrThrow("System.Decimal"),
                        GetNamedTypeSpecifierOrThrow("System.Quantity"),
                        GetNamedTypeSpecifierOrThrow("System.Ratio"),
                        GetNamedTypeSpecifierOrThrow("System.Date"),
                        GetNamedTypeSpecifierOrThrow("System.Time"),
                        GetNamedTypeSpecifierOrThrow("System.DateTime")
                    ];
                    var intervalChoiceType = new Model.ChoiceTypeSpecifier(intervalTypes);

                    var intervalType = GenericTypeDefinition.CreateTemplate("Interval",
                        modelDefinition,
                        [GenericArgumentSpecifier.T],
                         new Dictionary<Model.GenericArgumentSpecifier, Model.TypeSpecifier>() { { GenericArgumentSpecifier.T, intervalChoiceType } },
                         anyType,
                         AccessModifier.Public);

                    intervalType.Elements = new ReadOnlyCollection<ClassTypeElementDefinition>([
                        new ClassTypeElementDefinition("low", GenericArgumentSpecifier.T, null),
                        new ClassTypeElementDefinition("high",  GenericArgumentSpecifier.T, null),
                        new ClassTypeElementDefinition("lowClosed", GetNamedTypeSpecifierOrThrow("System.Boolean"), null),
                        new ClassTypeElementDefinition("highClosed", GetNamedTypeSpecifierOrThrow("System.Boolean"), null),
                    ]);
                    modelTypes.Add("System.Interval", intervalType);
                }
            }
            // populate types now that they exist.
            foreach (var typeInfo in modelInfo.typeInfo)
            {
                if (typeInfo is SimpleTypeInfo simpleTypeInfo)
                {
                    var name = qualify(simpleTypeInfo.name, modelDefinition);
                    var typeDefinition = modelTypes[name];
                    if (typeDefinition is SimpleTypeDefinition simpleTypeDef)
                    {
                        if (!string.IsNullOrWhiteSpace(simpleTypeInfo.baseType))
                        {
                            if (TryGetType(simpleTypeInfo.baseType, out var baseType))
                                simpleTypeDef.BaseType = baseType;
                            else throw new InvalidOperationException($"Type {simpleTypeInfo.baseType} not found.");
                        }
                    }
                    else throw new InvalidOperationException($"SimpleTypeInfo should translate to SimpleTypeDefinition.");

                }
                else if (typeInfo is ClassInfo classInfo)
                {
                    var name = qualify(classInfo.name, modelDefinition);
                    var typeDefinition = modelTypes[name];
                    if (typeDefinition is ClassTypeDefinition classTypeDef)
                    {
                        if (TryGetType(classInfo.baseType, out var baseType))
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
                            classTypeDef.Elements = new ReadOnlyCollection<ClassTypeElementDefinition>(elements);
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
                    if (TryGetType($"{modelDefinition.Name}.{contextInfo.contextType.name}", out var contextType))
                    {
                        var cd = new ContextDefinition(contextInfo.name, modelDefinition, contextType);
                        modelDefinition.Contexts.Add(cd.Name, cd);
                    }
                    else throw new InvalidOperationException($"Context type {contextInfo.contextType.name} doesn't exist.");
                }
            }

            if (modelInfo.conversionInfo is not null)
            {
                foreach (var conversion in modelInfo.conversionInfo)
                {
                    if (TryGetType(conversion.fromType, out var from) &&
                        TryGetType(conversion.toType, out var to))
                    {
                        var fromSpecifier = from.ToTypeSpecifier();
                        if (!modelDefinition.ImplicitConversions.TryGetValue(fromSpecifier, out var conversionsFrom))
                        {
                            conversionsFrom = new(EqualityComparer<Model.TypeSpecifier>.Default);
                            modelDefinition.ImplicitConversions.Add(fromSpecifier, conversionsFrom);
                        }
                        var toSpecifier = to.ToTypeSpecifier();
                        if (conversionsFrom.TryGetValue(toSpecifier, out var existing))
                            throw new InvalidOperationException($"Conversion from {conversion.fromType} to {conversion.toType} is already defined.");
                        else conversionsFrom.Add(toSpecifier, conversion.functionName);
                    }
                    else throw new InvalidOperationException($"onversion {conversion.fromType} to {conversion.toType} has types that cannot be resolved.");
                }
            }


            return modelDefinition;

            Hl7.Cql.Model.TypeSpecifier getElementTypeSpecifier(string? name, Xml.TypeSpecifier? elementTypeSpecifier)
            {
                if (!string.IsNullOrWhiteSpace(name))
                {
                    if (TryGetType(name, out var elementType))
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
                    return GetNamedTypeSpecifierOrThrow(qualify(nts.name, modelDefinition));
                }
                else if (elementTypeSpecifier is Xml.ListTypeSpecifier lts)
                {
                    if (TryGetType("System.List", out var listType))
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
                    if (TryGetType("System.Interval", out var intervalType))
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
            string qualify(string name, ModelDefinition model)
            {
                var parts = name.Split('.');
                if (parts.Length == 1)
                    return $"{model.Name}.{name}";
                else if (parts.Length > 1)
                {
                    if (parts[0] != model.Name)
                        return $"{model.Name}.{name}";
                    else return name;
                }
                else throw new ArgumentException("Name must have at least one part", nameof(name));
            }
        }

        public bool TryGetModel(string modelName, string? version, [NotNullWhen(true)] out ModelDefinition? model)
        {
            if (ByName.TryGetValue(modelName, out var byVersion))
            {
                if (version is null)
                {
                    var highestVersion = byVersion.Keys.OrderByDescending(key => Version.Parse(key))
                        .FirstOrDefault();
                    if (highestVersion is not null)
                    {
                        model = byVersion[highestVersion];
                        return true;
                    }
                    else
                    {
                        model = null;
                        return false;
                    }
                }
                else
                    return byVersion.TryGetValue(version ?? string.Empty, out model);
            }
            else
            {
                var mi = ResolveByNameAndVersion(modelName, version);
                if (mi is not null)
                {
                    model = Load(mi);
                    return true;
                }
                else
                {
                    model = null;
                    return false;
                }
            }
        }

        public bool TryGetModelFromUri(string uri, [NotNullWhen(true)] out ModelDefinition? model)
        {
            if (ByUri.TryGetValue(uri, out model))
                return true;
            else
            {
                var mi = ResolveByUri(uri);
                if (mi is not null)
                {
                    model = Load(mi);
                    return true;
                }
                else
                {
                    model = null;
                    return false;
                }
            }


        }

        public bool TryGetType(string qualifiedName, [NotNullWhen(true)] out Model.TypeDefinition? type)
        {
            if (qualifiedName.StartsWith('{'))
            {
                var closingIndex = qualifiedName.IndexOf('}', 1);
                var uri = qualifiedName.Substring(1, closingIndex - 1);
                if (ByUri.TryGetValue(uri, out var model))
                {
                    var dotDelimited = $"{model.Name}.{qualifiedName.Substring(closingIndex + 1)}";
                    return model.TryGetType(dotDelimited, out type);
                }
                else
                {
                    type = null;
                    return false;
                }
            }
            else
            {
                var leftAngleIndex = qualifiedName.IndexOf('<');
                if (leftAngleIndex > 0)
                {
                    var rightAngleIndex = qualifiedName.LastIndexOf('>');
                    if (rightAngleIndex > 0)
                    {
                        var genericTypeName = qualifiedName.Substring(0, leftAngleIndex);
                        var genericArgNames = qualifiedName.Substring(leftAngleIndex + 1, rightAngleIndex - leftAngleIndex - 1)
                            .Split(',');
                        var genericType = getType(genericTypeName);
                        if (genericType is not null && genericType is GenericTypeDefinition gtd)
                        {
                            var genericArgs = new Model.TypeSpecifier[genericArgNames.Length];
                            for (int i = 0; i < genericArgNames.Length; i++)
                            {
                                if (TryGetType(genericArgNames[i], out var argType))
                                {
                                    var argSpecifier = argType.ToTypeSpecifier();
                                    genericArgs[i] = argSpecifier;
                                }
                                else
                                {
                                    type = null;
                                    return false;
                                }
                            }
                            type = gtd.MakeGenericType(genericArgs);
                            return true;
                        }
                        else
                        {
                            type = null;
                            return false;
                        }


                    }
                    else throw new ArgumentException($"If a qualified name contains a < character it must also contain a closing > character.");
                }
                else
                {
                    type = getType(qualifiedName);
                    return type is not null;

                }
                throw new ArgumentException($"Qualified name {qualifiedName} is not a URI qualified name.", nameof(qualifiedName));

                TypeDefinition? getType(string qname)
                {
                    var dotIndex = qname.IndexOf('.');
                    string modelName;
                    if (dotIndex < 0)
                    { // if not qualified, assume System
                        modelName = "System";
                        qname = "System." + qname;
                    }
                    else
                        modelName = qname.Substring(0, dotIndex);
                    if (ByName.TryGetValue(modelName, out var model))
                    {
                        var models = new List<ModelDefinition>();
                        TypeDefinition? found = null;
                        foreach (var bnbv in model.Values)
                        {
                            if (bnbv.TryGetType(qname, out found))
                                models.Add(bnbv);
                        }
                        if (models.Count == 0)
                        {
                            return null;
                        }
                        if (models.Count > 1)
                            throw new ArgumentException($"Type name {qname} is ambiguous in model {modelName} in versios {string.Join(", ", models.Select(m => m.Version))}.");
                        else
                        {
                            return found;
                        }
                    }
                    return null;
                }
            }
        }

        private Model.NamedTypeSpecifier GetNamedTypeSpecifierOrThrow(string qualifiedName)
        {
            if (TryGetType(qualifiedName, out var type))
                return type switch
                {
                    SimpleTypeDefinition std => (Model.NamedTypeSpecifier)std.ToTypeSpecifier(),
                    ClassTypeDefinition ctd => (Model.NamedTypeSpecifier)ctd.ToTypeSpecifier(),
                    _ => throw new InvalidOperationException($"Type's specifier will not be a named type specifier.")
                };
            else throw new InvalidOperationException($"Type {qualifiedName} not found.");
        }


    }
}
