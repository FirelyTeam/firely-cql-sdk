using System.Diagnostics;
using elm = Hl7.Cql.Elm;

namespace Hl7.Cql.Compiler;

[DebuggerDisplay("{DebuggerView}")]
partial class ContextualExpressionBuilder : IContextualExpressionBuilder
{
    private readonly Elm.Element _element;

    private readonly ContextualExpressionBuilder? _outerContext;

    IContextualExpressionBuilder? IContextualExpressionBuilder.OuterContext => (IContextualExpressionBuilder?)_outerContext ?? LibraryContext;

    BuilderContextInfo IContextualExpressionBuilder.ContextInfo => BuilderContextInfo.FromElement(_element);

    private string FormatMessage(string message, elm.Element? element = null)
    {
        var locator = element?.locator;

        return string.IsNullOrWhiteSpace(locator)
            ? $"{LibraryContext.LibraryKey}: {message}"
            : $"{LibraryContext.LibraryKey} line {locator}: {message}";
    }

    public string DebuggerView => this.GetDebuggerView();
}