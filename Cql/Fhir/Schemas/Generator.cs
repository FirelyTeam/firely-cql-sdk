using Ncqa.Fhir.Schemas;
using Ncqa.Graph;
using Ncqa.Iso8601;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;

namespace Ncqa.Fhir.Schemas
{
    public class Generator
    {
        public IDictionary<string, Type> Generate(r4.Schema r4, r4.Bundle profiles)
        {
            var graph = GetBuildOrder(profiles, false);
            using (var stream = new FileInfo("fhir-graph.json").OpenWrite())
            {
                graph.SerializeToJson(stream);
            }
            graph = GetBuildOrder(profiles, true);
            var asmName = "Ncqa.Fhir.Schemas.R4";
            var assemblyBuilder = AssemblyBuilder.DefineDynamicAssembly(new System.Reflection.AssemblyName(asmName), AssemblyBuilderAccess.Run);
            var moduleBuilder = assemblyBuilder.DefineDynamicModule(asmName);

            var types = new Dictionary<string, TypeBuilder>(StringComparer.OrdinalIgnoreCase);
            var roots = graph.StartNode.ForwardEdges
                .Select(edge => graph.Nodes[edge.ToId])
                //.Where(r => r.NodeId == "http://hl7.org/fhir/StructureDefinition/Resource")
                .ToArray();
            foreach (var root in roots)
            {
                BuildType(moduleBuilder, types, r4, graph, root, null);
            }
            var properties = new Dictionary<Type, Dictionary<string, PropertyBuilder>>();
            foreach (var kvp in graph.Nodes)
            {
                var node = kvp.Value;
                // get the stored resource on the digraph node's properties collection
                if (node.Properties?.TryGetValue("Resource", out var resourceProp) ?? false)
                {
                    if (types.TryGetValue(kvp.Key, out var typeBuilder))
                    {
                        if (resourceProp is r4.EntryResource resource)
                        {
                            // constraints are things like MoneyQuantity vs. Quantity.  They don't have new members.
                            if (resource.Derivation != "constraint")
                            {
                                var elements = resource?.Snapshot?.Element ?? Array.Empty<r4.SnapshotElement>();
                                if (elements.Length > 0)
                                {
                                    var tree = GetElementTree(resource!.Id!, elements);
                                    if (tree != null)
                                    {
                                        DefineMembers(types, properties, typeBuilder, tree);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            var built = types.ToDictionary(kvp => kvp.Key, kvp => kvp.Value.CreateType());
            return built;
        }


        private static readonly Regex Indexer = new Regex("(?<name>\\S+)\\[\\S+\\]", RegexOptions.Compiled);

        private void DefineMembers(Dictionary<string, TypeBuilder> allTypes, 
            Dictionary<Type, Dictionary<string, PropertyBuilder>> allProperties, 
            TypeBuilder thisType, 
            ElementAndChildren tree)
        {
            var directProperties = tree.Children
                .Where(child => 
                    child!.Element!.Path!.StartsWith($"{tree.Element!.Path}.") 
                        && child.Element.Path.Substring(tree.Element!.Path!.Length+1).Count(c => c == '.') == 0)
                .ToList();
            foreach (var propertyElement in directProperties)
            {
                Type? propertyType = null;
                var componentTypeName = ResourceIdToComponentTypeName(thisType, propertyElement.Element!.Path!);
                if (allTypes.TryGetValue(componentTypeName, out var componentType))
                {
                    propertyType = componentType;
                }
                string propertyName = propertyElement.Element.Id!;
                var lastDot = propertyName.LastIndexOf('.');
                if (lastDot > -1)
                {
                    propertyName = propertyName.Substring(lastDot + 1);
                }
                var match = Indexer.Match(propertyName);
                if (match.Success)
                {
                    propertyName = match.Groups["name"].Value;
                }
                if (!allProperties.TryGetValue(thisType, out var propertiesForType))
                {
                    propertiesForType = new Dictionary<string, PropertyBuilder>();
                    allProperties.Add(thisType, propertiesForType);
                }

                var inherits = false;
                var baseType = thisType.BaseType;
                while (baseType != null)
                {
                    if (allProperties.TryGetValue(baseType, out var baseProperties))
                    {
                        if (baseProperties.ContainsKey(propertyName))
                            inherits = true;
                    }
                    baseType = baseType.BaseType;
                }
                if (!inherits && !propertiesForType.TryGetValue(propertyName, out var builder))
                {
                    if (propertyElement.Element.Type?.Length == 1)
                    {
                        // resource.id is incorrectly named as a string value in the structure definition
                        // but is assumed to be an IdElement in CQL.
                        if (propertyElement.Element.Path == "Resource.id")
                            propertyType = allTypes["http://hl7.org/fhir/StructureDefinition/id"];
                        else propertyType = propertyType ?? ElementCodeToType(propertyElement.Element.Type[0].Code!, allTypes);
                        var propertyBuilder = DefineProperty(thisType, propertyName, propertyType!, propertyElement.Element.Min, propertyElement.Element.Max!, propertyElement.Element.Binding!);
                        propertiesForType.Add(propertyName, propertyBuilder);
                    }
                    else if (propertyElement.Element.Type?.Length > 1)
                    {
                        var types = propertyElement.Element.Type.Select(t => ElementCodeToType(t.Code!, allTypes))
                            .ToArray();
                        var commonBaseType = GetCommonBaseClass(types!);
                        var propertyBuilder = DefineProperty(thisType, propertyName, commonBaseType, propertyElement.Element.Min, propertyElement.Element.Max!, propertyElement.Element.Binding!, types!);
                        propertiesForType.Add(propertyName, propertyBuilder);
                    }
                }
            }

            var withoutEnclosingPath = tree.Children
                .Where(child => child.Element!.Path.Count(c => c == '.') > 1)
                .Select(child => KeyValuePair.Create(child.Element!.Path!.Substring(tree.Element!.Path!.Length + 1), child.Element))
                .ToList();
            if (withoutEnclosingPath.Any())
            {
                var byNestedType = withoutEnclosingPath
                    .Where(kvp => kvp.Key.IndexOf('.') > -1)
                    .GroupBy(kvp =>
                    kvp.Key.Substring(0, kvp.Key.IndexOf('.')))
                    .ToList();
                foreach (var group in byNestedType)
                {
                    var nodeForNestedType = tree.Children
                        .Single(child => child.Element!.Path == $"{tree.Element!.Path}.{group.Key}");
                    var className = ResourceIdToComponentTypeName(thisType, nodeForNestedType.Element!.Path!);
                    if (allTypes.TryGetValue(className, out var nestedType))
                    {
                        DefineMembers(allTypes, allProperties, nestedType, nodeForNestedType);
                    }
                    else throw new InvalidOperationException($"Type {className} should exist in the allTypes dictionary, but doesn't");
                }
            }
        }

        private string ResourceIdToComponentTypeName(TypeBuilder enclosingType, string id)
        {
            var parts = id.Split('.');
            if (parts.Length > 1)
            {
                string componentName = parts[parts.Length - 1];
                if (char.IsLower(componentName[0]))
                {
                    componentName = char.ToUpper(componentName[0]) + componentName.Substring(1);
                }
                parts[parts.Length - 1] = $"{componentName}Component";
                var className = string.Join("+", parts);
                return className;
            }
            else throw new ArgumentException("id should have at least 1 dot", nameof(id));
        }

        private Type? ElementCodeToType(string code, Dictionary<string, TypeBuilder> types)
        {
            code = code.ToLowerInvariant();
            if (!code.StartsWith("http://hl7.org/fhirpath/"))
            {
                var structureDefUri = $"http://hl7.org/fhir/StructureDefinition/{code}";
                if (types.TryGetValue(structureDefUri, out var type))
                    return type;
            }
            switch (code)
            {
                case "http://hl7.org/fhirpath/system.string":
                    return typeof(string);
                case "http://hl7.org/fhirpath/system.boolean":
                    return typeof(bool?);
                case "http://hl7.org/fhirpath/system.date":
                    return typeof(DateIso8601);
                case "http://hl7.org/fhirpath/system.datetime":
                    return typeof(DateTimeIso8601);
                case "http://hl7.org/fhirpath/system.time":
                    return typeof(TimeIso8601);
                case "http://hl7.org/fhirpath/system.decimal":
                    return typeof(decimal?);
                case "http://hl7.org/fhirpath/system.integer":
                    return typeof(int?);
                default: throw new ArgumentException($"Type {code} not understood");
            }
        }

        private void BuildType(ModuleBuilder module, Dictionary<string, TypeBuilder> allTypes,
            r4.Schema r4,
            DirectedGraph graph,
            DirectedGraphNode node, Type? parentType = null)
        {
            var resource = node.Properties?["Resource"] as r4.EntryResource;
            if (resource != null)
            {
                // Operation definitions can be skipped.
                if (resource.ResourceType == "StructureDefinition")
                {
                    var typeName = resource.Id!;
                    if (char.IsLower(typeName[0]))
                    {
                        typeName = char.ToUpper(typeName[0]) + typeName.Substring(1);
                    }
                    if (resource.Kind == "primitive-type")
                    {
                        typeName = $"{typeName}Element";
                    }
                    if (module.GetType(typeName) == null)
                    {
                        var flags = TypeAttributes.Public | TypeAttributes.Class;
                        if (resource.Abstract ?? false)
                            flags |= TypeAttributes.Abstract;

                        var type = module.DefineType(typeName, flags, parentType);
                        string? resourceUri = null;
                        if (resource.Url!.AbsoluteUri.StartsWith("http://hl7.org/fhir/StructureDefinition/"))
                        {
                            resourceUri = resource.Url.AbsoluteUri;
                            var uriAttribute = new CustomAttributeBuilder(typeof(FhirUriAttribute)
                                .GetConstructor(new[] { typeof(string) }), new[] { resource.Url.AbsoluteUri });
                            type.SetCustomAttribute(uriAttribute);
                        }

                        allTypes.Add(node.NodeId, type);
                        if (resource?.Snapshot?.Element?.Length > 0)
                        {
                            var tree = GetElementTree(resource.Id!, resource.Snapshot.Element);
                            if (tree != null)
                            {
                                BuildComponentTypes(tree, type, tree.Element!.Path!, allTypes, resourceUri);
                            }

                        }
                        var forwardNodes = from n in graph.Nodes.Values
                                           join id in node.ForwardEdges.Select(edge => edge.ToId) on n.NodeId equals id
                                           select n;
                        foreach (var child in forwardNodes)
                        {
                            BuildType(module, allTypes, r4, graph, child, type);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Recursively builds any nested types in this element tree
        /// </summary>
        private void BuildComponentTypes(ElementAndChildren tree,
            TypeBuilder enclosingType,
            string enclosingPath,
            Dictionary<string, TypeBuilder> allTypes,
            string? resourceUri)
        {
            // Tree contains all children elements, including properties, of the enclosing type
            // Their keys will be in the form:
            //      enclosingType.directMemberProperty1
            //      enclosingType.directMemberProperty2
            //
            // We are only looking for nested types, which exist if the tree has keys of the form:
            //      enclosingType.nestedType1.directMemberPropertyOnNestedType1
            //      enclosingType.nestedType1.nestedType2.directMemberPropertyOnNestedType2
            //
            // We can identify unique groups of nested types by looking for more than 1 period in the path.

            var withoutEnclosingPath = tree.Children
                .Where(child => child.Element!.Path.Count(c => c == '.') > 1)
                .Select(child => KeyValuePair.Create(child.Element!.Path!.Substring(enclosingPath.Length + 1), child.Element))
                .ToList();

            if (withoutEnclosingPath.Any())
            {
                var byNestedType = withoutEnclosingPath
                    .Where(kvp => kvp.Key.IndexOf('.') > -1)
                    .GroupBy(kvp =>
                    kvp.Key.Substring(0, kvp.Key.IndexOf('.')))
                    .ToList();
                foreach (var group in byNestedType)
                {
                    var nodeForNestedType = tree.Children
                        .Single(child => child.Element!.Path == $"{enclosingPath}.{group.Key}");
                    var className = ResourceIdToComponentTypeName(enclosingType, nodeForNestedType.Element!.Path!);
                    var nested = enclosingType.DefineNestedType(className, TypeAttributes.Class | TypeAttributes.Public | TypeAttributes.NestedFamily);

                    if (resourceUri != null)
                    {
                        var nestedUri = $"http://hl7.org/fhir/StructureDefinition/{nodeForNestedType.Element.Path!}";
                        var uriAttribute = new CustomAttributeBuilder(typeof(FhirUriAttribute)
                            .GetConstructor(new[] { typeof(string) }), new[] { nestedUri });
                        nested.SetCustomAttribute(uriAttribute);
                    }
                    allTypes.Add(className, nested);
                    BuildComponentTypes(nodeForNestedType, nested, nodeForNestedType.Element.Path!, allTypes, resourceUri);
                }
            }
        }

        private DirectedGraph GetBuildOrder(r4.Bundle profiles, bool writeProperties)
        {
            var graph = new DirectedGraph();
            var entries = profiles.Entry;
            var rootElements = profiles.Entry.Where(def => def.Resource!.BaseDefinition == null);
            var toExamine = new Queue<DirectedGraphNode>();
            foreach (var root in rootElements)
            {
                var props = writeProperties ? new Dictionary<string, object> { { "Resource", root.Resource! } } : null;
                var node = new DirectedGraphNode
                {
                    NodeId = root.FullUrl!.ToString(),
                    Label = root.Resource!.Id,
                    Properties = props,
                };
                graph.Add(node);
                var edge = new DirectedGraphEdge(graph.StartNode, node);
                graph.Add(edge);
                graph.StartNode.ForwardEdges.Add(edge);
                toExamine.Enqueue(node);
            }

            //var remaining = profiles.Entry.Where(def => def.Resource.BaseDefinition != null).ToList();
            while (toExamine.Count > 0)
            {
                var parent = toExamine.Dequeue();
                var children = profiles.Entry
                    .Where(e => e.Resource!.BaseDefinition != null && e.Resource.BaseDefinition.ToString() == parent.NodeId)
                    .ToArray();
                if (children.Length > 0)
                {
                    foreach (var child in children)
                    {
                        var props = writeProperties ? new Dictionary<string, object> { { "Resource", child.Resource! } } : null;
                        var node = new DirectedGraphNode
                        {
                            NodeId = child.FullUrl!.ToString(),
                            Label = child.Resource!.Id,
                            Properties = props,
                        };
                        graph.Add(node);
                        var edge = new DirectedGraphEdge(parent, node);
                        graph.Add(edge);
                        parent.ForwardEdges.Add(edge);
                        toExamine.Enqueue(node);
                    }
                }
                else
                {
                    var edge = new DirectedGraphEdge(parent, graph.EndNode);
                    parent.ForwardEdges.Add(edge);
                    graph.Add(edge);
                }
            }


            return graph;
        }

        private static PropertyBuilder DefineProperty(TypeBuilder myTypeBuilder,
            string normalizedName,
            Type type,
            long min,
            string max,
            r4.ElementBinding binding,
            Type[]? allowedDerviedTypes = null)
        {
            if (type.IsValueType)
            {
                if (min == 0)
                {
                    if (max == "1")
                    {
                        if (!type.IsGenericType || type.GetGenericTypeDefinition() != typeof(Nullable<>))
                            type = typeof(Nullable<>).MakeGenericType(type);
                    }
                    else if (max == "*")
                    {
                        type = typeof(ICollection<>).MakeGenericType(type);
                    }
                }
            }
            else if (max == "*")
            {
                if (myTypeBuilder.Name == "Bundle" && normalizedName == "entry")
                {
                    type = typeof(IEntryCollection<>).MakeGenericType(type);
                }
                else
                {
                    type = typeof(ICollection<>).MakeGenericType(type);
                }
            }
            var fieldBuilder = myTypeBuilder.DefineField($"_{normalizedName}", type, FieldAttributes.Private);
            var propertyBuilder = myTypeBuilder.DefineProperty(normalizedName, PropertyAttributes.None, type, null);
            if (!type.IsValueType && min == 1 && max == "1")
            {
                var notNullAttribute = new CustomAttributeBuilder(typeof(System.Diagnostics.CodeAnalysis.NotNullAttribute).GetConstructor(Array.Empty<Type>()), Array.Empty<object>());
                propertyBuilder.SetCustomAttribute(notNullAttribute);
            }
            if (allowedDerviedTypes != null)
            {
                foreach (var allowedType in allowedDerviedTypes)
                {
                    var typeName = allowedType.FullName;
                    var choiceTypeAttribute = new CustomAttributeBuilder(typeof(ChoiceTypeByNameAttribute).GetConstructor(new[] { typeof(string) }), new[] { typeName });
                    propertyBuilder.SetCustomAttribute(choiceTypeAttribute);
                }
                var jsonIgnore = new CustomAttributeBuilder(typeof(System.Text.Json.Serialization.JsonIgnoreAttribute).GetConstructor(new Type[0]), new object[0]);
                propertyBuilder.SetCustomAttribute(jsonIgnore);
            }
            if (binding != null && binding.ValueSet != null)
            {
                var bindingNameEtension = binding.Extension.SingleOrDefault(e => e.Url!.AbsoluteUri == "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName");
                if (bindingNameEtension != null)
                {
                    bool required = false;
                    if (binding.Strength == "required")
                        required = true;
                    var ctor = typeof(ValueSetBindingAttribute).GetConstructor(new[] { typeof(string), typeof(string), typeof(bool) });
                    var valueSetBindingAttribute = new CustomAttributeBuilder(ctor, new object[]
                    {
                        bindingNameEtension.ValueString!,
                        binding.ValueSet.AbsoluteUri,
                        required
                    });
                    propertyBuilder.SetCustomAttribute(valueSetBindingAttribute);
                }
            }


            //propertyBuilder.SetCustomAttribute(customAttributeBuilder);
            MethodAttributes attributes = MethodAttributes.Public
                    | MethodAttributes.SpecialName
                    | MethodAttributes.HideBySig;
            {
                var get = myTypeBuilder.DefineMethod($"get_{normalizedName}", attributes, type, Type.EmptyTypes);
                ILGenerator getIL = get.GetILGenerator();
                getIL.Emit(OpCodes.Ldarg_0);
                getIL.Emit(OpCodes.Ldfld, fieldBuilder);
                getIL.Emit(OpCodes.Ret);
                propertyBuilder.SetGetMethod(get);
            }

            {
                var set = myTypeBuilder.DefineMethod($"set_{normalizedName}", attributes, null, new Type[] { type });
                ILGenerator setIL = set.GetILGenerator();
                setIL.Emit(OpCodes.Ldarg_0);
                setIL.Emit(OpCodes.Ldarg_1);
                setIL.Emit(OpCodes.Stfld, fieldBuilder);
                setIL.Emit(OpCodes.Ret);
                propertyBuilder.SetSetMethod(set);
            }
            return propertyBuilder;
        }

        private ElementAndChildren? GetElementTree(string path, r4.SnapshotElement[] all)
        {
            var elements = all.Where(el => el.Path == path).ToArray();
            if (elements.Length == 0)
                return null;
            else if (elements.Length > 1)
                throw new InvalidOperationException($"This snapshot has more than one element with path {path}");
            var element = elements[0];
            if (string.Equals(path, "CapabilityStatement.rest.interaction", StringComparison.OrdinalIgnoreCase))
            {
            }
            var byPath = all.Where(el => el.Path!.StartsWith($"{path}."))
                .GroupBy(el => el.Path);
            var related = byPath
                .Select(g => g.First())
                .ToArray();

            var node = new ElementAndChildren
            {
                Element = element,
                Children = new List<ElementAndChildren>()
            };
            foreach (var el in related)
            {
                if (el == element)
                    continue;
                var child = GetElementTree(el.Path!, all);
                if (child != null)
                {
                    node.Children.Add(child);
                }
            }
            return node;
        }

        [DebuggerDisplay("{Element.Path}")]
        private class ElementAndChildren
        {
            public r4.SnapshotElement? Element { get; set; }

            public List<ElementAndChildren>? Children { get; set; }
        }

        // https://stackoverflow.com/questions/353430/easiest-way-to-get-a-common-base-class-from-a-collection-of-types
        public static Type GetCommonBaseClass(params Type[] types)
        {
            if (types.Length == 0)
                return typeof(object);

            Type ret = types[0];

            for (int i = 1; i < types.Length; ++i)
            {
                if (types[i].IsAssignableFrom(ret))
                    ret = types[i];
                else
                {
                    // This will always terminate when ret == typeof(object)
                    while (!ret.IsAssignableFrom(types[i]))
                        ret = ret.BaseType;
                }
            }

            return ret;
        }

    }
}
