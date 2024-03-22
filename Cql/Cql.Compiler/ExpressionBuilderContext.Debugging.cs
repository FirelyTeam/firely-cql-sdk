using System.Diagnostics;
using elm = Hl7.Cql.Elm;

namespace Hl7.Cql.Compiler;

[DebuggerDisplay("{DebuggerView}")]
partial class ExpressionBuilderContext : IBuilderContext
{
    private readonly Elm.Element _element;

    private readonly ExpressionBuilderContext? _outerContext;

    IBuilderContext? IBuilderContext.OuterContext => (IBuilderContext?)_outerContext ?? LibraryContext;

    BuilderContextInfo IBuilderContext.ContextInfo => BuilderContextInfo.FromElement(_element);

    public string FormatMessage(string message, elm.Element? element = null)
    {
        var locator = element?.locator;

        return string.IsNullOrWhiteSpace(locator)
            ? $"{LibraryContext.LibraryKey}: {message}"
            : $"{LibraryContext.LibraryKey} line {locator}: {message}";
    }

    public string DebuggerView => this.GetDebuggerView();
}