/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Packager.Commands.Global;
using Hl7.Cql.Packager.Commands.Logging;
using Hl7.Cql.Packaging;
using Hl7.Fhir.Model;

namespace Hl7.Cql.Packager.Commands.ExtractLibraryAttachments;

internal sealed class ExtractLibraryAttachmentsProgram
(
    ILogger<ExtractLibraryAttachmentsProgram> logger,
    IOptions<ExtractLibraryAttachmentsOptions> extractAttachmentsOptions) : IProgram
{
    public int Run()
    {
        try
        {
            var opt = extractAttachmentsOptions.Value;

            // Validate at least one output directory is specified
            if (opt is { CqlOutDir: null, ElmOutDir: null, CSharpOutDir: null, DllOutDir: null, PdbOutDir: null })
            {
                logger.LogError("Exiting. At least one output directory must be specified.");
                return ExitCodes.NoOutputDirs.Code;
            }

            // Parse FHIR Library resource
            logger.LogInformation("Reading FHIR Library resource from {LibraryFile}", opt.LibraryFile.FullName);
            var libraryJson = File.ReadAllText(opt.LibraryFile.FullName);
            FhirLibrary fhirLibrary = FhirLibrary.ReadLibraryFromJson(libraryJson);

            if (string.IsNullOrWhiteSpace(fhirLibrary.Name))
            {
                logger.LogError("FHIR Library must have a Name property.");
                return ExitCodes.InvalidLibraryJson.Code;
            }

            var libraryName = fhirLibrary.Name;
            var libraryVersion = fhirLibrary.Version;
            var libraryIdentifier = CqlVersionedLibraryIdentifier.ParseFromIdentifierAndVersion(libraryName, libraryVersion);

            logger.LogInformation("Processing FHIR Library: {LibraryIdentifier}", libraryIdentifier);

            if (fhirLibrary is { Content: null or { Count: 0 } })
            {
                logger.LogWarning("No content attachments found in FHIR Library resource.");
                return ExitCodes.Success.Code;
            }

            List<string> successfulExtractions = [];
            List<(string? elementId, string? contentType)> failedExtractions = [];

            // Process each attachment
            foreach (var attachment in fhirLibrary.Content)
            {
                if (attachment is { Data: null })
                {
                    logger.LogWarning("Skipping attachment with ID {AttachmentId}: no data", attachment.ElementId);
                    failedExtractions.Add((attachment.ElementId, attachment.ContentType));
                    continue;
                }

                var contentType = attachment.ContentType;
                var elementId = attachment.ElementId;
                logger.LogDebug("Processing attachment: ID={ElementId}, ContentType={ContentType}", elementId, contentType);

                // Determine which type of attachment this is and extract if requested
                var (success, outputPath) = TrySaveAttachmentToFile(attachment, opt, libraryIdentifier, contentType, elementId);
                if (success && outputPath != null)
                {
                    successfulExtractions.Add(outputPath);
                }
                else if (!success)
                {
                    failedExtractions.Add((elementId, contentType));
                }
            }

            // Display summary
            if (successfulExtractions.Count > 0)
            {
                logger.LogInformation("Successfully extracted {Count} attachment(s):", successfulExtractions.Count);
                foreach (var path in successfulExtractions)
                {
                    logger.LogInformation("  - {Path}", path);
                }
            }

            if (failedExtractions.Count > 0)
            {
                logger.LogWarning("Failed to extract {Count} attachment(s):", failedExtractions.Count);
                foreach (var (elementId, contentType) in failedExtractions)
                {
                    logger.LogWarning("  - ElementId: {ElementId}, ContentType: {ContentType}", elementId ?? "N/A", contentType ?? "N/A");
                }
            }

            if (successfulExtractions.Count == 0 && failedExtractions.Count == 0)
            {
                logger.LogInformation("No attachments matched the requested output directories.");
            }

            return ExitCodes.Success.Code;
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error extracting attachments from FHIR Library resource");
            return ExitCodes.LibraryExtractionError.Code;
        }
    }

    private (bool success, string? outputPath) TrySaveAttachmentToFile(
        Attachment attachment,
        ExtractLibraryAttachmentsOptions opt,
        CqlVersionedLibraryIdentifier libraryIdentifier,
        string? contentType,
        string? elementId)
    {
        return contentType switch
        {
            ContentMimeTypes.Cql when opt is { CqlOutDir: not null }
                => TrySaveAttachmentToFile(attachment, opt.CqlOutDir, libraryIdentifier, FileExtensions.Cql),

            ContentMimeTypes.Elm when opt is { ElmOutDir: not null }
                => TrySaveAttachmentToFile(attachment, opt.ElmOutDir, libraryIdentifier, FileExtensions.Elm),

            ContentMimeTypes.CSharp when opt is { CSharpOutDir: not null } && elementId?.Contains("csharp") == true
                => TrySaveAttachmentToFile(attachment, opt.CSharpOutDir, libraryIdentifier, FileExtensions.CSharp),

            ContentMimeTypes.Binary when opt is { DllOutDir: not null } && elementId?.Contains("dll") == true
                => TrySaveAttachmentToFile(attachment, opt.DllOutDir, libraryIdentifier, FileExtensions.Dll),

            ContentMimeTypes.Binary when opt is { PdbOutDir: not null } && elementId?.Contains("pdb") == true
                => TrySaveAttachmentToFile(attachment, opt.PdbOutDir, libraryIdentifier, FileExtensions.Pdb),

            _ => (true, null)
        };
    }

    /// <summary>
    /// Extracts an attachment from a FHIR Library to a file.
    /// Returns a tuple indicating success and the output path if successful.
    /// </summary>
    private (bool success, string? outputPath) TrySaveAttachmentToFile(
        Attachment attachment,
        DirectoryInfo outputDir,
        CqlVersionedLibraryIdentifier libraryIdentifier,
        string fileExtension)
    {
        try
        {
            if (attachment.Data is null)
            {
                logger.LogWarning("Attachment has no data: {ElementId}", attachment.ElementId);
                return (false, null);
            }

            var fileName = $"{libraryIdentifier}{fileExtension}";
            var outputPath = Path.Combine(outputDir.FullName, fileName);

            // Ensure output directory exists
            if (!outputDir.Exists)
            {
                outputDir.Create();
            }

            File.WriteAllBytes(outputPath, attachment.Data);

            logger.LogInformation("Saved {Extension} to {OutputPath}", fileExtension, outputPath);
            return (true, outputPath);
        }
        catch (Exception ex)
        {
            logger.LogError(
                ex,
                "Failed to save attachment: {ElementId}",
                attachment.ElementId);
            return (false, null);
        }
    }

    internal static int CommandHandler(
        IConsole console,
        LoggingCommand loggingCommand,
        GlobalCommand globalCommand,
        ExtractLibraryAttachmentsCommand extractAttachmentsCommand) =>
        RunProgram<ExtractLibraryAttachmentsProgram>(
            console,
            loggingCommand,
            globalCommand,
            extractAttachmentsCommand.GetConfigMapping,
            (_, services) =>
                services.AddAndBindOptions<ExtractLibraryAttachmentsOptions>());
}