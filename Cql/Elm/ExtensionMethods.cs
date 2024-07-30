#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Hl7.Cql.Abstractions.Exceptions;

namespace Hl7.Cql.Elm
{
    public static class ExtensionMethods
    {
        internal static TypeSpecifier[] BuildSignatureFromOperands(this IHasSignature hasSignature) =>
            hasSignature.Operands.Select(o =>
                                             o.GetTypeSpecifier() ??
                                             throw new UntypedOperandInFunctionError(hasSignature, o).ToException()
                                         ).ToArray();

        internal static TypeSpecifier[] GetArgumentTypes(this FunctionRef funcRef) =>
            (funcRef.operand ?? []).Select((o,i) =>
                                             o.GetTypeSpecifier() ??
                                             throw new UntypedOperandInFunctionRefError(funcRef, i).ToException()
            ).ToArray();

        /// <summary>
        /// Compares two signatures for exact equality, based on the Equals of the TypeSpecifier.
        /// </summary>
        internal static bool ExactlyMatches(this TypeSpecifier[] me, TypeSpecifier[] signature)
        {
            return me.Length == signature.Length &&
                   me.Zip(signature, (l,r) => r.Equals(l)).All(r => r);
        }

        /// <summary>
        /// Determines whether a given symbol is visible for the kind of access given in <paramref name="access"/>.
        /// </summary>
        internal static bool IsVisible(this IDefinitionElement symbol, AccessModifier access)
        {
            return access >= symbol.Access;
        }

        /// <summary>
        /// Retrieves all error nodes in the ELM tree rooted in <paramref name="node"/>.
        /// </summary>
        public static CqlToElmError[] GetErrors(this Element node)
        {
            var allErrors = new HashSet<CqlToElmError>();

            var visitor = new ElmTreeWalker(nodeHandler, nodeFilter);

            visitor.Walk(node);
            return allErrors.ToArray();

            static bool nodeFilter(PropertyInfo property)
            {
                var type = property.PropertyType;
                if (type.IsAssignableTo(typeof(Element)))
                {
                    return true;
                }
                else if (type.IsArray)
                {
                    if (type.GetElementType()!.IsAssignableTo(typeof(TypeSpecifier)))
                        return false;
                    else if (type.GetElementType()!.IsAssignableTo(typeof(Element)))
                        return true;
                }
                return false;
            }

            bool nodeHandler(object node)
            {
                if (node is Element element && element.annotation?.OfType<CqlToElmError>() is { } errors && errors.Any())
                {
                    // avoid duplicate errors.
                    foreach (var error in errors)
                    {
                        if (!allErrors.Contains(error))
                            allErrors.Add(error);
                    }
                }
                // Let the walker visit my children.
                return false;
            }
        }

        /// <summary>
        /// Adds an error or warning to the given node using a <see cref="CqlToElmError"/> annotation."/>
        /// </summary>
        public static T AddError<T>(this T node,
            string errorMessage,
            ErrorType errorType = ErrorType.semantic,
            ErrorSeverity severity = ErrorSeverity.error) where T : Element
        {
            var error = new CqlToElmError
            {
                errorSeverity = severity,
                errorSeveritySpecified = true,
                errorType = errorType,
                message = errorMessage,
            };

            return AddError(node, error);
        }

        /// <summary>
        /// Adds an error to the given node.
        /// </summary>
        public static T AddError<T>(this T node, CqlToElmError error) where T : Element
        {
            node.annotation = node.annotation is { } annotations
                ? annotations.Append(error).ToArray()
                : new[] { error };
            return node;
        }

    }
}