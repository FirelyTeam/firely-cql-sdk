/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;

namespace Hl7.Cql.Exceptions;

/// <summary>
/// Records on an exception which CQL definitions it passed through while they were being evaluated.
/// </summary>
/// <remarks>
/// The frames are recorded from exception filters that always return <see langword="false"/>: a filter runs while the
/// exception propagates, before any stack unwinds, and never catches it, so the exception reaches the host unchanged.
/// An exception thrown inside a filter is discarded by the runtime, and the filter then counts as
/// <see langword="false"/>, so recording can never replace the exception being recorded on. The frames are kept in
/// <see cref="Exception.Data"/>, so any exception carries them, not only a <see cref="CqlException"/>, and
/// <see cref="CqlErrorExtensions.GetCqlEvaluationFrames"/> reads them.
/// <para>
/// A frame is skipped only when it equals the last one recorded. An exception instance that is thrown again, such as
/// a failure a host caches and rethrows from another definition, gets the frames of its second pass after those of
/// its first. Like <see cref="Exception.Data"/> itself, the list is not safe for one instance that propagates on two
/// threads at once.
/// </para>
/// </remarks>
internal static class CqlEvaluationFrames
{
    private const string DataKey = "Hl7.Cql.EvaluationFrames";

    // Weakly keyed, so that a cached frame never keeps a library loaded in a collectible AssemblyLoadContext alive.
    private static readonly ConditionalWeakTable<MethodInfo, CqlEvaluationFrame?> FramesByComputeMethod = new();

    /// <summary>
    /// The suffix of the private method a generated library computes a cached definition with: the public method
    /// <c>Patient</c> computes its value with <c>Patient_Compute</c>.
    /// </summary>
    private const string ComputeMethodSuffix = "_Compute";

    /// <summary>
    /// Records the definition that <paramref name="computeMethod"/> computes, read from the attributes of the
    /// generated library that declares it, once per method. A method that is not one of a CQL library records nothing.
    /// </summary>
    /// <returns><see langword="false"/>, so that the exception filter calling this never catches the exception.</returns>
    public static bool Record(Exception exception, MethodInfo computeMethod)
    {
        if (FramesByComputeMethod.GetValue(computeMethod, FrameOf) is { } frame)
            Add(exception, frame);
        return false;
    }

    /// <summary>
    /// Records a definition by its names, unless it is the one recorded last.
    /// </summary>
    /// <returns><see langword="false"/>, so that the exception filter calling this never catches the exception.</returns>
    public static bool Record(Exception exception, string libraryName, string? libraryVersion, string definitionName)
    {
        Add(exception, new CqlEvaluationFrame(libraryName, libraryVersion, definitionName));
        return false;
    }

    /// <summary>
    /// The definitions recorded on <paramref name="exception"/>, innermost first; empty when none were.
    /// </summary>
    public static IReadOnlyList<CqlEvaluationFrame> Get(Exception exception) =>
        exception.Data[DataKey] as IReadOnlyList<CqlEvaluationFrame> ?? [];

    // The invoker records the definition it invoked after the cache has recorded it, and the two are then equal.
    private static void Add(Exception exception, CqlEvaluationFrame frame)
    {
        if (exception.Data[DataKey] is not List<CqlEvaluationFrame> frames)
            exception.Data[DataKey] = frames = [];

        if (frames is [.., var last] && last == frame)
            return;

        frames.Add(frame);
    }

    private static CqlEvaluationFrame? FrameOf(MethodInfo computeMethod)
    {
        if (computeMethod.DeclaringType is not { } libraryType
            || libraryType.GetCustomAttributes<CqlLibraryAttribute>().FirstOrDefault() is not { } library)
            return null;

        var methodName = computeMethod.Name;
        var definitionMethodName = methodName.EndsWith(ComputeMethodSuffix, StringComparison.Ordinal)
            ? methodName[..^ComputeMethodSuffix.Length]
            : methodName;

        // A definition takes the context as its only parameter, which also tells it apart from functions of the
        // same name.
        var definitionName = libraryType
                             .GetMethods(BindingFlags.Public | BindingFlags.Instance)
                             .Where(method => method.Name == definitionMethodName && method.GetParameters().Length == 1)
                             .Select(method => method.GetCustomAttribute<CqlDefinitionAttribute>()?.Name)
                             .FirstOrDefault(name => name is not null)
                             ?? definitionMethodName;

        return new CqlEvaluationFrame(library.Identifier, library.Version, definitionName);
    }
}
