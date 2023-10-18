/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Elm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hl7.Cql.CqlToElm.Builtin
{

    /// <summary>
    /// A kind of FunctionDef that represents a built-in CQL function.
    /// </summary>
    internal class BuiltInFunctionDef : FunctionDef
    {
        public static readonly TypeSpecifier[] EmptyOperands = Array.Empty<TypeSpecifier>();

        public Type ElmNodeType { get; }

        public BuiltInFunctionDef(string name, IEnumerable<TypeSpecifier> operands, TypeSpecifier resultType, Type elmNodeType)
        {
            this.name = name;
            expression = null;
            external = true;
            fluent = false;   // not too sure, maybe should be true for fhirpath functions?
            context = null;    // any context?
            accessLevel = AccessModifier.Public;    // All built-in functions are public                
            resultTypeSpecifier = resultType;
            resultTypeName = resultType.TryToQualifiedName();

            operand = operands.Select((o, ix) =>
                    new OperandDef
                    {
                        name = GetArgumentName(ix),
                        operandTypeSpecifier = o,
                        operandType = o.TryToQualifiedName()
                    }.WithResultType(o))
                .ToArray();
           
            ElmNodeType = elmNodeType;
        }

        public BuiltInFunctionDef ReplaceGenericParameters(GenericParameterAssignments replacements)
        {
            var newOperands = operand.Select(o => 
                new OperandDef 
                { 
                    name = o.name, 
                    operandTypeSpecifier =  o.operandTypeSpecifier.ReplaceGenericParameters(replacements), 
                    operandType = o.operandTypeSpecifier.ReplaceGenericParameters(replacements).TryToQualifiedName() 
                });

            var newResultType = resultTypeSpecifier.ReplaceGenericParameters(replacements);
            return new BuiltInFunctionDef(name, newOperands.Select(o => o.operandTypeSpecifier), newResultType, ElmNodeType);
        }

        /// <summary>
        /// Return a string like "first", "second", "third", etc. for the given position of the argument.
        /// </summary>
        internal static string GetArgumentName(int position) => position switch
        {
            0 => "first",
            1 => "second",
            2 => "third",
            3 => "fourth",
            4 => "fifth",
            5 => "sixth",
            6 => "seventh",
            7 => "eighth",
            8 => "ninth",
            _ => $"{position + 1}th"
        };
    }
}