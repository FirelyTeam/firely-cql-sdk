/*
 * Copyright (c) 2024, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Elm;
using Hl7.Cql.Primitives;
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
                if (!_libraryContext.LibraryDefinitions.TryGetDefinition(libraryName, expressionRef.name, out var definition))
                {
                    if (throwIfNotFound)
                        throw new InvalidOperationException($"Unabled to get an expression by name : '{libraryName}.{expressionRef.name}'");
                    return null;
                }

                var returnType = definition.ReturnType;
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

        if (resultTypeSpecifier is ChoiceTypeSpecifier)
        {
            return typeof(object);
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
            .SelectToArray(e => (e.name, GetTupleElementTypeSpecifier(e)));
        return TupleTypeFor(elementTuples, changeType);
    }

    private TypeSpecifier GetTupleElementTypeSpecifier(TupleElement element)
    {
        // If we already have a resultTypeSpecifier, use it
        if (element.value.resultTypeSpecifier != null)
            return element.value.resultTypeSpecifier;

        // If we have a resultTypeName, create a NamedTypeSpecifier from it
        if (element.value.resultTypeName != null)
            return new NamedTypeSpecifier { name = element.value.resultTypeName };

        // Try to infer the type from the element value
        var inferredType = TypeFor(element.value, throwIfNotFound: false);
        if (inferredType != null)
        {
            // Convert the inferred Type back to a TypeSpecifier
            return CreateTypeSpecifierFromType(inferredType);
        }

        throw new InvalidOperationException($"Tuple element '{element.name}' value does not have a resultTypeSpecifier and type could not be inferred").WithContext(this);
    }

    private TypeSpecifier CreateTypeSpecifierFromType(Type type)
    {
        // Handle nullable types by unwrapping them
        var actualType = Nullable.GetUnderlyingType(type) ?? type;

        // Handle CQL primitive types
        if (actualType == _typeResolver.StringType)
            return new NamedTypeSpecifier { name = new System.Xml.XmlQualifiedName("String", "urn:hl7-org:elm-types:r1") };
        if (actualType == _typeResolver.IntegerType)
            return new NamedTypeSpecifier { name = new System.Xml.XmlQualifiedName("Integer", "urn:hl7-org:elm-types:r1") };
        if (actualType == _typeResolver.DecimalType)
            return new NamedTypeSpecifier { name = new System.Xml.XmlQualifiedName("Decimal", "urn:hl7-org:elm-types:r1") };  
        if (actualType == _typeResolver.BooleanType)
            return new NamedTypeSpecifier { name = new System.Xml.XmlQualifiedName("Boolean", "urn:hl7-org:elm-types:r1") };
        if (actualType == _typeResolver.DateTimeType)
            return new NamedTypeSpecifier { name = new System.Xml.XmlQualifiedName("DateTime", "urn:hl7-org:elm-types:r1") };
        if (actualType == _typeResolver.DateType)
            return new NamedTypeSpecifier { name = new System.Xml.XmlQualifiedName("Date", "urn:hl7-org:elm-types:r1") };
        if (actualType == _typeResolver.TimeType)
            return new NamedTypeSpecifier { name = new System.Xml.XmlQualifiedName("Time", "urn:hl7-org:elm-types:r1") };
        if (actualType == _typeResolver.QuantityType)
            return new NamedTypeSpecifier { name = new System.Xml.XmlQualifiedName("Quantity", "urn:hl7-org:elm-types:r1") };
        if (actualType == _typeResolver.CodeType)
            return new NamedTypeSpecifier { name = new System.Xml.XmlQualifiedName("Code", "urn:hl7-org:elm-types:r1") };
        if (actualType == _typeResolver.ConceptType)
            return new NamedTypeSpecifier { name = new System.Xml.XmlQualifiedName("Concept", "urn:hl7-org:elm-types:r1") };
        if (actualType == _typeResolver.ValueSetType)
            return new NamedTypeSpecifier { name = new System.Xml.XmlQualifiedName("ValueSet", "urn:hl7-org:elm-types:r1") };

        // Handle generic IEnumerable<T> (lists)
        if (_typeResolver.IsListType(actualType))
        {
            var elementType = _typeResolver.GetListElementType(actualType, throwError: false);
            if (elementType != null)
                return new ListTypeSpecifier { elementType = CreateTypeSpecifierFromType(elementType) };
        }

        // Handle CqlInterval<T>
        if (actualType.IsGenericType && actualType.GetGenericTypeDefinition() == _typeResolver.IntervalType(typeof(object)).GetGenericTypeDefinition())
        {
            var pointType = actualType.GetGenericArguments()[0];
            return new IntervalTypeSpecifier { pointType = CreateTypeSpecifierFromType(pointType) };
        }

        // For FHIR types and other model types, try to find a matching type name
        // by checking if this type can be resolved by the type resolver
        foreach (var ns in _typeResolver.ModelNamespaces)
        {
            var typeName = actualType.Name;
            var fullTypeName = $"{{{ns}}}{typeName}";
            var resolvedType = _typeResolver.ResolveType(fullTypeName, throwError: false);
            if (resolvedType == actualType)
            {
                return new NamedTypeSpecifier { name = new System.Xml.XmlQualifiedName(typeName, ns) };
            }
        }

        // Fallback to Any type
        return new NamedTypeSpecifier { name = new System.Xml.XmlQualifiedName("Any", "urn:hl7-org:elm-types:r1") };
    }

    private Type TupleTypeFor((string name, TypeSpecifier elementType)[] elements, Func<Type, Type>? changeType)
    {
        var tupleFields = elements!
            .Select(el =>
            {
                if (el.elementType == null)
                    throw this.NewExpressionBuildingException(
                        $"Tuple element {el.name} has a null {nameof(el.elementType)} property.  This property is required.");

                var type = TypeFor(el.elementType)!;
                if (changeType != null)
                    type = changeType(type);

                return (type, el.name);
            })
            .ToList();

        return _tupleBuilderCache.CreateOrGetTupleTypeFor(tupleFields);
    }
}