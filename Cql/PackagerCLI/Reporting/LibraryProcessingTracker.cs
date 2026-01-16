/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Runtime;

namespace Hl7.Cql.Packager.Reporting;

/// <summary>
/// Tracks the processing status of libraries through various stages.
/// </summary>
internal sealed class LibraryProcessingTracker
{
    private readonly Dictionary<CqlVersionedLibraryIdentifier, Dictionary<LibraryProcessingStage, LibraryStageStatus>> _libraryStatuses = [];
    private readonly HashSet<LibraryProcessingStage> _activeStages = [];

    /// <summary>
    /// Gets the collection of active stages being tracked.
    /// </summary>
    public IReadOnlySet<LibraryProcessingStage> ActiveStages => _activeStages;

    /// <summary>
    /// Gets all tracked library identifiers.
    /// </summary>
    public IEnumerable<CqlVersionedLibraryIdentifier> Libraries => _libraryStatuses.Keys;

    /// <summary>
    /// Marks a stage as active for this processing run.
    /// </summary>
    public void MarkStageActive(LibraryProcessingStage stage)
    {
        _activeStages.Add(stage);
    }

    /// <summary>
    /// Records the status of a library at a specific stage.
    /// </summary>
    public void RecordStatus(
        CqlVersionedLibraryIdentifier libraryId,
        LibraryProcessingStage stage,
        LibraryStageStatus status)
    {
        if (!_libraryStatuses.TryGetValue(libraryId, out var stages))
        {
            stages = [];
            _libraryStatuses[libraryId] = stages;
        }

        stages[stage] = status;
        _activeStages.Add(stage);
    }

    /// <summary>
    /// Gets the status of a library at a specific stage.
    /// </summary>
    public LibraryStageStatus GetStatus(
        CqlVersionedLibraryIdentifier libraryId,
        LibraryProcessingStage stage)
    {
        if (_libraryStatuses.TryGetValue(libraryId, out var stages) &&
            stages.TryGetValue(stage, out var status))
        {
            return status;
        }

        return LibraryStageStatus.NotProcessed();
    }

    /// <summary>
    /// Gets statistics for a specific stage.
    /// </summary>
    public (int total, int libraries, int measures) GetStageStatistics(LibraryProcessingStage stage)
    {
        var total = 0;
        var libraries = 0;
        var measures = 0;

        foreach (var (libraryId, stages) in _libraryStatuses)
        {
            if (stages.TryGetValue(stage, out var status) &&
                status.StatusType is LibraryStatusType.Loaded or LibraryStatusType.Ok or LibraryStatusType.Saved)
            {
                total++;
                // Check if this is a measure based on FHIR resource stage
                if (stage == LibraryProcessingStage.FhirResource &&
                    status.FileExtensions.Contains("Measure-*.json"))
                {
                    measures++;
                }
                else
                {
                    libraries++;
                }
            }
        }

        return (total, libraries, measures);
    }
}
