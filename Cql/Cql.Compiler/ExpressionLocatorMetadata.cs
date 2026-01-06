/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Compiler;

/// <summary>
/// Stores CQL locator information (line:column ranges) for expressions.
/// This enables the code generator to emit source location comments in generated C# code.
/// </summary>
internal class ExpressionLocatorMetadata
{
    private readonly ConditionalWeakTable<Expression, string> _expressionToLocator = new();

    /// <summary>
    /// Associates a CQL source locator with an expression.
    /// </summary>
    /// <param name="expression">The LINQ expression.</param>
    /// <param name="locator">The CQL source location in format "startLine:startChar-endLine:endChar".</param>
    public void SetLocator(Expression expression, string? locator)
    {
        if (expression is not null && !string.IsNullOrWhiteSpace(locator))
        {
            _expressionToLocator.AddOrUpdate(expression, locator);
        }
    }

    /// <summary>
    /// Gets the CQL source locator for an expression, if available.
    /// </summary>
    /// <param name="expression">The LINQ expression.</param>
    /// <returns>The CQL source location string, or null if not found.</returns>
    public string? GetLocator(Expression expression)
    {
        if (expression is not null && _expressionToLocator.TryGetValue(expression, out var locator))
        {
            return locator;
        }
        return null;
    }

    /// <summary>
    /// Copies locator information from one expression to another.
    /// This is useful when expressions are transformed or wrapped.
    /// </summary>
    /// <param name="sourceExpression">The source expression with locator metadata.</param>
    /// <param name="targetExpression">The target expression to receive the metadata.</param>
    public void CopyLocator(Expression sourceExpression, Expression targetExpression)
    {
        if (sourceExpression is not null && targetExpression is not null)
        {
            var locator = GetLocator(sourceExpression);
            if (locator is not null)
            {
                SetLocator(targetExpression, locator);
            }
        }
    }
}
