using Antlr4.Runtime.Misc;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;
using System.Linq;

namespace Hl7.Cql.CqlToElm.Visitors
{
    internal class TypeSpecifierVisitor : Visitor<TypeSpecifier>
    {
        public LibraryBuilder LibraryBuilder { get; }

        public TypeSpecifierVisitor(
            LibraryBuilder libraryBuilder,
            LocalIdentifierProvider localIdentifierProvider,
            InvocationBuilder invocationBuilder) : base(localIdentifierProvider, invocationBuilder)
        {
            LibraryBuilder = libraryBuilder;
        }

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
            // Could be FHIR.Patient.Contact, so the first part is the library name, and the last part(s) are the type name.
            var qualifiers = context.qualifier().Select(q => q.identifier().Parse()!).ToArray();

            var libraryName = qualifiers.FirstOrDefault();
            var typeName = string.Join(".", qualifiers.Skip(1).Append(context.referentialOrTypeNameIdentifier().Parse()));

            _ = LibraryBuilder.SymbolTable.TryResolveNamedTypeSpecifier(libraryName, typeName, out var result, out var error);

            //TODO: Might need ErrorTypeSpecifier here
            result ??= new NamedTypeSpecifier($"urn:cql-unknown-type:{libraryName}", typeName);

            if (error is not null) result!.AddError(error);
            return result.WithLocator(context.Locator());
        }
    }
}
