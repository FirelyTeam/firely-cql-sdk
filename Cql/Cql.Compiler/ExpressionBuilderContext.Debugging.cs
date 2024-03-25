using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using elm = Hl7.Cql.Elm;

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

    private string FormatMessage(string message, elm.Element? element = null)
    {
        var locator = element?.locator;

        return string.IsNullOrWhiteSpace(locator)
            ? $"{LibraryContext.LibraryKey}: {message}"
            : $"{LibraryContext.LibraryKey} line {locator}: {message}";
    }

    public string DebuggerView => this.GetDebuggerView();

    private IDisposable PushElement(elm.Element element)
    {
        elm.Element? previous = _elementStack.Any() ? _elementStack.Peek() : null;
        if (previous == element) return new EmptyDisposable();

        _elementStack.Push(element);
        return new PopElementToken(this) { PreviousElement = previous };
    }

    private readonly record struct ExpressionBuilderNode : IBuilderNode
    {
        public LibraryExpressionBuilder LibraryExpressionBuilder { get; init; }
        public List<elm.Element> ElementStackList { get; init; }
        public int ElementStackPosition { get; init; }

        public IBuilderNode? OuterBuilder => ElementStackPosition > 0
            ? this with { ElementStackPosition = ElementStackPosition - 1 }
            : LibraryExpressionBuilder;

        public BuilderDebuggerInfo? BuilderDebuggerInfo => ElementStackPosition >= 0
            ? Hl7.Cql.Compiler.BuilderDebuggerInfo.FromElement(ElementStackList[ElementStackPosition])
            : null!;
    }

    private readonly record struct PopElementToken : IDisposable
    {
        private readonly ExpressionBuilder _owner;

        public PopElementToken(ExpressionBuilder Owner)
        {
            _owner = Owner;
        }

        public elm.Element? PreviousElement { get; init; }

        void IDisposable.Dispose() => _ = _owner._elementStack.Pop();
    }

    private readonly record struct EmptyDisposable : IDisposable
    {
        void IDisposable.Dispose()
        {
        }
    }
}