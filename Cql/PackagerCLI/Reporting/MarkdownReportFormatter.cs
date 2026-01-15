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
    /// <param name="tracker">The library processing tracker.</param>
    /// <param name="summaryText">Optional summary text to include at the beginning of the report.</param>
    public static string FormatReport(LibraryProcessingTracker tracker, string? summaryText = null)
    {
        if (!tracker.Libraries.Any())
            return string.Empty;

        var sb = new StringBuilder();
        sb.AppendLine();
        sb.AppendLine("## Processing Report");
        sb.AppendLine();

        // Include summary text if provided
        if (!string.IsNullOrWhiteSpace(summaryText))
        {
            sb.AppendLine("### Summary");
            sb.AppendLine(summaryText.Trim());
            sb.AppendLine();
        }

        // Determine column headers based on active stages
        var activeStages = tracker.ActiveStages.OrderBy(s => s).ToList();
        if (!activeStages.Any())
            return string.Empty;

        // Calculate column widths for padding
        var columnWidths = CalculateColumnWidths(tracker, activeStages);

        // Build header row
        sb.Append("| ");
        sb.Append("Library".PadRight(columnWidths[0]));
        sb.Append(" |");
        for (int i = 0; i < activeStages.Count; i++)
        {
            sb.Append(" ");
            sb.Append(GetStageDisplayName(activeStages[i]).PadRight(columnWidths[i + 1]));
            sb.Append(" |");
        }
        sb.AppendLine();

        // Build separator row
        sb.Append("| ");
        sb.Append(new string('-', columnWidths[0]));
        sb.Append(" |");
        for (int i = 0; i < activeStages.Count; i++)
        {
            sb.Append(" ");
            sb.Append(new string('-', columnWidths[i + 1]));
            sb.Append(" |");
        }
        sb.AppendLine();

        // Build totals row
        sb.Append("| ");
        sb.Append("**Total**".PadRight(columnWidths[0]));
        sb.Append(" |");
        for (int i = 0; i < activeStages.Count; i++)
        {
            var stage = activeStages[i];
            var (total, libraries, measures) = tracker.GetStageStatistics(stage);
            string totalText;
            if (stage == LibraryProcessingStage.FhirResource && measures > 0)
            {
                totalText = FormattableString.Invariant($"**{total}** (Lib:{libraries}, Meas:{measures})");
            }
            else
            {
                totalText = FormattableString.Invariant($"**{total}**");
            }
            sb.Append(" ");
            sb.Append(totalText.PadRight(columnWidths[i + 1]));
            sb.Append(" |");
        }
        sb.AppendLine();

        // Build library rows
        foreach (var libraryId in tracker.Libraries.OrderBy(l => l.Identifier.ToString()).ThenBy(l => l.Version))
        {
            sb.Append("| ");
            sb.Append(FormatLibraryName(libraryId).PadRight(columnWidths[0]));
            sb.Append(" |");

            var statuses = activeStages.Select(stage => (stage, status: tracker.GetStatus(libraryId, stage))).ToList();

            // Detect if we should mark a failure: if we have a Loaded/Ok/Saved followed by NotProcessed
            bool hasProcessedStage = false;
            bool hasFailureMarked = false;

            for (int i = 0; i < statuses.Count; i++)
            {
                var (stage, status) = statuses[i];

                // Track if we've seen a processed stage
                if (status.StatusType is LibraryStatusType.Loaded or LibraryStatusType.Ok or LibraryStatusType.Saved)
                {
                    hasProcessedStage = true;
                }

                // If we had a processed stage and now hit NotProcessed for the first time, mark as failure
                string cellText;
                if (hasProcessedStage && !hasFailureMarked && status.StatusType == LibraryStatusType.NotProcessed)
                {
                    cellText = "**FAIL**";
                    hasFailureMarked = true;
                }
                else
                {
                    cellText = FormatStatus(status);
                }

                sb.Append(" ");
                sb.Append(cellText.PadRight(columnWidths[i + 1]));
                sb.Append(" |");
            }

            sb.AppendLine();
        }

        return sb.ToString();
    }

    private static List<int> CalculateColumnWidths(LibraryProcessingTracker tracker, List<LibraryProcessingStage> activeStages)
    {
        var widths = new List<int>();

        // Calculate width for library name column
        int libraryNameWidth = "Library".Length;
        foreach (var libraryId in tracker.Libraries)
        {
            int nameLength = FormatLibraryName(libraryId).Length;
            if (nameLength > libraryNameWidth)
                libraryNameWidth = nameLength;
        }
        widths.Add(Math.Max(libraryNameWidth, "**Total**".Length));

        // Calculate width for each stage column
        foreach (var stage in activeStages)
        {
            int stageWidth = GetStageDisplayName(stage).Length;

            // Check total row width
            var (total, libraries, measures) = tracker.GetStageStatistics(stage);
            string totalText;
            if (stage == LibraryProcessingStage.FhirResource && measures > 0)
            {
                totalText = FormattableString.Invariant($"**{total}** (Lib:{libraries}, Meas:{measures})");
            }
            else
            {
                totalText = FormattableString.Invariant($"**{total}**");
            }
            stageWidth = Math.Max(stageWidth, totalText.Length);

            // Check all library rows for this stage
            foreach (var libraryId in tracker.Libraries)
            {
                var status = tracker.GetStatus(libraryId, stage);
                int statusLength = FormatStatus(status).Length;

                // Also check for FAIL which might be longer
                if (statusLength < "**FAIL**".Length)
                    statusLength = "**FAIL**".Length;

                if (statusLength > stageWidth)
                    stageWidth = statusLength;
            }

            widths.Add(stageWidth);
        }

        return widths;
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
