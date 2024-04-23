using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Hl7.Cql.Abstractions.Infrastructure;

namespace Hl7.Cql.Compiler;

[DebuggerDisplay("{DebuggerView}")]
partial class ExpressionBuilderContext : IBuilderContext
{
    private IBuilderContext CreateBuilderNode() => new ExpressionBuilderNode()
    {
        LibraryExpressionBuilder = _libraryContext,
        ElementStackList = [.. _elementStack],
        ElementStackPosition = 0,
    };

    IBuilderContext? IBuilderContext.OuterBuilderContext =>
        CreateBuilderNode().OuterBuilderContext;

    BuilderContextDebuggerInfo? IBuilderContext.DebuggerInfo =>
        CreateBuilderNode().DebuggerInfo;

    private string FormatMessage(string message, Elm.Element? element = null)
    {
        var locator = element?.locator;

        return string.IsNullOrWhiteSpace(locator)
            ? $"{_libraryContext.LibraryKey}: {message}"
            : $"{_libraryContext.LibraryKey} line {locator}: {message}";
    }

    public string DebuggerView => this.GetDebuggerView();

    private IPopToken PushElement(Elm.Element element)
    {
        _elementStack.TryPeek(out var previous);
        if (previous == element) return EmptyDisposable.Instance;

        _elementStack = _elementStack.Push(element);
        return new PopElementToken(this, previous);
    }

    private readonly record struct ExpressionBuilderNode : IBuilderContext
    {
        public ILibraryExpressionBuilderContext LibraryExpressionBuilder { get; init; }
        public IReadOnlyList<Elm.Element> ElementStackList { get; init; }
        public int ElementStackPosition { get; init; }

        public IBuilderContext? OuterBuilderContext => ElementStackPosition < ElementStackList.Count - 1
            ? this with { ElementStackPosition = ElementStackPosition + 1 }
            : LibraryExpressionBuilder;

        public BuilderContextDebuggerInfo? DebuggerInfo => ElementStackPosition >= 0 && ElementStackPosition < ElementStackList.Count
            ? BuilderContextDebuggerInfo.FromElement(ElementStackList[ElementStackPosition])
            : null!;
    }

    private readonly record struct PopElementToken : IPopToken
    {
        private readonly ExpressionBuilderContext _owner;
        private readonly Elm.Element? _previousElement;

        public PopElementToken(ExpressionBuilderContext owner, Elm.Element? previousElement)
        {
            _owner = owner;
            _previousElement = previousElement;
        }

        void IDisposable.Dispose() => Pop();

        public void Pop()
        {
            var expectedPreviousElement = _owner._elementStack.ElementAtOrDefault(1);

            if (_previousElement != expectedPreviousElement)
                throw new InvalidOperationException("Popping should be called in the correct reverse order.");

            _owner._elementStack = _owner._elementStack.Pop();
        }
    }
}