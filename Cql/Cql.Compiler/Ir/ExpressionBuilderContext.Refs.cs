/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Elm;
using Hl7.Cql.Model;
using Hl7.Cql.Operators;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.Compiler.Ir;

using ChoiceTypeSpecifier = Hl7.Cql.Elm.ChoiceTypeSpecifier;
using ListTypeSpecifier = Hl7.Cql.Elm.ListTypeSpecifier;
using NamedTypeSpecifier = Hl7.Cql.Elm.NamedTypeSpecifier;
using TypeSpecifier = Hl7.Cql.Elm.TypeSpecifier;

/// <summary>
/// IR counterpart of the reference regions of <c>ExpressionBuilderContext.cs</c>: references
/// to other definitions (expressions, functions, parameters, codes, code systems, concepts,
/// value sets), retrieves, and the runtime-context invocation helpers. Mechanical port of the
/// old per-node methods; see the remarks on <see cref="ExpressionBuilderContext"/>.
/// </summary>
partial class ExpressionBuilderContext
{
    protected IrExpression FunctionRef(FunctionRef op)
    {
        IrExpression[] operands = TranslateArgs(op.operand);

        // NOTE: Breaks
        //var resultType = op.resultTypeSpecifier ?? op.resultTypeName?.ToNamedType() ??
        //                 throw new InvalidOperationException($"FunctionRef {op.libraryName + "." + op.name} has no result type specifier or result type name.");
        //var invoke = InvokeDefinedFunctionThroughRuntimeContext(op.name!, op.libraryName!, operands, resultType);

        //var invoke = InvokeDefinitionThroughRuntimeContext(op.name!, op.libraryName!, op.signature, operands, op.resultTypeSpecifier);
        var invoke = InvokeDefinedFunctionThroughRuntimeContext(op.name!, op.libraryName!, op.signature, operands, op.resultTypeSpecifier);
        return invoke;
    }

    protected IrExpression ExpressionRef(ExpressionRef expressionRef)
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

    protected IrExpression ParameterRef(ParameterRef op)
    {
        if (_libraryContext.LibraryDefinitions.TryGetDefinition(_libraryContext.LibraryVersionedIdentifier, op.name!, out var definition))
        {
            var invoke = InvokeDefinitionThroughRuntimeContext(op.name!, null, definition);
            return invoke;
        }

        throw this.NewExpressionBuildingException($"Parameter {op.name} hasn't been defined yet.");
    }

    protected IrExpression CodeRef(CodeRef codeRef)
    {
        if (string.IsNullOrWhiteSpace(codeRef.name))
            throw this.NewExpressionBuildingException("The code ref has no name.");

        var type = _typeResolver.ResolveType(codeRef.resultTypeName.Name) ??
                   throw this.NewExpressionBuildingException($"Unable to resolve type {codeRef.resultTypeName}");
        var definitionCallExpression = InvokeDefinitionThroughRuntimeContext(codeRef.name, codeRef.libraryName, type);
        return definitionCallExpression;
    }

    private IrExpression CodeSystemRef(CodeSystemRef codeSystemRef)
    {
        if (string.IsNullOrWhiteSpace(codeSystemRef.name))
            throw this.NewExpressionBuildingException("The code system ref has no name.");

        var type = _typeResolver.CodeType.MakeArrayType();
        var definitionCallExpression = InvokeDefinitionThroughRuntimeContext(codeSystemRef.name, codeSystemRef.libraryName, type);
        return definitionCallExpression;
    }

    protected IrExpression ConceptRef(ConceptRef conceptRef)
    {
        if (string.IsNullOrWhiteSpace(conceptRef.name))
            throw this.NewExpressionBuildingException("The concept ref has no name.");

        var conceptType = TypeFor(conceptRef)!;
        return InvokeDefinitionThroughRuntimeContext(conceptRef.name, conceptRef.libraryName, conceptType);
    }

    protected IrExpression ValueSetRef(ValueSetRef valueSetRef)
    {
        if (string.IsNullOrWhiteSpace(valueSetRef.name))
            throw this.NewExpressionBuildingException($"The ValueSetRef at {valueSetRef.locator} is missing a name.");

        var cqlValueSet = InvokeDefinitionThroughRuntimeContext(valueSetRef.name, valueSetRef.libraryName, typeof(CqlValueSet));
        return cqlValueSet;
    }

    private IrExpression Retrieve(Retrieve retrieve)
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

        IrExpression? codeProperty;

        var hasCodePropertySpecified = sourceElementType != null && retrieve.codeProperty != null;
        var isDefaultCodeProperty = retrieve.codeProperty is null ||
                                    (cqlRetrieveResultType is not null &&
                                     ModelMapping.TryGetValue(cqlRetrieveResultType, out ClassInfo? classInfo) &&
                                     classInfo.primaryCodePath == retrieve.codeProperty);

        if (hasCodePropertySpecified && !isDefaultCodeProperty)
        {
            var codePropertyInfo = _typeResolver.GetProperty(sourceElementType!, retrieve.codeProperty!);
            codeProperty = new IrConstant(codePropertyInfo, typeof(PropertyInfo));
        }
        else
        {
            codeProperty = new IrConstant(null, typeof(PropertyInfo));
        }

        var templateId = TranslateArg(retrieve.templateId);
        var sourceElementTypeExpr = new IrConstant(sourceElementType, typeof(Type));
        IrExpression values = new IrConstant(null, typeof(CqlValueSet));

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

    private IrExpression BindValueInValueSet(
        IrExpression valueExpr,
        IrExpression valueSetExpr,
        bool isList)
    {
        var codeType = isList ? _typeResolver.GetListElementType(valueExpr.Type, throwError: true)! : valueExpr.Type;

        if (codeType == _typeResolver.CodeType)
            return BindCqlOperator(isList ? nameof(ICqlOperators.CodesInValueSet) : nameof(ICqlOperators.CodeInValueSet), valueExpr, valueSetExpr);

        if (codeType == _typeResolver.ConceptType)
            return BindCqlOperator(isList ? nameof(ICqlOperators.ConceptsInValueSet) : nameof(ICqlOperators.ConceptInValueSet), valueExpr, valueSetExpr);

        if (codeType == typeof(string))
            return BindCqlOperator(isList ? nameof(ICqlOperators.StringsInValueSet) : nameof(ICqlOperators.StringInValueSet), valueExpr, valueSetExpr);

        throw new NotImplementedException().WithContext(this);
    }

    private IrExpression TranslateValueSet(ValueSetRef valueSetRef, Elm.Expression valueSetExpression)
    {
        var valueSet =
            (valueSetRef, valueSetExpression) switch
            {
                // If valueSetExpression is not null, use it (even if valueSetRef also exists)
                (_, { } e) => TranslateElement(e),
                // If only valueSetRef is not null
                ({ } r, null) => InvokeDefinitionThroughRuntimeContext(r.name!, r.libraryName, typeof(CqlValueSet)),
                _             => throw this.NewExpressionBuildingException("Expected either a ValueSetRef or a ValueSetExpression")
            };
        return valueSet;
    }

    /// <param name="name">The function name</param>
    /// <param name="libraryAlias">If this is an external call, the local alias defined in the using statement</param>
    /// <param name="signature">The signature as specified in the function call.</param>
    /// <param name="arguments">The function arguments</param>
    /// <param name="returnType">The function's return type</param>
    /// <returns></returns>
    protected IrExpression InvokeDefinedFunctionThroughRuntimeContext(
        string name,
        string? libraryAlias,
        TypeSpecifier[]? signature,
        IrExpression[] arguments,
        TypeSpecifier returnType)
    {
        string libraryName = _libraryContext.GetLibraryVersionedIdentifierFromAlias(libraryAlias, throwError: false)
                             ?? throw this.NewExpressionBuildingException($"Local library {libraryAlias} is not defined; are you missing a using statement?");

        var rtt = TypeFor(returnType) ?? throw this.NewExpressionBuildingException($"Unable to resolve type for {returnType}");
        var convertedArguments = arguments
                                 .Select((a, i) => ConvertArgumentTargetType(a, signature?[i], i))
                                 .Prepend(IrContextParameter.Instance)
                                 .ToArray();

        // NOTE(phase4): the old builder built a Func<> delegate type here (prepending CqlContext to
        // the argument types and appending rtt) purely to construct FunctionCallExpression, which
        // needed it to reduce to a runtime DefinitionDictionary<Delegate> lookup. IrDefinitionCall
        // takes the return type directly and needs no delegate type.
        var (splitLibraryName, splitLibraryVersion) = SplitLibraryVersionedIdentifier(libraryName);
        var isLocalLibrary = libraryName == _libraryContext.LibraryVersionedIdentifier;
        var functionCallExpression = new IrDefinitionCall(splitLibraryName, splitLibraryVersion, name, isLocalLibrary, convertedArguments, rtt);
        return functionCallExpression;

        IrExpression ConvertArgumentTargetType(
            IrExpression argument,
            TypeSpecifier? targetTypeSpecifier,
            int argumentIndex)
        {
            /*
                This function will handle the cases where the normal C# invocation is insufficient to represent the CQL function call:
                the argument is of a choice type, and the parameter is of a specific type (or for now, also a choice type).
                In this case we need to insert a conversion from the choice type to the specific type of the argument. Presumably, the
                cql2elm compiler has already checked that the call is valid, but we do need to cast the choice type (in C# represented by
                object/DataType) to the actual type to make this a valid C# call. CQL semantics state that the result may be null if the
                choice is not compatible with the parameter, so we'll use an As in C#.
            */
            if (argument.Type == typeof(object))
            {
                if (targetTypeSpecifier is not null and not ChoiceTypeSpecifier)
                {
                    var changeType = ChangeType(argument, targetTypeSpecifier, considerSafeUpcast: true);
                    return changeType;
                }
            }

            /*
               **Background**

               FHIRHelpers 4.0.1 removed this line `define function ToString(value FHIR.id): value.value`
                with the mistaken assumption that a FHIR Id inherits from FHIR String (from the diagram in 'FHIR Primitive Types'
                referenced below)

               **Solution**

               So, we have to convert a FHIR Id to a FHIR String at runtime, before passing it to
                FHIRHelpers.ToString(value FHIR.string) function.

               A conversion for this is added in FhirTypeConverter.AddSubtypeConversions.

               So, this convert method was added to ensure that the argument can be converted to the parameter type.

               This seems like overkill for just this one case. An alternative solution could be to preprocess the Library
                in LibraryPreprocessor.PreprocessLibrary, but since that is a non-FHIR specific class, it would require
                more work to open it up for FHIR-specific processing.

               **Note**

               This new convert method makes the convertChoice (commented out) obsolete. We will keep it there for now.

               **References**
               - FHIRHelpers 4.0.1:  https://github.com/cqframework/clinical_quality_language/blame/master/Src/java/quick/src/main/resources/org/hl7/fhir/FHIRHelpers-4.0.1.cql
               - FHIR Primitive Types:  https://hl7.org/fhir/datatypes.html#:~:text=Standards%20Status%20Colors-,Primitive%20Types,-PrimitiveType
             */

            var parameterType = TypeFor(targetTypeSpecifier, false);
            if (parameterType is null
                || !_cqlOperatorsBinder.TryConvert(argument, parameterType, out var result))
            {
                var fromArgumentType = argument.Type.ToCSharpString();
                var toParameterType = parameterType?.ToCSharpString() ?? targetTypeSpecifier?.ToString() ?? "Unknown";
                string message =
                        $"Unable to bind argument to function ref parameter, however, we will ignore it and proceed to generate the expression for it."
                        + $" From Argument Type: {fromArgumentType}"
                        + $", To Parameter Type: {toParameterType}"
                        + $", Library Alias: {libraryName}"
                        + $", Function Name: {name}"
                        + $", Parameter : #{argumentIndex}" // Signatures don't have named parameters
                    ;

                /*
                 * Instead of failing here, just go ahead and return the argument as-is. Another quirk is
                 *  that we have an argument of type FHIR Code to parameter FHIR String called on
                 *  FHIRHelpers-4.0.1.ToString(value). (There is no such conversion in the CQL, but,
                 *  in the ELM there are many methods added ToString(FHIR Code), but somehow the ELM call
                 *  to it has a signature of ToString(FHIR String), which doesn't exist here yet.
                 *
                 * So, instead of failing here, just generate the C#, and this specific case will resolve there.
                 *
                 */

                _logger.LogWarning(message);
                return argument;
            }

            return result.conversion switch
            {
                TypeConversion.ExpressionCast
                    or TypeConversion.ExpressionTypeAs => argument,
                _                                      => result.arg
            };
        }
    }

    /// <remarks>The old builder resolved <c>CqlDefinition.Type</c> (the <c>Func&lt;…&gt;</c> delegate
    /// type of the definition's <c>LambdaExpression</c>, always prefixed with <c>CqlContext</c>) for
    /// any <see cref="CqlDefinition"/>; only <see cref="CqlLambdaDefinition"/> exposes a comparable
    /// <see cref="CqlLambdaDefinition.Type"/> here (the old base <c>CqlDefinition</c> did not override
    /// <c>Expression.Type</c> either, so passing a non-lambda definition would have failed at
    /// runtime there too). In practice only <see cref="ParameterRef"/> calls this overload, and
    /// parameter references always resolve to an <see cref="CqlParameterDefinition"/>.</remarks>
    private IrExpression InvokeDefinitionThroughRuntimeContext(
        string name,
        string? libraryAlias,
        CqlDefinition definition)
    {
        if (definition is CqlLambdaDefinition { Type: { IsGenericType: true } type })
        {
            var typeArgs = type.GetGenericArguments();
            var returnType = typeArgs[^1];
            var invoke = InvokeDefinitionThroughRuntimeContext(name, libraryAlias, returnType);
            return invoke;
        }

        throw this.NewExpressionBuildingException("LambdaExpressions should be a variant of Func<>");
    }

    private IrDefinitionCall InvokeDefinitionThroughRuntimeContext(
        string name,
        string? libraryAlias,
        Type definitionReturnType)
    {
        string libraryName = _libraryContext.GetLibraryVersionedIdentifierFromAlias(libraryAlias, throwError: false)
                             ?? throw this.NewExpressionBuildingException($"Local library {libraryAlias} is not defined; are you missing a using statement?");
        var (splitLibraryName, splitLibraryVersion) = SplitLibraryVersionedIdentifier(libraryName);
        var isLocalLibrary = libraryName == _libraryContext.LibraryVersionedIdentifier;
        return new IrDefinitionCall(splitLibraryName, splitLibraryVersion, name, isLocalLibrary, [IrContextParameter.Instance], definitionReturnType);
    }

    /// <summary>
    /// Splits a <see cref="LibraryExpressionBuilderContext.LibraryVersionedIdentifier"/>-shaped
    /// string (e.g. <c>"FHIRHelpers-4.0.1"</c>) back into its name and version parts, for
    /// <see cref="IrDefinitionCall"/>, which (unlike the old <c>DefinitionCallExpression</c>/
    /// <c>FunctionCallExpression</c>, which only ever carried the combined key for a runtime
    /// dictionary lookup) needs the two separately to print either <c>this.…</c> or
    /// <c>LibraryClass.Instance.…</c>.
    /// </summary>
    private static (string libraryName, string libraryVersion) SplitLibraryVersionedIdentifier(string libraryVersionedIdentifier)
    {
        var parsed = CqlVersionedLibraryIdentifier.Parse(libraryVersionedIdentifier);
        string name = parsed.Identifier;
        string version = parsed.Version is { } v ? v : "";
        return (name, version);
    }
}
