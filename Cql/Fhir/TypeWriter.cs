using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;

namespace Ncqa.Fhir
{
    public class TypeWriter
    {
        public void Write(IEnumerable<Type> types, DirectoryInfo directory)
        {
            while (!directory.Exists)
            {
                directory.Create();
                directory.Refresh();
            }
            var rootTypes = types.Where(t => t.DeclaringType == null)
                .ToArray();
            var all = types.ToDictionary(t => t.FullName);
            foreach (var type in rootTypes)
            {
                WriteClass(directory, 0, type, null, all, null);
            }
        }

        public void WriteElementConverters(Type elementType, IEnumerable<Type> types, DirectoryInfo directory)
        {
            var converterTypeNames = new List<string>();
            WriteElementConvertersStep(elementType, types, directory, converterTypeNames);

            var convertersFi = new FileInfo(Path.Combine(directory.FullName, $"Converters.cs"));
            using var convertersFs = new FileStream(convertersFi.FullName, FileMode.Create, FileAccess.Write, FileShare.Read);
            using var convertersWriter = new StreamWriter(convertersFs);

            convertersWriter.WriteLine("using Ncqa.Fhir.Serialization;");
            convertersWriter.WriteLine("using Ncqa.Iso8601;");
            convertersWriter.WriteLine("using System.Text.Json;");
            convertersWriter.WriteLine("using Ncqa.Fhir.R4.Model;");
            convertersWriter.WriteLine();
            convertersWriter.WriteLine("namespace Ncqa.Fhir.R4.Serialization");
            convertersWriter.WriteLine("{");
            convertersWriter.WriteLineIndented(1, $"public static class Converters");
            convertersWriter.WriteLineIndented(1, $"{{");
            convertersWriter.WriteLineIndented(2, "public static void AddR4Converters(this JsonSerializerOptions options)");
            convertersWriter.WriteLineIndented(2, $"{{");
            foreach (var typeName in converterTypeNames)
            {
                convertersWriter.WriteLineIndented(3, $"options.Converters.Add(new {typeName}());");
            }
            convertersWriter.WriteLineIndented(2, $"}}");
            convertersWriter.WriteLineIndented(1, $"}}");
            convertersWriter.WriteLine("}");
        }

        private void WriteElementConvertersStep(Type elementType, IEnumerable<Type> types, DirectoryInfo directory, List<string> converterTypeNames)
        {
            foreach (var type in types.Where(t => t.BaseType == elementType))
            {
                var valueProperty = type.GetProperty("value");
                if (valueProperty != null)
                {
                    const string defaultAssignment = "element.value = value";
                    const string throwJsonException = "throw new JsonException()";
                    string tokenTypes, stringBody, decimalBody, booleanBody;
                    if (valueProperty.PropertyType == typeof(string) ||
                        valueProperty.PropertyType.GetMethod("op_Implicit", new[] { typeof(string) }) != null)
                    {
                        tokenTypes = "new[] { JsonTokenType.String }";
                        decimalBody = throwJsonException;
                        stringBody = defaultAssignment;
                        booleanBody = throwJsonException;
                    }
                    else if (valueProperty.PropertyType == typeof(int?))
                    {
                        tokenTypes = "new[] { JsonTokenType.Number }";
                        decimalBody = "element.value = (int?)value";
                        stringBody = throwJsonException;
                        booleanBody = throwJsonException;
                    }
                    else if (valueProperty.PropertyType == typeof(decimal?))
                    {
                        tokenTypes = "new[] { JsonTokenType.Number }";
                        decimalBody = defaultAssignment;
                        stringBody = throwJsonException;
                        booleanBody = throwJsonException;
                    }
                    else if (valueProperty.PropertyType == typeof(bool?))
                    {
                        tokenTypes = "new[] { JsonTokenType.True, JsonTokenType.False }";
                        stringBody = throwJsonException;
                        decimalBody = throwJsonException;
                        booleanBody = defaultAssignment;
                    }
                    else continue; // value prop is not a simple, convertible type.

                    var className = $"{type.Name}Converter";
                    var fi = new FileInfo(Path.Combine(directory.FullName, $"{className}.cs"));
                    using var fs = new FileStream(fi.FullName, FileMode.Create, FileAccess.Write, FileShare.Read);
                    using var writer = new StreamWriter(fs);

                    var typeName = TypeNameFor(type);
                    var propTypeName = TypeNameFor(valueProperty.PropertyType);
                    string? writeMethod = null;
                    switch (propTypeName)
                    {

                        case "bool?":
                            writeMethod = $"writer.WriteBooleanValue(value.value ?? false);";
                            break;
                        case "decimal?":
                            writeMethod = $"writer.WriteNumberValue(value.value ?? 0m);";
                            break;
                        case "DateIso8601":
                        case "DateTimeIso8601":
                        case "TimeIso8601":
                            writeMethod = $"writer.WriteStringValue(value.value.ToString());";
                            break;
                        case "int?":
                            writeMethod = $"writer.WriteNumberValue(value.value ?? 0);";
                            break;
                        case "string":
                            writeMethod = $"writer.WriteStringValue(value.value);";
                            break;
                        default:
                            throw new NotImplementedException($"Element type {propTypeName} isn't implemented for writing during conversion.");
                    }
                    converterTypeNames.Add(className);
                    writer.WriteLine("using Ncqa.Fhir.Serialization;");
                    writer.WriteLine("using Ncqa.Iso8601;");
                    writer.WriteLine("using System.Text.Json;");
                    writer.WriteLine("using Ncqa.Fhir.R4.Model;");
                    writer.WriteLine();
                    writer.WriteLine("namespace Ncqa.Fhir.R4.Serialization");
                    writer.WriteLine("{");
                    writer.WriteLineIndented(1, $"public class {className} : ElementConverter<{typeName}>");
                    writer.WriteLineIndented(1, "{");
                    writer.WriteLineIndented(2, $"public {className}(): base({tokenTypes}, typeof({propTypeName})) {{ }}");
                    writer.WriteLineIndented(2, $"protected override void Assign({typeName} element, string value) => {stringBody};");
                    writer.WriteLineIndented(2, $"protected override void Assign({typeName} element, decimal? value) => {decimalBody};");
                    writer.WriteLineIndented(2, $"protected override void Assign({typeName} element, bool? value) => {booleanBody};");
                    writer.WriteLineIndented(2, $"public override void Write(Utf8JsonWriter writer, {typeName} value, JsonSerializerOptions options)");
                    writer.WriteLineIndented(2, "{");
                    writer.WriteLineIndented(3, "if (value.value != null)");
                    writer.WriteLineIndented(4, writeMethod);
                    writer.WriteLineIndented(2, "}");
                    writer.WriteLineIndented(1, "}");
                    writer.WriteLine("}");
                }
                WriteElementConvertersStep(type, types, directory, converterTypeNames);
            }
        }

        private static readonly string[] Usings = new[]
        {
            "Ncqa.Fhir",
            "Ncqa.Fhir.Serialization",
            "Ncqa.Iso8601",
            "System.Collections.Generic",
            "System.Diagnostics",
            "System.Diagnostics.CodeAnalysis",
            "System.Text.Json.Serialization"
        };

        private void WriteClass(DirectoryInfo directory,
            int indent, Type type, Type? enclosingType, IDictionary<string, Type> allTypes, StreamWriter? writer)
        {
            var className = TypeNameFor(type);
            bool disposeWriter = false;
            if (writer == null)
            {
                var fi = new FileInfo(Path.Combine(directory.FullName, $"{className}.cs"));
                var fs = new FileStream(fi.FullName, FileMode.Create, FileAccess.Write, FileShare.Read);
                writer = new StreamWriter(fs);
                disposeWriter = true;

                foreach (var @using in Usings)
                {
                    writer.WriteLine($"using {@using};");
                }
                writer.WriteLine();
                writer.WriteLine("namespace Ncqa.Fhir.R4.Model");
                writer.WriteLine("{");
                indent += 1;
            }

            var baseType = type.BaseType == typeof(object) ? "" : $" : {type.BaseType.Name}";
            if (type.GetProperty("value") != null)
            {
                writer.WriteLineIndented(indent, "[DebuggerDisplay(\"{value}\")]");
            }

            foreach (var attribute in type.GetCustomAttributes())
            {
                switch (attribute)
                {
                    case FhirUriAttribute fhirUri:
                        writer.WriteLineIndented(indent, $"[FhirUri(\"{fhirUri.Uri}\")]");
                        break;
                    default:
                        break;

                }
            }
            writer.WriteLineIndented(indent, $"public partial class {className}{baseType}");
            writer.WriteLineIndented(indent, "{");
            foreach (var prop in type.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
            {
                writer.WriteLine();
                var propertyTypeName = TypeNameFor(prop.PropertyType);
                var propName = NormalizePropertyName(prop.Name);
                foreach (var attr in prop.GetCustomAttributes(false))
                {
                    switch (attr)
                    {
                        case NotNullAttribute nna:
                            writer.WriteLineIndented(indent + 1, "[NotNull]");
                            break;
                        case ValueSetBindingAttribute binding:
                            writer.WriteLineIndented(indent + 1, $"[ValueSetBinding(\"{binding.Name}\", \"{binding.Url}\", {binding.IsRequired.ToString().ToLowerInvariant()})]");
                            break;
                        case Schemas.ChoiceTypeByNameAttribute choice:
                            if (allTypes.TryGetValue(choice.TypeName, out var choiceType))
                            {
                                writer.WriteLineIndented(indent + 1, $"[Choice(typeof({TypeNameFor(choiceType)}))]");
                            }
                            break;
                        case System.Text.Json.Serialization.JsonIgnoreAttribute:
                            writer.WriteLineIndented(indent + 1, $"[JsonIgnore]");
                            break;
                        default: break;
                    }
                }
                writer.WriteLineIndented(indent + 1, $"public {propertyTypeName} {propName} {{ get; set; }}");

                foreach (var attr in prop.GetCustomAttributes(false))
                {
                    switch (attr)
                    {

                        case Schemas.ChoiceTypeByNameAttribute choice:
                            {
                                if (allTypes.TryGetValue(choice.TypeName, out var choiceType))
                                {
                                    var choiceTypeName = TypeNameFor(choiceType);
                                    var choicePropName = $"{propName}{TypeSuffixFor(choiceType)}";
                                    var setName = propName;
                                    if (setName == "value")
                                        setName = "this.value";
                                    writer.WriteLineIndented(indent + 1, $"public {choiceTypeName} {choicePropName} {{ get => ChoiceAttribute.AsExactly<{choiceTypeName}>({propName}); set {{ {setName} = value; }} }}");
                                }
                                break;
                            }
                        default: break;
                    }
                }
            }

            foreach (var nested in allTypes.Where(kvp => kvp.Value.DeclaringType == type))
            {
                WriteClass(directory, indent + 1, nested.Value, type, allTypes, writer);
            }
            writer.WriteLineIndented(indent, "}");
            writer.Flush();
            if (disposeWriter)
            {
                writer.WriteLine("}");
                writer.Dispose();
            }
        }

        private string TypeSuffixFor(Type choiceType)
        {
            var suffix = choiceType.Name;
            if (suffix.EndsWith("Element") && suffix != "Element")
            {
                var idx = suffix.IndexOf("Element");
                suffix = suffix.Substring(0, idx);
            }
            return suffix;
        }

        private string NormalizePropertyName(string name)
        {
            if (SyntaxFacts.GetKeywordKind(name) != SyntaxKind.None)
            {
                name = $"@{name}";
            }
            return name;
        }

        private Dictionary<string, string> TypeNameSubstitutions = new Dictionary<string, string>
        {
        };

        private string TypeNameFor(Type type)
        {
            string typeName = type.Name;
            var parts = type.Name.Split('+');
            if (parts.Length > 1)
            {
                typeName = parts[parts.Length - 1];
            }
            if (TypeNameSubstitutions.TryGetValue(typeName, out var newName))
                return newName;
            if (type == typeof(int))
                return "int";
            else if (type == typeof(bool))
                return "bool";
            else if (type == typeof(decimal))
                return "decimal";
            else if (type == typeof(float))
                return "float";
            else if (type == typeof(double))
                return "double";
            else if (type == typeof(string))
                return "string";
            else if (type == typeof(object))
                return "object";
            if (type.IsGenericType)
            {
                if (type.IsGenericTypeDefinition == false && type.GetGenericTypeDefinition() == typeof(Nullable<>))
                {
                    typeName = $"{TypeNameFor(Nullable.GetUnderlyingType(type))}?";
                }
                else
                {
                    if (type.IsGenericType)
                    {
                        var tildeIndex = type.Name.IndexOf('`');
                        var rootName = type.Name.Substring(0, tildeIndex);
                        var genericArgumentNames = type.GetGenericArguments()
                            .Select(arg => TypeNameFor(arg));
                        var prettyName = $"{rootName}<{string.Join(",", genericArgumentNames)}>";
                        typeName = prettyName;
                    }
                }
            }
            return typeName;
        }
    }

    public static class TextWriterExtensions
    {
        public static void WriteLineIndented(this TextWriter writer, int tabs, string line)
        {
            for (int i = 0; i < tabs; i++)
                writer.Write("\t");
            writer.WriteLine(line);
        }
    }
}
