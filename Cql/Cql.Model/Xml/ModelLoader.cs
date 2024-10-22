using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using TypeSpecifier = Hl7.Cql.Model.TypeSpecifier;

namespace Hl7.Cql.Model.Xml
{
    internal class ModelLoader
    {
        public ModelLoader(Func<string, ModelInfo> resolveModel)
        {
            ResolveModel = resolveModel;
        }

        private readonly Func<string, ModelInfo> ResolveModel;

        private Dictionary<string, ModelDefinition> Models = new();

        public void Load(ModelInfo modelInfo)
        {
            var modelDefinition = new ModelDefinition(modelInfo.name, modelInfo.version, modelInfo.url);
            var modelTypes = new Dictionary<string, TypeDefinition>();
            modelDefinition.TypeDefinitions = modelTypes;
            Models.Add(modelInfo.name, modelDefinition);
            foreach (var requiredModel in modelInfo.requiredModelInfo ?? [])
            {
                if (!Models.TryGetValue(requiredModel.name, out var requiredModelDefinition))
                {
                    var mi = ResolveModel(requiredModel.name);
                    Load(mi);
                }
            }
            // create the type stubs.  these will be populated later.
            foreach (var typeInfo in modelInfo.typeInfo)
            {
                if (typeInfo is SimpleTypeInfo simpleType)
                {
                    var name = qualify(simpleType.name, modelDefinition);
                    modelTypes.Add(name, new SimpleTypeDefinition(name, modelDefinition));
                }
                else if (typeInfo is ClassInfo classType)
                {
                    var name = qualify(classType.name, modelDefinition);
                    modelTypes.Add(name, new ClassTypeDefinition(name, modelDefinition));
                }
                else throw new InvalidOperationException($"Unrecognized TypeInfo type {typeInfo.GetType().Name}");
            }
            if (TryGetType("System.Any", out var anyType))
            {
                var anyTs = anyType switch
                {
                    SimpleTypeDefinition st => st.ToTypeSpecifier(),
                    _=>throw new InvalidOperationException($"Expecting Any to be a simple type.")
                };
                if (modelInfo.name == "System")
                {
                    var listType = new GenericTypeDefinition("System.List", modelDefinition,
                        new Dictionary<string, Model.TypeSpecifier> { { "T", anyTs } });

                    TypeDefinition[] intervalTypes = [
                        GetTypeOrThrow("System.Integer"),
                        GetTypeOrThrow("System.Long"),
                        GetTypeOrThrow("System.Decimal"),
                        GetTypeOrThrow("System.Quantity"),
                        GetTypeOrThrow("System.Ratio"),
                        GetTypeOrThrow("System.Date"),
                        GetTypeOrThrow("System.Time"),
                        GetTypeOrThrow("System.DateTime")
                    ];
                    var intervalChoiceSpecifiers = intervalTypes
                        .Select(t => t switch
                        {
                            SimpleTypeDefinition std => std.ToTypeSpecifier(),
                            _ => throw new InvalidOperationException($"Expecting interval types to be simple types.")
                        })
                        .ToArray();
                    var intervalChoiceType = new Model.ChoiceTypeSpecifier(intervalChoiceSpecifiers);
                    var intervalType = new GenericTypeDefinition("System.Interval", modelDefinition,
                        new Dictionary<string, Model.TypeSpecifier> { { "T", intervalChoiceType } });

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
                        if (TryGetType(simpleTypeInfo.baseType, out var baseType))
                            simpleTypeDef.BaseType = baseType;

                        else throw new InvalidOperationException($"Type {simpleTypeInfo.baseType} not found.");
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
                        var elements = new List<ClassTypeElementDefinition>();
                        foreach (var elementInfo in classInfo.element)
                        {

                        }
                    }
                    else throw new InvalidOperationException($"ClassTypeInfo should translate to SimpleTypeDefinition.");

                }
                else throw new InvalidOperationException($"Unrecognized TypeInfo type {typeInfo.GetType().Name}");
            }

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

        public bool TryGetModel(string name, [NotNullWhen(true)] out ModelDefinition? model) =>        
            Models.TryGetValue(name, out model);

        private Hl7.Cql.Model.TypeSpecifier GetElementTypeSpecifier(string? name, Xml.TypeSpecifier? elementTypeSpecifier)
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
            else if (elementTypeSpecifier is Xml.ListTypeSpecifier lts)
            {
                if (TryGetType("System.List", out var listType))
                {
                    if (listType is GenericTypeDefinition gtd)
                    {
                        var elementTs = GetElementTypeSpecifier(lts.elementType, lts.elementTypeSpecifier);
                        return gtd.ToTypeSpecifier([elementTs]);
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
                        var elementTs = GetElementTypeSpecifier(its.pointType, its.pointTypeSpecifier);
                        return gtd.ToTypeSpecifier([elementTs]);
                    }
                    else throw new InvalidOperationException($"List type is not generic.");
                }
                else throw new InvalidOperationException("Interval type is not defined.");
            }
            else if (elementTypeSpecifier is Xml.ChoiceTypeSpecifier cts)
            {
                var choices = cts.choice
                    .Select(c => GetElementTypeSpecifier(null, c))
                    .ToArray();
                var choiceTs = new Model.ChoiceTypeSpecifier(choices);
                return choiceTs;
            }
            else throw new NotSupportedException();
        }

        private bool TryGetType(string qualifiedName, [NotNullWhen(true)] out TypeDefinition? type)
        {
            foreach (var model in Models)
            {
                if (model.Value.TryGetType(qualifiedName, out type))
                    return true;
            }
            type = null;
            return false;
        }

        private TypeDefinition GetTypeOrThrow(string qualifiedName)
        {
            if (TryGetType(qualifiedName, out var type))
                return type;
            else throw new InvalidOperationException($"Type {qualifiedName} not found.");
        }
    }
}
