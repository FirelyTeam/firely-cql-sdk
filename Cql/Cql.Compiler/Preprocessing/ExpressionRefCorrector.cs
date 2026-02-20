/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Exceptions;
using Hl7.Cql.Elm;

namespace Hl7.Cql.Compiler.Preprocessing;

/// <summary>
/// Ensures that all ExpressionRefs and FunctionRefs have a resultTypeSpecifier.
/// </summary>
internal class ExpressionRefCorrector(
    ILogger<ExpressionRefCorrector> logger,
    LibrarySet librarySet)
{
    public void Fix(Library library)
    {
        logger.LogDebug("Preprocessing library '{library}'", library.VersionedLibraryIdentifier);

        var walker = new ElmTreeWalker(node =>
        {
            switch (node)
            {
                case FunctionRef functionRef:
                {
                    if (functionRef.signature is null && librarySet.TryResolveDefinition(library!, functionRef, out IFunctionElement? expressionDef) && expressionDef is IHasSignature hasSig)
                    {
                        // We can only correct signatures if we know the function & it has a single signature
                        // (it is not a function with overloads), since we don't want to re-implement overload resolution here.
                        // We could do so by making overload resulution a public method on LibrarySet, but that's a bigger change
                        // and will require isolating the resolution logic. This will be picked up by
                        // issue https://github.com/FirelyTeam/firely-cql-sdk/issues/497. For now, this is good enough.
                        functionRef.signature = hasSig.BuildSignatureFromOperands();
                    }

                    if (functionRef.resultTypeSpecifier is null)
                    {
                        FixFunctionRef(library!, functionRef);
                    }

                    break;
                }
                case ExpressionRef { resultTypeSpecifier: null } expressionRef:
                    FixExpressionRef(library!, expressionRef);
                    break;
            }

            return false; // Continue walking children
        });

        walker.Start(library);
    }

    private void FixExpressionRef(Library library, ExpressionRef reference)
    {
        // If we cannot find the symbol at all, protest.
        if (!librarySet.TryResolveDefinition(library, reference, out ExpressionDef? expressionDef))
            throw new UnresolvedReferenceError(library, reference).ToException();

        reference.resultTypeSpecifier = expressionDef.GetTypeSpecifier();
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
                var resultTypeSpecifier = sig.GetTypeSpecifier();
                reference.resultTypeSpecifier = resultTypeSpecifier;
                break;
            default:
                throw new NotSupportedException("Unexpected expressionDef type: " + expressionDef.GetType().Name);
        }
    }
}