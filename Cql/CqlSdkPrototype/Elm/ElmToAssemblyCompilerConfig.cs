using Hl7.Cql.Abstractions.Exceptions;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Compiler;

namespace CqlSdkPrototype.Elm;

public sealed record ElmToAssemblyCompilerConfig(
    ProcessBatchItemExceptionHandling ProcessBatchItemExceptionHandling = default,
    AssemblyCompilerDebugInformationFormat AssemblyCompilerDebugInformationFormat = AssemblyCompilerDebugInformationFormat.None,
    bool AllowScopeRedefinition = true,
    bool AllowUnresolvedExternals = true,
    int LRUCacheSize = 0)
{
    public static ElmToAssemblyCompilerConfig Default { get; } = new();

    /// <summary>
    /// Allows a child scope to redefine an existing parent scope.  Default is <see langword="true" />
    /// </summary>
    /// <remarks>
    /// For example, consider this query:
    ///
    /// IinCC X
    ///    return
    ///    (
    ///        Tuple
    ///        {
    ///            sdate: start of X,
    ///            edate:
    ///            end of X,
    ///            ndate:
    ///            end of X + System.Quantity { value: DDiff, unit: 'day' }
    ///        }
    ///    ) X
    ///         return Tuple
    ///         {
    ///             CInterval: Interval[X.sdate, X.edate],
    ///             RInterval: Interval[X.sdate, X.ndate]
    ///         }
    ///
    /// Here, X is being used twice, because the source is a subquery.  X is used in the subquery and is also used
    /// in the main query.  ELM does not limit the scope of the first X to only the subquery as it probably should.
    /// </remarks>
    public bool AllowScopeRedefinition { get; init; } = AllowScopeRedefinition;

    /// <summary>
    /// When <see langword="true"/>, functions declared external will throw <see cref="NotImplementedException"/> at runtime
    /// if they are not found in customImplementations.  When <see langword="false"/>, an
    /// <see cref="InvalidOperationException"/> will be thrown during compilation if they are not found in customImplementations.
    /// The default value is <see langword="true"/>.
    /// </summary>
    public bool AllowUnresolvedExternals { get; init; } = AllowUnresolvedExternals;

    internal ExpressionBuilderSettings ToExpressionBuilderSettings() => new()
    {
        AllowScopeRedefinition = AllowScopeRedefinition,
        AllowUnresolvedExternals = AllowUnresolvedExternals
    };
}