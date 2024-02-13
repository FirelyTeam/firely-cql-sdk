using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.Elm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hl7.Cql.CqlToElm
{


    /// <summary>
    /// Builds the implicit casts described in the CQL spec. Given the type of the parameter and an expression 
    /// representing the argument at the call site, this class will the necessary chain of nested expressions
    /// to implement the implicit casts.
    /// 
    /// See https://cql.hl7.org/03-developersguide.html#conversion-precedence
    /// </summary>
    internal class InvocationBuilder
    {
        public IModelProvider Provider { get; }
        public TypeConverter TypeConverter { get; }

        public InvocationBuilder(IModelProvider provider, TypeConverter typeConverter)
        {
            Provider = provider;
            TypeConverter = typeConverter;
        }

        internal ConversionResult<Expression> Build(FunctionDef candidate, Expression[] arguments)
        {
            if (candidate is SystemFunction builtIn)
            {
                if (arguments.Length < (builtIn.RequiredParameterCount ?? builtIn.operand.Length))
                {
                    var resultExpression = candidate.CreateElmNode(arguments)
                        .WithResultType(candidate.resultTypeSpecifier);
                    return new ConversionResult<Expression>(resultExpression, ConversionCost.Incompatible,
                        $"{candidate.Signature()} must be called with at least {builtIn.RequiredParameterCount} arguments, not {arguments.Length}.");
                }
                else if (arguments.Length > builtIn.operand.Length)
                {
                    var resultExpression = candidate.CreateElmNode(arguments)
                        .WithResultType(candidate.resultTypeSpecifier);
                    return new ConversionResult<Expression>(resultExpression, ConversionCost.Incompatible,
                        $"{candidate.Signature()} must be called with no more than {builtIn.operand.Length} arguments, not {arguments.Length}.");
                }
            }
            else if (candidate.operand.Length != arguments.Length)
            {
                var resultExpression = candidate.CreateElmNode(arguments)
                    .WithResultType(candidate.resultTypeSpecifier);

                return new ConversionResult<Expression>(resultExpression, ConversionCost.Incompatible,
                    $"{candidate.Signature()} must be called with {candidate.operand.Length} arguments, not {arguments.Length}.");
            }

            var operands = candidate.operand.Select(o => o.operandTypeSpecifier).ToArray();
            var positionResults = new List<ConversionResult<Expression>>();
            int? nextPosition = 0;

            while (nextPosition is not null)
            {
                var start = nextPosition.Value;
                nextPosition = null;
                var iterationResults = new ConversionResult<Expression>[arguments.Length];
                var assignments = new GenericParameterAssignments();
                string? firstError = null;

                for (var iteration = 0; iteration < arguments.Length; iteration++)
                {
                    var argumentIndex = (start + iteration) % arguments.Length;
                    var operand = operands[argumentIndex];
                    var argument = arguments[argumentIndex];

                    // Now, try to implicitly cast the argument to the parameter type.
                    var operandToTest = operand.ReplaceGenericParameters(assignments);
                    if (operandToTest != operand && argumentIndex > start && nextPosition is null) nextPosition = argumentIndex;

                    var argumentResult = TypeConverter.Convert(argument, operandToTest);
                    //assignments.AddRange(newAssignments);

                    if (!argumentResult.Success && firstError is null)
                        firstError = $"the {SystemFunction.GetArgumentName(argumentIndex)} argument {argumentResult.Error}.";

                    iterationResults[argumentIndex] = argumentResult;
                }

                var concreteCandidate = SystemFunction.ReplaceGenericParameters(candidate, assignments);
                var resultExpression = candidate.CreateElmNode(iterationResults.Select(a => a.Expression).ToArray())
                        .WithResultType(concreteCandidate.resultTypeSpecifier);
                //var totalCost = iterationResults.Sum(r => r.Cost);
                //var totalError = firstError is not null ? $"Cannot resolve call to {concreteCandidate.Signature()}, {firstError}" : null;

                var errorResult = new ConversionResult<Expression>(resultExpression, iterationResults.SelectMany(r => r.Cost), iterationResults.SelectMany(r => r.Errors));
                positionResults.Add(errorResult);
            }

            return ConversionResult<Expression>.SelectBestCandidate(positionResults).First();
        }
    }
}

