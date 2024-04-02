using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Hl7.Cql.Compiler;

[DebuggerDisplay("{DebuggerView}")]
partial class ExpressionBuilder : IBuilderNode
{
   private readonly Stack<Elm.Element> _elementStack = new();

    private IBuilderNode CreateBuilderNode() => new ExpressionBuilderNode()
    {
        LibraryExpressionBuilder = LibraryContext,
        ElementStackList = _elementStack.ToList(),
        ElementStackPosition = _elementStack.Count - 1
    };

    IBuilderNode? IBuilderNode.OuterBuilder =>
        CreateBuilderNode().OuterBuilder;

    BuilderDebuggerInfo? IBuilderNode.BuilderDebuggerInfo =>
        CreateBuilderNode().BuilderDebuggerInfo;

    private string FormatMessage(string message, Elm.Element? element = null)
    {
        var locator = element?.locator;

        return string.IsNullOrWhiteSpace(locator)
            ? $"{LibraryContext.LibraryKey}: {message}"
            : $"{LibraryContext.LibraryKey} line {locator}: {message}";
    }

    public string DebuggerView => this.GetDebuggerView();

    private IPopToken PushElement(Elm.Element element)
    {
        Elm.Element? previous = _elementStack.Any() ? _elementStack.Peek() : null;
        if (previous == element) return new EmptyDisposable();

        _elementStack.Push(element);
        return new PopElementToken(this, previous);
    }

    private readonly record struct ExpressionBuilderNode : IBuilderNode
    {
        public LibraryExpressionBuilder LibraryExpressionBuilder { get; init; }
        public List<Elm.Element> ElementStackList { get; init; }
        public int ElementStackPosition { get; init; }

        public IBuilderNode? OuterBuilder => ElementStackPosition > 0
            ? this with { ElementStackPosition = ElementStackPosition - 1 }
            : LibraryExpressionBuilder;

        public BuilderDebuggerInfo? BuilderDebuggerInfo => ElementStackPosition >= 0
            ? Hl7.Cql.Compiler.BuilderDebuggerInfo.FromElement(ElementStackList[ElementStackPosition])
            : null!;
    }

    protected interface IPopToken : IDisposable
    {
        void Pop();
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
            var expectedPreviousElement = _owner._elementStack.Count > 1 ? _owner._elementStack.ElementAt(1) : null;
            if (_previousElement != expectedPreviousElement)
                throw new InvalidOperationException("Popping should be called in the correct reverse order.");

            _ = _owner._elementStack.Pop();
        }
    }

    private readonly record struct EmptyDisposable : IPopToken
    {
        void IDisposable.Dispose()
        {
        }

        void IPopToken.Pop()
        {
        }
    }
}