using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;

namespace Hl7.Cql.Compiler;

[DebuggerDisplay("{DebuggerView}")]
partial class ExpressionBuilder : IBuilderNode
{
    private IBuilderNode CreateBuilderNode() => new ExpressionBuilderNode()
    {
        LibraryExpressionBuilder = _libraryContext,
        ElementStackList = [.. _elementStack],
        ElementStackPosition = 0,
    };

    IBuilderNode? IBuilderNode.OuterBuilder =>
        CreateBuilderNode().OuterBuilder;

    BuilderDebuggerInfo? IBuilderNode.BuilderDebuggerInfo =>
        CreateBuilderNode().BuilderDebuggerInfo;

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
        Elm.Element? previous = _elementStack.IsEmpty ? null : _elementStack.Peek();
        if (previous == element) return EmptyDisposable.Instance;

        _elementStack = _elementStack.Push(element);
        return new PopElementToken(this, previous);
    }

    private readonly record struct ExpressionBuilderNode : IBuilderNode
    {
        public LibraryExpressionBuilder LibraryExpressionBuilder { get; init; }
        public IReadOnlyList<Elm.Element> ElementStackList { get; init; }
        public int ElementStackPosition { get; init; }

        public IBuilderNode? OuterBuilder => ElementStackPosition < ElementStackList.Count - 1
            ? this with { ElementStackPosition = ElementStackPosition + 1 }
            : LibraryExpressionBuilder;

        public BuilderDebuggerInfo? BuilderDebuggerInfo => ElementStackPosition >= 0
            ? Hl7.Cql.Compiler.BuilderDebuggerInfo.FromElement(ElementStackList[ElementStackPosition])
            : null!;
    }

    private readonly record struct PopElementToken : IPopToken
    {
        private readonly ExpressionBuilder _owner;
        private readonly Elm.Element? _previousElement;

        public PopElementToken(ExpressionBuilder owner, Elm.Element? previousElement)
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