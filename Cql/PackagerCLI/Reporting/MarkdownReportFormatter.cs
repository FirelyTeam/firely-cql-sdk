/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Text;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.Packager.Reporting;

/// <summary>
/// Formats library processing status as a markdown table.
/// </summary>
internal static class MarkdownReportFormatter
{
    /// <summary>
    /// Formats the tracking data as a markdown table.
    /// </summary>
    public static string FormatReport(LibraryProcessingTracker tracker)
    {
        if (!tracker.Libraries.Any())
            return string.Empty;

        var sb = new StringBuilder();
        sb.AppendLine();
        sb.AppendLine("## Processing Report");
        sb.AppendLine();

        // Determine column headers based on active stages
        var activeStages = tracker.ActiveStages.OrderBy(s => s).ToList();
        if (!activeStages.Any())
            return string.Empty;

        // Build header row
        sb.Append("| Library ");
        foreach (var stage in activeStages)
        {
            sb.Append(CultureInfo.InvariantCulture, $"| {GetStageDisplayName(stage)} ");
        }
        sb.AppendLine("|");

        // Build separator row
        sb.Append("| --- ");
        foreach (var _ in activeStages)
        {
            sb.Append("| --- ");
        }
        sb.AppendLine("|");

        // Build totals row
        sb.Append("| **Total** ");
        foreach (var stage in activeStages)
        {
            var (total, libraries, measures) = tracker.GetStageStatistics(stage);
            sb.Append("| ");
            if (stage == LibraryProcessingStage.FhirResource && measures > 0)
            {
                sb.Append(CultureInfo.InvariantCulture, $"**{total}** (Lib:{libraries}, Meas:{measures}) ");
            }
            else
            {
                sb.Append(CultureInfo.InvariantCulture, $"**{total}** ");
            }
        }
        sb.AppendLine("|");

        // Build library rows
        foreach (var libraryId in tracker.Libraries.OrderBy(l => l.Identifier).ThenBy(l => l.Version))
        {
            sb.Append(CultureInfo.InvariantCulture, $"| {FormatLibraryName(libraryId)} ");

            foreach (var stage in activeStages)
            {
                var status = tracker.GetStatus(libraryId, stage);
                sb.Append(CultureInfo.InvariantCulture, $"| {FormatStatus(status)} ");
            }

            sb.AppendLine("|");
        }

        return sb.ToString();
    }

    private static string GetStageDisplayName(LibraryProcessingStage stage) => stage switch
    {
        LibraryProcessingStage.Cql => "CQL",
        LibraryProcessingStage.Elm => "ELM",
        LibraryProcessingStage.CSharp => "C#",
        LibraryProcessingStage.DotNet => ".NET",
        LibraryProcessingStage.FhirResource => "FHIR Resource",
        _ => stage.ToString()
    };

    private static string FormatLibraryName(CqlVersionedLibraryIdentifier libraryId)
    {
        if (libraryId.Version is null)
            return libraryId.Identifier.ToString();

        return FormattableString.Invariant($"{libraryId.Identifier}-{libraryId.Version}");
    }

    private static string FormatStatus(LibraryStageStatus status) => status.StatusType switch
    {
        LibraryStatusType.Loaded => FormatWithExtensions("loaded", status.FileExtensions),
        LibraryStatusType.Ok => "ok",
        LibraryStatusType.Saved => FormatWithExtensions("saved", status.FileExtensions),
        LibraryStatusType.Failed => "**FAIL**",
        LibraryStatusType.NotProcessed => "-",
        _ => "-"
    };

    private static string FormatWithExtensions(string statusText, IReadOnlyList<string> extensions)
    {
        if (extensions.Count == 0)
            return statusText;

        var extText = string.Join(", ", extensions);
        return $"{statusText} {extText}";
    }
}
