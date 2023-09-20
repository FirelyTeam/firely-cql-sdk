using Antlr4.Runtime.Misc;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm.Visitors
{
    internal class TypeSpecifierVisitor : Visitor<TypeSpecifier>
    {
        public TypeSpecifierVisitor(IServiceProvider services) : base(services)
        {
            SystemModel = ModelProvider.GetSystemModel(LibraryContext.Library
                ?? throw new InvalidOperationException($"No library is in context"));
        }

        private IModelProvider ModelProvider => Services.GetRequiredService<IModelProvider>();
        private LibraryContext LibraryContext => Services.GetRequiredService<LibraryContext>();
        private TupleElementDefinitionVisitor TupleElementDefinitionVisitor => Services.GetRequiredService<TupleElementDefinitionVisitor>();
        private readonly Model.ModelInfo SystemModel;

        public override TypeSpecifier VisitChoiceTypeSpecifier([NotNull] cqlParser.ChoiceTypeSpecifierContext context)
        {
            var elementCount = context.ChildCount - 3;
            if ((elementCount & 0x1) == 1)
                elementCount = (elementCount >> 1) + 1;
            else
                elementCount >>= 1;
            var choice = new ChoiceTypeSpecifier
            {
                choice = new TypeSpecifier[elementCount],
                localId = NextId(),
                locator = context.Locator(),
            };
            for(int i = 2, j = 0; i < context.ChildCount; i+=2)
            {
                choice.choice[j] = Visit(context.GetChild(i));
                j++;
            }
            return choice;
        }

        public override TypeSpecifier VisitIntervalTypeSpecifier([NotNull] cqlParser.IntervalTypeSpecifierContext context)
        {
            var pointType = Visit(context.GetChild(2));
            var its = new IntervalTypeSpecifier
            {
                pointType = pointType,
                localId = NextId(),
                locator = context.Locator(),
            };
            return its;
        }

        public override TypeSpecifier VisitListTypeSpecifier([NotNull] cqlParser.ListTypeSpecifierContext context)
        {
            var elementType = Visit(context.GetChild(2));
            var lts = new ListTypeSpecifier
            {
                elementType = elementType,
                localId = NextId(),
                locator = context.Locator(),
            };
            return lts;
        }

        public override TypeSpecifier VisitNamedTypeSpecifier([NotNull] cqlParser.NamedTypeSpecifierContext context)
        {
            System.Xml.XmlQualifiedName? name = null;
            if (context.ChildCount == 3)
            {
                var modelName = context.GetChild(0).GetText().AsSpan().Dequote().ToString();
                var model = ModelProvider.ModelFromName(modelName)
                    ?? throw Critical($"Unknown model {modelName}");
                var typeName = context.GetChild(2).GetText().AsSpan().Dequote().ToString();
                var qtn = ModelProvider.QualifiedTypeName(model, typeName)
                    ?? throw Critical($"Unable to resolve type {typeName} in model {model.name}");
                name = new System.Xml.XmlQualifiedName(qtn);
            }
            else
            {
                var typeName = context.GetChild(0).GetText().AsSpan().Dequote().ToString();
                var (qtn, templateId) = LibraryContext.UnambiguousType(typeName);
                name = qtn;
            }
            var nts = new NamedTypeSpecifier();
            nts.name = name;
            nts.localId = NextId();
            nts.locator = context.Locator();
            return nts;
        }

        public override TypeSpecifier VisitTupleTypeSpecifier([NotNull] cqlParser.TupleTypeSpecifierContext context)
        {
            var elementCount = context.ChildCount - 3;
            if ((elementCount & 0x1) == 1)
                elementCount = (elementCount >> 1) + 1;
            else
                elementCount >>= 1;
            var tuple = new TupleTypeSpecifier
            {
                element = new TupleElementDefinition[elementCount],
                localId = NextId(),
                locator = context.Locator(),
            };
            for (int i = 2, j = 0; i < context.ChildCount; i += 2)
            {
                tuple.element[j] = TupleElementDefinitionVisitor.Visit(context.GetChild(i));
                j++;
            }
            return tuple;
        }

    }
}
