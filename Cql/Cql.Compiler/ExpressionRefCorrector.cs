/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System;
using System.Diagnostics;
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

    public override void Walk(Library library)
    {
        _library = library;

        base.Walk(library);
    }

    protected override bool Process(object node)
    {
        if (node is ExpressionRef { resultTypeSpecifier: null } element)
        {
            switch (node)
            {
                case FunctionRef fref: FixFunctionRef(_library!, fref); break;
                case ExpressionRef exref: FixExpressionRef(_library!, exref); break;
            }

            FixElement(element);
        }

        if(node is FunctionRef { signature: null } noSignature)
        {
            if (librarySet.TryResolveDefinition(_library!, noSignature,
                                                out IFunctionElement? expressionDef) &&
                expressionDef is IHasSignature hasSig)
            {
                // We can only correct signatures if we know the function & it has a single signature
                // (it is not a function with overloads), since we don't want to re-implement overload resolution here.
                // We could do so by making overload resulution a public method on LibrarySet, but that's a bigger change
                // and will require isolating the resolution logic. This will be picked up by
                // issue https://github.com/FirelyTeam/firely-cql-sdk/issues/497. For now, this is good enough.
                noSignature.signature = hasSig.BuildSignatureFromOperands();
            }
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

    private static void FixElement(Element element)
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