using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;
using System;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;

namespace Hl7.Cql.CqlToElm.Visitors
{
    internal static class ContextualParserExtensions
    {
        private static readonly ObjectIDGenerator _idGenerator = new ObjectIDGenerator();

        public static string NextId(object context) => _idGenerator.GetId(context, out _)
                .ToString(CultureInfo.InvariantCulture);

        // : (qualifier '.')* identifier
        public static (string qualifier, string id) Parse(this cqlParser.QualifiedIdentifierContext context)
        {
            var qualifiers = context.qualifier().Select(q => q.identifier().Parse()!).ToArray();

            if (qualifiers.Any())
            {
                if (qualifiers.Length > 1)
                    throw new InvalidOperationException($"Multiple qualifiers not supported");

                return (qualifiers.Single(), context.identifier().Parse()!);
            }
            else
                return (string.Empty, context.identifier().Parse()!);
        }

        //   : 'year' | 'month' | 'week' | 'day' | 'hour' | 'minute' | 'second' | 'millisecond'
        public static DateTimePrecision Parse(this cqlParser.DateTimePrecisionContext context) =>
              context?.GetText() switch
              {
                  "year" => DateTimePrecision.Year,
                  "month" => DateTimePrecision.Month,
                  "week" => DateTimePrecision.Week,
                  "day" => DateTimePrecision.Day,
                  "hour" => DateTimePrecision.Hour,
                  "minute" => DateTimePrecision.Minute,
                  "second" => DateTimePrecision.Second,
                  "millisecond" => DateTimePrecision.Millisecond,
                  var other => throw new InvalidOperationException($"Unknown precision '{other}'")
              };

        //: accessModifier? 'concept' identifier ':' '{' codeIdentifier(',' codeIdentifier)* '}' displayClause?
        public static ConceptDef Parse(this cqlParser.ConceptDefinitionContext context)
        {
            var conceptDef = new ConceptDef
            {
                accessLevel = context.accessModifier().Parse(),
                name = context.identifier().Parse(),
                code = context.codeIdentifier().Select(ci => ci.Parse()).ToArray(),
                display = context.displayClause()?.STRING().ParseString(),

                localId = NextId(context),
                locator = context.Locator()
            };
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

                localId = NextId(context),
                locator = context.Locator()
            };

            return codeSystemDef;
        }


        // : (libraryIdentifier '.')? identifier
        public static CodeRef Parse(this cqlParser.CodeIdentifierContext context)
        {
            var codeRef = new CodeRef
            {
                libraryName = context.libraryIdentifier()?.identifier().Parse(),
                name = context.identifier().Parse(),
                localId = NextId(context),
                locator = context.Locator()
            };
            return codeRef;
        }

        //: accessModifier? 'code' identifier ':' codeId 'from' codesystemIdentifier displayClause?
        public static CodeDef Parse(this cqlParser.CodeDefinitionContext context)
        {
            return new()
            {
                accessLevel = context.accessModifier().Parse(),
                name = context.identifier().Parse(),
                id = context.codeId().STRING().ParseString(),
                codeSystem = context.codesystemIdentifier().Parse(),
                display = context.displayClause()?.STRING()?.ParseString(),

                localId = NextId(context),
                locator = context.Locator()
            };
        }

        // : (libraryIdentifier '.')? identifier
        public static CodeSystemRef? Parse(this cqlParser.CodesystemIdentifierContext context)
        {
            if (context is null) return null;

            var csRef = new CodeSystemRef
            {
                libraryName = context.libraryIdentifier()?.identifier().Parse(),
                name = context.identifier().Parse(),
                localId = NextId(context),
                locator = context.Locator()
            };
            return csRef;
        }

        public static string? Parse(this cqlParser.IdentifierContext? context)
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
    }
}
