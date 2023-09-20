using Antlr4.Runtime;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;

namespace Hl7.Cql.CqlToElm.Visitors
{
    internal abstract class Visitor<T> : cqlBaseVisitor<T>
    {
        protected Visitor(IServiceProvider services) : base()
        {
            Services = services;
        }

        public IServiceProvider Services { get; }

        public ILogger<Visitor<T>> Log => Services.GetRequiredService<ILogger<Visitor<T>>>();

        protected IEqualityComparer<TypeSpecifier> TypeComparer => Services.GetRequiredService<IEqualityComparer<TypeSpecifier>>();


        protected string NextId() => Services.GetRequiredService<LocalIdentifierProvider>().Next();


        [DebuggerStepThrough]
        protected InvalidOperationException Critical(string message)
        {
            var ex = new InvalidOperationException(message);
            Log.LogCritical(ex, ex.Message);
            return ex;
        }

        protected string FormatLocator(int startLine, int startCol, int endLine, int endCol) =>
            $"{startLine}:{startCol}-{endLine}:{endCol}";

        protected NamedTypeSpecifier NamedType(string type, ParserRuleContext ctx) =>
            new NamedTypeSpecifier
            {
                name = new XmlQualifiedName(type),
            };

        protected IntervalTypeSpecifier IntervalType(TypeSpecifier pointType, ParserRuleContext ctx) =>
            new IntervalTypeSpecifier
            {
                pointType = pointType,
            };

        protected ListTypeSpecifier ListType(TypeSpecifier elementType, ParserRuleContext ctx) =>
            new ListTypeSpecifier
            {
                elementType = elementType,
            };

        protected bool UnitsAreCompatible(string unitsX, string unitsY) =>
            unitsX == unitsY;

        protected TypeSpecifier? PointType(TypeSpecifier? type)
        {
            if (type == null)
                return null;
            else if (type is IntervalTypeSpecifier intervalType)
            {
                return intervalType.pointType;
            }
            return null;
        }

    }
}
