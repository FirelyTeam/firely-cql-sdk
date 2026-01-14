/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.CodeDom;
using System.CodeDom.Compiler;
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
    private XmlSchemaSet? _schemaSet;

    public XsdCodeGenerator(CommandLineOptions options)
    {
        _options = options;
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

        foreach (XmlSchema schema in _schemaSet.Schemas())
        {
            // Generate classes from complex types
            foreach (XmlSchemaType schemaType in schema.SchemaTypes.Values)
            {
                if (schemaType is XmlSchemaComplexType complexType)
                {
                    var codeType = GenerateComplexType(complexType, schema.TargetNamespace);
                    if (codeType != null)
                    {
                        codeNamespace.Types.Add(codeType);
                    }
                }
                else if (schemaType is XmlSchemaSimpleType simpleType)
                {
                    var codeType = GenerateSimpleType(simpleType, schema.TargetNamespace);
                    if (codeType != null)
                    {
                        codeNamespace.Types.Add(codeType);
                    }
                }
            }

            // Generate classes from global elements
            foreach (XmlSchemaElement element in schema.Elements.Values)
            {
                if (element.SchemaType is XmlSchemaComplexType complexType)
                {
                    var codeType = GenerateComplexType(complexType, schema.TargetNamespace, element.Name);
                    if (codeType != null)
                    {
                        codeNamespace.Types.Add(codeType);
                    }
                }
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
                }
            }
        }

        // Generate fields and properties
        GenerateMembers(codeType, complexType);

        return codeType;
    }

    private CodeTypeDeclaration? GenerateSimpleType(XmlSchemaSimpleType simpleType, string? targetNamespace)
    {
        var typeName = simpleType.Name;
        if (string.IsNullOrEmpty(typeName))
        {
            return null;
        }

        // Check if this is an enum
        if (simpleType.Content is XmlSchemaSimpleTypeRestriction restriction &&
            restriction.BaseTypeName.Name == "string")
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
        var propertyName = MakeSafeMemberName(element.Name!);
        var fieldName = MakeFieldName(propertyName);
        
        var propertyType = GetElementType(element);
        var isArray = element.MaxOccurs > 1 || element.MaxOccursString == "unbounded";
        
        if (isArray)
        {
            propertyType += "[]";
        }

        // Generate private field
        var field = new CodeMemberField(propertyType, fieldName);
        field.Attributes = MemberAttributes.Private;
        codeType.Members.Add(field);

        // Generate public property
        var property = new CodeMemberProperty
        {
            Name = propertyName,
            Type = new CodeTypeReference(propertyType),
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
        AddPropertyAttributes(property, element, isArray);

        // Add remarks comment
        property.Comments.Add(new CodeCommentStatement("<remarks/>", true));

        codeType.Members.Add(property);
    }

    private void GenerateAttributeProperty(CodeTypeDeclaration codeType, XmlSchemaAttribute attribute)
    {
        var propertyName = MakeSafeMemberName(attribute.Name!);
        var fieldName = MakeFieldName(propertyName);
        var propertyType = GetAttributeType(attribute);

        // Generate private field
        var field = new CodeMemberField(propertyType, fieldName);
        field.Attributes = MemberAttributes.Private;
        codeType.Members.Add(field);

        // Generate public property
        var property = new CodeMemberProperty
        {
            Name = propertyName,
            Type = new CodeTypeReference(propertyType),
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
    }

    private void AddGeneratedCodeAttribute(CodeTypeDeclaration codeType)
    {
        codeType.CustomAttributes.Add(new CodeAttributeDeclaration(
            "System.CodeDom.Compiler.GeneratedCodeAttribute",
            new CodeAttributeArgument(new CodePrimitiveExpression("xsd")),
            new CodeAttributeArgument(new CodePrimitiveExpression("4.8.3928.0"))
        ));
    }

    private void AddPropertyAttributes(CodeMemberProperty property, XmlSchemaElement element, bool isArray)
    {
        if (isArray)
        {
            // Add XmlArrayItem attribute
            var itemName = element.Name;
            property.CustomAttributes.Add(new CodeAttributeDeclaration(
                "System.Xml.Serialization.XmlArrayItemAttribute",
                new CodeAttributeArgument(new CodePrimitiveExpression("def")),
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
        // Make a valid C# enum member name
        if (string.IsNullOrEmpty(value)) return value;
        
        var sb = new StringBuilder();
        bool capitalizeNext = true;

        foreach (char c in value)
        {
            if (char.IsLetterOrDigit(c))
            {
                sb.Append(capitalizeNext ? char.ToUpper(c) : c);
                capitalizeNext = false;
            }
            else
            {
                capitalizeNext = true;
            }
        }

        var result = sb.ToString();
        
        // Enum members can't start with a digit
        if (char.IsDigit(result[0]))
        {
            result = "Item" + result;
        }

        return result;
    }

    private string MakeFieldName(string propertyName)
    {
        // Convert to camelCase and add "Field" suffix
        return char.ToLower(propertyName[0]) + propertyName.Substring(1) + "Field";
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
            BracingStyle = "C",
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
    }
}
