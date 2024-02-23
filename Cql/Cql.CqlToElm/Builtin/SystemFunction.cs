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
using System.Diagnostics;
using System.Linq;

namespace Hl7.Cql.CqlToElm.Builtin
{
    internal abstract class SystemFunction: FunctionDef
    {
        public abstract Type ElmNodeType { get; }
        public abstract int? RequiredParameterCount { get; }

        /// <summary>
        /// Calls all validators associated with this function def on the specified call, adding any resulting errors.
        /// </summary>
        /// <param name="element">The element to validate.</param>
        public abstract TElement Validate<TElement>(TElement element)
            where TElement : Element;

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

    /// <summary>
    /// A kind of FunctionDef that represents a built-in CQL function.
    /// </summary>
    internal class SystemFunction<T> : SystemFunction
        where T: Element
    {
        public SystemFunction<T> CreateOverload(OperandDef[] newOperands, TypeSpecifier newReturnType) =>
            new SystemFunction<T>()
            {
                accessLevel = accessLevel,
                annotation = annotation,
                context = context,
                expression = expression,
                external = external,
                externalSpecified = externalSpecified,
                fluent = fluent,
                fluentSpecified = fluentSpecified,
                locator = locator,
                name = name,
                operand = newOperands,
                resultTypeName = newReturnType is NamedTypeSpecifier rnts ? rnts.name : null,
                resultTypeSpecifier = newReturnType,
                validators = new(validators),
            };

        public override Type ElmNodeType => typeof(T);

        public override int? RequiredParameterCount { get; }
        private SystemFunction()
        {
        }
        public SystemFunction(IEnumerable<TypeSpecifier> operands, TypeSpecifier resultType, string? name = null, int? requiredParameterCount = null)
        {
            this.name = name ?? typeof(T).Name;
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

            RequiredParameterCount = requiredParameterCount;
        }

        /// <summary>
        /// For system functions with variable length argument lists, this represents the minimum number of parameters required to be provided.
        /// For example, Date() can take up to 3 parameters but only requires 1.
        /// </summary>

        private List<Action<T>> validators = new();

        public SystemFunction<T> ValidateWith(Action<T> action)
        {
            validators.Add(action);
            return this;
        }

        public override TElement Validate<TElement>(TElement element)
        {
            if (element is T t)
                return (TElement)(Element)Validate(t);
            else return element;
        }

        public T Validate(T element)
        {
            foreach (var validator in validators) validator(element);
            return element;
        }

        public override string ToString() =>
            $"{name}({string.Join(", ", operand?.Select(o => o.resultTypeSpecifier) ?? Enumerable.Empty<TypeSpecifier>())})";

    }
}