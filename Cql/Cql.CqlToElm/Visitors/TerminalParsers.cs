using Antlr4.Runtime.Tree;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace Hl7.Cql.CqlToElm.Visitors
{
    internal static class TerminalParsers
    {
        public static string? ParseIdentifier(this ITerminalNode? terminal)
        {
            if (terminal is null) return null;
            if (terminal.Symbol.Type != cqlParser.IDENTIFIER)
                throw new InvalidOperationException($"Expected IDENTIFIER token, got {terminal.Symbol.Type}");

            return terminal.Symbol.Text;
        }

        public static string? ParseQuotedIdentifier(this ITerminalNode? terminal)
        {
            if (terminal is null) return null;
            if (terminal.Symbol.Type != cqlParser.QUOTEDIDENTIFIER)
                throw new InvalidOperationException($"Expected QUOTEDIDENTIFIER token, got {terminal.Symbol.Type}");

            var str = terminal.Symbol.Text;
            if (str[0] == '\"' && str[^1] == '\"')
                str = str[1..^1];
            else
                throw new InvalidOperationException("Expected QUOTEDIDENTIFIER token to start and end with double quote.");

            return Regex.Unescape(str);
        }

        public static string? ParseDelimitedIdentifier(this ITerminalNode? terminal)
        {
            if (terminal is null) return null;
            if (terminal.Symbol.Type != cqlParser.DELIMITEDIDENTIFIER)
                throw new InvalidOperationException($"Expected DELIMITEDIDENTIFIER token, got {terminal.Symbol.Type}");

            var str = terminal.Symbol.Text;
            if (str[0] == '`' && str[^1] == '`')
                str = str[1..^1];
            else
                throw new InvalidOperationException("Expected DELIMITEDIDENTIFIER token to start and end with a backtick.");

            return Regex.Unescape(str);
        }
        public static string? ParseString(this ITerminalNode? terminal)
        {
            if (terminal is null) return null;
            if (terminal.Symbol.Type != cqlParser.STRING)
                throw new InvalidOperationException($"Expected STRING token, got {terminal.Symbol.Type}");

            var str = terminal.Symbol.Text;
            if (str[0] == '\'' && str[^1] == '\'')
                str = str[1..^1];
            else
                throw new InvalidOperationException("Expected STRING token to start and end with single quote.");

            return Regex.Unescape(str);
        }

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

        public static DateTimePrecision Parse(this cqlParser.DateTimePrecisionSpecifierContext context) =>
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

        //  : identifier | keywordIdentifier
        public static string Parse(this cqlParser.ReferentialIdentifierContext context)
        {
            if (context.identifier() is { } identifierContext)
                return identifierContext.Parse()!;
            else if (context.keywordIdentifier() is { } kwi)
                return kwi.GetText();
            else
                throw new InvalidOperationException($"Unexpected referentialIdentifier child.");
        }

        // referentialIdentifier | typeNameIdentifier;
        public static string Parse(this cqlParser.ReferentialOrTypeNameIdentifierContext context)
        {
            if (context.referentialIdentifier() is { } ri)
                return ri.Parse()!;
            else if (context.typeNameIdentifier() is { } tni)
                return tni.GetText();
            else
                throw new InvalidOperationException($"Unexpected referentialIdentifier child.");
        }

        //  : identifier | functionIdentifier;
        public static string Parse(this cqlParser.IdentifierOrFunctionIdentifierContext context)
        {
            if (context.identifier() is { } identifierContext)
                return identifierContext.Parse()!;
            else if (context.functionIdentifier() is { } kwi)
                return kwi.GetText();
            else
                throw new InvalidOperationException($"Unexpected identifierOrFunctionIdentifier child.");
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


        // : referentialIdentifier typeSpecifier
        public static TupleElementDefinition Parse(this cqlParser.TupleElementDefinitionContext context, TypeSpecifierVisitor typeSpecVisitor)
        {
            var name = context.referentialIdentifier().Parse();
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
            var name = context.referentialIdentifier().Parse();
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

        // referentialIdentifier typeSpecifier;
        public static OperandDef Parse(this cqlParser.OperandDefinitionContext context, TypeSpecifierVisitor typeSpecVisitor)
        {
            var identifier = context.referentialIdentifier().Parse();
            var type = typeSpecVisitor.Visit(context.typeSpecifier());

            var od = new OperandDef() { name = identifier, operandTypeSpecifier = type };
            return od.WithLocator(context.Locator()).WithResultType(type);
        }
    }
}
