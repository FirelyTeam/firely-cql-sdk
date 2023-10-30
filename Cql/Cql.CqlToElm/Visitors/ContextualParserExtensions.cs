﻿using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;

namespace Hl7.Cql.CqlToElm.Visitors
{
    internal static class ContextualParserExtensions
    {
        // quantity: NUMBER unit?;
        public static (decimal value, string unit) Parse(this cqlParser.QuantityContext context)
        {
            var value = context.NUMBER().GetText();
            if (!decimal.TryParse(value, NumberStyles.Number, CultureInfo.InvariantCulture, out var decimalValue))
                throw new InvalidOperationException($"Value {value} is not a valid decimal.");

            // This is either a unit, or a datetimeprecision (which we parse as text here)
            var unitText = context.unit().STRING().ParseString() ?? context.unit().GetText();
            var unit = translateUnit(unitText);

            return (decimalValue, unit!);

            static string translateUnit(string u) => u switch
            {
                "year" or "years" => "a",
                "month" or "months" => "mo",
                "week" or "weeks" => "wk",
                "day" or "days" => "d",
                "hour" or "hours" => "h",
                "minute" or "minutes" => "min",
                "second" or "seconds" => "s",
                "millisecond" or "milliseconds" => "ms",
                _ => u
            };
        }


        // pluralDateTimePrecision: 'years' | 'months' | 'weeks' | 'days' | 'hours' | 'minutes' | 'seconds' | 'milliseconds'
        public static DateTimePrecision Parse(this cqlParser.PluralDateTimePrecisionContext context) =>
           context.GetText() switch
           {
               "years" => DateTimePrecision.Year,
               "months" => DateTimePrecision.Month,
               "weeks" => DateTimePrecision.Week,
               "days" => DateTimePrecision.Day,
               "hours" => DateTimePrecision.Hour,
               "minutes" => DateTimePrecision.Minute,
               "seconds" => DateTimePrecision.Second,
               "milliseconds" => DateTimePrecision.Millisecond,
               _ => throw new InvalidOperationException($"Encountered invalid plural date time precision {context.GetText()}.")
           };

        // pluralDateTimePrecision: 'year' | 'month' | 'week' | 'day' | 'hour' | 'minute' | 'second' | 'millisecond'
        public static DateTimePrecision Parse(this cqlParser.DateTimePrecisionContext context) =>
           context.GetText() switch
           {
               "year" => DateTimePrecision.Year,
               "month" => DateTimePrecision.Month,
               "week" => DateTimePrecision.Week,
               "day" => DateTimePrecision.Day,
               "hour" => DateTimePrecision.Hour,
               "minute" => DateTimePrecision.Minute,
               "second" => DateTimePrecision.Second,
               "millisecond" => DateTimePrecision.Millisecond,
               _ => throw new InvalidOperationException($"Encountered invalid date time precision {context.GetText()}.")
           };

        // 'using' qualifiedIdentifier ('version' versionSpecifier)? ('called' localIdentifier)?
        public static UsingDef Parse(this cqlParser.UsingDefinitionContext context, IModelProvider provider)
        {
            // Although the rule allows for multiple qualifiers, it is not clear what a qualified model name would mean.
            // For now, we take the whole qualified name as the name of the model.
            var (ns, id) = context.qualifiedIdentifier().Parse();
            var modelName = string.IsNullOrWhiteSpace(ns) ? $"{id}" : $"{ns}.{id}";
            var modelVersion = context.versionSpecifier()?.STRING().ParseString();
            var localIdentifier = context.localIdentifier()?.identifier().Parse();

            var model = provider.ModelFromName(modelName, modelVersion)
                ?? throw new InvalidOperationException($"Model {modelName} version {modelVersion ?? "<unspecified>"} is not available.");

            var usingDef = new UsingDef()
            {
                uri = model.url,
                version = modelVersion,
                localIdentifier = localIdentifier ?? modelName,
            };

            return usingDef.WithLocator(context.Locator());
        }

        //  : accessModifier? 'valueset' identifier ':' valuesetId ('version' versionSpecifier)? codesystems?
        public static ValueSetDef Parse(this cqlParser.ValuesetDefinitionContext context)
        {
            var valueSetDef = new ValueSetDef
            {
                accessLevel = context.accessModifier().Parse(),
                name = context.identifier().Parse(),
                id = context.valuesetId().STRING().ParseString(),
                version = context.versionSpecifier()?.STRING().ParseString(),
                codeSystem = context.codesystems()?.codesystemIdentifier().Select(csi =>
                    csi.Parse()).ToArray(),
            }.WithLocator(context.Locator());

            return valueSetDef;
        }

        // : (qualifier '.')* identifier
        public static (string qualifier, string id) Parse(this cqlParser.QualifiedIdentifierContext context)
        {
            var qualifiers = context.qualifier().Select(q => q.identifier().Parse()!).ToArray();

            if (qualifiers.Any())
            {
                if (qualifiers.Length > 1)
                    throw new InvalidOperationException($"Multiple qualifiers not supported.");

                return (qualifiers.Single(), context.identifier().Parse()!);
            }
            else
                return (string.Empty, context.identifier().Parse()!);
        }

        //   : 'include' qualifiedIdentifier ('version' versionSpecifier)? ('called' localIdentifier)?
        public static IncludeDef Parse(this cqlParser.IncludeDefinitionContext context)
        {
            var (qualifier, id) = context.qualifiedIdentifier().Parse();

            var includeDef = new IncludeDef
            {
                path = string.IsNullOrWhiteSpace(qualifier) ? id : $"{qualifier}.{id}",
                localIdentifier = context.localIdentifier()?.identifier().Parse(),
                version = context.versionSpecifier()?.STRING().ParseString(),
            }.WithLocator(context.Locator());

            return includeDef;
        }

        //: accessModifier? 'concept' identifier ':' '{' codeIdentifier(',' codeIdentifier)* '}' displayClause?
        public static ConceptDef Parse(this cqlParser.ConceptDefinitionContext context)
        {
            var conceptDef = new ConceptDef
            {
                accessLevel = context.accessModifier().Parse(),
                name = context.identifier().Parse(),
                code = context.codeIdentifier().Select(ci => ci.Parse()).ToArray(),
                display = context.displayClause()?.STRING().ParseString(),
            }.WithLocator(context.Locator());

            return conceptDef;
        }


        //accessModifier? 'codesystem' identifier ':' codesystemId('version' versionSpecifier)?
        public static CodeSystemDef Parse(this cqlParser.CodesystemDefinitionContext context)
        {
            var codeSystemDef = new CodeSystemDef
            {
                accessLevel = context.accessModifier().Parse(),
                name = context.identifier().Parse(),
                id = context.codesystemId().STRING().ParseString(),
                version = context.versionSpecifier()?.STRING().ParseString(),
            }.WithLocator(context.Locator());

            return codeSystemDef;
        }


        // : (libraryIdentifier '.')? identifier
        public static CodeRef Parse(this cqlParser.CodeIdentifierContext context)
        {
            var codeRef = new CodeRef
            {
                libraryName = context.libraryIdentifier()?.identifier().Parse(),
                name = context.identifier().Parse(),
            }.WithLocator(context.Locator());
            return codeRef;
        }

        //: accessModifier? 'code' identifier ':' codeId 'from' codesystemIdentifier displayClause?
        public static CodeDef Parse(this cqlParser.CodeDefinitionContext context)
        {
            var codeDef = new CodeDef()
            {
                accessLevel = context.accessModifier().Parse(),
                name = context.identifier().Parse(),
                id = context.codeId().STRING().ParseString(),
                codeSystem = context.codesystemIdentifier().Parse(),
                display = context.displayClause()?.STRING()?.ParseString(),
            }.WithLocator(context.Locator());

            return codeDef;
        }

        // : (libraryIdentifier '.')? identifier
        public static CodeSystemRef? Parse(this cqlParser.CodesystemIdentifierContext context)
        {
            if (context is null) return null;

            var csRef = new CodeSystemRef
            {
                libraryName = context.libraryIdentifier()?.identifier().Parse(),
                name = context.identifier().Parse(),
            }.WithLocator(context.Locator());

            return csRef;
        }

        public static string? Parse([NotNullIfNotNull(nameof(context))] this cqlParser.IdentifierContext? context)
        {
            if (context is null) return null;

            if (context.IDENTIFIER() is { } identifier)
                return identifier.ParseIdentifier();
            else if (context.QUOTEDIDENTIFIER() is { } quotedIdentifier)
                return quotedIdentifier.ParseQuotedIdentifier();
            else if (context.DELIMITEDIDENTIFIER() is { } delimitedIdentifier)
                return delimitedIdentifier.ParseDelimitedIdentifier();
            else
                throw new InvalidOperationException($"Identifier {context.GetText()} is not supported.");
        }

        public static AccessModifier Parse(this cqlParser.AccessModifierContext? context,
            AccessModifier @default = AccessModifier.Public)
        {
            if (context is null) return @default;

            return context.GetText().ToLower() switch
            {
                "public" => AccessModifier.Public,
                "private" => AccessModifier.Private,
                _ => throw new InvalidOperationException($"Access modifier {context.GetText()} is not supported")
            };
        }

        //    : 'context' (modelIdentifier '.')? identifier
        public static (NamedTypeSpecifier type, ContextDef cd) Parse(this cqlParser.ContextDefinitionContext context, LibraryContext library)
        {
            var identifier = context.identifier().Parse()!;
            var modelIdentifier = context.modelIdentifier()?.identifier().Parse();

            _ = library.TryResolveNamedTypeSpecifier(modelIdentifier, identifier, out var namedType, out var error);

            var cd = new ContextDef
            {
                name = modelIdentifier is null ? identifier : $"{modelIdentifier}.{identifier}"
            }.WithLocator(context.Locator());

            if (error is not null) cd.AddError(error, ErrorType.semantic);

            return (namedType, cd);
        }

        // 'define' accessModifier? identifier ':' expression
        public static ExpressionDef Parse(this cqlParser.ExpressionDefinitionContext context, ExpressionVisitor expressionVisitor)
        {
            var expression = expressionVisitor.Visit(context.expression());

            var def = new ExpressionDef
            {
                accessLevel = context.accessModifier().Parse(),
                name = context.identifier().Parse(),
                expression = expression,
            }.WithResultType(expression.resultTypeSpecifier).WithLocator(context.Locator());

            return def;
        }

        // : referentialIdentifier typeSpecifier
        public static TupleElementDefinition Parse(this cqlParser.TupleElementDefinitionContext context, TypeSpecifierVisitor typeSpecVisitor)
        {
            var name = context.referentialIdentifier().GetText();
            var type = typeSpecVisitor.Visit(context.typeSpecifier());

            var ted = new TupleElementDefinition
            {
                name = name,
                elementType = type,
            }.WithLocator(context.Locator());

            return ted;
        }

        //  referentialIdentifier ':' expression
        public static TupleElement Parse(this cqlParser.TupleElementSelectorContext context, ExpressionVisitor expressionVisitor)
        {
            var name = context.referentialIdentifier().GetText();
            var expression = expressionVisitor.Visit(context.expression());

            var te = new TupleElement
            {
                name = name,
                value = expression,
            };

            return te;
        }

        //    : 'library' qualifiedIdentifier ('version' versionSpecifier)?
        public static VersionedIdentifier Parse(this cqlParser.LibraryDefinitionContext context)
        {
            var id = context.qualifiedIdentifier().Parse();

            var versionedIdentifier = new VersionedIdentifier
            {
                id = id.id,
                system = id.qualifier,
                version = context.versionSpecifier()?.STRING().ParseString()
            };

            return versionedIdentifier;
        }

    }
}
