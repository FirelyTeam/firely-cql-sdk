/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Elm;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Linq;

namespace Hl7.Cql.CqlToElm.Builtin
{
    internal static class FunctionDefinitionBuilders
    {
        /// <summary>
        /// Creates overloads by replacing <paramref name="typeArgument"/> in all operands and the return type of <paramref name="def"/> for each <paramref name="replacements"/>.
        /// </summary>
        /// <typeparam name="T">The ELM type of expression to which <paramref name="def"/> will be translated.</typeparam>
        /// <param name="def">The base function which contains generic operands.</param>
        /// <param name="typeArgument">The generic type argument found in operands and the return type to replace.</param>
        /// <param name="replacements">The types with which to replace <paramref name="typeArgument"/>.</param>
        /// <returns>A new <see cref="OverloadedFunctionDef"/> containing all the new overloads.</returns>
        /// <exception cref="System.ArgumentException">If <paramref name="def"/> has no operands, or the resulting replacements would create duplicate overloads, or the replacements would not create at least 2 overloads.</exception>
        public static OverloadedFunctionDef For<T>(this SystemFunction<T> def, ParameterTypeSpecifier typeArgument, params TypeSpecifier[] replacements)
            where T : Element
        {
            if (replacements.Length < 2)
                throw new System.ArgumentException($"At least two types must be supplied to create overloads.", nameof(replacements));
            var functions = new FunctionDef[replacements.Length];
            var operandCount = def.operand?.Count() ?? 0;
            if (operandCount > 0)
            {

                for (int i = 0; i < replacements.Length; i++)
                {
                    var genericMap = new Dictionary<string, TypeSpecifier> { { typeArgument.parameterName, replacements![i] } };
                    var overload = CreateOverload(def, operandCount, genericMap);
                    functions[i] = overload;
                }
                var overloaded = new OverloadedFunctionDef(functions, def.name, def.accessLevel);
                return overloaded;
            }
            else throw new System.ArgumentException($"Function has no operands", nameof(def));
        }
        public static OverloadedFunctionDef WithListAndIntervalVariants<T>(this SystemFunction<T> def, ParameterTypeSpecifier typeArgument)
             where T : Element =>
            new OverloadedFunctionDef(For(def, typeArgument, typeArgument.ToIntervalType(), typeArgument.ToListType()).Functions.Append(def).Reverse().ToArray(),
                def.name, def.accessLevel);

        internal static SystemFunction CreateOverload<T>(SystemFunction<T> baseFunctionDef, int operandCount, Dictionary<string, TypeSpecifier> replacements) where T : Element
        {
            var newOperands = new OperandDef[operandCount];
            for (int j = 0; j < operandCount; j++)
            {
                var existingOperand = baseFunctionDef.operand![j];
                var operandType = InvocationBuilder.ReplaceGenericTypes(existingOperand.operandTypeSpecifier, replacements);
                var newOperand = new OperandDef
                {
                    name = existingOperand.name,
                    annotation = existingOperand.annotation,
                    locator = existingOperand.locator,
                    operandTypeSpecifier = operandType,
                    resultTypeName = operandType is NamedTypeSpecifier onts ? onts.name : null,
                    resultTypeSpecifier = operandType,
                };
                newOperands[j] = newOperand;
            }
            var newReturnType = InvocationBuilder.ReplaceGenericTypes(baseFunctionDef.resultTypeSpecifier, replacements);
            var overload = baseFunctionDef.CreateOverload(newOperands, newReturnType);
            return overload;
        }

        public static OverloadedFunctionDef Combine(this OverloadedFunctionDef @this, params OverloadedFunctionDef[] overloadedFunctions) =>
            OverloadedFunctionDef.Create(@this.Functions.Concat(overloadedFunctions.SelectMany(def => def.Functions)).ToArray());

        public static OverloadedFunctionDef Combine<T>(this SystemFunction<T> @this, params SystemFunction<T>[] functions) where T : Element =>
            OverloadedFunctionDef.Create(functions.Append(@this).ToArray());

        public static OverloadedFunctionDef Combine<T>(this OverloadedFunctionDef @this, params SystemFunction<T>[] functions) where T : Element =>
            OverloadedFunctionDef.Create(@this.Functions.Concat(functions).ToArray());

        public static SystemFunction<T> MakeFluent<T>(this SystemFunction<T> function)
            where T : Element
        {
            function.fluent = true;
            function.fluentSpecified = true;
            return function;
        }
    }

}