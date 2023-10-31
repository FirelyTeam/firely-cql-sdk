using Antlr4.Runtime.Misc;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hl7.Cql.CqlToElm.Visitors
{
    internal class TypeSpecifierVisitor : Visitor<TypeSpecifier>
    {
        private class UnqualifiedTypeNameSpecifier : TypeSpecifier
        {
            public UnqualifiedTypeNameSpecifier(string unqualifiedName)
            {
                UnqualifiedName = unqualifiedName;
            }

            public string UnqualifiedName { get; set; }

            internal override TypeSpecifier ReplaceGenericParameters(GenericParameterAssignments assignments) => this;

            internal override IEnumerable<ParameterTypeSpecifier> GetGenericParameters() => Enumerable.Empty<ParameterTypeSpecifier>();
        }

        public TypeSpecifierVisitor(
            LibraryContext libraryContext,
            LocalIdentifierProvider localIdentifierProvider,
            InvocationBuilder invocationBuilder) : base(localIdentifierProvider, invocationBuilder)
        {
            LibraryContext = libraryContext;
        }

        private readonly LibraryContext LibraryContext;

        //     : 'Choice' '<' typeSpecifier (',' typeSpecifier)* '>'
        public override TypeSpecifier VisitChoiceTypeSpecifier([NotNull] cqlParser.ChoiceTypeSpecifierContext context)
        {
            var choice = new ChoiceTypeSpecifier
            {
                choice = context.typeSpecifier().Select(Visit).ToArray(),
            }.WithLocator(context.Locator());

            return choice;
        }

        //    : 'Interval' '<' typeSpecifier '>'
        public override TypeSpecifier VisitIntervalTypeSpecifier([NotNull] cqlParser.IntervalTypeSpecifierContext context)
        {
            var pointType = Visit(context.typeSpecifier());
            var its = new IntervalTypeSpecifier
            {
                pointType = pointType,
            }.WithLocator(context.Locator());

            return its;
        }

        //    : 'List' '<' typeSpecifier '>'
        public override TypeSpecifier VisitListTypeSpecifier([NotNull] cqlParser.ListTypeSpecifierContext context)
        {
            var elementType = Visit(context.typeSpecifier());
            var lts = new ListTypeSpecifier
            {
                elementType = elementType,
            }.WithLocator(context.Locator());

            return lts;
        }

        // : 'Tuple' '{' tupleElementDefinition (',' tupleElementDefinition)* '}'
        public override TypeSpecifier VisitTupleTypeSpecifier([NotNull] cqlParser.TupleTypeSpecifierContext context)
        {
            var tuple = new TupleTypeSpecifier
            {
                element = context.tupleElementDefinition().Select(ted => ted.Parse(this)).ToArray(),
            }.WithLocator(context.Locator());

            return tuple;
        }


        //    : (qualifier '.')* referentialOrTypeNameIdentifier
        public override TypeSpecifier VisitNamedTypeSpecifier([NotNull] cqlParser.NamedTypeSpecifierContext context)
        {
            var qualifiers = context.qualifier().Select(q => q.identifier().Parse()!).ToArray();
            var unqualified = (UnqualifiedTypeNameSpecifier)Visit(context.referentialOrTypeNameIdentifier());

            if (qualifiers.Length > 1)
                throw new InvalidOperationException($"Multiple qualifiers not supported.");

            _ = LibraryContext.TryResolveNamedTypeSpecifier(qualifiers.SingleOrDefault(), unqualified.UnqualifiedName, out var result, out var error);

            if (error is not null) result.AddError(error, ErrorType.semantic);

            return result.WithLocator(context.Locator());
        }

        // : identifier | keywordIdentifier;
        public override TypeSpecifier VisitReferentialIdentifier([NotNull] cqlParser.ReferentialIdentifierContext context)
        {
            string typeName = context.keywordIdentifier()?.GetText() ??
                context.identifier().Parse()!;

            return new UnqualifiedTypeNameSpecifier(typeName).WithLocator(context.Locator());
        }

        // typeNameIdentifier: 'Code' | 'Concept' | 'date'| 'time';
        public override TypeSpecifier VisitTypeNameIdentifier([NotNull] cqlParser.TypeNameIdentifierContext context)
        {
            // These are reserved words that are also valid type names
            return new UnqualifiedTypeNameSpecifier(context.GetText()).WithLocator(context.Locator());
        }
    }
}
