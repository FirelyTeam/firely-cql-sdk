/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Compiler.Expressions;
using Hl7.Cql.Compiler.Infrastructure;
using Hl7.Cql.Elm;
using Hl7.Cql.Model;
using Hl7.Cql.Operators;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Xml;
using ChoiceTypeSpecifier = Hl7.Cql.Elm.ChoiceTypeSpecifier;
using Convert = System.Convert;
using DateTime = Hl7.Cql.Elm.DateTime;
using Expression = System.Linq.Expressions.Expression;
using TypeSpecifier = Hl7.Cql.Elm.TypeSpecifier;
using ListTypeSpecifier = Hl7.Cql.Elm.ListTypeSpecifier;
using NamedTypeSpecifier = Hl7.Cql.Elm.NamedTypeSpecifier;
using Tuple = Hl7.Cql.Elm.Tuple;
using TupleTypeSpecifier = Hl7.Cql.Elm.TupleTypeSpecifier;
using TypeConverter = Hl7.Cql.Conversion.TypeConverter;

namespace Hl7.Cql.Compiler;

#region Context

/// <summary>
/// The ExpressionBuilderContext class maintains scope information for the traversal of ElmPackage statements.
/// </summary>
/// <remarks>
/// The scope information in this class is useful for <see cref="IExpressionMutator"/> and is supplied to <see cref="IExpressionMutator.Mutate(Expression, Elm.Element, ExpressionBuilderContext)"/>.
/// </remarks>
partial class ExpressionBuilderContext(
    ILogger<ExpressionBuilder> logger,
    ExpressionBuilderSettings expressionBuilderSettings,
    CqlOperatorsBinder cqlOperatorsBinder,
    TupleBuilderCache tupleBuilderCache,
    TypeResolver typeResolver,
    CqlContextBinder cqlContextBinder,
    LibraryExpressionBuilderContext libraryContext,
    Dictionary<string, ParameterExpression>? operands = null // Parameters for function definitions. Used during ProcessExpressionDef.
    )
{
    private readonly ILogger<ExpressionBuilder> _logger = logger;
    private readonly ExpressionBuilderSettings _expressionBuilderSettings = expressionBuilderSettings;
    private readonly CqlOperatorsBinder _cqlOperatorsBinder = cqlOperatorsBinder;
    private readonly TupleBuilderCache _tupleBuilderCache = tupleBuilderCache;
    private readonly TypeResolver _typeResolver = typeResolver;
    private readonly CqlContextBinder _cqlContextBinder = cqlContextBinder;
    private readonly LibraryExpressionBuilderContext _libraryContext = libraryContext;
    private readonly Dictionary<string, ParameterExpression>? _operands = operands;
    private readonly IReadOnlyCollection<IExpressionMutator> _expressionMutators = ReadOnlyCollection<IExpressionMutator>.Empty; // Not used yet, since it's always empty
    private ImmutableStack<Element> _elementStack = ImmutableStack<Element>.Empty;

    /// <summary>
    /// Contains query aliases and let declarations, and any other symbol that is now "in scope"
    /// </summary>
    private ImmutableStack<(object? id, string? impliedAlias, IReadOnlyDictionary<string, (Expression expr, Element element)>? scopes)> _impliedAliasAndScopesStack = ImmutableStack<(object? id, string? impliedAlias, IReadOnlyDictionary<string, (Expression expr, Element element)>? scopes)>.Empty;

    private static Expression[] NoArgs { get; } = [];

    private static Type[] NoTypes { get; } = [];

    private Expression BindCqlOperator<TArg>(
        string methodName,
        params TArg?[] args) =>
        _cqlOperatorsBinder.BindToMethod(methodName, TranslateArgs(args), NoTypes);

    private Expression BindCqlOperator<TArg>(
        string methodName,
        TArg?[] args,
        Type[] typeArgs) =>
         _cqlOperatorsBinder.BindToMethod(methodName, TranslateArgs(args), typeArgs);

    [DebuggerStepThrough]
    private Type[] TranslateTypes<TType>(params TType?[] args) =>
        args switch
        {
            Type[] types => types,
            { } objects => objects.SelectToArray(obj => TranslateType(obj!)),
            _ => [],
        };

    [DebuggerStepThrough]
    private Type TranslateType<TType>(TType? arg) =>
        arg switch
        {
            Type type => type,
            XmlQualifiedName xmlQualifiedName => _typeResolver.ResolveType(xmlQualifiedName.Name)!,
            _ => null!,
        };

    [DebuggerStepThrough]
    private Expression[] TranslateArgs<TArg>(params TArg?[] args) =>
        args switch
        {
            Expression[] expressions => expressions,
            { } objects => objects.SelectToArray(obj => TranslateArg(obj!)),
            _ => [],
        };

    [DebuggerStepThrough]
    internal Expression TranslateArg<TArg>(TArg? arg) =>
        arg switch
        {
            Expression expression => expression,
            Element element => TranslateElement(element),
            null => NullExpression.ForType<TArg>(),
            _ => Expression.Constant(arg),
        };

    private Expression TranslateElement(Element element) =>
        this.CatchRethrowExpressionBuildingException(_ =>
        {
            using (PushElement(element))
            {
                Expression? expression = element switch
                {
                    //@formatter:off
                    Ratio e => throw new NotSupportedException($"Operator {element.GetType().Name} is not supported yet."),
                    Flatten e => BindCqlOperator(nameof(ICqlOperators.Flatten), e.operand),
                    Negate e => Negate(e),
                    As e => As(e),
                    Case e => Case(e),
                    ToTime e => ChangeType(e.operand!, _typeResolver.TimeType),
                    ToBoolean e => ChangeType(e.operand!, typeof(bool?)),
                    ToString e => ChangeType(e.operand!, typeof(string)),
                    ToConcept e => ChangeType(e.operand!, _typeResolver.ConceptType),
                    ToDate e => ChangeType(e.operand!, _typeResolver.DateType),
                    ToDecimal e => ChangeType(e.operand!, typeof(decimal?)),
                    ToInteger e => ChangeType(e.operand!, typeof(int?)),
                    ToDateTime e => ChangeType(e.operand!, _typeResolver.DateTimeType),
                    ToLong e => ChangeType(e.operand!, typeof(long?)),
                    ToQuantity e => ChangeType(e.operand!, _typeResolver.QuantityType),
                    Coalesce e => Coalesce(e),
                    Equivalent e => Equivalent(e),
                    AliasRef e => GetScopeExpression(e.name!),
                    QueryLetRef e => GetScopeExpression(e.name!),
                    IdentifierRef e => IdentifierRef(e),
                    If e => If(e),
                    IncludedIn e => IncludedIn(e),
                    Includes e => Includes(e),
                    Instance e => Instance(e),
                    Is e => Is(e),
                    IsNull e => IsNull(e),
                    List e => List(e),
                    Literal e => Literal(e),
                    Message e => Message(e),
                    Null e => NullExpression.ForType(TypeFor(e)!),
                    OperandRef e => OperandRef(e),
                    ProperContains e => ProperContains(e),
                    ProperIn e => ProperIn(e),
                    ProperIncludedIn e => ProperIncludedIn(e),
                    ProperIncludes e => ProperIncludes(e),
                    Property e => Property(e),
                    Query e => Query(e),
                    Tuple e => Tuple(e),

                    // InvokeDefinedFunctionThroughRuntimeContext
                    FunctionRef e => FunctionRef(e),

                    // InvokeDefinitionThroughRuntimeContext
                    CodeRef e => CodeRef(e),
                    CodeSystemRef e => CodeSystemRef(e),
                    ConceptRef e => ConceptRef(e),
                    ExpressionRef e => ExpressionRef(e),
                    AnyInValueSet e => ProcessValueSet(e.valueset, e.codes, isList: true),
                    InValueSet e => ProcessValueSet(e.valueset!, e.code, isList: false),
                    Retrieve e => Retrieve(e),
                    ValueSetRef e => ValueSetRef(e),
                    ParameterRef e => ParameterRef(e),

                    // NOTE: Do not rename ICqlOperators.CreateValueSetFacade to ExpandValueSet
                    ExpandValueSet e => _cqlOperatorsBinder.BindToMethod(nameof(ICqlOperators.CreateValueSetFacade), TranslateArgs(GetBindArgs(element)), TranslateTypes(GetTypeArgs(element))),

                    // All other Elm types matches on type name to the ICqlOperators method name
                    _ => _cqlOperatorsBinder.BindToMethod(element.GetType().Name, TranslateArgs(GetBindArgs(element)), TranslateTypes(GetTypeArgs(element))),
                    //@formatter:on
                };

                if (expression is not null)
                    expression = ConvertToResultType();

                expression = Mutate(element, expression);
                return expression!;

                Expression ConvertToResultType()
                {
                    var tsType = TypeFor(element.resultTypeSpecifier, false);
                    if (tsType is not null)
                    {
                        var converted = ChangeType(expression, element.resultTypeSpecifier, out var typeConversion);
                        if (typeConversion != TypeConversion.NoMatch)
                            return converted;

                        // If we make this a hard fail, 15 unit tests fail.
                        // throw this.NewExpressionBuildingException(
                        //      $"Cannot convert {expression.Type.ToCSharpString(Defaults.TypeCSharpFormat)} to {tsType.ToCSharpString(Defaults.TypeCSharpFormat)}");

                        _logger.LogDebug(
                            "Failed to change expression '{elementType}' at '{elementLocator}' from type '{expressionType}' to '{resultType}'",
                            element.GetType().Name,
                            element.locator,
                            tsType.ToCSharpString(Defaults.TypeCSharpFormat),
                            expression.Type.ToCSharpString(Defaults.TypeCSharpFormat));
                    }

                    return expression;
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
            _ => NoTypes,
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
            Collapse e => Collapse(e),
            Contains e => Contains(e),
            Union e => Union(e),
            Combine e => [e.source, e.separator],
            IndexOf e => [e.source, e.element],
            Slice e => [e.source, e.startIndex, e.endIndex],
            Date e => [e.year, e.month, e.day],
            DateTime e => [e.year, e.month, e.day, e.hour, e.minute, e.second, e.millisecond, e.timezoneOffset],
            Interval e => [e.low, e.high, (object)e.lowClosedExpression ?? e.lowClosed, (object)e.highClosedExpression ?? e.highClosed],
            LastPositionOf e => [e.@string, e.pattern],
            PositionOf e => [e.pattern, e.@string],
            Quantity e => [e.value, e.unit], // http://unitsofmeasure.org
            Ratio e => [e.numerator, e.denominator],
            Round r => [r.operand, r.precision],
            Split e => [e.stringToSplit, e.separator],
            Substring e => [e.stringToSub, e.startIndex, e.length],
            Time e => [e.hour, e.minute, e.second, e.millisecond],
            MinValue or MaxValue => [], // type is a generic type arg

            // special expression types
            UnaryWithPrecision uwp => [uwp.operand, uwp.GetPrecision()],
            NaryWithPrecision nwp => [.. nwp.operand, nwp.GetPrecision()],
            IHasSource hs => [hs.source],

            // common expression types
            Elm.UnaryExpression unary => [unary.operand],
            Elm.BinaryExpression binary => binary.operand,
            TernaryExpression ternary => ternary.operand,
            NaryExpression nary => nary.operand,
            OperatorExpression => [], // nullaries, but all others too.  handle last.

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
                    _ => NullExpression.String
                };

                return [operand, precision];
            }
            throw this.NewExpressionBuildingException($"Collapse expects a list of intervals, but got {operand.Type.ToCSharpString(Defaults.TypeCSharpFormat)}");
        }

        object?[] Contains(Contains e)
        {
            if (TranslateArgs(e.operand) is [{ } left, { } right, ..])
            {
                if (_typeResolver.GetListElementType(left.Type, throwError: false) is { } leftType)
                {
                    if (leftType != right.Type)
                    {
                        var typeConversion = TypeConversion.NoMatch;
                        if (leftType.IsAssignableFrom(right.Type))
                            right = ChangeType(right, leftType, out typeConversion);
                        if (typeConversion == TypeConversion.NoMatch)
                            throw this.NewExpressionBuildingException($"Cannot convert Contains target {right.Type.ToCSharpString(Defaults.TypeCSharpFormat)} to {leftType.ToCSharpString(Defaults.TypeCSharpFormat)}");
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
                    && leftListElemType == rightListElemType)
                    return [left, right];

                if (left.Type.IsCqlInterval(out var leftPointType)
                    && right.Type.IsCqlInterval(out var rightPointType)
                    && leftPointType == rightPointType)
                    return [left, right];
            }
            throw this.NewExpressionBuildingException($"Union expects two arguments of the same list or interval type.");
        }
    }

    protected Expression? Mutate(Element op, Expression? expression) =>
        _expressionMutators.Aggregate(
            expression,
            (current, visitor) => visitor.Mutate(current!, op, this));

    protected Expression? IdentifierRef(IdentifierRef ire)
    {
        if (string.Equals("$this", ire.name) && ImpliedAlias != null)
        {
            var scopeExpression = GetScopeExpression(ImpliedAlias!);
            return scopeExpression;
        }
        var pe = new Property
        {
            resultTypeSpecifier = ire.resultTypeSpecifier,
            resultTypeName = ire.resultTypeName,
            localId = ire.localId,
            locator = ire.locator,
            path = ire.name,
            scope = ImpliedAlias!,
        };
        var prop = Property(pe);
        return prop;
    }

    protected Expression ValueSetRef(ValueSetRef valueSetRef)
    {
        if (string.IsNullOrWhiteSpace(valueSetRef.name))
            throw this.NewExpressionBuildingException($"The ValueSetRef at {valueSetRef.locator} is missing a name.");
        var cqlValueSet = InvokeDefinitionThroughRuntimeContext(valueSetRef.name, valueSetRef.libraryName, typeof(CqlValueSet));

        //var type = TypeFor(valueSetRef)!;
        // if (_typeResolver.IsListType(type))
        // {
        //     var elementType = _typeResolver.GetListElementType(type);
        //     if (elementType != typeof(CqlCode))
        //     {
        //         throw this.NewExpressionBuildingException($"The expected type for value set {valueSetRef.name} in this context is {type.ToCSharpString(Defaults.TypeCSharpFormat)}");
        //     }
        //
        //     var method = typeof(ICqlOperators).GetMethod(nameof(ICqlOperators.ExpandValueSet))!;
        //     var call = Expression.Call(CqlExpressions.Operators_PropertyExpression, method, cqlValueSet);
        //     return call;
        // }
        return cqlValueSet;
    }

    protected Expression Tuple(Tuple tuple)
    {
        Type tupleType;
        if (tuple.resultTypeSpecifier is null)
        {
            tupleType = TupleTypeFor(tuple);
        }
        else
        {
            var tupleTypeSpecifier = tuple.resultTypeSpecifier as TupleTypeSpecifier ?? throw this.NewExpressionBuildingException($"Tuple expression has a resultType that is not a TupleTypeSpecifier.");
            tupleType = TupleTypeFor(tupleTypeSpecifier);
        }

        var @new = Expression.New(tupleType);
        if (tuple.element?.Length > 0)
        {
            var elementBindings =
                tuple.element!
                     .SelectToArray(element =>
                     {
                         var value = TranslateArg(element.value!);
                         var propInfo = GetProperty(tupleType, NormalizeIdentifier(element.name!), _typeResolver)
                                        ?? throw this.NewExpressionBuildingException($"Could not find member {element} on type {tupleType.ToCSharpString(Defaults.TypeCSharpFormat)}");
                         var binding = Binding(value, propInfo);
                         return binding;
                     });
            var init = Expression.MemberInit(@new, elementBindings);
            return init;
        }

        return @new;
    }

    protected Expression List(List list)
    {
        if (list.resultTypeSpecifier == null)
            throw this.NewExpressionBuildingException($"List is missing a result type specifier.");
        if (list.resultTypeSpecifier is ListTypeSpecifier listTypeSpecifier)
        {

            var elementType = TypeFor(listTypeSpecifier.elementType)!;
            var elements = TranslateArgs(list.element);
            if (!elementType.IsNullableValueType(out _) && elements.Any(exp => exp.Type.IsNullableValueType(out _)))
            {
                for (int i = 0; i < elements.Length; i++)
                {
                    elements[i] = HandleNullable(elements[i], elementType);

                }
            }
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i].Type != elementType)
                {
                    elements[i] = elements[i].NewTypeAsExpression(elementType);
                }
            }
            Expression? array = null;
            if (elements != null)
            {
                array = Expression.NewArrayInit(elementType, elements);
            }
            else
            {
                array = Expression.NewArrayBounds(elementType, Expression.Constant(0));
            }
            var asEnumerable = array.NewTypeAsExpression(typeof(IEnumerable<>).MakeGenericType(elementType));
            return asEnumerable;
        }

        throw this.NewExpressionBuildingException($"List is the wrong type");

    }

    protected Expression CodeRef(CodeRef codeRef)
    {
        if (string.IsNullOrWhiteSpace(codeRef.name))
            throw this.NewExpressionBuildingException("The code ref has no name.");

        var type = _typeResolver.ResolveType(codeRef.resultTypeName.Name) ?? throw this.NewExpressionBuildingException($"Unable to resolve type {codeRef.resultTypeName}");
        return InvokeDefinitionThroughRuntimeContext(codeRef.name, codeRef.libraryName, type);
    }

    private Expression CodeSystemRef(CodeSystemRef codeSystemRef)
    {
        if (string.IsNullOrWhiteSpace(codeSystemRef.name))
            throw this.NewExpressionBuildingException("The code system ref has no name.");

        var type = _typeResolver.CodeType.MakeArrayType();
        return InvokeDefinitionThroughRuntimeContext(codeSystemRef.name, codeSystemRef.libraryName, type);
    }

    protected Expression ConceptRef(ConceptRef conceptRef)
    {
        if (string.IsNullOrWhiteSpace(conceptRef.name))
            throw this.NewExpressionBuildingException("The concept ref has no name.");

        var conceptType = TypeFor(conceptRef)!;
        return InvokeDefinitionThroughRuntimeContext(conceptRef.name, conceptRef.libraryName, conceptType);
    }

    protected Expression Instance(Instance ine)
    {
        var instanceType = _typeResolver.ResolveType(ine.classType.Name)
                           ?? throw this.NewExpressionBuildingException($"Could not resolve type for '{ine.classType.Name}'");

        if (instanceType.IsEnum())
        {
            // constructs like:
            // FHIR.RemittanceOutcome {value: 'complete'}
            // FHIR.RemittanceOutcome maps to an enum type
            if (ine.element?.Length == 1 && string.Equals(ine.element![0].name, "value", StringComparison.OrdinalIgnoreCase))
            {
                var enumValueValue = TranslateArg(ine.element[0]!.value!);

                if (enumValueValue.Type == instanceType)
                    return enumValueValue;

                if (enumValueValue.Type == typeof(string)) //@ TODO: Cast - Instance
                {
                    var parseMethod = typeof(Enum)
                                      .GetMethods()
                                      .Single(m => m.Name == nameof(Enum.Parse) && m.GetParameters().Length == 3);
                    var callEnumParse = Expression.Call(parseMethod, Expression.Constant(instanceType), enumValueValue, Expression.Constant(true));
                    return callEnumParse;
                }
            }
        }
        // Prefer a constructor will all parameters.


        //var valueTypes = values
        //    .Select(v => v.Type)
        //    .ToArray();
        //var allConstructors = instanceType!
        //    .GetConstructors();
        //ConstructorInfo? allParamsCtor = null;
        //foreach(var ctor in allConstructors)
        //{
        //    var ctorParameters = ctor.GetParameters();
        //    if (ctorParameters.Length == valueTypes.Length)
        //    {
        //        if (ctorParameters.All(p => p.T))
        //    }
        //}

        var tuples = ine.element!.SelectToArray(el => (el.name!, TranslateArg(el.value)));

        // Handle immutable primitives without public setters on their properties.
        if (instanceType == typeof(CqlRatio))
        {
            Expression? numeratorExpr = null;
            Expression? denominatorExpr = null;

            foreach (var tuple in tuples)
            {
                if (tuple.Item1 == "numerator")
                    numeratorExpr = tuple.Item2;
                else if (tuple.Item1 == "denominator")
                    denominatorExpr = tuple.Item2;
                else throw this.NewExpressionBuildingException($"No property called {tuple.Item1} should exist on {nameof(CqlRatio)}");
            }
            var ctor = ConstructorInfos.CqlRatio;
            var @new = Expression.New(ctor,
                                      numeratorExpr ?? Expression.Default(typeof(CqlQuantity)),
                                      denominatorExpr ?? Expression.Default(typeof(CqlQuantity)));
            return @new;
        }

        if (instanceType == typeof(CqlQuantity))
        {
            Expression? valueExpr = null;
            Expression? unitExpr = null;

            foreach (var tuple in tuples)
            {
                if (tuple.Item1 == "value")
                    valueExpr = tuple.Item2;
                else if (tuple.Item1 == "unit")
                    unitExpr = tuple.Item2;
                else throw this.NewExpressionBuildingException($"No property called {tuple.Item1} should exist on {nameof(CqlQuantity)}");
            }
            var ctor = ConstructorInfos.CqlQuantity;

            TypeConversion typeConversion = TypeConversion.NoMatch;
            if (unitExpr is not null)
                unitExpr = ChangeType(unitExpr, typeof(string), out typeConversion);
            if (typeConversion == TypeConversion.NoMatch)
                throw this.NewExpressionBuildingException($"Unit property cannot be converted to string.");

            var @new = Expression.New(ctor,
                                      valueExpr ?? Expression.Default(typeof(decimal?)),
                                      unitExpr ?? Expression.Default(typeof(string)));
            return @new;
        }
        if (instanceType == typeof(CqlCode))
        {
            Expression? codeExpr = null;
            Expression? systemExpr = null;
            Expression? versionExpr = null;
            Expression? displayExpr = null;


            foreach (var tuple in tuples)
            {
                if (tuple.Item1 == "code")
                    codeExpr = tuple.Item2;
                else if (tuple.Item1 == "system")
                    systemExpr = tuple.Item2;
                else if (tuple.Item1 == "version")
                    versionExpr = tuple.Item2;
                else if (tuple.Item1 == "display")
                    displayExpr = tuple.Item2;
                else throw this.NewExpressionBuildingException($"No property called {tuple.Item1} should exist on {nameof(CqlCode)}");
            }
            var ctor = ConstructorInfos.CqlCode;
            var @new = Expression.New(ctor,
                                      codeExpr ?? Expression.Default(typeof(string)),
                                      systemExpr ?? Expression.Default(typeof(string)),
                                      versionExpr ?? Expression.Default(typeof(string)),
                                      displayExpr ?? Expression.Default(typeof(string)));
            return @new;
        }
        if (instanceType == typeof(CqlConcept))
        {
            Expression? codesExpr = null;
            Expression? displayExpr = null;

            foreach (var tuple in tuples)
            {
                if (tuple.Item1 == "codes")
                    codesExpr = tuple.Item2;
                else if (tuple.Item1 == "display")
                    displayExpr = tuple.Item2;
                else throw this.NewExpressionBuildingException($"No property called {tuple.Item1} should exist on {nameof(CqlConcept)}");
            }
            var ctor = ConstructorInfos.CqlConcept;
            var @new = Expression.New(ctor,
                                      codesExpr ?? Expression.Default(typeof(IEnumerable<CqlCode>)),
                                      displayExpr ?? Expression.Default(typeof(string)));
            return @new;
        }
        else
        {
            var elementBindings = new MemberAssignment[tuples.Length];
            for (int i = 0; i < tuples.Length; i++)
            {
                var tuple = tuples[i];
                var element = tuple.Item1;
                var expression = tuple.Item2;
                var memberInfo = GetProperty(instanceType, element, _typeResolver) ?? throw this.NewExpressionBuildingException($"Could not find member {element} on type {instanceType.ToCSharpString(Defaults.TypeCSharpFormat)}");
                var binding = Binding(expression, memberInfo);
                elementBindings[i] = binding;
            }
            var ctor = instanceType.GetConstructor(Type.EmptyTypes)!;
            var @new = Expression.New(ctor);
            var init = Expression.MemberInit(@new, elementBindings);
            return init;
        }
    }

    internal static PropertyInfo? GetProperty(Type type, string name, TypeResolver typeResolver)
    {
        if (type.IsGenericType)
        {
            var gtd = type.GetGenericTypeDefinition();
            if (gtd == typeof(Nullable<>))
            {
                if (string.Equals(name, "value", StringComparison.OrdinalIgnoreCase))
                {
                    var valueMember = type.GetProperty("Value");
                    return valueMember;
                }
            }
        }

        var member = typeResolver.GetProperty(type, name);
        return member;
    }


    protected MemberAssignment Binding(Expression value, MemberInfo memberInfo)
    {
        if (memberInfo is PropertyInfo property)
        {
            if (value.Type == property.PropertyType)
            {
                return Expression.Bind(memberInfo, value);
            }

            if (property.PropertyType.IsArray)
            {
                if (value.Type.IsArray)
                {
                    if (property.PropertyType.GetElementType() == value.Type.GetElementType())
                    {
                        return Expression.Bind(memberInfo, value);
                    }
                }
                else if (value.Type.IsGenericType)
                {
                    string message = $"{value.Type} was expected to be a list type.";
                    var valueEnumerableElement = _typeResolver.GetListElementType(value.Type) ?? throw this.NewExpressionBuildingException(message);
                    var memberArrayElement = property.PropertyType.GetElementType()!;
                    if (valueEnumerableElement == memberArrayElement)
                    {
                        var toArrayMethod = typeof(Enumerable)
                                            .GetMethod(nameof(Enumerable.ToArray))!
                                            .MakeGenericMethod(valueEnumerableElement);
                        var callToArray = Expression.Call(toArrayMethod, value);
                        return Expression.Bind(memberInfo, callToArray);
                    }
                    else
                    {
                        var selectParameter = Expression.Parameter(valueEnumerableElement, TypeNameToIdentifier(value.Type, this));
                        var typeConversion = TypeConversion.NoMatch;
                        var body = ChangeType(selectParameter, memberArrayElement, out typeConversion);
                        if (typeConversion == TypeConversion.NoMatch)
                            throw this.NewExpressionBuildingException($"Cannot convert {selectParameter.Type} to {memberArrayElement}.");
                        var selectLambda = Expression.Lambda(body, selectParameter);
                        var callSelectMethod = BindCqlOperator(nameof(ICqlOperators.Select), [value, selectLambda
                                                               ]);
                        var toArrayMethod = typeof(Enumerable)
                                            .GetMethod(nameof(Enumerable.ToArray))!
                                            .MakeGenericMethod(memberArrayElement);
                        var callToArray = Expression.Call(toArrayMethod, callSelectMethod);
                        return Expression.Bind(memberInfo, callToArray);
                    }
                }
            }
            else if (property.PropertyType.IsImplementingGenericTypeDefinition(typeof(ICollection<>)))
            {
                if (_typeResolver.IsListType(value.Type))
                {
                    var elementType = _typeResolver.GetListElementType(property.PropertyType)!;
                    var ctor = ConstructorInfos.ListOf(elementType);
                    var newList = Expression.New(ctor, value);
                    return Expression.Bind(memberInfo, newList);
                }
            }

            var propertyConversion = TypeConversion.NoMatch;
            var convert = ChangeType(value, property.PropertyType, out propertyConversion);
            if (propertyConversion == TypeConversion.NoMatch)
                throw this.NewExpressionBuildingException($"Cannot convert {value.Type} to {property.PropertyType}.");
            return Expression.Bind(memberInfo, convert);
        }

        throw new NotImplementedException().WithContext(this);
    }

    protected Expression If(If @if)
    {
        var rc = TranslateArg(@if.condition!);
        var condition = rc.Coalesce();
        var then = TranslateArg(@if.then!);
        if (@if.@else != null)
        {
            var @else = TranslateArg(@if.@else!);
            if (then.Type.IsValueType)
            {
                @else = HandleNullable(@else, then.Type);
            }

            if (then.Type != @else.Type)
            {
                // In fact, this is allowed, but since this would be handled using type "object" at runtime
                // (since the CLR does not support discriminated unions), we will throw an exception here.
                // We could also optimize by first trying whether the arguments are convertible to each other,
                // since that would catch quite a few cases (mostly the if .... then X else List<X> cases),
                // which are common.
                throw this.NewExpressionBuildingException(
                    $"The If expression at {@if.locator} produces two branches with different types.");
                // then = Expression.Convert(then, typeof(object));
                // @else = Expression.Convert(@else, typeof(object));
            }

            var ifThenElse = Expression.Condition(condition, then, @else);

            return ifThenElse;
        }

        var @false = Expression.Constant(null).NewAssignToTypeExpression(then.Type);
        var ifThen = Expression.Condition(condition, then, @false);
        return ifThen;
    }

    protected Expression Literal(Literal lit)
    {
        var type = _typeResolver.ResolveType(lit.valueType.Name) ?? throw this.NewExpressionBuildingException($"Cannot resolve type for {lit.valueType}");




        var (value, convertedType) = ConvertLiteral(lit, type);

        // var result = _operatorBinding.ConvertToType(Expression.Constant(value), convertedType);
        // return result;

        if (type.IsNullableValueType(out _))
        {
            var changed = Expression.Constant(value!, convertedType);
            var asNullable = changed.NewAssignToTypeExpression(type);
            return asNullable;
        }
        return Expression.Constant(value, convertedType);
    }

    protected (object?, Type) ConvertLiteral(Literal lit, Type? type) //@ TODO: Cast - ConvertLiteral
    {
        if (type == null)
            throw new NotImplementedException().WithContext(this);

        if (type.IsNullableValueType(out var underlyingType))
        {
            if (string.IsNullOrWhiteSpace(lit.value))
                return (null, type);

            if (!typeof(IConvertible).IsAssignableFrom(underlyingType))
                throw new NotSupportedException("Only convertible types can be used for literals.");

            try
            {
                var converted = Convert.ChangeType(lit.value, underlyingType, CultureInfo.InvariantCulture); //@ TODO: Cast - ConvertLiteral
                return (converted, underlyingType);
            }
            catch (OverflowException)
            {
                return (null, type);
            }
        }

        if (type == typeof(string))
            return (lit.value, type);

        if (typeof(IConvertible).IsAssignableFrom(type))
        {
            var converted = Convert.ChangeType(lit.value, type, CultureInfo.InvariantCulture); //@ TODO: Cast - ConvertLiteral
            return (converted, type);
        }

        throw new NotSupportedException("Only convertible types can be used for literals.");
    }

    protected Expression OperandRef(OperandRef ore)
    {
        if (_operands?.TryGetValue(ore.name!, out var expression) == true)
            return expression;
        throw this.NewExpressionBuildingException($"Operand reference to {ore.name} not found in definition operands.");
    }

    protected Expression Case(Case ce)
    {
        //[{ when1, then1 }, { when2, then2}, { when3, then3 }]
        // when1 ? then 1 : (when2 ? then 2 : (when3 ? then 3 : else }
        if (ce.caseItem?.Length > 0 && ce.@else != null)
        {
            var elseThen = TranslateArg(ce.@else!);
            var cases = new List<CaseWhenThenExpression.WhenThenCase>();

            if (ce.comparand != null)
            {
                var comparand = TranslateArg(ce.comparand);

                foreach (var caseItem in ce.caseItem)
                {
                    var caseWhen = TranslateArg(caseItem.when!);
                    var caseWhenEquality = BindCqlOperator(nameof(ICqlOperators.Equal), [comparand, caseWhen]).Coalesce();
                    var caseThen = TranslateArg(caseItem.then!);

                    if (caseThen.Type != elseThen.Type)
                        caseThen = caseThen.NewAssignToTypeExpression(elseThen.Type);

                    cases.Add(new(caseWhenEquality, caseThen));
                }
            }
            else
            {
                foreach (var caseItem in ce.caseItem)
                {
                    var caseWhen = TranslateArg(caseItem.when!);
                    var caseThen = TranslateArg(caseItem.then!);

                    if (caseThen.Type != elseThen.Type)
                        caseThen = caseThen.NewAssignToTypeExpression(elseThen.Type);

                    if (caseWhen.Type.IsNullableValueType(out _))
                    {
                        caseWhen = caseWhen.Coalesce();
                    }

                    cases.Add(new(caseWhen, caseThen));
                }
            }

            return new CaseWhenThenExpression(cases, elseThen);
        }

        throw this.NewExpressionBuildingException("Invalid case expression.  At least 1 case and an else must be present.");
    }

    private Expression Retrieve(Retrieve retrieve)
    {
        Type? sourceElementType;
        string? cqlRetrieveResultType;

        // SingletonFrom does not have this specified; in this case use DataType instead
        if (retrieve.resultTypeSpecifier == null)
        {
            if (string.IsNullOrWhiteSpace(retrieve.dataType.Name))
                throw this.NewExpressionBuildingException("If a Retrieve lacks a ResultTypeSpecifier it must have a DataType");
            cqlRetrieveResultType = retrieve.dataType.Name;

            sourceElementType = _typeResolver.ResolveType(cqlRetrieveResultType);
        }
        else
        {
            if (retrieve.resultTypeSpecifier is ListTypeSpecifier listTypeSpecifier)
            {
                cqlRetrieveResultType = listTypeSpecifier.elementType is NamedTypeSpecifier nts ? nts.name.Name : null;
                sourceElementType = TypeFor(listTypeSpecifier.elementType)!;
            }
            else throw new NotImplementedException($"Sources with type {retrieve.resultTypeSpecifier.GetType().Name} are not implemented.").WithContext(this);
        }

        Expression? codeProperty;

        var hasCodePropertySpecified = sourceElementType != null && retrieve.codeProperty != null;
        var isDefaultCodeProperty = retrieve.codeProperty is null ||
                                    (cqlRetrieveResultType is not null &&
                                     ModelMapping.TryGetValue(cqlRetrieveResultType, out ClassInfo? classInfo) &&
                                     classInfo.primaryCodePath == retrieve.codeProperty);

        if (hasCodePropertySpecified && !isDefaultCodeProperty)
        {
            var codePropertyInfo = _typeResolver.GetProperty(sourceElementType!, retrieve.codeProperty!);
            codeProperty = Expression.Constant(codePropertyInfo, typeof(PropertyInfo));
        }
        else
        {
            codeProperty = NullExpression.ForType<PropertyInfo>();
        }

        var templateId = TranslateArg(retrieve.templateId);
        var sourceElementTypeExpr = Expression.Constant(sourceElementType, typeof(Type));
        Expression values = NullExpression.ForType<CqlValueSet>();

        if (retrieve.codes != null)
        {
            if (retrieve.codes is ValueSetRef valueSetRef)
            {
                if (string.IsNullOrWhiteSpace(valueSetRef.name))
                    throw this.NewExpressionBuildingException($"The ValueSetRef at {valueSetRef.locator} is missing a name.");

                values = InvokeDefinitionThroughRuntimeContext(valueSetRef.name!, valueSetRef.libraryName, typeof(CqlValueSet));
            }
            else
            {
                // In this construct, instead of querying a value set, we're testing resources
                // against a list of codes, e.g., as defined by the code from or codesystem construct
                values = TranslateArg(retrieve.codes);
            }
        }

        return BindCqlOperator(CqlOperator.Retrieve, sourceElementTypeExpr, values, codeProperty, templateId);
    }

    protected Expression Property(Property op)
    {
        using (PushElement(op))
        {
            if (string.IsNullOrWhiteSpace(op.path))
                throw this.NewExpressionBuildingException("path cannot be null or empty");
            var path = op.path;

            if (!string.IsNullOrWhiteSpace(op.scope))
            {
                var scopeExpression = GetScopeExpression(op.scope!);
                var expectedType = TypeFor(op) ?? typeof(object);
                var pathMemberInfo = _typeResolver.GetProperty(scopeExpression.Type, path!) ??
                                     _typeResolver.GetProperty(scopeExpression.Type, op.path);
                if (pathMemberInfo == null)
                {
                    _logger.LogWarning(FormatMessage($"Property {op.path} can't be known at design time, and will be late-bound, slowing performance.  Consider casting the source first so that this property can be definitely bound.", op));
                    return BindCqlOperator(nameof(ICqlOperators.LateBoundProperty), scopeExpression, Expression.Constant(op.path, typeof(string)), Expression.Constant(expectedType, typeof(Type)));
                }
                var propogate = PropagateNull(scopeExpression, pathMemberInfo);
                string message = $"TupleBuilderCache failed to resolve type.";
                var resultType = TypeFor(op) ?? throw this.NewExpressionBuildingException(message);
                if (resultType != propogate.Type)
                {
                    propogate = ChangeType(propogate, resultType, out var typeConversion);
                    if (typeConversion == TypeConversion.NoMatch)
                        throw this.NewExpressionBuildingException($"Cannot convert {propogate.Type} to {resultType}.");
                }

                return propogate;
            }

            if (op.source != null)
            {
                var source = TranslateArg(op.source);
                var parts = path.Split('.');
                if (parts.Length > 1)
                {
                    // support paths like birthDate.value on Patient
                    for (int i = 0; i < parts.Length; i++)
                    {
                        var pathPart = parts[i];
                        var pathMemberInfo = _typeResolver.GetProperty(source.Type, pathPart);
                        if (pathMemberInfo != null)
                        {
                            var propertyAccess = PropagateNull(source, pathMemberInfo);
                            source = propertyAccess;
                        }
                    }
                    return source;
                }

                var expectedType = TypeFor(op, throwIfNotFound: false);

                // If we cannot determine the type from the ELM, let's try
                // if the POCO model can help us.
                if (expectedType == null)
                {
                    expectedType = _typeResolver.GetProperty(source.Type, path)?.PropertyType
                                   ?? throw this.NewExpressionBuildingException("Cannot resolve type for expression");
                }

                var result = PropertyHelper(source, path, expectedType);
                return result;
            }

            throw new NotImplementedException().WithContext(this);
        }
    }

    protected Expression PropertyHelper(Expression source, string? path, Type expectedType)
    {
        Expression? result = null;
        if (_typeResolver.ShouldUseSourceObject(source.Type, path!))
        {
            result = source;
        }
        else
        {
            var pathMemberInfo = _typeResolver.GetProperty(source.Type, path!);

            if (pathMemberInfo == null)
            {
                _logger.LogWarning(FormatMessage($"Property {path} can't be known at design time, and will be late-bound, slowing performance.  Consider casting the source first so that this property can be definitely bound."));
                return BindCqlOperator(nameof(ICqlOperators.LateBoundProperty), source, Expression.Constant(path, typeof(string)), Expression.Constant(expectedType, typeof(Type)));
            }

            if (pathMemberInfo.DeclaringType != source.Type) // the property is on a derived type, so cast it
            {
                var isCheck = source.NewTypeIsExpression(pathMemberInfo.DeclaringType!);
                var typeAs = source.NewTypeAsExpression(pathMemberInfo.DeclaringType!);
                var pathAccess = Expression.MakeMemberAccess(typeAs, pathMemberInfo);
                Expression? ifIs = pathAccess;
                Expression elseNull = Expression.Constant(null, pathMemberInfo.PropertyType);
                // some ops, like properties on alias refs, don't have type information on them.
                // can't check against what we don't have.
                if (expectedType != null)
                {
                    if (expectedType != ifIs.Type)
                    {
                        var ifIsConversion = TypeConversion.NoMatch;
                        ifIs = ChangeType(ifIs, expectedType, out ifIsConversion);
                        if (ifIsConversion == TypeConversion.NoMatch)
                            throw this.NewExpressionBuildingException($"Cannot convert {ifIs.Type} to {expectedType}.");
                    }
                    if (expectedType != elseNull.Type)
                    {
                        var elseConversion = TypeConversion.NoMatch;
                        elseNull = ChangeType(elseNull, expectedType, out elseConversion);
                        if (elseConversion == TypeConversion.NoMatch)
                            throw this.NewExpressionBuildingException($"Cannot convert {elseNull.Type} to {expectedType}.");
                    }
                }
                var condition = Expression.Condition(isCheck, ifIs, elseNull);
                return condition;
            }

            result = PropagateNull(source, pathMemberInfo);
        }

        if (expectedType != null && expectedType != result.Type)
        {
            var resultConversion = TypeConversion.NoMatch;
            result = ChangeType(result, expectedType, out resultConversion);
            if (resultConversion == TypeConversion.NoMatch)
                throw this.NewExpressionBuildingException($"Cannot convert {result.Type} to {expectedType}.");
        }
        return result;
    }

    protected Expression FunctionRef(FunctionRef op)
    {
        Expression[] operands = TranslateArgs(op.operand);

        // NOTE: Breaks
        //var resultType = op.resultTypeSpecifier ?? op.resultTypeName?.ToNamedType() ??
        //                 throw new InvalidOperationException($"FunctionRef {op.libraryName + "." + op.name} has no result type specifier or result type name.");
        //var invoke = InvokeDefinedFunctionThroughRuntimeContext(op.name!, op.libraryName!, operands, resultType);

        var invoke = InvokeDefinedFunctionThroughRuntimeContext(op.name!, op.libraryName!, op.signature, operands, op.resultTypeSpecifier);

        return invoke;
    }

    protected Expression ExpressionRef(ExpressionRef expressionRef)
    {
        IPopToken popToken = null!;
        try
        {
            Type? expressionType = null;
            if (expressionRef.resultTypeSpecifier != null)
            {
                expressionType = TypeFor(expressionRef.resultTypeSpecifier)!;
            }
            else if (!string.IsNullOrWhiteSpace(expressionRef.resultTypeName?.Name))
            {
                expressionType = _typeResolver.ResolveType(expressionRef.resultTypeName.Name);
            }
            else
            {
                var def = _libraryContext.Library.statements?.SingleOrDefault(d => d.name == expressionRef.name);
                if (def != null)
                {
                    popToken = PushElement(def);
                    expressionType = TypeFor(def);
                }
                else throw new NotSupportedException("Unable to resolve expression reference type.");
            }

            if (expressionType == null)
                throw this.NewExpressionBuildingException($"Unable to determine type for {expressionRef.localId}");

            var invoke = InvokeDefinitionThroughRuntimeContext(expressionRef.name!, expressionRef.libraryName, expressionType);

            return invoke;
        }
        finally
        {
            popToken?.Pop();
        }
    }

    protected Expression ParameterRef(ParameterRef op)
    {
        if (_libraryContext.LibraryDefinitions.TryGetValue(_libraryContext.LibraryVersionedIdentifier, op.name!, out var lambda) && lambda != null)
        {
            var invoke = InvokeDefinitionThroughRuntimeContext(op.name!, null, lambda);
            return invoke;
        }

        throw this.NewExpressionBuildingException($"Parameter {op.name} hasn't been defined yet.");
    }

    /// <param name="name">The function name</param>
    /// <param name="libraryAlias">If this is an external call, the local alias defined in the using statement</param>
    /// <param name="signature">The signature as specified in the function call.</param>
    /// <param name="arguments">The function arguments</param>
    /// <param name="returnType">The function's return type</param>
    /// <returns></returns>
    protected Expression InvokeDefinedFunctionThroughRuntimeContext(
        string name,
        string? libraryAlias,
        TypeSpecifier[]? signature,
        Expression[] arguments,
        TypeSpecifier returnType)
    {
        string libraryName = _libraryContext.GetLibraryVersionedIdentifierFromAlias(libraryAlias, throwError: false)
                             ?? throw this.NewExpressionBuildingException($"Local library {libraryAlias} is not defined; are you missing a using statement?");

        var rtt = TypeFor(returnType) ?? throw this.NewExpressionBuildingException($"Unable to resolve type for {returnType}");
        var convertedArguments = arguments
                                 .Select((a,i) => convertChoice(a, signature?[i]))
                                 .Prepend(CqlExpressions.ParameterExpression)
                                 .ToArray();
        var funcType = convertedArguments.Select(a => a.Type).Append(rtt).ToArray();
        Type definitionType = Expression.GetFuncType(funcType);

        return new FunctionCallExpression(CqlExpressions.Definitions_PropertyExpression, libraryName, name, convertedArguments, definitionType);

        // This function will handle the cases where the normal C# invocation is insufficient to represent the CQL function call:
        // the argument is of a choice type, and the parameter is of a specific type (or for now, also a choice type).
        // In this case we need to insert a conversion from the choice type to the specific type of the argument. Presumably, the
        // cql2elm compiler has already checked that the call is valid, but we do need to cast the choice type (in C# represented by
        // object/DataType) to the actual type to make this a valid C# call. CQL semantics state that the result may be null if the
        // choice is not compatible with the parameter, so we'll use an As in C#.
        Expression convertChoice(Expression argument, TypeSpecifier? targetTypeSpecifier)
        {
            if(argument.Type == typeof(object)
               && targetTypeSpecifier is not null and not ChoiceTypeSpecifier)
            {
                var changeType = ChangeType(argument, targetTypeSpecifier, out var typeConversion, considerSafeUpcast: true);
                Debug.Assert(typeConversion == TypeConversion.ExpressionTypeAs);
                return changeType;
            }

            return argument;
        }
    }

    protected Expression InvokeDefinitionThroughRuntimeContext(
        string name,
        string? libraryAlias,
        LambdaExpression definition)
    {
        var type = definition.Type;
        if (type.IsGenericType)
        {
            var typeArgs = type.GetGenericArguments();
            var returnType = typeArgs[^1];
            var invoke = InvokeDefinitionThroughRuntimeContext(name, libraryAlias, returnType);
            return invoke;
        }

        throw this.NewExpressionBuildingException("LambdaExpressions should be a variant of Func<>");
    }

    protected Expression InvokeDefinitionThroughRuntimeContext(
        string name,
        string? libraryAlias,
        Type definitionReturnType)
    {
        string libraryName = _libraryContext.GetLibraryVersionedIdentifierFromAlias(libraryAlias, throwError: false)
                             ?? throw this.NewExpressionBuildingException($"Local library {libraryAlias} is not defined; are you missing a using statement?");

        var funcType = typeof(Func<,>).MakeGenericType(typeof(CqlContext), definitionReturnType);
        return new DefinitionCallExpression(CqlExpressions.Definitions_PropertyExpression, libraryName, name, CqlExpressions.ParameterExpression, funcType);
    }

    private Expression ProcessValueSet(ValueSetRef valueSetRef, Elm.Expression valueExpr, bool isList)
    {
        Expression expr = TranslateArg(valueExpr);

        var codeType = isList ? _typeResolver.GetListElementType(expr.Type, throwError: true)! : expr.Type;

        var valueSet = InvokeDefinitionThroughRuntimeContext(valueSetRef.name!, valueSetRef.libraryName, typeof(CqlValueSet));
        if (codeType == _typeResolver.CodeType)
            return BindCqlOperator(isList ? nameof(ICqlOperators.CodesInValueSet) : nameof(ICqlOperators.CodeInValueSet), expr, valueSet);

        if (codeType == _typeResolver.ConceptType)
            return BindCqlOperator(isList ? nameof(ICqlOperators.ConceptsInValueSet) : nameof(ICqlOperators.ConceptInValueSet), expr, valueSet);

        if (codeType == typeof(string))
            return BindCqlOperator(isList ? nameof(ICqlOperators.StringsInValueSet) : nameof(ICqlOperators.StringInValueSet), expr, valueSet);

        throw new NotImplementedException().WithContext(this);
    }
}

#endregion

#region ArithmeticOperators

internal partial class ExpressionBuilderContext
{
    private const string Int32MaxPlusOneAsString = "2147483648";

    private Expression NegateLiteral(Negate e, Literal literal)
    {
        // handle things like -2147483648 which gets translated to Negate(2147483648)
        // since int.MaxValue is 2147483647, we have to handle this specially
        var literalType = TypeFor(literal);
        if (literalType == typeof(int?) && literal.value == Int32MaxPlusOneAsString)
            return Expression.Constant(int.MinValue);

        if (literalType == typeof(long?)
            && literal.value == long.MinValue.ToString(CultureInfo.InvariantCulture))
            return Expression.Constant(long.MinValue);

        return BindCqlOperator(nameof(ICqlOperators.Negate), e.operand);
    }

    private Expression Negate(Negate e)
    {
        if (e.operand is Literal literal)
            return NegateLiteral(e, literal);

        return BindCqlOperator(nameof(ICqlOperators.Negate), e.operand);
    }
}

#endregion

#region ComparisonOperators

internal partial class ExpressionBuilderContext
{
    protected Expression Equivalent(Equivalent eqv)
    {
        if (TranslateArgs(eqv.operand) is [{ } left, { } right]
            && _typeResolver.GetListElementType(left.Type, throwError: false) is { } leftType
            && _typeResolver.GetListElementType(right.Type, throwError: false) is { } rightType
            && leftType != rightType)
        {
            // This appears in the CQL tests:
            //  { 'a', 'b', 'c' } ~ { 1, 2, 3 } = false
            return Expression.Constant(false, typeof(bool?));
        }

        return BindCqlOperator(nameof(ICqlOperators.Equivalent), GetBindArgs(eqv));
    }
}

#endregion

#region ErrorsAndMessaging

internal partial class ExpressionBuilderContext
{
    private Expression Message(Message e)
    {
        var condition = TranslateArg(e.condition!);

        var source = TranslateArg(e.source!);
        var code = TranslateArg(e.code!);
        var severity = TranslateArg(e.severity!);
        var message = TranslateArg(e.message!);

        if (source is ConstantExpression { Value: null } constant)
        {
            // create an explicit "null as object" so the generic type can be inferred in source code.
            source = constant.NewAssignToTypeExpression(constant.Type);
        }

        var call = BindCqlOperator(nameof(ICqlOperators.Message), source, code, severity, message);
        if (condition.Type.IsNullableValueType(out _))
        {
            condition = condition.Coalesce();
        }

        return Expression.Condition(condition, call, source);
    }
}

#endregion

#region IntervalOperators

internal partial class ExpressionBuilderContext
{
    protected Expression? Includes(Includes e)
    {
        var left = TranslateArg(e.operand![0]);
        var right = TranslateArg(e.operand![1]);
        if (_typeResolver.IsListType(left.Type))
        {
            var leftElementType = _typeResolver.GetListElementType(left.Type);
            if (_typeResolver.IsListType(right.Type))
            {
                var rightElementType = _typeResolver.GetListElementType(left.Type);
                if (leftElementType != rightElementType)
                    throw this.NewExpressionBuildingException();
                return BindCqlOperator(nameof(ICqlOperators.ListIncludesList), left, right);
            }

            if (leftElementType != right.Type)
                throw this.NewExpressionBuildingException();
            return BindCqlOperator(nameof(ICqlOperators.ListIncludesElement), left, right);
        }

        if (left.Type.IsCqlInterval(out var leftPointType))
        {
            if (right.Type.IsCqlInterval(out var pointType))
            {
                var precision = ((IGetPrecision)e).GetPrecision();
                return BindCqlOperator(nameof(ICqlOperators.IntervalIncludesInterval), left, right, precision);
            }
            else
            {
                var precision = ((IGetPrecision)e).GetPrecision();
                return BindCqlOperator(nameof(ICqlOperators.IntervalIncludesElement), left, right, precision);
            }
        }
        throw new NotImplementedException().WithContext(this);
    }

    protected Expression IncludedIn(IncludedIn e)
    {
        var left = TranslateArg(e.operand![0]);
        var right = TranslateArg(e.operand![1]);
        if (_typeResolver.IsListType(left.Type))
        {
            var leftElementType = _typeResolver.GetListElementType(left.Type);
            if (_typeResolver.IsListType(right.Type))
            {
                var rightElementType = _typeResolver.GetListElementType(left.Type);
                if (leftElementType != rightElementType)
                    throw this.NewExpressionBuildingException();
                return BindCqlOperator(nameof(ICqlOperators.ListIncludesList), right, left);
            }

            if (leftElementType != right.Type)
                throw this.NewExpressionBuildingException();
            return BindCqlOperator(nameof(ICqlOperators.ListIncludesElement), right, left);
        }

        if (left.Type.IsCqlInterval(out var leftPointType) && right.Type.IsCqlInterval(out var rightPointType))
        {
            var precision = ((IGetPrecision)e).GetPrecision();
            return BindCqlOperator(nameof(ICqlOperators.IntervalIncludesInterval), right, left, precision);
        }
        if (right.Type.IsCqlInterval(out var pointType))
        {
            var precision = ((IGetPrecision)e).GetPrecision();
            if (left.Type != pointType)
                throw this.NewExpressionBuildingException();
            return BindCqlOperator(nameof(ICqlOperators.IntervalIncludesElement), right, left, precision);

        }

        throw new NotImplementedException().WithContext(this);
    }

    protected Expression? ProperIncludes(ProperIncludes e)
    {
        var left = TranslateArg(e.operand![0]);
        var right = TranslateArg(e.operand![1]);
        if (left.Type.IsCqlInterval(out var leftPointType))
        {
            var precision = ((IGetPrecision)e).GetPrecision();
            if (right.Type.IsCqlInterval(out var rightPointType))
            {
                return BindCqlOperator(nameof(ICqlOperators.IntervalProperlyIncludesInterval), left, right, precision);
            }

            return BindCqlOperator(nameof(ICqlOperators.IntervalProperlyIncludesElement), left, right, precision);
        }

        if (_typeResolver.IsListType(left.Type))
        {
            // var leftElementType = _typeResolver.GetListElementType(left.Type);
            if (_typeResolver.IsListType(right.Type))
            {
                // var rightElementType = _typeResolver.GetListElementType(right.Type);
                return BindCqlOperator(nameof(ICqlOperators.ListProperlyIncludesList), left, right);
            }

            return BindCqlOperator(nameof(ICqlOperators.ListProperlyIncludesElement), left, right);
        }
        throw new NotImplementedException().WithContext(this);
    }


    protected Expression? ProperIncludedIn(ProperIncludedIn e)
    {
        var left = TranslateArg(e.operand![0]);
        var right = TranslateArg(e.operand![1]);
        if (left.Type.IsCqlInterval(out var leftPointType))
        {
            if (right.Type.IsCqlInterval(out var rightPointType))
            {
                var precision = ((IGetPrecision)e).GetPrecision();
                return BindCqlOperator(nameof(ICqlOperators.IntervalProperlyIncludesInterval), right, left, precision);
            }
        }
        else if (_typeResolver.IsListType(left.Type))
        {
            var leftElementType = _typeResolver.GetListElementType(left.Type);
            if (_typeResolver.IsListType(right.Type))
            {
                var rightElementType = _typeResolver.GetListElementType(right.Type);
                if (leftElementType != rightElementType)
                    throw this.NewExpressionBuildingException();
                return BindCqlOperator(nameof(ICqlOperators.ListProperlyIncludesList), right, left);
            }
        }
        else if (right.Type.IsCqlInterval(out var rightPointType))
        {
            var precision = ((IGetPrecision)e).GetPrecision();
            return BindCqlOperator(nameof(ICqlOperators.IntervalProperlyIncludesElement), right, left, precision);
        }
        throw new NotImplementedException().WithContext(this);
    }

    private Expression? ProperIn(ProperIn e)
    {
        var element = TranslateArg(e.operand![0]);
        var intervalOrList = TranslateArg(e.operand![1]);
        if (intervalOrList.Type.IsCqlInterval(out var pointType))
        {
            var precision = ((IGetPrecision)e).GetPrecision();
            return BindCqlOperator(nameof(ICqlOperators.IntervalProperlyIncludesElement), intervalOrList, element, precision);
        }

        if (_typeResolver.IsListType(intervalOrList.Type))
        {
            return BindCqlOperator(nameof(ICqlOperators.ListProperlyIncludesElement), intervalOrList, element);
        }
        throw new NotImplementedException().WithContext(this);
    }

    protected Expression? ProperContains(ProperContains e)
    {
        var left = TranslateArg(e.operand![0]);
        var right = TranslateArg(e.operand![1]);
        if (_typeResolver.IsListType(left.Type))
        {
            var leftElementType = _typeResolver.GetListElementType(left.Type);
            if (_typeResolver.IsListType(right.Type))
            {
                var rightElementType = _typeResolver.GetListElementType(right.Type);
                if (leftElementType != rightElementType)
                    throw this.NewExpressionBuildingException();
                return BindCqlOperator(nameof(ICqlOperators.ListProperlyIncludesList), left, right);
            }

            if (leftElementType != right.Type)
                throw this.NewExpressionBuildingException();
            return BindCqlOperator(nameof(ICqlOperators.ListProperlyIncludesElement), left, right);
        }

        if (left.Type.IsCqlInterval(out var leftPointType))
        {
            if (leftPointType != right.Type)
                throw this.NewExpressionBuildingException();
            var precision = ((IGetPrecision)e).GetPrecision();
            return BindCqlOperator(nameof(ICqlOperators.IntervalProperlyIncludesElement), left, right, precision);
        }
        throw new NotImplementedException().WithContext(this);
    }
}

#endregion

#region NullologicalOperators

internal partial class ExpressionBuilderContext
{
    protected Expression Coalesce(Coalesce ce)
    {
        var operands = TranslateArgs(ce.operand);

        if (operands.Length == 1 && _typeResolver.IsListType(operands[0].Type))
            return BindCqlOperator(nameof(ICqlOperators.Coalesce), operands[0]);

        var distinctOperandTypes = operands
                                   .Select(op => op.Type)
                                   .Distinct()
                                   .ToArray();
        if (distinctOperandTypes.Length != 1)
            throw this.NewExpressionBuildingException("All operand types should match when using Coalesce");

        var type = operands[0].Type;
        if (type.IsValueType && !type.IsNullableValueType(out _))
            throw new NotSupportedException("Coalesce on value types is not defined.");

        if (operands.Length == 1)
            return operands[0];

        var coalesce = Expression.Coalesce(operands[0], operands[1]);
        for (int i = 2; i < operands.Length; i++)
        {
            coalesce = Expression.Coalesce(coalesce, operands[i]);
        }
        return coalesce;
    }

    protected Expression IsNull(IsNull isn)
    {
        var operand = TranslateArg(isn.operand!);
        if (operand.Type.IsValueType && operand.Type.IsNullableValueType(out _) == false)
            return Expression.Constant(false, typeof(bool));

        var compare = Expression.Equal(operand, Expression.Constant(null));
        var asNullableBool = compare.NewAssignToTypeExpression<bool?>();
        return asNullableBool;
    }
}

#endregion

#region Query
internal partial class ExpressionBuilderContext
{
    protected Expression Query(Query query)
    {
        QueryDumpDebugInfoToLog(query);

        Action popTokens = null!;

        void PushScopes(
            string? alias = null,
            params ExpressionElementPairForIdentifier[] kvps)
        {
            var popToken = this.PushScopes(alias, kvps);
            popTokens = (() => popToken.Pop()) + popTokens;
        }

        try
        {
            var sources = query.source;
            if (sources.Length == 0)
                throw this.NewExpressionBuildingException("Queries must define at least 1 source");

            var (@return, sourcesPreviouslySingletons) = ProcessQuerySources(query);
            var returnElementType = _typeResolver.GetListElementType(@return.Type, true)!;

            ParameterExpression scopeParameter;
            if (sources.Length == 1)
            {
                var source0 = sources[0];
                var sourceParameterName = NormalizeIdentifier(source0.alias);
                scopeParameter = Expression.Parameter(returnElementType, sourceParameterName);
                PushScopes(ImpliedAlias, KeyValuePair.Create(source0.alias, ((Expression)scopeParameter, (Element)source0.expression)));
            }
            else
            {
                var sourceParameterName = TypeNameToIdentifier(returnElementType, this);
                scopeParameter = Expression.Parameter(returnElementType, sourceParameterName);
                var scopes =
                    (
                        from property in returnElementType!.GetProperties()
                        let propertyAccess = Expression.Property(scopeParameter, property)
                        select new ExpressionElementPairForIdentifier(property.Name, (propertyAccess, query))
                    )
                    .ToArray();
                PushScopes(ImpliedAlias, scopes);
            }

            if (query.let != null)
            {
                foreach (var let in query.let)
                {
                    var expression = TranslateArg(let.expression!);
                    PushScopes(ImpliedAlias, KeyValuePair.Create(let.identifier!, (expression, (Element)let.expression!)));
                }
            }

            // handle with/such-that
            if (query.relationship is not null)
            {
                foreach (var relationship in query.relationship)
                {
                    using (PushElement(relationship))
                    {
                        var selectManyLambda = WithToSelectManyBody(scopeParameter, relationship);

                        var selectManyCall = BindCqlOperator(nameof(ICqlOperators.SelectMany), @return, selectManyLambda);
                        if (relationship is Without)
                        {
                            var callExcept = BindCqlOperator(nameof(ICqlOperators.Except), @return, selectManyCall);
                            @return = callExcept;
                        }
                        else
                        {
                            @return = selectManyCall;
                        }
                    }
                }
            }
            // 20240312 EK: refactoring made this redundant, but I am not sure it really is, so I am keeping
            // it around. It was used to redefine the type for the "rootScopeParameter", which used to be defined
            // inside every if statement here (so for where, return, etc).
            // -----
            // The element type may have changed
            // elementType = TypeResolver.GetListElementType(@return.Type, @throw: true)!;
            if (query.where is { } queryWhere)
            {
                @return = Where(queryWhere, scopeParameter, @return);
            }

            if (query.@return != null)
            {
                using (PushElement(query.@return))
                {
                    var selectBody = TranslateArg(query.@return.expression!);
                    var selectLambda = Expression.Lambda(selectBody, scopeParameter);
                    var callSelect = BindCqlOperator(nameof(ICqlOperators.Select), @return, selectLambda);
                    @return = callSelect;
                }
            }

            if (query.aggregate is { } queryAggregate)
            {
                @return = AggregateClause(query, queryAggregate, scopeParameter, @return);
            }

            if (query.sort is { by.Length: > 0 })
            {
                if (sources.Length == 1)
                    @return = SortClause(query, @return);
                else
                {
                    throw new NotImplementedException("Sort is broken in ELM XSD?").WithContext(this);
                    //foreach (var by in query.sort.by)
                    //{
                    //    var order = ListSortDirection.Ascending;
                    //    if (by.direction == "desc" || by.direction == "descending")
                    //        order = ListSortDirection.Descending;
                    //    else if (by.direction == "asc" || by.direction == "ascending")
                    //        order = ListSortDirection.Ascending;
                    //    else throw ctx.NewExpressionBuildingException($"Invalid sort order {by.direction}");

                    //    if (by.expression != null)
                    //    {
                    //        var parameterName = "@this";
                    //        var returnElementType = TypeResolver.GetListElementType(@return.Type);
                    //        var sortMemberParameter = Expression.Parameter(returnElementType, parameterName);
                    //        var subContext = ctx.WithImpliedAlias(parameterName!, sortMemberParameter, by.expression);
                    //        var sortMemberExpression = TranslateExpression(by.expression, subContext);
                    //        var lambdaBody = Expression.Convert(sortMemberExpression, typeof(object));
                    //        var sortLambda = System.Linq.Expressions.Expression.Lambda(lambdaBody, sortMemberParameter);
                    //        var sort = Operators.Bind(CqlOperator.SortBy, ctx.RuntimeContextParameter,
                    //            @return, sortLambda, Expression.Constant(order, typeof(SortOrder)));
                    //        @return = sort;
                    //    }
                    //    else if (by.path != null && by.resultTypeName != null)
                    //    {
                    //        var parameterName = "@this";
                    //        var returnElementType = TypeResolver.GetListElementType(@return.Type);
                    //        var sortMemberParameter = Expression.Parameter(returnElementType, parameterName);
                    //        var pathMemberType = TypeResolver.ResolveType(by.resultTypeName);
                    //        if (pathMemberType == null)
                    //        {
                    //            var msg = $"Type specifier {by.resultTypeName} at {by.locator ?? "unknown"} could not be resolved.";
                    //            ctx.LogError(msg);
                    //            throw ctx.NewExpressionBuildingException(msg);
                    //        }
                    //        var pathExpression = PropertyHelper(sortMemberParameter, by.path, pathMemberType!, ctx);
                    //        var lambdaBody = Expression.Convert(pathExpression, typeof(object));
                    //        var sortLambda = System.Linq.Expressions.Expression.Lambda(lambdaBody, sortMemberParameter);
                    //        var sort = Operators.Bind(CqlOperator.SortBy, ctx.RuntimeContextParameter,
                    //            @return, sortLambda, Expression.Constant(order, typeof(SortOrder)));
                    //        @return = sort;
                    //    }
                    //    else
                    //    {
                    //        var sort = Operators.Bind(CqlOperator.Sort, ctx.RuntimeContextParameter,
                    //            @return, Expression.Constant(order, typeof(SortOrder)));
                    //        @return = sort;
                    //    }
                    //}

                }
            }

            // Because we promoted the source to a list, we now have to demote the result again.
            var wereAllSourcesPreviouslySingletons = sourcesPreviouslySingletons.All(b => b);
            if (wereAllSourcesPreviouslySingletons)
            {
                @return = DemoteSourceListToSingleton(@return);
            }

            if (query.resultTypeSpecifier is ListTypeSpecifier && !_typeResolver.IsListType(@return.Type))
            {
                @return = Expression.NewArrayInit(@return.Type, @return);
            }

            return @return;
        }
        finally
        {
            popTokens?.Invoke();
        }
    }

    private Expression DemoteSourceListToSingleton(Expression source)
    {
        // Do not inline this method, so that we can clearly see the pairing with the call to PromoteSourceSingletonToList
        var typeArg = _typeResolver.GetListElementType(source.Type, true);
        return BindCqlOperator(nameof(ICqlOperators.SingletonFrom), [source], [typeArg!]);
    }

    private (Expression source, bool sourceOriginallyASingleton) PromoteSourceSingletonToList(Expression source)
    {
        if (_typeResolver.IsListType(source.Type))
            return (source, false);

        source = Expression.NewArrayInit(source.Type, source);
        return (source, true);
    }



    [Conditional("DEBUG")]
    private void QueryDumpDebugInfoToLog(Query query)
    {
        var sourceLength = query.source?.Length ?? 0;
        var lines = ReadCqlLines(query);
        var sources = ReadSources();

        (string alias, Type sourceType, bool isEnumerationType)[] ReadSources() => query.source!
            .SelectToArray(s =>
            {
                var sourceType = TranslateArg(s.expression).Type;
                var isEnumerationType = _typeResolver.IsListType(sourceType);
                if (isEnumerationType) sourceType = _typeResolver.GetListElementType(sourceType, true)!;
                return (
                           s.alias,
                           sourceType,
                           isEnumerationType
                       );
            });

        string[]? ReadCqlLines(Element element)
        {
            if (element.locator?.Split([":", "-"], 4, StringSplitOptions.TrimEntries) is not [{ } r0, { } c0, { } r1, { } c1]) return null;

            static int ParseInt32(string s) => int.Parse(s, CultureInfo.InvariantCulture);

            var (row0, col0, row1, col1) = (ParseInt32(r0), ParseInt32(c0), ParseInt32(r1), ParseInt32(c1));

            var elmFilePath = _libraryContext.Library.OriginalFilePath;
            if (elmFilePath is null)
                return null;

            var fiElm = new FileInfo(elmFilePath);
            var fiCql = new FileInfo(Path.Combine(fiElm.Directory!.Parent!.FullName, "CQL", fiElm.Name[..^4] + "cql"));
            if (!fiCql.Exists)
                return null;

            var lines =
                File.ReadLines(fiCql.FullName)
                    .Select((lineText, i) => (lineText, lineNum: i + 1))
                    .Where(t => t.lineNum >= row0 && t.lineNum <= row1)
                    .Select(t =>
                    {
                        var lineText = t.lineText;
                        Debug.Assert(row0 != row1 || col1 > col0);
                        if (t.lineNum == row1)
                        {
                            // Cannot trust the locator data in elm files to be within the bounds of the current line
                            col1 = Math.Clamp(col1, 0, lineText.Length);
                            lineText = lineText[..col1] + "<<<" + lineText[col1..];
                        }

                        if (t.lineNum == row0)
                        {
                            // Cannot trust the locator data in elm files to be within the bounds of the current line
                            col0 = Math.Clamp(col0, 0, lineText.Length);
                            lineText = lineText[..col0] + ">>>" + lineText[col0..];
                        }

                        return lineText;
                    })
                    .ToArray();
            return lines;
        }

        _logger.LogDebug(
            """
            Found {queryType} Query with {sourceCount} source(s) at: {at}
            Sources:{sources}
            CQL: {lines}
            """,
            ((ReadOnlySpan<string>)["Empty", "Single", "Multi"])[Math.Clamp(sourceLength, 0, 2)],
            sourceLength,
            DebuggerView,
            $"{string.Concat(from s in sources select $"\n\t{s.alias}: {(s.isEnumerationType ? "Enumeration" : "Singleton")} of {s.sourceType}")}",
            lines is not null ? $"{string.Concat(from l in lines select $"\n\t{l}")}" : "");
    }

    private (Expression sourceExpression, bool[] sourcesPreviouslySingletons) ProcessQuerySources(Query query)
    {
        AliasedQuerySource[] sources = query.source;

        if (sources.Length is 0)
            throw this.NewExpressionBuildingException("A query must have at least one source.");

        var aliases = sources.SelectToArray(s => s.alias);
        if (aliases.Any(alias => string.IsNullOrEmpty(alias)))
            throw this.NewExpressionBuildingException("Query sources must have aliases.");

        var sourceExpressions = TranslateArgs(sources.SelectToArray(source => source.expression));

        // Returns a CrossJoin between IEnumerable<> of T1, T2, T3, etc and return into IEnumerable<(T1, T2, T3, etc)>
        // a) If a source is not of a list-type (ie, a singleton), it needs to be promoted to a list type.
        // b) Cross-Join
        //    IEnumerable<A> a = ...;
        //    IEnumerable<B> b = ...;
        //    IEnumerable<c> c = ...;
        //    IEnumerable<(A, B, C)> crossJoinedValueTupleResults = CrossJoin<A, B, C>(a, b, c);

        var temp = sourceExpressions.SelectToArray(expr => PromoteSourceSingletonToList(expr));
        var promotedSourceExpressions = temp.SelectToArray(s => s.source);
        var sourcesPreviouslySingletons = temp.SelectToArray(s => s.sourceOriginallyASingleton);

        // Only one source, so no need for cross-joining. Return as-is.
        if (sources.Length == 1)
            return (promotedSourceExpressions[0], sourcesPreviouslySingletons);

        var crossJoinedValueTupleResultsExpression = BindCqlOperator(nameof(ICqlOperators.CrossJoin), promotedSourceExpressions);

        // Select the IEnumerable<> of value-tuples above into IEnumerable<> of our custom tuple
        // a) Create the custom tuple
        // b) Select
        //    IEnumerable<Tuple_ABC> crossJoinedCqlTupleResults = Select(
        //        crossJoinedValueTupleResults,
        //        valueTuple => {
        //            var abc = new Tuple_ABC();
        //            abc.A = t.Item1;
        //            abc.B = t.Item2;
        //            abc.C = t.Item3;
        //            return abc;
        //        });

        Type[] sourceListElementTypes = promotedSourceExpressions
            .SelectToArray(pse => _typeResolver.GetListElementType(pse.Type, true)!);

        var aliasAndElementTypes = aliases
                                   .Zip(sourceListElementTypes, (alias, elementType) => (alias, elementType))
                                   .ToDictionary(t => t.alias, t => t.elementType);

        // IEnumerable<(A,B,C)
        var funcResultType = crossJoinedValueTupleResultsExpression.Type;

        // (A,B,C)
        const BindingFlags bfPublicInstance = BindingFlags.Public | BindingFlags.Instance;

        Type valueTupleType = _typeResolver.GetListElementType(funcResultType, true)!;
        FieldInfo[] valueTupleFields = valueTupleType.GetFields(bfPublicInstance | BindingFlags.GetField);

        Type cqlTupleType = _tupleBuilderCache.CreateOrGetTupleTypeFor(aliasAndElementTypes);
        PropertyInfo[] cqlTupleProperties = cqlTupleType.GetProperties(bfPublicInstance | BindingFlags.SetProperty);

        Debug.Assert(valueTupleFields.Length > 0);
        Debug.Assert(valueTupleFields.Length == cqlTupleProperties.Length);

        var valueTupleTypeParam = Expression.Parameter(valueTupleType, "_valueTuple");
        var selectExpression =
            Expression.Lambda(
                CopyValueTupleIntoCqlTuple(),
                valueTupleTypeParam);

        Expression CopyValueTupleIntoCqlTuple()
        {
            var newCqlTupleExpr = Expression.New(cqlTupleType);

            var memberAssignments = valueTupleFields
                                    .Zip(cqlTupleProperties, (valueTupleField, cqlTupleProp) => (valueTupleField, cqlTupleProp))
                                    .SelectToArray(
                                        valueTupleFields.Length,
                                        t => Expression.Bind(
                                            t.cqlTupleProp.GetSetMethod()!,
                                            Expression.Field(valueTupleTypeParam, t.valueTupleField)));

            var copyProps = Expression.MemberInit(newCqlTupleExpr, memberAssignments);
            return copyProps;
        }

        var crossJoinedCqlTupleResultsExpression = BindCqlOperator(nameof(ICqlOperators.Select), crossJoinedValueTupleResultsExpression, selectExpression);

        return (crossJoinedCqlTupleResultsExpression, sourcesPreviouslySingletons)!;
    }

    protected Expression SortClause(
        Query query,
        Expression @return)
    {
        //[System.Xml.Serialization.XmlIncludeAttribute(typeof(ByExpression))]
        //[System.Xml.Serialization.XmlIncludeAttribute(typeof(ByColumn))]
        //[System.Xml.Serialization.XmlIncludeAttribute(typeof(ByDirection))]
        using (PushElement(query.sort))
        {
            foreach (var by in query.sort.by)
            {
                using (PushElement(by))
                {
                    ListSortDirection order = by.direction.ListSortOrder();
                    switch (by)
                    {
                        case ByExpression byExpression:
                            {
                                var parameterName = "@this";
                                var returnElementType = _typeResolver.GetListElementType(@return.Type, true)!;
                                var sortMemberParameter = Expression.Parameter(returnElementType, parameterName);
                                using (PushScopes(parameterName,
                                                  KeyValuePair.Create(parameterName, ((Expression)sortMemberParameter, (Element)byExpression.expression))))
                                {
                                    var sortMemberExpression = TranslateArg(byExpression.expression);
                                    var lambdaBody = _cqlOperatorsBinder.ConvertToType(sortMemberExpression, typeof(object));
                                    var sortLambda = Expression.Lambda(lambdaBody, sortMemberParameter);
                                    return BindCqlOperator(nameof(ICqlOperators.SortBy), @return, sortLambda, Expression.Constant(order, typeof(ListSortDirection)));
                                }
                            }
                        case ByColumn byColumn:
                            {
                                var parameterName = "@this";
                                var returnElementType = _typeResolver.GetListElementType(@return.Type, true)!;
                                var sortMemberParameter = Expression.Parameter(returnElementType, parameterName);
                                var pathMemberType = TypeFor(byColumn);
                                if (pathMemberType == null)
                                {
                                    throw this.NewExpressionBuildingException($"Type specifier {by.resultTypeName} at {by.locator ?? "unknown"} could not be resolved.");
                                }
                                var pathExpression = PropertyHelper(sortMemberParameter, byColumn.path, pathMemberType!);
                                var lambdaBody = _cqlOperatorsBinder.ConvertToType(pathExpression, typeof(object));
                                var sortLambda = Expression.Lambda(lambdaBody, sortMemberParameter);
                                return BindCqlOperator(nameof(ICqlOperators.SortBy), @return, sortLambda, Expression.Constant(order, typeof(ListSortDirection)));
                            }
                        default:
                            {
                                return BindCqlOperator(nameof(ICqlOperators.ListSort), @return, Expression.Constant(order, typeof(ListSortDirection)));
                            }
                    }
                }
            }
        }
        return @return;
    }

    protected LambdaExpression WithToSelectManyBody(
        ParameterExpression rootScopeParameter,
        RelationshipClause with)
    {
        if (with.expression == null)
            throw this.NewExpressionBuildingException("With must have a 'source' expression.");

        if (with.suchThat == null)
            throw this.NewExpressionBuildingException("With must have a 'such that' expression.");

        //define "With Such That":
        //[Encounter] E
        //  with[Condition] P
        //   such that P.onset during E.period
        //     and P.abatement after end of E.period

        //Func<Bundle, Context, IEnumerable<Encounter>> x = (bundle, ctx) =>
        //    bundle.Entry.ByResourceType<Encounter>()
        //    .SelectMany(E =>
        //        bundle.Entry.ByResourceType<Condition>() // <--
        //            .Where(P => true) // such that goes here
        //            .Select(P => E));
        var source = TranslateArg(with.expression);
        if (!_typeResolver.IsListType(source.Type))
        {
            // e.g.:
            // with "Index Prescription Start Date" IPSD
            // where IPSD is a Date
            // Promote to an array for consistency.
            var newArray = Expression.NewArrayInit(source.Type, source);
            source = newArray;
        }
        var sourceElementType = _typeResolver.GetListElementType(source.Type)!;

        var whereLambdaParameter = Expression.Parameter(sourceElementType, with.alias);
        using (PushScopes(ImpliedAlias, KeyValuePair.Create(with.alias!, ((Expression)whereLambdaParameter, (Element)with))))
        {
            var suchThatBody = TranslateArg(with.suchThat);

            var whereLambda = Expression.Lambda(suchThatBody, whereLambdaParameter);
            var callWhereOnSource = BindCqlOperator(nameof(ICqlOperators.Where), source, whereLambda);

            var selectLambdaParameter = Expression.Parameter(sourceElementType, with.alias);
            var selectBody = rootScopeParameter; // P => E
            var selectLambda = Expression.Lambda(selectBody, selectLambdaParameter);
            var callSelectOnWhere = BindCqlOperator(nameof(ICqlOperators.Select), callWhereOnSource, selectLambda);
            var selectManyLambda = Expression.Lambda(callSelectOnWhere, rootScopeParameter);
            return selectManyLambda;

        }
    }


    protected Expression Where(
        Elm.Expression queryWhere,
        ParameterExpression sourceParameter,
        Expression @return)
    {
        using (PushElement(queryWhere))
        {
            var whereBody = TranslateArg(queryWhere);
            var whereLambda = Expression.Lambda(whereBody, sourceParameter);
            return BindCqlOperator(nameof(ICqlOperators.Where), @return, whereLambda);
        }
    }

    protected Expression AggregateClause(
        Query query,
        AggregateClause queryAggregate,
        ParameterExpression sourceParameter,
        Expression @return)
    {
        using (PushElement(queryAggregate))
        {
            var resultAlias = queryAggregate.identifier!;
            Type? resultType = null;
            if (queryAggregate.resultTypeSpecifier is { } typeSpecifier)
            {
                resultType = TypeFor(typeSpecifier)!;
            }
            else if (!string.IsNullOrWhiteSpace(queryAggregate.resultTypeName.Name!))
            {
                resultType = _typeResolver.ResolveType(queryAggregate.resultTypeName.Name!);
            }

            if (resultType is null)
                throw this.NewExpressionBuildingException(
                    $"Could not resolve aggregate query result type for query {query.localId} at {query.locator}");

            var resultParameter = Expression.Parameter(resultType, resultAlias);
            using (PushScopes(ImpliedAlias, KeyValuePair.Create(resultAlias!, ((Expression)resultParameter, (Element)queryAggregate))))
            {
                var lambdaBody = TranslateArg(queryAggregate.expression!);
                // when starting is not present, it is a null literal typed as Any (object).
                // cast the null to the expression type.
                var typeConversion = TypeConversion.NoMatch;
                var starting = TranslateArg(queryAggregate.starting!);
                var startingValue = ChangeType(starting, lambdaBody.Type, out typeConversion);
                if (typeConversion == TypeConversion.NoMatch)
                {
                    throw this.NewExpressionBuildingException(
                        $"Cannot convert starting value of type {starting.Type.ToCSharpString()} to the result type of the aggregate expression ({lambdaBody.Type.ToCSharpString()})");
                }
                if (queryAggregate.distinct)
                    @return = _cqlOperatorsBinder.BindToMethod(nameof(ICqlOperators.Distinct), [@return], [resultType]);
                var lambda = Expression.Lambda(lambdaBody, resultParameter, sourceParameter);

                return BindCqlOperator(nameof(ICqlOperators.Aggregate), @return, lambda, startingValue);
            }
        }
    }
}

#endregion

#region Type Operators

internal partial class ExpressionBuilderContext
{
    protected Expression As(As @as) //@ TODO: Cast - As
    {
        if (@as.operand is List list)
        {
            using (PushElement(list))
            {
                // create new ListType[0]; instead of new object[0] as IEnumerable<object> as IEnumerable<ListType>;
                if ((list.element?.Length ?? 0) == 0)
                {
                    var type = TypeFor(@as.asTypeSpecifier!)!;
                    if (_typeResolver.IsListType(type))
                    {
                        var listElementType = _typeResolver.GetListElementType(type) ??
                                              throw this.NewExpressionBuildingException(
                                                  $"{type} was expected to be a list type.");
                        var newArray = Expression.NewArrayBounds(listElementType, Expression.Constant(0));
                        var elmAs = new ElmAsExpression(newArray, type, @as.strict);
                        return elmAs;
                    }
                    else if (type == _typeResolver.AnyType) // handles untyped empty lists whose type is Any
                    {
                        var newArray = Expression.NewArrayBounds(_typeResolver.AnyType, Expression.Constant(0));
                        var elmAs = new ElmAsExpression(newArray, type, @as.strict);
                        return elmAs;
                    }

                    throw this.NewExpressionBuildingException(
                        "Cannot use as operator on a list if the as type is not also a list type.");
                }
            }
        }

        // asTypeSpecifier is an expression with its own resulttypespecifier that actually contains the real type
        if (@as.asTypeSpecifier != null)
        {
            using (PushElement(@as.asTypeSpecifier))
            {
                if (@as.operand is Null)
                {
                    var type = TypeFor(@as.asTypeSpecifier!)!;
                    var defaultExpression = Expression.Default(type);
                    return new ElmAsExpression(defaultExpression, type, @as.strict);
                }
                else
                {
                    var type = TypeFor(@as.asTypeSpecifier!)!;
                    var operand = TranslateArg(@as.operand!);
                    var converted = ChangeType(operand, type, out var typeConversion, considerSafeUpcast:true);
                    switch (typeConversion)
                    {
                        case TypeConversion.NoMatch:
                            // log an unsafe cast
                            _logger.LogWarning(
                                FormatMessage(
                                    $"{operand.Type.ToCSharpString(Defaults.TypeCSharpFormat)} as {type.ToCSharpString(Defaults.TypeCSharpFormat)} will always result in null.",
                                    @as.operand));
                            return Expression.Default(type);

                        case TypeConversion.OperatorConvert:
                            return converted;

                        case TypeConversion.ExpressionTypeAs:
                        default:
                            return new ElmAsExpression(operand, type, @as.strict);
                    }
                }
            }
        }

        {
            if (string.IsNullOrWhiteSpace(@as.asType.Name))
                throw this.NewExpressionBuildingException("The 'as' operator has no type name.");

            if (@as.operand is null)
                throw this.NewExpressionBuildingException("Operand cannot be null");

            var type = _typeResolver.ResolveType(@as.asType.Name!)
                       ?? throw this.NewExpressionBuildingException($"Cannot resolve type {@as.asType.Name}");

            var operand = TranslateArg(@as.operand);
            if (!type.IsAssignableTo(operand.Type))
            {
                _logger.LogWarning(FormatMessage(
                                       $"Potentially unsafe cast from {operand.Type.ToCSharpString(Defaults.TypeCSharpFormat)} to type {type.ToCSharpString(Defaults.TypeCSharpFormat)}",
                                       @as.operand));
            }

            return new ElmAsExpression(operand, type, @as.strict);
        }
    }

    protected Expression Is(Is @is) // @TODO: Cast - Is
    {
        var op = TranslateArg(@is.operand!);
        Type? type = null;
        if (@is.isTypeSpecifier != null)
        {
            if (@is.isTypeSpecifier is ChoiceTypeSpecifier choice)
            {
                var firstChoiceType = TypeFor(choice.choice[0], false) ??
                                      throw this.NewExpressionBuildingException("Could not resolve type for Is expression");

                Expression result = op.NewTypeIsExpression(firstChoiceType);
                for (int i = 1; i < choice.choice.Length; i++)
                {
                    var cti = TypeFor(choice.choice[i], false) ??
                              throw this.NewExpressionBuildingException("Could not resolve type for Is expression");

                    var ie = op.NewTypeIsExpression(cti);
                    result = Expression.Or(result, ie);
                }

                var ta = result.NewTypeAsExpression<bool?>();
                return ta;
            }

            type = TypeFor(@is.isTypeSpecifier, false) ??
                   throw this.NewExpressionBuildingException($"Could not resolve type for Is expression");
        }
        else if (!string.IsNullOrWhiteSpace(@is.isType?.Name))
        {
            type = _typeResolver.ResolveType(@is.isType.Name) ??
                   throw this.NewExpressionBuildingException($"Could not resolve type {@is.isType.Name}");
        }

        if (type == null)
            throw this.NewExpressionBuildingException(
                $"Could not identify Is type specifer via {nameof(@is.isTypeSpecifier)} or {nameof(@is.isType)}.");

        var isExpression = op.NewTypeIsExpression(type);
        var nullable = isExpression.NewTypeAsExpression<bool?>();
        return nullable;
    }
}

#endregion

#region ChangeType

internal partial class ExpressionBuilderContext
{
    private Expression ChangeType(
        Expression expr,
        TypeSpecifier? typeSpecifier,
        out TypeConversion typeConversion,
        bool considerSafeUpcast = false) // @TODO: Cast - ChangeType
    {
        if (typeSpecifier is not null)
        {
            if (TypeFor(typeSpecifier, false) is { } resultType)
            {
                if (resultType != expr.Type)
                {
                    var typeAs = ChangeType(expr, resultType, out typeConversion, considerSafeUpcast);
                    return typeAs;
                }
            }
            else
            {
                typeConversion = TypeConversion.NoMatch;
                return expr;
            }
        }

        typeConversion = TypeConversion.ExactType;
        return expr;
    }


    private Expression ChangeType(
        Element element,
        Type outputType,
        bool considerSafeUpcast = false)
        => ChangeType(
            TranslateArg(element),
            outputType,
            out TypeConversion typeConversion,
            considerSafeUpcast); // @TODO: Cast - ChangeType

    private Expression ChangeType(
        Expression input,
        Type outputType,
        out TypeConversion typeConversion,
        bool considerSafeUpcast = false) // @TODO: Cast - ChangeType
    {
        var (expression, tc) = input.TryNewAssignToTypeExpression(outputType, false, considerSafeUpcast);
        if (tc != TypeConversion.NoMatch)
        {
            typeConversion = tc;
            return expression!;
        }

        // tuples are not convertible.
        if (input.Type.IsAssignableTo(typeof(TupleBaseType)) || outputType.IsAssignableTo(typeof(TupleBaseType)))
        {
            // unless they're the same type.
            typeConversion = input.Type == outputType ? TypeConversion.ExactType : TypeConversion.NoMatch;
            return input;
        }

        if (_typeResolver.IsListType(input.Type)
            && _typeResolver.IsListType(outputType))
        {
            var inputElementType = _typeResolver.GetListElementType(input.Type, true)!;
            var outputElementType = _typeResolver.GetListElementType(outputType, true)!;
            var lambdaParameter = Expression.Parameter(inputElementType, TypeNameToIdentifier(inputElementType, this));
            var lambdaBody = ChangeType(lambdaParameter, outputElementType, out typeConversion);
            if (typeConversion != TypeConversion.NoMatch)
            {
                var lambda = Expression.Lambda(lambdaBody, lambdaParameter);
                return BindCqlOperator(nameof(ICqlOperators.Select), input, lambda);
            }

            typeConversion = TypeConversion.NoMatch;
            return input;
        }

        Type toType = TryCorrectQiCoreBindingError(input.Type, outputType, out var correctedTo)
                          ? correctedTo!
                          : outputType;
        _cqlOperatorsBinder.TryConvert(input, toType, out (Expression arg, TypeConversion conversion) tryConvert);
        typeConversion = tryConvert.conversion;
        return tryConvert.arg;
    }

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