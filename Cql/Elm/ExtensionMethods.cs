#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System;
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
            (funcRef.operand ?? []).Select((o, i) =>
                                             o.GetTypeSpecifier() ??
                                             throw new UntypedOperandInFunctionRefError(funcRef, i).ToException()
            ).ToArray();

        internal static IReadOnlyCollection<IHasSignature> FilterOverloads(this OverloadedFunctionDef overloads, TypeSpecifier[] signature)
        {
            return overloads.Functions.Where(match).ToArray();

            bool match(IHasSignature candidate) =>
                candidate.BuildSignatureFromOperands().ExactlyMatches(signature);
        }

        internal static TypeSpecifier? GetTypeSpecifier(this IHasSignature func) =>
            func.ResultTypeSpecifier ?? (func is Element e ? e.GetTypeSpecifier() : null);

        /// <summary>
        /// Compares two signatures for exact equality, based on the Equals of the TypeSpecifier.
        /// </summary>
        internal static bool ExactlyMatches(this TypeSpecifier[] me, TypeSpecifier[] signature)
        {
            return me.Length == signature.Length &&
                   me.Zip(signature, (l, r) => r.Equals(l)).All(r => r);
        }

        /// <summary>
        /// Determines whether a given symbol is visible for the kind of access given in <paramref name="access"/>.
        /// </summary>
        internal static bool IsVisible(this IDefinitionElement symbol, AccessModifier access)
        {
            return access >= symbol.Access;
        }

        /// <summary>
        /// Retrieves all error nodes in the ELM tree rooted in <paramref name="root"/>.
        /// </summary>
        public static CqlToElmError[] GetErrors(this Element root)
        {
            var allErrors = new HashSet<CqlToElmError>();

            var visitor = new ElmTreeWalker(nodeHandler);

            visitor.Start(root);
            return allErrors.ToArray();

            bool nodeHandler(object node)
            {
                if (node is not Element element) return false;

                var errors = element.annotation?.OfType<CqlToElmError>()?.ToArray() ?? Array.Empty<CqlToElmError>();

                if (errors.Length > 0) {
                    // propagate the element's locator to the error.
                    // this is important for error reporting in the IDE.
                    // TODO: fix in the source?
                    // this only happens if someone calls the GetErrors function to invoke this
                    var l = locator(element.locator);
                    if (l is not null)
                    {
                        foreach (var error in errors)
                        {
                            error.startLine = l.Value.startLine;
                            error.startLineSpecified = true;
                            error.startChar = l.Value.startChar;
                            error.startCharSpecified = true;
                            error.endLine = l.Value.endLine;
                            error.endLineSpecified = true;
                            error.endChar = l.Value.endChar;
                            error.endCharSpecified = true;
                        }
                    }

                    // avoid duplicate errors.
                    foreach (var error in errors)
                        allErrors.Add(error);
                }
                // Let the walker visit my children to scan for nested Elements.
                return false;
            }

            (int startLine, int startChar, int endLine, int endChar)? locator(string locator)
            {
                if (string.IsNullOrWhiteSpace(locator))
                {
                    return null;
                }

                var parts = locator.Split(new[] { '-', ':' }, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length != 4)
                {
                    return null;
                }

                if (!int.TryParse(parts[0], out int startLine) ||
                    !int.TryParse(parts[1], out int startChar) ||
                    !int.TryParse(parts[2], out int endLine) ||
                    !int.TryParse(parts[3], out int endChar))
                {
                    return null;
                }

                return (startLine, startChar, endLine, endChar);
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