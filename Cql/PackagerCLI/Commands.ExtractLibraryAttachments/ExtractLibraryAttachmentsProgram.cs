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
                return ExitCode.NoOutputDirs;
            }

            // Parse FHIR Library resource
            logger.LogInformation("Reading FHIR Library resource from {LibraryFile}", opt.LibraryFile.FullName);
            var libraryJson = File.ReadAllText(opt.LibraryFile.FullName);
            FhirLibrary library = FhirLibrary.ReadLibraryFromJson(libraryJson);

            if (string.IsNullOrWhiteSpace(library.Name))
            {
                logger.LogError("FHIR Library must have a Name property.");
                return ExitCode.InvalidLibraryJson;
            }

            var libraryName = library.Name;

            var libraryVersion = library.Version;
            var libraryIdentifier = CqlVersionedLibraryIdentifier.ParseFromIdentifierAndVersion(libraryName, libraryVersion);

            logger.LogInformation("Processing FHIR Library: {LibraryIdentifier}", libraryIdentifier);

            if (library is { Content: null or { Count: 0 } })
            {
                logger.LogWarning("No content attachments found in FHIR Library resource.");
                return ExitCode.Normal;
            }

            int extractedCount = 0;

            // Process each attachment
            foreach (var attachment in library.Content)
            {
                if (attachment is { Data: null })
                {
                    logger.LogWarning("Skipping attachment with ID {AttachmentId}: no data", attachment.ElementId);
                    continue;
                }

                var contentType = attachment.ContentType;
                var elementId = attachment.ElementId;

                logger.LogDebug("Processing attachment: ID={ElementId}, ContentType={ContentType}", elementId, contentType);

                // Determine which type of attachment this is and extract if requested
                var extracted = TrySaveAttachmentToFile(attachment, opt, libraryIdentifier, contentType, elementId);
                if (extracted)
                {
                    extractedCount++;
                }
            }

            logger.LogInformation("Successfully extracted {ExtractedCount} attachment(s) from FHIR Library resource.", extractedCount);
            return ExitCode.Normal;
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error extracting attachments from FHIR Library resource");
            return ExitCode.LibraryExtractionError;
        }
    }

    private bool TrySaveAttachmentToFile(
        Attachment attachment,
        ExtractLibraryAttachmentsOptions opt,
        CqlVersionedLibraryIdentifier libraryIdentifier,
        string? contentType,
        string? elementId)
    {
        var extracted = contentType switch
        {
            "text/cql" when opt is { CqlOutDir: not null }
                => TrySaveAttachmentToFile(attachment, opt.CqlOutDir, libraryIdentifier, ".cql"),

            "application/elm+json" when opt is { ElmOutDir: not null }
                => TrySaveAttachmentToFile(attachment, opt.ElmOutDir, libraryIdentifier, ".json"),

            "text/plain" when opt is { CSharpOutDir: not null } && elementId?.Contains("csharp") == true
                => TrySaveAttachmentToFile(attachment, opt.CSharpOutDir, libraryIdentifier, ".g.cs"),

            "application/octet-stream" when opt is { DllOutDir: not null } && elementId?.Contains("dll") == true
                => TrySaveAttachmentToFile(attachment, opt.DllOutDir, libraryIdentifier, ".dll"),

            "application/octet-stream" when opt is { PdbOutDir: not null } && elementId?.Contains("pdb") == true
                => TrySaveAttachmentToFile(attachment, opt.PdbOutDir, libraryIdentifier, ".pdb"),

            _ => false
        };
        return extracted;
    }

    /// <summary>
    /// Extracts an attachment from a FHIR Library to a file.
    /// Returns true if extraction was successful, false otherwise.
    /// </summary>
    private bool TrySaveAttachmentToFile(
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
                return false;
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
            return true;
        }
        catch (Exception ex)
        {
            logger.LogError(
                ex,
                "Failed to save attachment: {ElementId}",
                attachment.ElementId);
            return false;
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