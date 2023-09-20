using Antlr4.Runtime.Misc;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;
using System;
using System.Linq;

namespace Hl7.Cql.CqlToElm.Visitors
{
    internal class TypeSpecifierVisitor : Visitor<TypeSpecifier>
    {
        public TypeSpecifierVisitor(
            IServiceProvider services,
            IModelProvider modelProvider,
            LibraryContext libraryContext,
            TupleElementDefinitionVisitor tedVisitor) : base(services)
        {
            SystemModel = modelProvider.GetSystemModel(libraryContext.Library
                ?? throw new InvalidOperationException($"No library is in context"));

            ModelProvider = modelProvider;
            LibraryContext = libraryContext;
            TupleElementDefinitionVisitor = tedVisitor;
        }

        private IModelProvider ModelProvider { get; }
        private LibraryContext LibraryContext { get; }
        private TupleElementDefinitionVisitor TupleElementDefinitionVisitor { get; }

        private readonly Model.ModelInfo SystemModel;

        //     : 'Choice' '<' typeSpecifier (',' typeSpecifier)* '>'
        public override TypeSpecifier VisitChoiceTypeSpecifier([NotNull] cqlParser.ChoiceTypeSpecifierContext context)
        {
            var choice = new ChoiceTypeSpecifier
            {
                choice = context.typeSpecifier().Select(Visit).ToArray(),
                localId = NextId(),
                locator = context.Locator(),
            };

            return choice;
        }

        //    : 'Interval' '<' typeSpecifier '>'
        public override TypeSpecifier VisitIntervalTypeSpecifier([NotNull] cqlParser.IntervalTypeSpecifierContext context)
        {
            var pointType = Visit(context.typeSpecifier());
            var its = new IntervalTypeSpecifier
            {
                pointType = pointType,
                localId = NextId(),
                locator = context.Locator(),
            };
            return its;
        }

        //    : 'List' '<' typeSpecifier '>'
        public override TypeSpecifier VisitListTypeSpecifier([NotNull] cqlParser.ListTypeSpecifierContext context)
        {
            var elementType = Visit(context.typeSpecifier());
            var lts = new ListTypeSpecifier
            {
                elementType = elementType,
                localId = NextId(),
                locator = context.Locator(),
            };
            return lts;
        }


        //    : (qualifier '.')* referentialOrTypeNameIdentifier
        public override TypeSpecifier VisitNamedTypeSpecifier([NotNull] cqlParser.NamedTypeSpecifierContext context)
        {
            var qualifiers = context.qualifier().Select(q => q.identifier().Parse()!).ToArray();
            var typeSpec = (NamedTypeSpecifier)Visit(context.referentialOrTypeNameIdentifier());

            System.Xml.XmlQualifiedName? name = null;

            if (qualifiers.Any())
            {
                if (qualifiers.Length > 1)
                    throw Critical($"Multiple qualifiers not supported");

                var modelName = qualifiers.Single();
                var model = ModelProvider.ModelFromName(modelName)
                    ?? throw Critical($"Unknown model {modelName}");

                var typeName = typeSpec.name.Name;
                var qtn = ModelProvider.QualifiedTypeName(model, typeName)
                    ?? throw Critical($"Unable to resolve type {typeName} in model {model.name}");
                name = new System.Xml.XmlQualifiedName(qtn);
            }
            else
            {
                var typeName = typeSpec.name.Name;
                (name, _) = LibraryContext.UnambiguousType(typeName);
            }

            return new NamedTypeSpecifier
            {
                name = name,
                localId = NextId(),
                locator = context.Locator()
            };
        }

        // : identifier | keywordIdentifier;
        public override TypeSpecifier VisitReferentialIdentifier([NotNull] cqlParser.ReferentialIdentifierContext context)
        {
            string typeName = context.keywordIdentifier()?.GetText() ??
                context.identifier().Parse()!;

            return new NamedTypeSpecifier()
            {
                name = new System.Xml.XmlQualifiedName(typeName),
                localId = NextId(),
                locator = context.Locator()
            };
        }

        public override TypeSpecifier VisitTypeNameIdentifier([NotNull] cqlParser.TypeNameIdentifierContext context)
        {
            string typeName = context.GetText();

            return new NamedTypeSpecifier()
            {
                name = new System.Xml.XmlQualifiedName(typeName),
                localId = NextId(),
                locator = context.Locator()
            };
        }

        // : 'Tuple' '{' tupleElementDefinition (',' tupleElementDefinition)* '}'
        public override TypeSpecifier VisitTupleTypeSpecifier([NotNull] cqlParser.TupleTypeSpecifierContext context)
        {
            var tuple = new TupleTypeSpecifier
            {
                element = context.tupleElementDefinition().Select(TupleElementDefinitionVisitor.Visit).ToArray(),
                localId = NextId(),
                locator = context.Locator(),
            };

            return tuple;
        }

    }
}
