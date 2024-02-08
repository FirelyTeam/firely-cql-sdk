using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hl7.Cql.Elm;

namespace Hl7.Cql.Compiler.Exceptions;
internal class CqlCompilerException : Exception
{
    protected internal CqlCompilerException(CqlCompilerError error, Exception? innerException) : base(null, innerException)
    {
        Error = error;
    }
    
    public CqlCompilerError Error { get; }

    private string? _message;

    public override string Message => _message ??= Error.GetMessage(this).ToString(null);
}

internal abstract record CqlCompilerError
{
    internal abstract FormattableString GetMessage(CqlCompilerException exception);
}

internal record CqlExpressionBuilderError(int Code, Element Element, ExpressionBuilderContext Context) : CqlCompilerError
{
    internal override FormattableString GetMessage(CqlCompilerException exception) => Code switch
    {
        TypeForNotFound => $"The type for the element was not found. Element: {GetElementPath()}",
        _ => $"The error code '{Code}' is not recognized."
    };

    private string GetElementPath() =>
        string.Concat(
            Context.Predecessors
                .OrEmptyEnumerable()
                .Concat(new[] { Element })
                .Select(elem => $"{Environment.NewLine}- {GetElementAsString(elem, null)}"));

    private static string GetElementAsString(Element e, IFormatProvider? formatProvider)
    {
        StringBuilder sb = new();
        sb.Append(e.GetType().Name);
        if (e is IHasName { name: {} name }) sb.Append(formatProvider, $"'{name}'");
        if (e is IHasPath { path: { } path }) sb.Append(formatProvider, $"'{path}'");
        if (e.resultTypeName is {} resultTypeName) sb.Append(formatProvider, $" : {resultTypeName}");
        if (e.locator is { } locator) sb.Append(formatProvider, $", locator:'{locator}'");
        if (e.localId is { } localId) sb.Append(formatProvider, $", localId:'{localId}'");
        if (e is IHasExpressionSource { source: { } source }) sb.Append(formatProvider, $", source:{{{GetElementAsString(source, formatProvider)}}}");
        return sb.ToString();
    }

    public const int TypeForNotFound = 1;
}

internal static class CqlCompilerExceptionArgsExtensions
{
    public static CqlCompilerException ToException(this CqlExpressionBuilderError error, Exception? innerException = null) => new(error, innerException);
}