/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Packager.Reporting;

/// <summary>
/// Represents the status of a library at a specific stage.
/// </summary>
/// <param name="StatusType">The type of status (Loaded, Ok, Saved, Failed, NotProcessed).</param>
/// <param name="FileExtensions">The file extensions associated with this status (e.g., ".cql", ".json", ".dll").</param>
internal readonly record struct LibraryStageStatus(
    LibraryStatusType StatusType,
    IReadOnlyList<string> FileExtensions)
{
    public static LibraryStageStatus Loaded(params string[] extensions) =>
        new(LibraryStatusType.Loaded, extensions);

    public static LibraryStageStatus Ok() =>
        new(LibraryStatusType.Ok, []);

    public static LibraryStageStatus Saved(params string[] extensions) =>
        new(LibraryStatusType.Saved, extensions);

    public static LibraryStageStatus Failed() =>
        new(LibraryStatusType.Failed, []);

    public static LibraryStageStatus NotProcessed() =>
        new(LibraryStatusType.NotProcessed, []);
}

/// <summary>
/// The type of status at a stage.
/// </summary>
internal enum LibraryStatusType
{
    NotProcessed,
    Loaded,
    Ok,
    Saved,
    Failed
}
