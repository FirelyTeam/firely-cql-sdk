using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Hl7.Cql.Elm;
using Hl7.Cql.Primitives;

namespace Hl7.Cql.Compiler;

internal partial class ExpressionBuilder
{
    private Type? TypeFor(
        Element element,
        bool throwIfNotFound = true)
    {
        if (element?.resultTypeSpecifier != null)
            return TypeFor(element.resultTypeSpecifier);

        if (!string.IsNullOrWhiteSpace(element?.resultTypeName?.Name))
            return _typeManager.Resolver.ResolveType(element!.resultTypeName!.Name)
                   ?? throw this.NewExpressionBuildingException("Cannot resolve type for expression");

        switch (element)
        {
            case ExpressionRef expressionRef:
            {
                var libraryName = expressionRef.libraryName ?? LibraryContext.LibraryKey;
                if (!LibraryContext.LibraryDefinitions.TryGetValue(libraryName, expressionRef.name, out var definition))
                    throw new InvalidOperationException($"Unabled to get an expression by name : '{libraryName}.{expressionRef.name}'");

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
                                    type = _typeManager.Resolver.ResolveType(retrieve.dataType.Name);
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
                    var property = _typeManager.Resolver.GetProperty(sourceType, propertyExpression.path);
                    if (property != null)
                        return property.PropertyType;
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
                Operands.TryGetValue(operandRef.name, out var operand);
                if (operand != null)
                    return operand.Type;
                break;
            }
        }
        if (throwIfNotFound)
            throw this.NewExpressionBuildingException("Cannot resolve type for expression");

        return null;
    }

    private Type TypeFor(TypeSpecifier? resultTypeSpecifier)
    {
        if (resultTypeSpecifier == null)
            return typeof(object);

        if (resultTypeSpecifier is IntervalTypeSpecifier interval)
        {
            var pointType = TypeFor(interval.pointType!);
            var intervalType = typeof(CqlInterval<>).MakeGenericType(pointType);
            return intervalType;
        }

        if (resultTypeSpecifier is NamedTypeSpecifier named)
        {
            var type = _typeManager.Resolver.ResolveType(named.name.Name!);
            if (type == null)
                throw new ArgumentException("Cannot resolve type for expression");
            return type!;
        }

        if (resultTypeSpecifier is ChoiceTypeSpecifier)
        {
            return typeof(object);
        }

        if (resultTypeSpecifier is ListTypeSpecifier list)
        {
            if (list.elementType == null)
                throw new ArgumentException("ListTypeSpecifier must have a non-null elementType");
            var elementType = TypeFor(list.elementType);
            if (elementType == null)
                throw new ArgumentException("Cannot resolve type for expression");

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
                return TypeFor(tuple.resultTypeSpecifier);

            return TupleTypeFor(tuple);
        }

        throw new NotImplementedException().WithContext(this);
    }

    private Type TupleTypeFor(TupleTypeSpecifier tuple, Func<Type, Type>? changeType = null)
    {
        var elements = tuple.element;

        if (elements?.Length == 0)
            return typeof(object);

        var elementTuples = elements!
            .Select(e => (e.name, e.elementType))
            .ToArray();
        return TupleTypeFor(elementTuples, changeType);
    }

    private Type TupleTypeFor(Elm.Tuple tuple, Func<Type, Type>? changeType = null)
    {
        var elements = tuple.element;

        if (elements?.Length == 0)
            return typeof(object);

        var elementTuples = elements!
            .Select(e => (e.name, e.value.resultTypeSpecifier ?? throw new InvalidOperationException($"Tuple element value does not have a resultTypeSpecifier")))
            .ToArray();
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

                    var type = TypeFor(el.elementType);
                    if (changeType != null)
                        type = changeType(type);

                    return type;
                });

        return TupleTypeFor(elementInfo);
    }

    private Type TupleTypeFor(IReadOnlyDictionary<string, Type> elementInfo)
    {
        var normalizedProperties = elementInfo
            .SelectToArray(kvp =>
            {
                var propName = NormalizeIdentifier(kvp.Key);
                var propType = kvp.Value;
                return (propName, propType);
            });

        var matchedTupleType = _typeManager.TupleTypes
            .FirstOrDefault(tupleType =>
            {
                var isMatch = normalizedProperties
                    .All(prop =>
                        tupleType.GetProperty(prop.propName) is { PropertyType: { } tuplePropertyType }
                        && tuplePropertyType == prop.propType);
                return isMatch;
            });
        if (matchedTupleType != null)
            return matchedTupleType;

        var typeName = $"{_typeManager.TupleTypeNamespace}.{_typeManager.TupleTypeNameFor(elementInfo)}";

        var myTypeBuilder = _typeManager.ModuleBuilder.DefineType(typeName, TypeAttributes.Public | TypeAttributes.Class, typeof(TupleBaseType));

        foreach (var kvp in elementInfo)
        {
            if (kvp.Key != null)
            {
                var name = NormalizeIdentifier(kvp.Key);
                var type = kvp.Value;
                TypeManager.DefineProperty(myTypeBuilder, name!, kvp.Key, type);
            }
        }
        var typeInfo = myTypeBuilder.CreateTypeInfo();
        _typeManager.AddTupleType(typeInfo!); // TODO: PDB - This is changing external state. Should become internal instead
        return typeInfo!;
    }
}