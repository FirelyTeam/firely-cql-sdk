/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Compiler.Infrastructure;
using Hl7.Cql.Elm;
using Hl7.Cql.Operators;
using Hl7.Cql.Primitives;
using TypeConverter = Hl7.Cql.Conversion.TypeConverter;

namespace Hl7.Cql.Compiler;

using DateTime = Hl7.Cql.Elm.DateTime;
using ListTypeSpecifier = Hl7.Cql.Elm.ListTypeSpecifier;
using NamedTypeSpecifier = Hl7.Cql.Elm.NamedTypeSpecifier;
using Tuple = Hl7.Cql.Elm.Tuple;

#region Context

/// <summary>
/// The ExpressionBuilderContext class maintains scope information for the traversal of ElmPackage statements.
/// </summary>
/// <remarks>
/// Translates ELM nodes into <see cref="CodeExpression"/> trees. The dispatch shape and
/// per-operator behavior are preserved bug-for-bug from the deleted Linq.Expressions-based
/// pipeline (see <c>docs/linq-expression-removal-plan.md</c>; its sources remain readable at
/// that pipeline's final commit, <c>85207efd5</c>).
/// </remarks>
internal partial class ExpressionBuilderContext
(
    ILogger<ExpressionBuilder> logger,
    ExpressionBuilderSettings expressionBuilderSettings,
    CqlOperatorsBinder cqlOperatorsBinder,
    TupleBuilderCache tupleBuilderCache,
    TypeResolver typeResolver,
    TypeConverter typeConverter,
    CqlContextBinder cqlContextBinder,
    LibraryExpressionBuilderContext libraryContext,
    Dictionary<string, CodeLocal>? operands = null // Parameters for function definitions. Used during ProcessExpressionDef.
)
{
    private readonly ILogger<ExpressionBuilder> _logger = logger;
    private readonly ExpressionBuilderSettings _expressionBuilderSettings = expressionBuilderSettings;
    private readonly CqlOperatorsBinder _cqlOperatorsBinder = cqlOperatorsBinder;
    private readonly TupleBuilderCache _tupleBuilderCache = tupleBuilderCache;
    private readonly TypeResolver _typeResolver = typeResolver;
    private readonly TypeConverter _typeConverter = typeConverter;
    private readonly CqlContextBinder _cqlContextBinder = cqlContextBinder;
    private readonly LibraryExpressionBuilderContext _libraryContext = libraryContext;
    private readonly Dictionary<string, CodeLocal>? _operands = operands;

    // NOTE(phase4): the old builder carried an IExpressionMutator list here, documented as
    // "Not used yet, since it's always empty". That (Expression-based) hook was dropped in the
    // IR port; see Mutate below.

    private ImmutableStack<Element> _elementStack = ImmutableStack<Element>.Empty;

    /// <summary>
    /// Contains query aliases and let declarations, and any other symbol that is now "in scope"
    /// </summary>
    private ImmutableStack<(object? id, string? impliedAlias, IReadOnlyDictionary<string, (CodeExpression expr, Element element)>? scopes)>
        _impliedAliasAndScopesStack =
            ImmutableStack<(object? id, string? impliedAlias, IReadOnlyDictionary<string, (CodeExpression expr, Element element)>? scopes)>.Empty;

    private static CodeExpression[] NoArgs { get; } = [];

    private static Type[] NoTypes { get; } = [];

    private CodeExpression BindCqlOperator<TArg>(
        string methodName,
        params TArg?[] args) =>
        _cqlOperatorsBinder.BindToMethod(methodName, TranslateArgs(args), NoTypes);

    private CodeExpression BindCqlOperator<TArg>(
        string methodName,
        TArg?[] args,
        Type[] typeArgs) =>
        _cqlOperatorsBinder.BindToMethod(methodName, TranslateArgs(args), typeArgs);

    [DebuggerStepThrough]
    private Type[] TranslateTypes<TType>(params TType?[] args) =>
        args switch
        {
            Type[] types => types,
            { } objects  => objects.SelectToArray(obj => TranslateType(obj!)),
            _            => [],
        };

    [DebuggerStepThrough]
    private Type TranslateType<TType>(TType? arg) =>
        arg switch
        {
            Type type                             => type,
            XmlQualifiedName xmlQualifiedName     => _typeResolver.ResolveType(xmlQualifiedName.Name)!,
            NamedTypeSpecifier namedTypeSpecifier => TranslateType(namedTypeSpecifier.name)!,
            null                                  => throw this.NewExpressionBuildingException("Cannot translate null to a type"),
            _                                     => throw this.NewExpressionBuildingException($"Cannot translate '{arg}' to a type"),
        };

    [DebuggerStepThrough]
    private CodeExpression[] TranslateArgs<TArg>(params TArg?[] args) =>
        args switch
        {
            CodeExpression[] expressions => expressions,
            { } objects                => objects.SelectToArray(obj => TranslateArg(obj!)),
            _                          => [],
        };

    [DebuggerStepThrough]
    internal CodeExpression TranslateArg<TArg>(TArg? arg) =>
        arg switch
        {
            CodeExpression expression => expression,
            Element element         => TranslateElement(element),
            null                    => new CodeConstant(null, typeof(TArg)),
            _                       => new CodeConstant(arg, arg.GetType()),
        };

    private CodeExpression TranslateElement(Element element) =>
        this.CatchRethrowExpressionBuildingException(_ =>
        {
            using (PushElement(element))
            {
                /*
                This code is useful for setting breakpoints to inspect the expression tree at a specific element.
                The ELM json must be modified to add an annotation tags with a debug counter first.

                var debugCounter = element.annotation
                                          ?.OfType<Annotation>()
                                          .FirstOrDefault()?.t.FirstOrDefault(t => t.name == "debug")
                                          ?.value;
                if (debugCounter == "42") // Identify the correct debug counter from the ELM file
                {
                    ; // Set a breakpoint here
                }
                */

                CodeExpression? expression = element switch
                {
                    //@formatter:off
                    Ratio e            => throw new NotSupportedException($"Operator {element.GetType().Name} is not supported yet."),
                    Flatten e          => BindCqlOperator(nameof(ICqlOperators.Flatten), e.operand),
                    Negate e           => Negate(e),
                    As e               => As(e),
                    Case e             => Case(e),
                    Interval { low: Null, high: Null } => new CodeConstant(null, typeof(object)),
                    ToTime e           => ChangeType(e.operand!, _typeResolver.TimeType),
                    ToBoolean e        => ChangeType(e.operand!, typeof(bool?)),
                    ToString e         => ChangeType(e.operand!, typeof(string)),
                    ToConcept e        => ChangeType(e.operand!, _typeResolver.ConceptType),
                    ToDate e           => ChangeType(e.operand!, _typeResolver.DateType),
                    ToDecimal e        => ChangeType(e.operand!, typeof(decimal?)),
                    ToInteger e        => ChangeType(e.operand!, typeof(int?)),
                    ToDateTime e       => ChangeType(e.operand!, _typeResolver.DateTimeType),
                    ToLong e           => ChangeType(e.operand!, typeof(long?)),
                    ToQuantity e       => ChangeType(e.operand!, _typeResolver.QuantityType),
                    Coalesce e         => Coalesce(e),
                    Equivalent e       => Equivalent(e),
                    AliasRef e         => GetScopeExpression(e.name!),
                    QueryLetRef e      => GetScopeExpression(e.name!),
                    IdentifierRef e    => IdentifierRef(e),
                    If e               => If(e),
                    IncludedIn e       => IncludedIn(e),
                    Includes e         => Includes(e),
                    Instance e         => Instance(e),
                    Is e               => Is(e),
                    IsNull e           => IsNull(e),
                    List e             => List(e),
                    Literal e          => Literal(e),
                    Message e          => Message(e),
                    Null e             => new CodeConstant(null, TypeFor(e)!),
                    OperandRef e       => OperandRef(e),
                    ProperContains e   => ProperContains(e),
                    ProperIn e         => ProperIn(e),
                    ProperIncludedIn e => ProperIncludedIn(e),
                    ProperIncludes e   => ProperIncludes(e),
                    Property e         => Property(e),
                    Query e            => Query(e),
                    Tuple e            => Tuple(e),

                    // InvokeDefinedFunctionThroughRuntimeContext
                    FunctionRef e => FunctionRef(e),

                    // InvokeDefinitionThroughRuntimeContext
                    CodeRef e       => CodeRef(e),
                    CodeSystemRef e => CodeSystemRef(e),
                    ConceptRef e    => ConceptRef(e),
                    ExpressionRef e => ExpressionRef(e),
                    AnyInValueSet e => BindValueInValueSet(valueExpr: TranslateArg(e.codes), valueSetExpr: TranslateValueSet(e.valueset, e.valuesetExpression),
                                                           isList: true),
                    InValueSet e => BindValueInValueSet(valueExpr: TranslateArg(e.code), valueSetExpr: TranslateValueSet(e.valueset, e.valuesetExpression),
                                                        isList: false),
                    Retrieve e     => Retrieve(e),
                    ValueSetRef e  => ValueSetRef(e),
                    ParameterRef e => ParameterRef(e),

                    // NOTE: Do not rename ICqlOperators.CreateValueSetFacade to ExpandValueSet
                    ExpandValueSet e => _cqlOperatorsBinder.BindToMethod(nameof(ICqlOperators.CreateValueSetFacade), TranslateArgs(GetBindArgs(element)),
                                                                         TranslateTypes(GetTypeArgs(element))),

                    // All other Elm types matches on type name to the ICqlOperators method name
                    _ => _cqlOperatorsBinder.BindToMethod(element.GetType().Name, TranslateArgs(GetBindArgs(element)), TranslateTypes(GetTypeArgs(element))),
                    //@formatter:on
                };

                if (expression is not null)
                    expression = ConvertToResultType();

                expression = Mutate(element, expression);
                return expression!;

                CodeExpression ConvertToResultType()
                {
                    var tsType = TypeFor(element.resultTypeSpecifier, false);
                    if (tsType is not null)
                    {
                        return ChangeType(expression!, element.resultTypeSpecifier, throwOnError: true);
                    }

                    return expression!;
                }
            }
        });

    private object?[] GetTypeArgs(Element element)
    {
        // ReSharper disable CoVariantArrayConversion
        object[] types = element switch
        {
            MinValue e => [e.valueType],
            MaxValue e => [e.valueType],
            Elm.Convert e => [e.resultTypeSpecifier],
            _          => NoTypes,
        };
        // ReSharper restore CoVariantArrayConversion
        return types;
    }

    private object?[] GetBindArgs(Element element)
    {
        // ReSharper disable CoVariantArrayConversion
        object?[] args = element switch
        {
            //@formatter:off

            // ORDER MATTERS.

            // special cases
            Collapse e           => Collapse(e),
            Contains e           => Contains(e),
            Union e              => Union(e),
            Combine e            => [e.source, e.separator],
            IndexOf e            => [e.source, e.element],
            Slice e              => [e.source, e.startIndex, e.endIndex],
            Date e               => [e.year, e.month, e.day],
            DateTime e           => [e.year, e.month, e.day, e.hour, e.minute, e.second, e.millisecond, e.timezoneOffset],
            Interval e           => [e.low, e.high, (object)e.lowClosedExpression ?? e.lowClosed, (object)e.highClosedExpression ?? e.highClosed],
            LastPositionOf e     => [e.@string, e.pattern],
            PositionOf e         => [e.pattern, e.@string],
            Quantity e           => [e.value, e.unit], // http://unitsofmeasure.org
            Ratio e              => [e.numerator, e.denominator],
            Round r              => [r.operand, r.precision],
            Split e              => [e.stringToSplit, e.separator],
            Substring e          => [e.stringToSub, e.startIndex, e.length],
            Time e               => [e.hour, e.minute, e.second, e.millisecond],
            MinValue or MaxValue => [], // type is a generic type arg

            // special expression types
            UnaryWithPrecision uwp => [uwp.operand, uwp.GetPrecision()],
            NaryWithPrecision nwp  => [.. nwp.operand, nwp.GetPrecision()],
            IHasSource hs          => [hs.source],

            // common expression types
            Elm.UnaryExpression unary   => [unary.operand],
            Elm.BinaryExpression binary => binary.operand,
            TernaryExpression ternary   => ternary.operand,
            NaryExpression nary         => nary.operand,
            OperatorExpression          => [], // nullaries, but all others too.  handle last.

            _ => throw this.NewExpressionBuildingException($"Cannot get arguments for element {element.GetType().FullName}.")
            //@formatter:on
        };
        return args;
        // ReSharper restore CoVariantArrayConversion

        object?[] Collapse(Collapse e)
        {
            var operand = TranslateArg(e.operand![0]!);
            if (_typeResolver.GetListElementCqlIntervalPointType(operand.Type) is { })
            {
                object precision = e.operand switch
                {
                    [_, Quantity quantity, ..] => quantity.unit,
                    _                          => new CodeConstant(null, typeof(string))
                };

                return [operand, precision];
            }

            throw this.NewExpressionBuildingException(
                $"Collapse expects a list of intervals, but got {operand.Type.ToCSharpString(Defaults.TypeCSharpFormat)}");
        }

        object?[] Contains(Contains e)
        {
            if (TranslateArgs(e.operand) is [{ } left, { } right, ..])
            {
                if (_typeResolver.GetListElementType(left.Type, throwError: false) is { } leftType)
                {
                    if (leftType != right.Type)
                    {
                        if (leftType.IsAssignableFrom(right.Type))
                            right = ChangeType(right, leftType, throwOnError: true);
                    }

                    return [left, right, e.GetPrecision()];
                }

                if (left.Type.IsCqlInterval(out _))
                {
                    return [left, right, e.GetPrecision()];
                }
            }

            throw this.NewExpressionBuildingException($"Contains expects two arguments, but got {e.operand.Length}");
        }

        object?[] Union(Union e)
        {
            if (TranslateArgs(e.operand) is [{ } left, { } right, ..])
            {
                if (_typeResolver.GetListElementType(left.Type, throwError: false) is { } leftListElemType
                    && _typeResolver.GetListElementType(right.Type, throwError: false) is { } rightListElemType
                    && ElmTupleTypeUtility.AreCompatibleForUnionOperation(leftListElemType, rightListElemType, _typeConverter))
                    return [left, right];

                if (left.Type.IsCqlInterval(out var leftPointType)
                    && right.Type.IsCqlInterval(out var rightPointType)
                    && ElmTupleTypeUtility.AreCompatibleForUnionOperation(leftPointType, rightPointType, _typeConverter))
                    return [left, right];
            }

            throw this.NewExpressionBuildingException($"Union expects two arguments of the same list or interval type.");
        }
    }

    /// <summary>
    /// No-op. The old builder aggregated an <c>IExpressionMutator</c> list here, but that list
    /// was always empty (the hook was never used), so the IR port drops it and simply returns
    /// the expression.
    /// </summary>
    protected CodeExpression? Mutate(Element op, CodeExpression? expression) =>
        expression;
}

#endregion

file static class LocalExtensions
{
    public static Type? GetListElementCqlIntervalPointType(
        this TypeResolver typeResolver,
        Type type) =>
        typeResolver.GetListElementType(type, throwError: false) is { } elementType
        && elementType.IsCqlInterval(out var pointType)
            ? pointType
            : null;
}
