using Hl7.Cql.CqlToElm2.Symbols;
using Hl7.Cql.CqlToElm.Grammar.r2;
using System;
using System.Collections.Generic;
using System.Linq;
using Hl7.Cql.Model;
using System.Runtime.CompilerServices;
using Antlr4.Runtime;

namespace Hl7.Cql.CqlToElm2.Visitors;

internal static class Extensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string? Detick(this string? text)
    {
        if (text is not null)
        {
            if (text.StartsWith("'") && text.EndsWith("'"))
            {
                return text[1..^1];
            }
            return text;
        }
        return null;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string? Dequote(this cqlParser.IdentifierContext? context)
    {
        if (context is not null)
        {
            var text = context.GetText();
            if (text.StartsWith(@"""") && text.EndsWith(@""""))
            {
                return text[1..^1];
            }
            return text;
        }
        return null;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string[]? Dequote(this cqlParser.QualifiedIdentifierContext? context) =>
        context is not null
        ? context.identifier().Select(id => id.Dequote()!).ToArray()
        : null;



    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T WithError<T>(this T symbol, ErrorType errorType, params object[] details)
        where T: Element
    {
        symbol.Errors.Add(new(errorType, details));
        return symbol;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T WithLocation<T>(this T symbol, ParserRuleContext rule)
        where T: Element
    {
        var start = new Coordinate(rule.Start.Line, rule.Start.Column);
        var end = new Coordinate(rule.Stop.Line, rule.Stop.Column);
        symbol.Position = new Position(start, end);
        return symbol;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static AccessModifier Parse(this cqlParser.AccessModifierContext accessModifierContext)
    {
        return accessModifierContext switch
        {
            null => AccessModifier.Public,
            _ => accessModifierContext.GetText() switch
            {
                "private" => AccessModifier.Private,
                _ => AccessModifier.Public
            }
        };
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Version Parse(this cqlParser.VersionSpecifierContext context) =>
        context switch
        {
            null => new Version(1, 0, 0),
            _ => Version.Parse(context.GetText().Detick()!)
        };


    public static TypeSymbol[] Parse(this cqlParser.TypeSpecifierContext? context, SymbolTable scope,
        IEnumerable<TypeSymbol>? genericArgs)
    {
        if (context is not null)
        {
            var nts = context.namedTypeSpecifier();
            if (nts is not null)
                return nts.Parse(scope, genericArgs);
            var gts = context.genericTypeSpecifier();
            if (gts is not null)
                return gts.Parse(scope, genericArgs);
            var cts = context.choiceTypeSpecifier();
            if (cts is not null)
                return cts.Parse(scope, genericArgs);
        }
        return [];
    }

    public static TypeSymbol[] Parse(this cqlParser.NamedTypeSpecifierContext nts, SymbolTable scope,
        IEnumerable<TypeSymbol>? genericArgs)
    {
        var typeNameParts = nts!.qualifiedIdentifier().Dequote();
        if (typeNameParts?.Length == 1)
        {
            var matchingArgs = genericArgs?.Where(arg => arg.Name == typeNameParts[0]).ToArray();
            var matchingArg = matchingArgs?.Length switch
            {
                null or 0 => null,
                1 => matchingArgs[0],
                _ => throw new InvalidOperationException($"Generic argument {typeNameParts} is ambiguous."),
            };
            if (matchingArg is not null)
                return [matchingArg];
        }
        var typeDef = GetNamedType(typeNameParts, scope);
        if (typeDef is not null)
            return [typeDef];
        else return [];
    }

    public static TypeSymbol[] Parse(this cqlParser.GenericTypeSpecifierContext gts, SymbolTable scope,
         IEnumerable<TypeSymbol>? genericArgs)
    {
        var typeName = gts!.qualifiedIdentifier().Dequote();
        var typeSymbol = GetNamedType(typeName, scope);
        if (typeSymbol is null) // find matching types in all used models
        {
            var fromModels = scope.OfType<ModelSymbol>()
                .Select(model => GetNamedType(typeName, model.Symbols))
                .Where(type => type is not null)
                .ToArray();
            return fromModels!;
        }
        if (typeSymbol?.TypeDefinition is GenericTypeDefinition gtd)
        {
            var args = gts!.typeSpecifier();
            var argSymbols = args.Select(arg => arg.Parse(scope, genericArgs)).ToList();
            if (argSymbols.Any(s => s is null))
                return [];
            else
            {
                var specifiers = argSymbols.Select(symbol => symbol[0].TypeDefinition.ToTypeSpecifier()).ToArray();
                var genericType = gtd.MakeGenericType(specifiers);
                return [new TypeSymbol(genericType)];
            }
        }
        else return [];
    }

    public static TypeSymbol[] Parse(this cqlParser.ChoiceTypeSpecifierContext cts, SymbolTable scope,
        IEnumerable<TypeSymbol>? genericArgs)
    {
        var args = cts!.typeSpecifier();
        var argSymbols = args.Select(arg => arg.Parse(scope, genericArgs)).ToList();
        if (argSymbols.Any(s => s.Length != 1))
            return [];
        else
        {
            var ctd = new ChoiceTypeDefinition(argSymbols.Select(sym => sym[0].TypeDefinition).ToArray());
            return [new TypeSymbol(ctd)];
        }
    }

    private static TypeSymbol? GetNamedType(string[]? parts, SymbolTable scope)
    {
        if (parts is null)
            return null;
        else if (parts.Length == 1) // no model specified
            return scope.GetUnique<TypeSymbol>(parts[0]);
        else
        {
            for (int i = parts.Length; i > 0; i--)
            {
                string modelName = string.Join(".", parts.Take(i));
                var model = scope.GetUnique<ModelSymbol>(modelName);
                if (model != null)
                {
                    string typeName = string.Join(".", parts.Skip(i));
                    var modelType = model.Symbols.GetUnique<TypeSymbol>(typeName);
                    if (modelType is not null)
                        return modelType;
                }
            }
        }
        return null;
    }
}

