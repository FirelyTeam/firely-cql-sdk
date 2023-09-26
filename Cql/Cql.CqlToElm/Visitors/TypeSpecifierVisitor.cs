using Antlr4.Runtime.Misc;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;
using System;
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

            public override TypeSpecifier ReplaceGenericParameters(GenericParameterAssignments assignments)
            {
                throw new NotImplementedException();
            }
        }

        public TypeSpecifierVisitor(
            IServiceProvider services,
            LibraryContext libraryContext,
            TupleElementDefinitionVisitor tedVisitor) : base(services)
        {
            LibraryContext = libraryContext;
            TupleElementDefinitionVisitor = tedVisitor;
        }

        private readonly LibraryContext LibraryContext;
        private TupleElementDefinitionVisitor TupleElementDefinitionVisitor { get; }


        //     : 'Choice' '<' typeSpecifier (',' typeSpecifier)* '>'
        public override TypeSpecifier VisitChoiceTypeSpecifier([NotNull] cqlParser.ChoiceTypeSpecifierContext context)
        {
            var choice = new ChoiceTypeSpecifier
            {
                choice = context.typeSpecifier().Select(Visit).ToArray(),
            }.WithLocator(context);

            return choice;
        }

        //    : 'Interval' '<' typeSpecifier '>'
        public override TypeSpecifier VisitIntervalTypeSpecifier([NotNull] cqlParser.IntervalTypeSpecifierContext context)
        {
            var pointType = Visit(context.typeSpecifier());
            var its = new IntervalTypeSpecifier
            {
                pointType = pointType,
            }.WithLocator(context);

            return its;
        }

        //    : 'List' '<' typeSpecifier '>'
        public override TypeSpecifier VisitListTypeSpecifier([NotNull] cqlParser.ListTypeSpecifierContext context)
        {
            var elementType = Visit(context.typeSpecifier());
            var lts = new ListTypeSpecifier
            {
                elementType = elementType,
            }.WithLocator(context);

            return lts;
        }

        // : 'Tuple' '{' tupleElementDefinition (',' tupleElementDefinition)* '}'
        public override TypeSpecifier VisitTupleTypeSpecifier([NotNull] cqlParser.TupleTypeSpecifierContext context)
        {
            var tuple = new TupleTypeSpecifier
            {
                element = context.tupleElementDefinition().Select(TupleElementDefinitionVisitor.Visit).ToArray(),
            }.WithLocator(context);

            return tuple;
        }


        //    : (qualifier '.')* referentialOrTypeNameIdentifier
        public override TypeSpecifier VisitNamedTypeSpecifier([NotNull] cqlParser.NamedTypeSpecifierContext context)
        {
            var qualifiers = context.qualifier().Select(q => q.identifier().Parse()!).ToArray();
            var unqualified = (UnqualifiedTypeNameSpecifier)Visit(context.referentialOrTypeNameIdentifier());

            var typeName = string.Join('.', qualifiers.Append(unqualified.UnqualifiedName));
            var (qtn, _) = LibraryContext.ResolveDottedTypeName(typeName);

            return new NamedTypeSpecifier
            {
                name = qtn,
            }.WithLocator(context);
        }

        // : identifier | keywordIdentifier;
        public override TypeSpecifier VisitReferentialIdentifier([NotNull] cqlParser.ReferentialIdentifierContext context)
        {
            string typeName = context.keywordIdentifier()?.GetText() ??
                context.identifier().Parse()!;

            return new UnqualifiedTypeNameSpecifier(typeName).WithLocator(context);
        }

        // typeNameIdentifier: 'Code' | 'Concept' | 'date'| 'time';
        public override TypeSpecifier VisitTypeNameIdentifier([NotNull] cqlParser.TypeNameIdentifierContext context)
        {
            // These are reserved words that are also valid type names
            return new UnqualifiedTypeNameSpecifier(context.GetText()).WithLocator(context);
        }
    }
}
