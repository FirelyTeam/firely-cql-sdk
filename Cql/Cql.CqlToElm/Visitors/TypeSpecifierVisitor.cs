using Antlr4.Runtime.Misc;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using NotNullWhenAttribute = System.Diagnostics.CodeAnalysis.NotNullWhenAttribute;
namespace Hl7.Cql.CqlToElm.Visitors
{
    internal class TypeSpecifierVisitor : Visitor<TypeSpecifier>
    {
        public LibraryBuilder LibraryBuilder { get; }
        public MessageProvider Messaging { get; }
        public CqlToElmOptions Options { get; }

        public TypeSpecifierVisitor(IServiceProvider services,
            LibraryBuilder libraryBuilder)
        {
            LibraryBuilder = libraryBuilder;
            Messaging = services.GetRequiredService<MessageProvider>();
            Options = services.GetRequiredService<IOptions<CqlToElmOptions>>().Value;
        }

        // : 'Choice' '<' typeSpecifier (',' typeSpecifier)* '>'
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
        public override TypeSpecifier VisitTupleTypeSpecifier([NotNull] cqlParser.TupleTypeSpecifierContext context) =>
            new TupleTypeSpecifier
            {
                element = context.tupleElementDefinition()
                    .Select(ted => ted.Parse(this))
                    .OrderBy(ted => ted.name)
                    .ToArray(),
            }.WithLocator(context.Locator());


        //    : (qualifier '.')* referentialOrTypeNameIdentifier
        public override TypeSpecifier VisitNamedTypeSpecifier([NotNull] cqlParser.NamedTypeSpecifierContext context)
        {
            //// Could be FHIR.Patient.Contact, so the first part is the library name, and the last part(s) are the type name.
            //var qualifiers = context.qualifier().Select(q => q.identifier().Parse()!).ToArray();

            var text = context.GetText();
            var firstDot = text.IndexOf('.');
            if (firstDot > -1)
            {
                var libraryName = text[0..firstDot];
                var typeName = text[(firstDot + 1)..];
                if (LibraryBuilder.SymbolTable.TryResolveSymbol(libraryName, out var model))
                {
                    if (model is UsingDefSymbol usingDef)
                    {
                        if (usingDef.Symbols.TryResolveSymbol(typeName, out var symbol))
                        {
                            if (symbol is TypeDef td)
                            {
                                return new NamedTypeSpecifier(td.uri!, td.name!)
                                    .WithLocator(context.Locator());
                            }
                        }
                    }
                }
            }
            else
            {
                var typeName = text;
                var usingDefs = LibraryBuilder.SymbolTable.OfType<UsingDefSymbol>();
                List<NamedTypeSpecifier> matches = new();
                foreach (var ud in usingDefs)
                {
                    if (ud.Symbols.TryResolveSymbol(typeName, out var symbol))
                    {
                        if (symbol is TypeDef td)
                        {
                            matches.Add(new NamedTypeSpecifier(td.uri!, td.name!)
                                .WithLocator(context.Locator()));
                        }
                    }
                }
                if (matches.Count == 1)
                    return matches[0];
                else if (matches.Count > 1)
                {
                    // Reference behavior when there is a conflict (e.g. FHIR.Quantity, System.Quantity) is to prefer the System type.
                    // So, an unqualified Quantity type in a library using FHIR will resolve to System.Quantity.
                    var behavior = Options.AmbiguousTypeBehavior ?? AmbiguousTypeBehavior.Error;
                    if (behavior == AmbiguousTypeBehavior.PreferSystem)
                    {
                        var systemMatches = matches
                            .Where(m => m.name.Name.StartsWith("{urn:hl7-org:elm-types:"))
                            .ToArray();
                        if (systemMatches.Length == 1)
                            return systemMatches[0];
                    }
                    else if (behavior == AmbiguousTypeBehavior.PreferModel)
                    {
                        var notSystemMatches = matches
                             .Where(m => !m.name.Name.StartsWith("{urn:hl7-org:elm-types:"))
                             .ToArray();
                        if (notSystemMatches.Length == 1)
                            return notSystemMatches[0];
                    }
                }
            }
            return new NamedTypeSpecifier(new System.Xml.XmlQualifiedName(Options.LiteralTypes.Default))
                    .WithLocator(context.Locator())
                    .AddError(Messaging.NamedTypeRequiredInContext());
        }

    }
}
