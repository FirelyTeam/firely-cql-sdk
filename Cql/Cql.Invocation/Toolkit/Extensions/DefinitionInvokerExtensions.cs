/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Runtime;
using Hl7.Cql.Toolkit;

namespace Hl7.Cql.Invocation.Toolkit.Extensions;

/// <summary>
/// Provides extension methods for enumerations of <see cref="DefinitionInvoker"/>.
/// </summary>
public static class DefinitionInvokerExtensions
{
    /// <summary>
    /// Invokes the definitions in the provided collection of <see cref="DefinitionInvoker"/> instances
    /// and returns their results along with the corresponding invokers.
    /// </summary>
    ///
    /// <param name="definitionInvokers">
    /// A collection of <see cref="DefinitionInvoker"/> instances to be invoked.
    /// </param>
    ///
    /// <param name="cqlContext">
    /// The <see cref="CqlContext"/> used during the invocation of the definitions.
    /// </param>
    ///
    /// <param name="selectResultsOptions">
    /// An optional <see cref="SelectResultsOptions"/> instance that provides callbacks for customizing behavior.
    /// </param>
    ///
    /// <returns>
    /// An enumerable of tuples where each tuple contains a <see cref="DefinitionInvoker"/> and its
    /// corresponding invocation result.
    /// </returns>
    public static IEnumerable<(DefinitionInvoker definitionInvoker, object? invocationResult)> SelectResults(
        this IEnumerable<DefinitionInvoker> definitionInvokers,
        CqlContext cqlContext,
        SelectResultsOptions? selectResultsOptions = null)
    {
        selectResultsOptions ??= SelectResultsOptions.Default;

        var (
            argumentsProviderCallback,
            preInvokeHandler,
            postInvokeHandler, invocationExceptionCallback) = selectResultsOptions;

        if (definitionInvokers.TryGetNonEnumeratedCount(out int count) && count == 0)
            return [];

        // We need to enumerate twice, which isn't a problem in the case of collections.
        if (definitionInvokers is not IReadOnlyCollection<DefinitionInvoker> or ICollection<DefinitionInvoker>)
            definitionInvokers = definitionInvokers.ToList();

        ILogger logger = NullLogger.Instance;
        BatchProcessExceptionContinuation continuation = BatchProcessExceptionContinuation.Throw;

        // First enumeration to check if we have a LibrarySetInvoker. We need this to get the logger and continuation.
        // ReSharper disable once PossibleMultipleEnumeration
        if (definitionInvokers.FirstOrDefault() is { LibraryInvoker.LibrarySetInvoker: { } lsi })
        {
            logger = lsi.CreateLogger(typeof(LibraryInvokerExtensions));
            continuation = lsi.BatchProcessExceptionContinuation;
        }

        // Second enumeration to actually invoke the definitions.
        // ReSharper disable once PossibleMultipleEnumeration
        return definitionInvokers
            .TrySelect(
                definitionInvoker =>
                {
                    object?[] args = [];
                    if (definitionInvoker.Parameters.Length > 0)
                    {
                        if (argumentsProviderCallback is null)
                            throw new ArgumentException($"The definition {definitionInvoker} has parameters, but no arguments were provided.");
                        args = argumentsProviderCallback(definitionInvoker, cqlContext);
                        if (args.Length != definitionInvoker.Parameters.Length)
                            throw new ArgumentException($"The number of arguments ({args.Length}) does not match the number of parameters ({definitionInvoker.Parameters.Length}) for definition {definitionInvoker}.");
                    }

                    preInvokeHandler?.Invoke(definitionInvoker, cqlContext, args);
                    (DefinitionInvoker definitionInvoker, object? invocationResult) result = (definitionInvoker, definitionInvoker.Invoke(cqlContext, args));
                    postInvokeHandler?.Invoke(definitionInvoker, cqlContext, args, result.invocationResult);
                    return result;
                },
                errorStrategy => errorStrategy
                                 .SetContinuation(continuation)
                                 .AddLoggerExceptionHandler(
                                     logger,
                                     (definitionInvoker, logMessage) => logMessage("Could not invoke definition {definition}", definitionInvoker))
                                 .AddExceptionHandler(invocationExceptionCallback)
            );
    }
}

/// <summary>
/// Represents a delegate that is invoked before the execution of a CQL definition.
/// </summary>
/// <param name="definitionInvoker">
/// The <see cref="DefinitionInvoker"/> responsible for invoking the CQL definition.
/// </param>
/// <param name="cqlContext">
/// The <see cref="CqlContext"/> providing the execution context for the CQL definition.
/// </param>
/// <param name="definitionArguments">
/// An array of arguments to be passed to the CQL definition.
/// </param>
public delegate void PreInvokeDefinitionHandler(
    DefinitionInvoker definitionInvoker,
    CqlContext cqlContext,
    object?[] definitionArguments);

/// <summary>
/// Represents a callback delegate that provides arguments for a CQL definition invocation.
/// </summary>
/// <param name="definitionInvoker">
/// The <see cref="DefinitionInvoker"/> instance responsible for invoking the CQL definition.
/// </param>
/// <param name="cqlContext">
/// The <see cref="CqlContext"/> representing the execution context for the CQL definition.
/// </param>
/// <returns>
/// An array of objects representing the arguments to be passed to the CQL definition.
/// </returns>
public delegate object?[] DefinitionArgumentsProvider(
    DefinitionInvoker definitionInvoker,
    CqlContext cqlContext);

/// <summary>
/// Represents a delegate that is invoked after the execution of a CQL definition.
/// </summary>
/// <param name="definitionInvoker">
/// The <see cref="DefinitionInvoker"/> responsible for invoking the CQL definition.
/// </param>
/// <param name="cqlContext">
/// The <see cref="CqlContext"/> providing the execution context for the CQL definition.
/// </param>
/// <param name="definitionArguments">
/// An array of arguments passed to the CQL definition during invocation.
/// </param>
/// <param name="definitionResult">
/// The result produced by the execution of the CQL definition.
/// </param>
public delegate void PostInvokeDefinitionHandler(
    DefinitionInvoker definitionInvoker,
    CqlContext cqlContext,
    object?[] definitionArguments,
    object? definitionResult);

/// <summary>
/// Represents the options for selecting results during the invocation of CQL definitions.
/// </summary>
///
/// <remarks>
/// This record provides callbacks for customizing the behavior of definition invocations,
/// including argument provision, pre-invocation actions, and exception handling.
/// </remarks>
///
/// <param name="ProviderArgumentsCallback">
/// A callback function that provides arguments for each <see cref="DefinitionInvoker"/>
/// that have more than one parameter. When selecting definitions using <see cref="DefinitionPredicates.ExpressionsOnly"/>, the
/// default behavior is to not include definitions with parameters, unless <see cref="DefinitionPredicates.FunctionsOnly"/> or
/// <see cref="DefinitionPredicates.ExpressionsAndFunctions"/> was specified. If this is the case, you must provide a callback to supply the arguments,
/// otherwise it is not needed.
/// </param>
///
/// <param name="PreInvokeDefinitionCallback">
/// A callback invoked before the execution of a definition.
/// </param>
///
/// <param name="PostInvokeDefinitionCallback">
/// A callback invoked after the execution of a definition, containing the result of the invocation.
/// </param>
///
/// <param name="InvocationExceptionCallback">
/// A callback for handling exceptions that occur during the definition invocation.
/// It takes the <see cref="DefinitionInvoker"/>, the exception, and a continuation strategy as parameters.
/// </param>
public record SelectResultsOptions(
    DefinitionArgumentsProvider? ProviderArgumentsCallback = null,
    PreInvokeDefinitionHandler? PreInvokeDefinitionCallback = null,
    PostInvokeDefinitionHandler? PostInvokeDefinitionCallback = null,
    BatchProcessExceptionHandler<DefinitionInvoker>? InvocationExceptionCallback = null)
{
    /// <summary>
    /// Gets the default instance of <see cref="SelectResultsOptions"/> with no custom callbacks or exception handlers.
    /// </summary>
    /// <remarks>
    /// This property provides a pre-configured instance of <see cref="SelectResultsOptions"/> with all optional
    /// callbacks and exception handlers set to <c>null</c>. It can be used as a baseline configuration
    /// when no specific customization is required.
    /// </remarks>
    /// <value>
    /// A default instance of <see cref="SelectResultsOptions"/>.
    /// </value>
    public static SelectResultsOptions Default { get; } = new();
}

