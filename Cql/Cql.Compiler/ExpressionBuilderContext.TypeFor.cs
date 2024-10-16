/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Elm;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;
using Hl7.Fhir.Model;
using Element = Hl7.Cql.Elm.Element;

namespace Hl7.Cql.Compiler;

partial class ExpressionBuilderContext
{
    private Type? TypeFor(
        Element element,
        bool throwIfNotFound = true)
    {
        if (element?.resultTypeSpecifier != null)
            return TypeFor(element.resultTypeSpecifier);

        if (!string.IsNullOrWhiteSpace(element?.resultTypeName?.Name))
            return _typeResolver.ResolveType(element!.resultTypeName!.Name, throwIfNotFound);

        switch (element)
        {
            case ExpressionRef expressionRef:
            {
                var libraryName = expressionRef.libraryName ?? _libraryContext.LibraryVersionedIdentifier;
                if (!_libraryContext.LibraryDefinitions.TryGetValue(libraryName, expressionRef.name, out var definition))
                {
                    if (throwIfNotFound)
                        throw new InvalidOperationException($"Unabled to get an expression by name : '{libraryName}.{expressionRef.name}'");
                    return null;
                }

                var returnType = definition!.ReturnType;

                return returnType;
            }

            case ExpressionDef { expression: not null } def:
            {
                using (PushElement(def.expression))
                {
                    var type = TypeFor(def.expression, throwIfNotFound: false);
                    if (type == null)
                    {
                        if (def.expression is SingletonFrom singleton)
                        {
                            type = TypeFor(singleton, throwIfNotFound: false);
                            if (type == null)
                            {
                                if (singleton.operand is Retrieve retrieve && retrieve.dataType != null)
                                {
                                    type = _typeResolver.ResolveType(retrieve.dataType.Name, throwIfNotFound);
                                    if (type != null)
                                        return type;
                                }
                            }
                            else return type;
                        }
                    }
                }
                break;
            }

            case Property propertyExpression when !string.IsNullOrWhiteSpace(propertyExpression.path):
            {
                Type? sourceType = null;
                if (propertyExpression.source != null)
                    sourceType = TypeFor(propertyExpression.source!, throwIfNotFound);
                else if (propertyExpression.scope != null)
                {
                    var scope = GetScope(propertyExpression.scope);
                    sourceType = scope.Item1.Type;
                }
                if (sourceType != null)
                {
                    // This is a temporary fix for the issue where the type of the Extension.url in the Firely
                    // model is different from the type of the url in the CQL model. Since GetProperty() cannot
                    // properly correct for this, we'll return the "correct" type here, so that in the end
                    // a cast from string->FhirString is generated and the code compiles.
                    // Task https://github.com/FirelyTeam/firely-cql-sdk/issues/493 will clean this up.
                    if(sourceType == typeof(Extension) && propertyExpression.path == "url")
                        return typeof(FhirString);

                    var property = _typeResolver.GetProperty(sourceType, propertyExpression.path);

                    // This is a temporary fix for the issue where the type the Firely SDK uses for a choice
                    // property is `DataType`, whereas the type the CQL model uses is `object`.
                    // Since GetProperty() cannot properly correct for this, we'll correct the type to `object` here.
                    // Task https://github.com/FirelyTeam/firely-cql-sdk/issues/493 will clean this up.
                    if (property != null)
                        return property.PropertyType == typeof(DataType) ? typeof(object) : property.PropertyType;

                    return typeof(object); // this is likely a choice
                }
                break;
            }

            case AliasRef aliasRef when !string.IsNullOrWhiteSpace(aliasRef.name):
            {
                var scope = GetScope(aliasRef.name);
                return scope.Item1.Type;
            }

            case OperandRef operandRef when !string.IsNullOrWhiteSpace(operandRef.name):
            {
                ParameterExpression? operand = null;
                _operands?.TryGetValue(operandRef.name, out operand);
                if (operand != null)
                    return operand.Type;
                break;
            }
        }

        if (throwIfNotFound)
            throw this.NewExpressionBuildingException("Cannot resolve type for expression");

        return null;
    }

    private Type? TypeFor(
        TypeSpecifier? resultTypeSpecifier,
        bool throwIfNotFound = true)
    {
        if (resultTypeSpecifier == null)
            return typeof(object);

        if (resultTypeSpecifier is IntervalTypeSpecifier interval)
        {
            var pointType = TypeFor(interval.pointType!, false);
            if (pointType == null)
            {
                if (throwIfNotFound)
                    throw new ArgumentException("Cannot resolve type for expression");

                return null;
            }

            var intervalType = typeof(CqlInterval<>).MakeGenericType(pointType);
            return intervalType;
        }

        if (resultTypeSpecifier is NamedTypeSpecifier named)
        {
            var type = _typeResolver.ResolveType(named.name.Name!, false);
            if (type == null && throwIfNotFound)
                throw new ArgumentException("Cannot resolve type for expression");
            return type!;
        }

        if (resultTypeSpecifier is ChoiceTypeSpecifier cts)
        {
            var distinctChoices = cts.choice.Distinct().ToList();
            var typeSpecifierToType = distinctChoices
                .Select(ts => (ts, type: TypeFor(ts, throwIfNotFound)));
            var typeSpecifiersByTypes = typeSpecifierToType
                                        .GroupBy(t => t.type)
                                        .OrderBy(t => t.Key?.AssemblyQualifiedName)
                                        .ToList();
            if (typeSpecifiersByTypes.FirstOrDefault(group => group.Key is null) is {} nullTypeGrouping)
            {
                if (throwIfNotFound)
                    throw new ArgumentException($"ChoiceTypeSpecifier contained TypeSpecifiers for which no .NET type was found: [{string.Join(", ", nullTypeGrouping.Select(g => g.ts))}]");
                return null;
            }

            var choiceType = CqlChoiceType.MakeChoiceType(typeSpecifiersByTypes.SelectToArray(g => g.Key!));
            return choiceType;
        }

        if (resultTypeSpecifier is ListTypeSpecifier list)
        {
            if (list.elementType == null)
            {
                if (throwIfNotFound)
                    throw new ArgumentException("ListTypeSpecifier must have a non-null elementType");

                return null;
            }

            var elementType = TypeFor(list.elementType, throwIfNotFound);
            if (elementType == null)
            {
                if (throwIfNotFound)
                    throw new ArgumentException("Cannot resolve type for expression");

                return null;
            }

            var enumerableOfElementType = typeof(IEnumerable<>).MakeGenericType(elementType);
            return enumerableOfElementType;
        }

        if (resultTypeSpecifier is TupleTypeSpecifier tuple)
        {
            // witnessed in ELM:
            //"type" : "TupleTypeSpecifier",
            //"resultTypeSpecifier" : {
            //      "type" : "TupleTypeSpecifier",
            //      "element": { ... x ... }
            // },
            // "element": { ... y ... }
            //
            // In the example above, x and y have different structures.
            // Code handles x but not y
            if (resultTypeSpecifier.resultTypeSpecifier != null)
                return TypeFor(tuple.resultTypeSpecifier, throwIfNotFound);

            return TupleTypeFor(tuple);
        }

        if (throwIfNotFound)
            throw new NotImplementedException().WithContext(this);

        return null;
    }

    private Type TupleTypeFor(TupleTypeSpecifier tuple, Func<Type, Type>? changeType = null)
    {
        var elements = tuple.element;

        if (elements?.Length == 0)
            return typeof(object);

        var elementTuples = elements!.SelectToArray(e => (e.name, e.elementType));
        return TupleTypeFor(elementTuples, changeType);
    }

    private Type TupleTypeFor(Elm.Tuple tuple, Func<Type, Type>? changeType = null)
    {
        var elements = tuple.element;

        if (elements?.Length == 0)
            return typeof(object);

        var elementTuples = elements!
            .SelectToArray(e => (e.name, e.value.resultTypeSpecifier ?? throw new InvalidOperationException($"Tuple element value does not have a resultTypeSpecifier")));
        return TupleTypeFor(elementTuples, changeType);
    }

    private Type TupleTypeFor((string name, TypeSpecifier elementType)[] elements, Func<Type, Type>? changeType)
    {
        Dictionary<string, Type> elementInfo = elements!
            .ToDictionary(
                el => el.name,
                el =>
                {
                    if (el.elementType == null)
                        throw this.NewExpressionBuildingException(
                            $"Tuple element {el.name} has a null {nameof(el.elementType)} property.  This property is required.");

                    var type = TypeFor(el.elementType)!;
                    if (changeType != null)
                        type = changeType(type);

                    return type;
                });

        return _tupleBuilderCache.CreateOrGetTupleTypeFor(elementInfo);
    }
}

internal class CqlChoiceType
{
    public object? Value { get; init; }
    public static Type MakeChoiceType(Type[] choiceTypes) =>
        choiceTypes.Length switch
        {
            // This could be better distributed, but it's not worth the effort
            0 => throw new ArgumentException("At least one choice type must be provided.", nameof(choiceTypes)),
            1 => typeof(CqlChoiceType<>).MakeGenericType(choiceTypes),
            2 => typeof(CqlChoiceType<,>).MakeGenericType(choiceTypes),
            3 => typeof(CqlChoiceType<,,>).MakeGenericType(choiceTypes),
            4 => typeof(CqlChoiceType<,,,>).MakeGenericType(choiceTypes),
            5 => typeof(CqlChoiceType<,,,,>).MakeGenericType(choiceTypes),
            6 => typeof(CqlChoiceType<,,,,,>).MakeGenericType(choiceTypes),
            7 => typeof(CqlChoiceType<,,,,,,>).MakeGenericType(choiceTypes),
            8 => typeof(CqlChoiceType<,,,,,,,>).MakeGenericType(choiceTypes),
            _ => typeof(CqlChoiceType<,,,,,,,>).MakeGenericType([..choiceTypes[0..7], MakeChoiceType(choiceTypes[8..])])
        };
}

internal class CqlChoiceType<T1> : CqlChoiceType { }
internal class CqlChoiceType<T1, T2> : CqlChoiceType<T1> { }
internal class CqlChoiceType<T1, T2, T3> : CqlChoiceType<T1, T2> { }
internal class CqlChoiceType<T1, T2, T3, T4> : CqlChoiceType<T1, T2, T3> { }
internal class CqlChoiceType<T1, T2, T3, T4, T5> : CqlChoiceType<T1, T2, T3, T4> { }
internal class CqlChoiceType<T1, T2, T3, T4, T5, T6> : CqlChoiceType<T1, T2, T3, T4, T5> { }
internal class CqlChoiceType<T1, T2, T3, T4, T5, T6, T7> : CqlChoiceType<T1, T2, T3, T4, T5, T6> { }
internal class CqlChoiceType<T1, T2, T3, T4, T5, T6, T7, T8> : CqlChoiceType<T1, T2, T3, T4, T5, T6, T7> { }