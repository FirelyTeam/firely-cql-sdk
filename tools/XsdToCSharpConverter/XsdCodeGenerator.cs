/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.CodeDom;
using System.CodeDom.Compiler;
using System.Reflection;
using System.Text;
using System.Xml;
using System.Xml.Schema;

namespace XsdToCSharpConverter;

/// <summary>
/// Native XSD to C# code generator that parses XSD files and generates C# classes.
/// </summary>
internal class XsdCodeGenerator
{
    private readonly CommandLineOptions _options;
    private readonly Dictionary<XmlQualifiedName, CodeTypeDeclaration> _generatedTypes = new();
    private readonly Dictionary<string, (string elementName, string? targetNamespace)> _rootElements = new();
    private readonly Dictionary<string, List<string>> _typeHierarchy = new(); // base type -> list of derived types
    private XmlSchemaSet? _schemaSet;
    private readonly string _toolVersion;

    public XsdCodeGenerator(CommandLineOptions options)
    {
        _options = options;
        // Get the assembly version for the GeneratedCodeAttribute
        _toolVersion = Assembly.GetExecutingAssembly().GetName().Version?.ToString() ?? "1.0.0.0";
    }

    public void Generate()
    {
        // Load and compile schemas
        LoadSchemas();

        // Generate code namespace
        var codeNamespace = new CodeNamespace(_options.Namespace);
        AddImports(codeNamespace);

        // Generate types from schemas
        GenerateTypes(codeNamespace);

        // Write output
        WriteOutput(codeNamespace);
    }

    private void LoadSchemas()
    {
        _schemaSet = new XmlSchemaSet();
        _schemaSet.ValidationEventHandler += OnValidationEvent;

        foreach (var schemaFile in _options.SchemaFiles)
        {
            if (!File.Exists(schemaFile))
            {
                throw new FileNotFoundException($"Schema file not found: {schemaFile}");
            }

            using var reader = XmlReader.Create(schemaFile);
            var schema = XmlSchema.Read(reader, OnValidationEvent);
            if (schema != null)
            {
                _schemaSet.Add(schema);
            }
        }

        _schemaSet.Compile();
    }

    private void OnValidationEvent(object? sender, ValidationEventArgs e)
    {
        if (e.Severity == XmlSeverityType.Error)
        {
            Console.Error.WriteLine($"Schema Error: {e.Message}");
        }
    }

    private void AddImports(CodeNamespace codeNamespace)
    {
        codeNamespace.Imports.Add(new CodeNamespaceImport("System.Xml.Serialization"));
    }

    private void GenerateTypes(CodeNamespace codeNamespace)
    {
        if (_schemaSet == null) return;

        // First pass: Track global elements that reference named types for XmlRootAttribute
        // Also build a list of type names referenced by global elements (for ordering)
        var rootElementTypeNames = new HashSet<string>();
        foreach (XmlSchema schema in _schemaSet.Schemas())
        {
            foreach (XmlSchemaElement element in schema.Elements.Values)
            {
                if (!string.IsNullOrEmpty(element.Name) && !element.SchemaTypeName.IsEmpty)
                {
                    var typeName = element.SchemaTypeName.Name;
                    if (!string.IsNullOrEmpty(typeName))
                    {
                        _rootElements[typeName] = (element.Name, schema.TargetNamespace);
                        rootElementTypeNames.Add(typeName);
                    }
                }
            }
        }

        // Second pass: Generate types in the same order as xsd.exe
        // xsd.exe generates types referenced by global elements first, then other types in document order
        var rootTypes = new List<CodeTypeDeclaration>();
        var otherTypes = new List<CodeTypeDeclaration>();

        // Process all schemas in the schema set (including imported ones)
        foreach (XmlSchema currentSchema in _schemaSet.Schemas())
        {
            // Skip schemas that are not in our main namespace (e.g., skip xsd namespace itself)
            if (currentSchema.TargetNamespace == "http://www.w3.org/2001/XMLSchema")
                continue;

            // Generate types from this schema in document order
            var schemaItems = currentSchema.Items;
            foreach (XmlSchemaObject item in schemaItems)
            {
                CodeTypeDeclaration? codeType = null;
                string? typeName = null;

                if (item is XmlSchemaComplexType complexType && !string.IsNullOrEmpty(complexType.Name))
                {
                    typeName = complexType.Name;
                    codeType = GenerateComplexType(complexType, currentSchema.TargetNamespace);
                }
                else if (item is XmlSchemaSimpleType simpleType && !string.IsNullOrEmpty(simpleType.Name))
                {
                    typeName = simpleType.Name;
                    codeType = GenerateSimpleType(simpleType, currentSchema.TargetNamespace);
                }
                else if (item is XmlSchemaElement element && !string.IsNullOrEmpty(element.Name) && element.SchemaType is XmlSchemaComplexType elemComplexType)
                {
                    typeName = element.Name;
                    codeType = GenerateComplexType(elemComplexType, currentSchema.TargetNamespace, element.Name);
                }

                if (codeType != null && typeName != null)
                {
                    // Types referenced by global elements go first
                    if (rootElementTypeNames.Contains(typeName))
                    {
                        rootTypes.Add(codeType);
                    }
                    else
                    {
                        otherTypes.Add(codeType);
                    }
                }
            }
        }

        // Add root element types first, then other types
        foreach (var type in rootTypes)
        {
            codeNamespace.Types.Add(type);
        }
        foreach (var type in otherTypes)
        {
            codeNamespace.Types.Add(type);
        }

        // Third pass: Add XmlIncludeAttribute for derived types
        AddXmlIncludeAttributes();
    }

    private void AddXmlIncludeAttributes()
    {
        // For each base type, add XmlIncludeAttribute for all derived types
        foreach (var (baseTypeName, derivedTypes) in _typeHierarchy)
        {
            // Find the base type declaration
            var baseType = _generatedTypes.Values.FirstOrDefault(t => t.Name == baseTypeName);
            if (baseType == null) continue;

            // Add XmlIncludeAttribute for each derived type
            foreach (var derivedTypeName in derivedTypes.OrderBy(n => n))
            {
                var xmlIncludeAttr = new CodeAttributeDeclaration(
                    "System.Xml.Serialization.XmlIncludeAttribute",
                    new CodeAttributeArgument(new CodeTypeOfExpression(derivedTypeName))
                );
                baseType.CustomAttributes.Add(xmlIncludeAttr);
            }
        }
    }

    private CodeTypeDeclaration? GenerateComplexType(XmlSchemaComplexType complexType, string? targetNamespace, string? elementName = null)
    {
        var typeName = elementName ?? complexType.Name;
        if (string.IsNullOrEmpty(typeName))
        {
            return null;
        }

        // Check if already generated
        var qualifiedName = new XmlQualifiedName(typeName, targetNamespace ?? "");
        if (_generatedTypes.ContainsKey(qualifiedName))
        {
            return null;
        }

        var codeType = new CodeTypeDeclaration(MakeSafeTypeName(typeName))
        {
            IsClass = true,
            IsPartial = true,
            TypeAttributes = System.Reflection.TypeAttributes.Public
        };

        // Mark as abstract if the XSD type is abstract
        if (complexType.IsAbstract)
        {
            codeType.TypeAttributes |= System.Reflection.TypeAttributes.Abstract;
        }

        _generatedTypes[qualifiedName] = codeType;

        // Add attributes for XML serialization
        AddTypeAttributes(codeType, complexType, targetNamespace);

        // Handle base type
        if (complexType.ContentModel is XmlSchemaComplexContent complexContent)
        {
            if (complexContent.Content is XmlSchemaComplexContentExtension extension)
            {
                var baseTypeName = GetClrTypeName(extension.BaseTypeName);
                if (!string.IsNullOrEmpty(baseTypeName))
                {
                    codeType.BaseTypes.Add(baseTypeName);

                    // Track the type hierarchy for XmlIncludeAttribute generation
                    if (!_typeHierarchy.ContainsKey(baseTypeName))
                    {
                        _typeHierarchy[baseTypeName] = new List<string>();
                    }
                    _typeHierarchy[baseTypeName].Add(typeName);
                }
            }
        }

        // Generate fields and properties
        GenerateMembers(codeType, complexType);

        // Handle mixed content (text nodes)
        if (complexType.IsMixed)
        {
            GenerateMixedContentProperty(codeType);
        }

        return codeType;
    }

    private CodeTypeDeclaration? GenerateSimpleType(XmlSchemaSimpleType simpleType, string? targetNamespace)
    {
        var typeName = simpleType.Name;
        if (string.IsNullOrEmpty(typeName))
        {
            return null;
        }

        // Check if this is an enum (has enumeration facets)
        if (simpleType.Content is XmlSchemaSimpleTypeRestriction restriction)
        {
            var hasEnumFacets = restriction.Facets.OfType<XmlSchemaEnumerationFacet>().Any();
            if (hasEnumFacets)
            {
                return GenerateEnum(simpleType, targetNamespace);
            }
        }

        return null;
    }

    private CodeTypeDeclaration GenerateEnum(XmlSchemaSimpleType simpleType, string? targetNamespace)
    {
        var enumType = new CodeTypeDeclaration(MakeSafeTypeName(simpleType.Name!))
        {
            IsEnum = true,
            TypeAttributes = System.Reflection.TypeAttributes.Public
        };

        // Add attributes
        AddGeneratedCodeAttribute(enumType);
        enumType.CustomAttributes.Add(new CodeAttributeDeclaration("System.SerializableAttribute"));

        if (!string.IsNullOrEmpty(targetNamespace))
        {
            enumType.CustomAttributes.Add(new CodeAttributeDeclaration(
                "System.Xml.Serialization.XmlTypeAttribute",
                new CodeAttributeArgument("Namespace", new CodePrimitiveExpression(targetNamespace))
            ));
        }

        // Add enum members
        if (simpleType.Content is XmlSchemaSimpleTypeRestriction restriction)
        {
            foreach (var facet in restriction.Facets.OfType<XmlSchemaEnumerationFacet>())
            {
                if (string.IsNullOrEmpty(facet.Value))
                    continue;

                var memberName = MakeSafeEnumMemberName(facet.Value);
                var member = new CodeMemberField(enumType.Name, memberName);

                if (memberName != facet.Value)
                {
                    // Add XmlEnum attribute if name was changed
                    member.CustomAttributes.Add(new CodeAttributeDeclaration(
                        "System.Xml.Serialization.XmlEnumAttribute",
                        new CodeAttributeArgument(new CodePrimitiveExpression(facet.Value))
                    ));
                }

                enumType.Members.Add(member);
            }
        }

        return enumType;
    }

    private void GenerateMembers(CodeTypeDeclaration codeType, XmlSchemaComplexType complexType)
    {
        var particle = complexType.Particle ?? complexType.ContentModel?.Content switch
        {
            XmlSchemaComplexContentExtension ext => ext.Particle,
            _ => null
        };

        if (particle is XmlSchemaSequence sequence)
        {
            foreach (var item in sequence.Items)
            {
                if (item is XmlSchemaElement element)
                {
                    GenerateProperty(codeType, element);
                }
            }
        }
        else if (particle is XmlSchemaChoice choice)
        {
            foreach (var item in choice.Items)
            {
                if (item is XmlSchemaElement element)
                {
                    GenerateProperty(codeType, element);
                }
            }
        }
        else if (particle is XmlSchemaAll all)
        {
            foreach (var item in all.Items)
            {
                if (item is XmlSchemaElement element)
                {
                    GenerateProperty(codeType, element);
                }
            }
        }

        // Handle attributes
        var attributes = complexType.Attributes;
        if (complexType.ContentModel?.Content is XmlSchemaComplexContentExtension extension)
        {
            attributes = extension.Attributes;
        }

        foreach (var attr in attributes)
        {
            if (attr is XmlSchemaAttribute attribute)
            {
                GenerateAttributeProperty(codeType, attribute);
            }
        }
    }

    private void GenerateProperty(CodeTypeDeclaration codeType, XmlSchemaElement element)
    {
        // Use the element name as-is for the property (xsd.exe preserves casing)
        var propertyName = element.Name!;
        var fieldName = MakeFieldName(propertyName);

        // Check if this is an array wrapper (element with anonymous complexType containing sequence with maxOccurs)
        string? arrayItemName = null;
        string? propertyType = null;
        bool isArray = false;

        if (element.SchemaType is XmlSchemaComplexType complexType &&
            complexType.Particle is XmlSchemaSequence sequence &&
            sequence.Items.Count > 0)
        {
            // This might be an array wrapper pattern
            var firstItem = sequence.Items[0];
            if (firstItem is XmlSchemaElement innerElement &&
                (innerElement.MaxOccurs > 1 || innerElement.MaxOccursString == "unbounded"))
            {
                // This is an array wrapper
                isArray = true;
                arrayItemName = innerElement.Name;
                propertyType = GetElementType(innerElement);
            }
        }

        if (propertyType == null)
        {
            // Normal element or direct array
            propertyType = GetElementType(element);
            isArray = element.MaxOccurs > 1 || element.MaxOccursString == "unbounded";
        }

        if (isArray)
        {
            propertyType += "[]";
        }

        // Generate private field
        var field = new CodeMemberField(GetCodeTypeReference(propertyType), fieldName);
        field.Attributes = MemberAttributes.Private;
        codeType.Members.Add(field);

        // Generate public property
        var property = new CodeMemberProperty
        {
            Name = propertyName,
            Type = GetCodeTypeReference(propertyType),
            Attributes = MemberAttributes.Public | MemberAttributes.Final,
            HasGet = true,
            HasSet = true
        };

        // Add getter
        property.GetStatements.Add(new CodeMethodReturnStatement(
            new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), fieldName)
        ));

        // Add setter
        property.SetStatements.Add(new CodeAssignStatement(
            new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), fieldName),
            new CodePropertySetValueReferenceExpression()
        ));

        // Add XML serialization attributes
        AddPropertyAttributes(property, element, isArray, arrayItemName);

        // Add remarks comment
        property.Comments.Add(new CodeCommentStatement("<remarks/>", true));

        codeType.Members.Add(property);
    }

    private void GenerateAttributeProperty(CodeTypeDeclaration codeType, XmlSchemaAttribute attribute)
    {
        // Preserve original casing from XSD (default behavior)
        var propertyName = attribute.Name!;
        var fieldName = MakeFieldName(propertyName);
        var propertyType = GetAttributeType(attribute);

        // Generate private field
        var field = new CodeMemberField(GetCodeTypeReference(propertyType), fieldName);
        field.Attributes = MemberAttributes.Private;
        codeType.Members.Add(field);

        // Check if we need a *Specified field for optional value types
        bool needsSpecifiedField = IsOptionalValueType(attribute, propertyType);
        if (needsSpecifiedField)
        {
            var specifiedFieldName = fieldName + "Specified";
            var specifiedField = new CodeMemberField(typeof(bool), specifiedFieldName);
            specifiedField.Attributes = MemberAttributes.Private;
            codeType.Members.Add(specifiedField);
        }

        // Generate public property
        var property = new CodeMemberProperty
        {
            Name = propertyName,
            Type = GetCodeTypeReference(propertyType),
            Attributes = MemberAttributes.Public | MemberAttributes.Final,
            HasGet = true,
            HasSet = true
        };

        // Add getter
        property.GetStatements.Add(new CodeMethodReturnStatement(
            new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), fieldName)
        ));

        // Add setter
        property.SetStatements.Add(new CodeAssignStatement(
            new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), fieldName),
            new CodePropertySetValueReferenceExpression()
        ));

        // Add XML attribute
        property.CustomAttributes.Add(new CodeAttributeDeclaration("System.Xml.Serialization.XmlAttributeAttribute"));

        // Add remarks comment
        property.Comments.Add(new CodeCommentStatement("<remarks/>", true));

        codeType.Members.Add(property);

        // Generate *Specified property if needed
        if (needsSpecifiedField)
        {
            var specifiedPropertyName = propertyName + "Specified";
            var specifiedFieldName = fieldName + "Specified";

            var specifiedProperty = new CodeMemberProperty
            {
                Name = specifiedPropertyName,
                Type = new CodeTypeReference(typeof(bool)),
                Attributes = MemberAttributes.Public | MemberAttributes.Final,
                HasGet = true,
                HasSet = true
            };

            // Add getter
            specifiedProperty.GetStatements.Add(new CodeMethodReturnStatement(
                new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), specifiedFieldName)
            ));

            // Add setter
            specifiedProperty.SetStatements.Add(new CodeAssignStatement(
                new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), specifiedFieldName),
                new CodePropertySetValueReferenceExpression()
            ));

            // Add XmlIgnore attribute
            specifiedProperty.CustomAttributes.Add(new CodeAttributeDeclaration("System.Xml.Serialization.XmlIgnoreAttribute"));

            // Add remarks comment
            specifiedProperty.Comments.Add(new CodeCommentStatement("<remarks/>", true));

            codeType.Members.Add(specifiedProperty);
        }
    }

    private void GenerateMixedContentProperty(CodeTypeDeclaration codeType)
    {
        // Generate a string[] property with XmlTextAttribute for mixed content
        var fieldName = "textField";
        var propertyName = "Text";

        // Add private field
        var field = new CodeMemberField(new CodeTypeReference(typeof(string[])), fieldName)
        {
            Attributes = MemberAttributes.Private
        };
        codeType.Members.Add(field);

        // Add public property
        var property = new CodeMemberProperty
        {
            Name = propertyName,
            Type = new CodeTypeReference(typeof(string[])),
            Attributes = MemberAttributes.Public | MemberAttributes.Final,
            HasGet = true,
            HasSet = true
        };

        // Add getter
        property.GetStatements.Add(new CodeMethodReturnStatement(
            new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), fieldName)
        ));

        // Add setter
        property.SetStatements.Add(new CodeAssignStatement(
            new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), fieldName),
            new CodePropertySetValueReferenceExpression()
        ));

        // Add XmlText attribute
        property.CustomAttributes.Add(new CodeAttributeDeclaration("System.Xml.Serialization.XmlTextAttribute"));

        // Add remarks comment
        property.Comments.Add(new CodeCommentStatement("<remarks/>", true));

        codeType.Members.Add(property);
    }

    private void AddTypeAttributes(CodeTypeDeclaration codeType, XmlSchemaComplexType complexType, string? targetNamespace)
    {
        // Add [GeneratedCode]
        AddGeneratedCodeAttribute(codeType);

        // Add [Serializable]
        codeType.CustomAttributes.Add(new CodeAttributeDeclaration("System.SerializableAttribute"));

        // Add [DebuggerStepThrough]
        codeType.CustomAttributes.Add(new CodeAttributeDeclaration("System.Diagnostics.DebuggerStepThroughAttribute"));

        // Add [DesignerCategory("code")]
        codeType.CustomAttributes.Add(new CodeAttributeDeclaration(
            "System.ComponentModel.DesignerCategoryAttribute",
            new CodeAttributeArgument(new CodePrimitiveExpression("code"))
        ));

        // Add [XmlType]
        if (!string.IsNullOrEmpty(targetNamespace))
        {
            codeType.CustomAttributes.Add(new CodeAttributeDeclaration(
                "System.Xml.Serialization.XmlTypeAttribute",
                new CodeAttributeArgument("Namespace", new CodePrimitiveExpression(targetNamespace))
            ));
        }

        // Add [XmlRoot] if this type is referenced by a global element
        var typeName = complexType.Name;
        if (!string.IsNullOrEmpty(typeName) && _rootElements.TryGetValue(typeName, out var rootInfo))
        {
            var xmlRootAttr = new CodeAttributeDeclaration("System.Xml.Serialization.XmlRootAttribute");
            xmlRootAttr.Arguments.Add(new CodeAttributeArgument(new CodePrimitiveExpression(rootInfo.elementName)));

            if (!string.IsNullOrEmpty(rootInfo.targetNamespace))
            {
                xmlRootAttr.Arguments.Add(new CodeAttributeArgument("Namespace", new CodePrimitiveExpression(rootInfo.targetNamespace)));
            }

            xmlRootAttr.Arguments.Add(new CodeAttributeArgument("IsNullable", new CodePrimitiveExpression(false)));

            codeType.CustomAttributes.Add(xmlRootAttr);
        }
    }

    private void AddGeneratedCodeAttribute(CodeTypeDeclaration codeType)
    {
        codeType.CustomAttributes.Add(new CodeAttributeDeclaration(
            "System.CodeDom.Compiler.GeneratedCodeAttribute",
            new CodeAttributeArgument(new CodePrimitiveExpression("xsd2cs")),
            new CodeAttributeArgument(new CodePrimitiveExpression(_toolVersion))
        ));
    }

    private void AddPropertyAttributes(CodeMemberProperty property, XmlSchemaElement element, bool isArray, string? arrayItemName = null)
    {
        if (isArray && arrayItemName != null)
        {
            // Add XmlArrayItem attribute with the inner element name
            property.CustomAttributes.Add(new CodeAttributeDeclaration(
                "System.Xml.Serialization.XmlArrayItemAttribute",
                new CodeAttributeArgument(new CodePrimitiveExpression(arrayItemName)),
                new CodeAttributeArgument("IsNullable", new CodePrimitiveExpression(false))
            ));
        }
    }

    private string GetElementType(XmlSchemaElement element)
    {
        if (element.SchemaTypeName != null && !element.SchemaTypeName.IsEmpty)
        {
            return GetClrTypeName(element.SchemaTypeName);
        }

        if (element.SchemaType != null)
        {
            return element.Name!; // Use element name as type
        }

        return "object";
    }

    private string GetAttributeType(XmlSchemaAttribute attribute)
    {
        if (attribute.SchemaTypeName != null && !attribute.SchemaTypeName.IsEmpty)
        {
            return GetClrTypeName(attribute.SchemaTypeName);
        }

        return "string";
    }

    private string GetClrTypeName(XmlQualifiedName xmlTypeName)
    {
        // Map XML Schema types to CLR types
        if (xmlTypeName.Namespace == "http://www.w3.org/2001/XMLSchema")
        {
            return xmlTypeName.Name switch
            {
                "string" => "string",
                "int" => "int",
                "integer" => "int",
                "long" => "long",
                "short" => "short",
                "byte" => "byte",
                "unsignedByte" => "byte",
                "boolean" => "bool",
                "decimal" => "decimal",
                "float" => "float",
                "double" => "double",
                "dateTime" => "System.DateTime",
                "date" => "System.DateTime",
                "time" => "System.TimeSpan",
                "duration" => "System.TimeSpan",
                "anyURI" => "string",
                "QName" => "System.Xml.XmlQualifiedName",
                "anyType" => "object",
                _ => "string"
            };
        }

        // For types in the target namespace, use just the type name
        return MakeSafeTypeName(xmlTypeName.Name);
    }

    private string MakeSafeTypeName(string name)
    {
        // Make a valid C# type name
        return MakeSafeMemberName(name);
    }

    private string MakeSafeMemberName(string name)
    {
        // Capitalize first letter for PascalCase
        if (string.IsNullOrEmpty(name)) return name;
        return char.ToUpper(name[0]) + name.Substring(1);
    }

    private string MakeSafeEnumMemberName(string value)
    {
        // Preserve original casing from XSD (xsd.exe behavior)
        if (string.IsNullOrEmpty(value)) return value;

        var sb = new StringBuilder();

        foreach (char c in value)
        {
            if (char.IsLetterOrDigit(c) || c == '_')
            {
                sb.Append(c);
            }
            // Skip non-alphanumeric characters except underscore
        }

        var result = sb.ToString();

        // Enum members can't start with a digit
        if (result.Length > 0 && char.IsDigit(result[0]))
        {
            result = "Item" + result;
        }

        // If result is empty or all non-alphanumeric, return a safe default
        if (string.IsNullOrEmpty(result))
        {
            result = "Item";
        }

        return result;
    }

    private string MakeFieldName(string propertyName)
    {
        // Convert property name to field name: propertyName -> propertyNameField
        // Preserve the original casing
        return propertyName + "Field";
    }

    private void WriteOutput(CodeNamespace codeNamespace)
    {
        var outputFile = string.IsNullOrEmpty(_options.OutputPath)
            ? _options.OutputFile
            : Path.Combine(_options.OutputPath, _options.OutputFile);

        if (string.IsNullOrEmpty(outputFile))
        {
            outputFile = Path.ChangeExtension(_options.SchemaFiles[0], ".cs");
        }

        using var writer = new StreamWriter(outputFile, false, Encoding.UTF8);
        using var provider = CodeDomProvider.CreateProvider("CSharp");

        var options = new CodeGeneratorOptions
        {
            BracingStyle = "Block",
            IndentString = "    ",
            BlankLinesBetweenMembers = true
        };

        // Write header
        WriteHeader(writer);

        // Generate code
        provider.GenerateCodeFromNamespace(codeNamespace, writer, options);
    }

    private void WriteHeader(StreamWriter writer)
    {
        writer.WriteLine("//------------------------------------------------------------------------------");
        writer.WriteLine("// <auto-generated>");
        writer.WriteLine("//     This code was generated by a tool.");
        writer.WriteLine($"//     Runtime Version:{Environment.Version}");
        writer.WriteLine("//");
        writer.WriteLine("//     Changes to this file may cause incorrect behavior and will be lost if");
        writer.WriteLine("//     the code is regenerated.");
        writer.WriteLine("// </auto-generated>");
        writer.WriteLine("//------------------------------------------------------------------------------");
        writer.WriteLine();
    }

    private bool IsOptionalValueType(XmlSchemaAttribute attribute, string clrTypeName)
    {
        // Only optional attributes need the *Specified pattern
        // Note: attributes without use="required" are optional (Use will be None or Optional)
        if (attribute.Use == XmlSchemaUse.Required)
            return false;

        // Attributes with default values don't need *Specified
        if (!string.IsNullOrEmpty(attribute.DefaultValue))
            return false;

        // Check if the CLR type is a value type that needs a *Specified field
        // Reference types (string, QName, etc.) don't need this pattern
        bool isBuiltInValueType = clrTypeName switch
        {
            "int" => true,
            "long" => true,
            "short" => true,
            "byte" => true,
            "bool" => true,
            "decimal" => true,
            "float" => true,
            "double" => true,
            "System.DateTime" => true,
            "System.TimeSpan" => true,
            _ => false
        };

        if (isBuiltInValueType)
            return true;

        // Check if the type is an enum (enums are value types in C#)
        // Enums defined in the schema namespace will not be in the built-in list
        // We need to check the schema type
        if (attribute.SchemaTypeName != null && !attribute.SchemaTypeName.IsEmpty)
        {
            // If it's not an xs: (XML Schema) type, it might be a custom type
            if (attribute.SchemaTypeName.Namespace != "http://www.w3.org/2001/XMLSchema")
            {
                // Check if this is an enum type by looking it up in the schema
                if (_schemaSet.GlobalTypes.Contains(attribute.SchemaTypeName))
                {
                    var schemaType = _schemaSet.GlobalTypes[attribute.SchemaTypeName]!;
                    if (schemaType is XmlSchemaSimpleType simpleType &&
                        simpleType.Content is XmlSchemaSimpleTypeRestriction restriction &&
                        restriction.Facets != null)
                    {
                        // Check if it has enumeration facets
                        foreach (var facet in restriction.Facets)
                        {
                            if (facet is XmlSchemaEnumerationFacet)
                            {
                                return true; // This is an enum, needs *Specified
                            }
                        }
                    }
                }
            }
        }

        return false;
    }

    private CodeTypeReference GetCodeTypeReference(string typeName)
    {
        // For built-in C# types, use typeof to avoid escaping keywords
        return typeName switch
        {
            "string" => new CodeTypeReference(typeof(string)),
            "int" => new CodeTypeReference(typeof(int)),
            "long" => new CodeTypeReference(typeof(long)),
            "short" => new CodeTypeReference(typeof(short)),
            "byte" => new CodeTypeReference(typeof(byte)),
            "bool" => new CodeTypeReference(typeof(bool)),
            "decimal" => new CodeTypeReference(typeof(decimal)),
            "float" => new CodeTypeReference(typeof(float)),
            "double" => new CodeTypeReference(typeof(double)),
            "object" => new CodeTypeReference(typeof(object)),
            "string[]" => new CodeTypeReference(typeof(string[])),
            "int[]" => new CodeTypeReference(typeof(int[])),
            "long[]" => new CodeTypeReference(typeof(long[])),
            "short[]" => new CodeTypeReference(typeof(short[])),
            "byte[]" => new CodeTypeReference(typeof(byte[])),
            "bool[]" => new CodeTypeReference(typeof(bool[])),
            "decimal[]" => new CodeTypeReference(typeof(decimal[])),
            "float[]" => new CodeTypeReference(typeof(float[])),
            "double[]" => new CodeTypeReference(typeof(double[])),
            "object[]" => new CodeTypeReference(typeof(object[])),
            _ => new CodeTypeReference(typeName)
        };
    }
}
