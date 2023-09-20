using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;
using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace Hl7.Cql.CqlToElm.Visitors
{
    internal static class ContextualParserExtensions
    {
        private static readonly ObjectIDGenerator _idGenerator = new ObjectIDGenerator();

        public static string NextId(object context) => _idGenerator.GetId(context, out _)
                .ToString(CultureInfo.InvariantCulture);

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
