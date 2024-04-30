/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Hl7.Cql.Elm;

namespace Hl7.Cql.Compiler;

internal readonly record struct BuilderContextDebuggerInfo(
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

    public static BuilderContextDebuggerInfo FromElement(Element element)
    {
        BuilderContextDebuggerInfo obj = new(
            ElementType: element.GetType().Name,
            Locator: element.locator,
            ResultType: GetElemTypeName(element),
            Name: GetNameText(element));
        return obj;


        string? GetNameText(Element elem)
        {
            StringBuilder sb = new();
            Append(FromNameAndVersion());
            Append(FromLibraryName());
            Append(FromContext());
            Append(FromName());
            Append(FromPath());
            return sb.Length == 0 ? null : sb.ToString();

            void Append(string? text)
            {
                if (text is null or "") return;
                if (sb.Length > 0) sb.Append(".");
                sb.Append(text);
            }

            string? FromPath() => (elem as IGetPath)?.path;
            string? FromContext() => (elem as ExpressionDef)?.context;
            string? FromNameAndVersion() => (elem as IGetNameAndVersion)?.NameAndVersion(throwError: false);
            string? FromLibraryName() => (elem as IGetLibraryName)?.libraryName;
            string? FromName() => (elem as IGetName)?.name;
        }

        string? GetElemTypeName(Element elem) =>
            elem switch
            {
                { resultTypeName: { } t } => t.ToString(),
                { resultTypeSpecifier: { } t } => GetTypeSpecifierName(t),
                As { asType: { } t } e => t.ToString(),
                As { asTypeSpecifier: { } t } e => GetTypeSpecifierName(t),
                _ => null,
            };

        string? GetTypeSpecifierName(TypeSpecifier type) =>
            type switch
            {
                ChoiceTypeSpecifier t => $"Choice<{string.Join(", ", from c in t.choice select GetTypeSpecifierName(c))}>",
                IntervalTypeSpecifier t => $"Interval<{GetTypeSpecifierName(t.pointType)}>",
                ListTypeSpecifier t => $"List<{GetTypeSpecifierName(t.elementType)}>",
                NamedTypeSpecifier t => t.name.ToString(),
                ParameterTypeSpecifier t => t.parameterName,
                TupleTypeSpecifier t => $"Tuple {{{string.Join(", ", from c in t.element select $"{c.name}: {GetTypeSpecifierName(c.elementType)}}}")}>",
                _ => throw new SwitchExpressionException("Unexpected switch type: " + type.GetType()),
            };
    }
}