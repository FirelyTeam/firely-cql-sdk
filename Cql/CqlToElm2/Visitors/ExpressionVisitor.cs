using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Hl7.Cql.CqlToElm.Grammar.r2;
using Hl7.Cql.CqlToElm2.Expressions;
using Hl7.Cql.CqlToElm2.Symbols;
using Hl7.Cql.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Xsl;

namespace Hl7.Cql.CqlToElm2.Visitors;
internal class ExpressionVisitor(SymbolTable Scope, LiteralTypeNames LiteralTypeNames) : cqlBaseVisitor<Expression>
{
    public override Expression VisitBinaryExpression([NotNull] cqlParser.BinaryExpressionContext context)
    {
        var operands = context.expression().Select(Visit).ToArray();
        var op = context.binaryOperator();
        var functionName = SymbolVisitor.FormatOperatorFunctionName(op);

        var expressions = new List<Expression>();

        var localFunctions = Scope.GetSymbols(functionName).OfType<FunctionSymbol>();
        var inModels = Scope.LocalOfType<ModelSymbol>().SelectMany(m =>
            m.Symbols.GetSymbols(functionName).OfType<FunctionSymbol>());
        var inIncludedLibraries = Scope.LocalOfType<LibrarySymbol>().SelectMany(l =>
            l.Symbols.GetSymbols(functionName).OfType<FunctionSymbol>());
        var allFunctions = localFunctions
            .Concat(inModels)
            .Concat(inIncludedLibraries);

        var expression = Invoke(allFunctions, operands, Scope, context);
        return expression;
    }

    public override Expression VisitBooleanLiteral([NotNull] cqlParser.BooleanLiteralContext context)
    {
        var text = context.GetText().ToLowerInvariant();
        var value = text switch
        {
            "true" => true,
            "false" => false,
            _ => throw new InvalidOperationException($"Invalid boolean literal.")
        };
        var boolType = Scope.GetUnique<TypeSymbol>(LiteralTypeNames.Boolean);
        if (boolType is not null)
            return new LiteralExpression(value, boolType)
                .WithLocation(context);
        else
            return new LiteralExpression(value, AnyType)
                .WithLocation(context)
                .WithError(ErrorType.LiteralTypeNotFound);
    }


    public override Expression VisitFunctionInvocation([NotNull] cqlParser.FunctionInvocationContext context)
    {
        var operands = context.expression().Select(Visit).ToArray();
        var functionName = context.qualifiedIdentifier().Dequote()!;
        var invocation = Invoke(functionName, operands, context);
        return invocation;
    }

    public override Expression VisitIfThenElseExpression([NotNull] cqlParser.IfThenElseExpressionContext context)
    {
        var expressions = context.expression().Select(Visit).ToArray();

        // the result of the then and else could have different return types.
        var signatures = new Signature[]
        {
            new(expressions[1].Type, expressions[1].Type),
            new(expressions[2].Type, expressions[2].Type),
        }
        .Distinct()
        .ToArray();
        var candidate = new Signature(expressions.Skip(1).Select(e => e.Type).ToArray());
        var compatibleConversions = Scope.CoercionGraph!.GetCompatibleSignatures(candidate, signatures);
        if (compatibleConversions.Length == 1)
        {
            var newExpressions = compatibleConversions[0].CoerceArguments(new[] { expressions[1], expressions[2] });
            var @case = new Case(expressions[0], newExpressions[0]);
            var conditional = new ConditionalExpression([@case], newExpressions[1])
                .WithLocation(context);
            return conditional;
        }
        else
        {
            var @case = new Case(expressions[0], expressions[0]);
            return new ConditionalExpression([@case], expressions[1])
                .WithLocation(context)
                .WithError(ErrorType.NoSuitableConditionalReturnType);
        }

    }

    private readonly Regex DecimalExpression = new Regex(@"^-?\d*(\.\d+)$", RegexOptions.Compiled);
    public override Expression VisitNumberLiteral([NotNull] cqlParser.NumberLiteralContext context)
    {
        var value = context.GetText();
        if (DecimalExpression.IsMatch(value))
        {
            var decimalType = Scope.GetUnique<TypeSymbol>(LiteralTypeNames.Decimal);
            if (decimalType is not null)
            {
                var abs = value;
                if (abs.StartsWith('-'))
                    abs = abs[1..];
                var parts = abs.Split('.');
                if (value.Length > 28)
                    return new LiteralExpression(value, AnyType)
                        .WithLocation(context)
                        .WithError(ErrorType.DecimalTooLarge);
                else if (parts[1].Length > 8)
                    return new LiteralExpression(value, AnyType)
                        .WithLocation(context)
                        .WithError(ErrorType.MantissaTooLarge);
                else if (decimal.TryParse(value, out var d))
                    return new LiteralExpression(d, decimalType)
                            .WithLocation(context);
                else return new LiteralExpression(value, decimalType)
                        .WithLocation(context)
                        .WithError(ErrorType.UnparseableDecimal);
            }
            else
                return new LiteralExpression(value, AnyType)
                       .WithLocation(context)
                       .WithError(ErrorType.LiteralTypeNotFound);
        }
        else
        {
            var intType = Scope.GetUnique<TypeSymbol>(LiteralTypeNames.Integer);
            if (intType is not null)
            {
                if (int.TryParse(value, out var i))
                    return new LiteralExpression(i, intType)
                        .WithLocation(context);
                else
                    return new LiteralExpression(value, intType)
                        .WithLocation(context)
                        .WithError(ErrorType.UnparseableInteger);
            }
            else
                return new LiteralExpression(value, AnyType)
                       .WithLocation(context)
                       .WithError(ErrorType.LiteralTypeNotFound);
        }
    }

    public override Expression VisitQualifiedIdentifier([NotNull] cqlParser.QualifiedIdentifierContext context)
    {
        var identifiers = context.identifier().Select(id=>id.GetText()).ToArray();
        var symbol = Scope.GetUnique(identifiers);
        if (symbol is not null)
            return new RefExpression(symbol)
                .WithLocation(context);
        else
            return new NullExpression(AnyType)
                .WithError(ErrorType.UnresolvedIdentifier, context.GetText());
    }

    public override Expression VisitRetrieve([NotNull] cqlParser.RetrieveContext context)
    {
        var contextId = context.contextIdentifier()?.qualifiedIdentifier()?.Dequote();
        Expression? retrieveContext;
        if (contextId is not null)
        {
            var symbol = Scope.GetUnique(contextId);
            if (symbol is not null)
                retrieveContext = new RefExpression(symbol);
            else
                retrieveContext = new NullExpression(AnyType)
                    .WithError(ErrorType.UnresolvedIdentifier, contextId);
        }
        else retrieveContext = null;

        var types = context.namedTypeSpecifier().Parse(Scope, null);
        var codePathContext = context.codePath();
        var codePath = codePathContext switch
        {
            { } => Visit(codePathContext),
            _ => null
        };
        var codeComparatorText = context.codeComparator()?.GetText();
        var isValidCodeComparator = Enum.TryParse<CodeComparator>(codeComparatorText, out var codeComparator);
        var terminologyContext = context.terminology();
        var terminology = terminologyContext switch
        {
            { } => Visit(terminologyContext),
            _ => null
        };

        var elementType = types.Length == 1 ? types[0] : AnyType;
        var retrieveType = new TypeSymbol(ListTypeTemplate.MakeGenericType(elementType.TypeDefinition.ToTypeSpecifier()));
        
        var retrieve = new RetrieveExpression(retrieveType, codePath, terminology, codeComparator, retrieveContext)
            .WithLocation(context);
        if (types.Length == 0)
            retrieve = retrieve.WithError(ErrorType.InvalidTypeSpecifier, context.namedTypeSpecifier().GetText());
        else if (types.Length > 1)
            retrieve = retrieve.WithError(ErrorType.AmbiguousTypeSpecifier, context.namedTypeSpecifier().GetText());
        if (codeComparatorText is not null && !isValidCodeComparator)
            retrieve = retrieve.WithError(ErrorType.InvalidCodeComparator, context.codeComparator().GetText());
        return retrieve;
    }

    private Expression Invoke(string[] functionName, Expression[] operands, ParserRuleContext context)
    {
        var functions = Scope.GetSymbols(functionName).OfType<FunctionSymbol>();
        if (functions.Any())
        {
            return Invoke(functions, operands, Scope, context);
        }
        else
            return new NullExpression()
                .WithLocation(context)
                .WithError(ErrorType.FunctionNotFound, functionName);
    }

    private static Expression Invoke(IEnumerable<FunctionSymbol> functions,
        Expression[] operands,
        SymbolTable Scope,
        ParserRuleContext context)
    {
        var candidates = functions.Select(f => f.Signature).ToArray();
        var signature = new Signature(operands.Select(o => o.Type).ToArray());
        var compatibleConversions = Scope.CoercionGraph!.GetCompatibleSignatures(signature, candidates);
        if (compatibleConversions.Length == 1)
        {
            var function = ((FunctionSignature)compatibleConversions[0].Signature).Function;
            var newOperands = compatibleConversions[0].CoerceArguments(operands);

            var operandCount = compatibleConversions[0].Signature.Operands.Count;
            var arguments = new ArgumentSymbol[operandCount];
            for(int i = 0; i < operandCount; i++)
                arguments[i] = new ArgumentSymbol(function.Operands[i], newOperands[i]);
            return new FunctionInvocationExpression(function, arguments, function.Type)
                .WithLocation(context);
        }
        else if (compatibleConversions.Length == 0)
            return new NullExpression()
                .WithLocation(context)
                .WithError(ErrorType.NoSuitableFunctionSignature, signature);
        else
            return new NullExpression()
                .WithLocation(context)
                .WithError(ErrorType.AmbiguousFunctionSignature, signature, compatibleConversions);
    }


    /// <summary>
    /// Gets the type defined by <see cref="LiteralTypeNames.Any"/>, or throws an <see cref="InvalidOperationException"/> if not found.
    /// </summary>
    private TypeSymbol AnyType => Scope.GetUnique<TypeSymbol>(LiteralTypeNames.Any) ??
        throw new InvalidOperationException($"Type {LiteralTypeNames.Any} has not been loaded in any model.");

    private GenericTypeDefinition ListTypeTemplate => Scope.GetUnique<TypeSymbol>(LiteralTypeNames.List) switch
    {
        TypeSymbol ts when ts.TypeDefinition is GenericTypeDefinition gtd && gtd.IsTemplate && gtd.Arguments.Count == 1 => gtd,
        null => throw new InvalidOperationException($"Type {LiteralTypeNames.List} has not been loaded in any model."),
        _ => throw new InvalidOperationException($"Literal list type must be a generic template with one argument.")
    };
        
}

