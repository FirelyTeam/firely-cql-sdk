/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Compiler;

namespace Hl7.Cql.CodeGeneration.NET.Visitors;

/// <summary>
/// Base class for expression visitors that need to preserve CQL source locator metadata
/// when transforming expressions.
/// </summary>
internal abstract class LocatorPreservingExpressionVisitor : ExpressionVisitor
{
    protected LocatorPreservingExpressionVisitor(ExpressionLocatorMetadata? locatorMetadata)
    {
        LocatorMetadata = locatorMetadata;
    }

    protected ExpressionLocatorMetadata? LocatorMetadata { get; }

    /// <summary>
    /// Copies locator metadata from the source expression to the target expression.
    /// Call this when creating a new expression from an existing one.
    /// </summary>
    protected void CopyLocator(Expression source, Expression target)
    {
        LocatorMetadata?.CopyLocator(source, target);
    }

    /// <summary>
    /// Helper to copy locator when updating an expression.
    /// </summary>
    protected T CopyLocatorOnUpdate<T>(Expression original, T updated) where T : Expression
    {
        if (!ReferenceEquals(original, updated))
        {
            CopyLocator(original, updated);
        }
        return updated;
    }
}
