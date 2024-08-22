/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System;
using System.Linq;
using Hl7.Cql.Abstractions.Exceptions;
using Hl7.Cql.Elm;

namespace Hl7.Cql.Compiler;

/// <summary>
/// Ensures that all ExpressionRefs and FunctionRefs have a resultTypeSpecifier.
/// </summary>
internal class ExpressionRefCorrector(LibrarySet librarySet) : BaseElmTreeWalker
{
    private Library? _library;

    public void Fix(Library library)
    {
        _library = library;

        // Walk the tree, fixing the ExpressionRefs and FunctionRefs.
        StartInternal(library);
    }

    protected override bool Process(object node)
    {
        if (node is ExpressionRef element && element.resultTypeSpecifier is null)
        {
            switch (node)
            {
                case FunctionRef fref: FixFunctionRef(_library!, fref); break;
                case ExpressionRef exref: FixExpressionRef(_library!, exref); break;
                default: break;
            }
            FixElement(_library!, element);

            //if (element.resultTypeSpecifier is null)
            //    throw new InvalidOperationException("Result type specifier is still null after attempting to fix it.");

        }
        return false;
    }

    private void FixExpressionRef(Library library, ExpressionRef reference)
    {
        // If we cannot find the symbol at all, protest.
        if (!librarySet.TryResolveDefinition(library, reference, out ExpressionDef? expressionDef))
            throw new UnresolvedReferenceError(library, reference).ToException();

        reference.resultTypeSpecifier = expressionDef.GetTypeSpecifier();
    }

    private void FixElement(Library library, Element element)
    {
        // Ensure resultTypeSpecifier is always populated.
        if (element.resultTypeSpecifier is null && element.resultTypeName is not null)
        {
            element.resultTypeSpecifier = new NamedTypeSpecifier { name = element.resultTypeName };
        }
    }

    private void FixFunctionRef(Library library, FunctionRef reference)
    {
        // If we cannot find the symbol at all, protest.
        if (!librarySet.TryResolveDefinition(library, reference, out IFunctionElement? expressionDef))
            throw new UnresolvedReferenceError(library, reference).ToException();

        switch (expressionDef)
        {
            case OverloadedFunctionDef mg:
                {
                    var signature = reference.signature ?? reference.GetArgumentTypes();
                    var candidates = mg.FilterOverloads(signature);

                    reference.resultTypeSpecifier = candidates.Count switch
                    {
                        0 => throw new UnresolvedReferenceError(library, reference).ToException(),
                        > 1 => throw new AmbiguousMatch(library, reference).ToException(),
                        _ => candidates.Single().GetTypeSpecifier()
                    };
                    break;
                }
            case IHasSignature sig:
                // No overloads, just return the type of the expression,
                // if signature and params don't match, we'll have semantic errors later.
                reference.resultTypeSpecifier = sig.GetTypeSpecifier();
                break;
            default:
                throw new NotSupportedException("Unexpected expressionDef type: " + expressionDef.GetType().Name);
        }
    }
}