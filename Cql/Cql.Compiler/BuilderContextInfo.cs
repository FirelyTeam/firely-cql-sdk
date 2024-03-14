using Hl7.Cql.Elm;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml.Linq;

namespace Hl7.Cql.Compiler;

internal readonly record struct BuilderContextInfo(
    string ElementType,
    string? Locator = null,
    string? ResultType = null,
    string? Name = null)
{
    public override string ToString()
    {
        StringBuilder sb = new();
        Append("", ElementType);
        Append("named", Name);
        Append("of type", ResultType);
        Append("at location", Locator);

        void Append(string prefix, string? text)
        {
            if (string.IsNullOrWhiteSpace(text)) return;
            if (sb.Length > 0) sb.Append(' ');
            if (prefix != "")
            {
                sb.Append(prefix);
                sb.Append(' ');
            }
            if (prefix.Length > 0) sb.Append('\'');
            sb.Append(text);
            if (prefix.Length > 0) sb.Append('\'');
        }
        return sb.ToString();
    }

    public static BuilderContextInfo FromElement(Elm.Element element)
    {
        BuilderContextInfo obj = new(
            ElementType: element.GetType().Name,
            Locator: element.locator,
            ResultType: GetElemTypeName(element),
            Name: GetNameText(element));
        return obj;


        string? GetNameText(Elm.Element elem)
        {
            StringBuilder sb = new();
            var elemType = elem.GetType();
            AppendProp("NameAndVersion");
            AppendProp("libraryName");
            AppendProp("context");
            AppendProp("name");
            AppendProp("path");
            return sb.Length==0 ? null : sb.ToString();

            StringBuilder AppendProp(string prop)
            {
                string? text = elemType.GetProperty(prop)?.GetValue(elem)?.ToString();
                if (string.IsNullOrEmpty(text)) return sb;
                if (sb.Length > 0) sb.Append('.');
                return sb.Append(text);
            }
        }

        string? GetElemTypeName(Elm.Element elem) =>
            elem switch
            {
                { resultTypeName: { } t } => t.ToString(),
                { resultTypeSpecifier: { } t } => GetTypeSpecifierName(t),
                Elm.As { asType:{ } t } e => t.ToString(),
                Elm.As { asTypeSpecifier:{ } t } e => GetTypeSpecifierName(t),
                _ => null,
            };

        string? GetTypeSpecifierName(Elm.TypeSpecifier type) =>
            type switch
            {
                Elm.ChoiceTypeSpecifier t => $"Choice<{string.Join(", ", from c in t.choice select GetTypeSpecifierName(c))}>",
                Elm.IntervalTypeSpecifier t => $"Interval<{GetTypeSpecifierName(t.pointType)}>",
                Elm.ListTypeSpecifier t => $"List<{GetTypeSpecifierName(t.elementType)}>",
                Elm.NamedTypeSpecifier t => t.name.ToString(),
                Elm.ParameterTypeSpecifier t => t.parameterName,
                Elm.TupleTypeSpecifier t => $"Tuple {{{string.Join(", ", from c in t.element select $"{c.name}: {GetTypeSpecifierName(c.elementType)}}}")}>",
                _ => throw new SwitchExpressionException("Unexpected switch type: " + type.GetType()),
            };
    }
}