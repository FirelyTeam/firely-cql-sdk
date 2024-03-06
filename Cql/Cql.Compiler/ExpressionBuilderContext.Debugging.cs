using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using elm = Hl7.Cql.Elm;
using Expression = System.Linq.Expressions.Expression;

namespace Hl7.Cql.Compiler;

partial class ExpressionBuilderContext
{
    private Elm.Element Element { get; init; }

    private ExpressionBuilderContext? OuterContext { get; init; }


    internal IEnumerable<ExpressionBuilderContext> SelfAndAncestorContexts
    {
        get
        {
            ExpressionBuilderContext? current = this;
            while (current != null)
            {
                yield return current;
                current = current.OuterContext;
            }
        }
    }


    internal IEnumerable<Elm.Element> SelfAndAncestorElements =>
        SelfAndAncestorContexts
            .Select(context => context.Element)
            .OfType<Elm.Element>();

    internal readonly record struct BasicElementInfo(
        string ElementType,
        string? Locator,
        string? Type,
        string? Name)
    {
        public override string ToString()
        {
            StringBuilder sb = new();
            Append("", ElementType);
            Append("named", Name);
            Append("of type", Type);
            Append("at location", Locator);

            void Append(string prefix, string? text)
            {
                if (string.IsNullOrWhiteSpace(text)) return;
                if (sb.Length > 0) sb.Append(' ');
                sb.Append(prefix);
                sb.Append(' ');
                if (prefix.Length > 0) sb.Append('\'');
                sb.Append(text);
                if (prefix.Length > 0) sb.Append('\'');
            }
            return sb.ToString();
        }
    }

    internal IEnumerable<BasicElementInfo> ElementPathToRoot
    {
        get
        {
            var contextsAndElements = SelfAndAncestorContexts
                .Select(context => (context, context.Element))
                .ToList();

            for (int i = 0; i < contextsAndElements.Count; i++)
            {
                var (context, element) = contextsAndElements[i];
                if (element is null) 
                    continue;

                BasicElementInfo obj = new(
                    ElementType: element.GetType().Name,
                    Locator: element.locator,
                    Type: GetElemTypeName(element),
                    Name: GetNameText(element));
                yield return obj;


                string? GetNameText(elm.Element elem)
                {
                    StringBuilder sb = new();
                    var elemType = elem.GetType();
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

                string? GetElemTypeName(elm.Element elem) =>
                    elem switch
                    {
                        { resultTypeName: { } t } => t.ToString(),
                        { resultTypeSpecifier: { } t } => GetTypeSpecifierName(t),
                        Elm.As { asType:{ } t } e => t.ToString(),
                        Elm.As { asTypeSpecifier:{ } t } e => GetTypeSpecifierName(t),
                        _ => null,
                    };

                string? GetTypeSpecifierName(elm.TypeSpecifier type) =>
                    type switch
                    {
                        Elm.ChoiceTypeSpecifier t => $"Choice<{string.Join(", ", from c in t.choice select GetTypeSpecifierName(c))}>",
                        Elm.IntervalTypeSpecifier t => $"Interval<{GetTypeSpecifierName(t.pointType)}>",
                        Elm.ListTypeSpecifier t => $"List<{GetTypeSpecifierName(t.elementType)}>",
                        Elm.NamedTypeSpecifier t => t.name.ToString(),
                        Elm.ParameterTypeSpecifier t => t.parameterName,
                        Elm.TupleTypeSpecifier t => $"Tuple {{{string.Join(", ", from c in t.element select $"{c.name}: {GetTypeSpecifierName(c.type)}}}")}>",
                        _ => throw new SwitchExpressionException("Unexpected switch type: " + type.GetType()),
                    };
            }
        }
    }

    public ExpressionBuildingException NewExpressionBuildingException(string message, Exception? innerException = null) => 
        new(this, message, innerException);
}