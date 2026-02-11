/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Fhir.Serialization.Extensions;
using Hl7.Cql.Packager.Commands.Global;
using Hl7.Cql.Packager.Commands.Logging;
using Hl7.Fhir.Model;

namespace Hl7.Cql.Packager.Commands.LibraryExtractAttachments;

internal sealed class LibraryExtractAttachmentsProgram
(
    ILogger<LibraryExtractAttachmentsProgram> logger,
    IOptions<LibraryExtractAttachmentsOptions> extractAttachmentsOptions) : IProgram
{
    public int Run()
    {
        try
        {
            var opt = extractAttachmentsOptions.Value;

            // Validate at least one output directory is specified
            if (opt.CqlOutDir is null && opt.ElmOutDir is null && opt.CSharpOutDir is null && opt.DllOutDir is null && opt.PdbOutDir is null)
            {
                logger.LogError("Exiting. At least one output directory must be specified.");
                return ExitCode.NoOutputDirs;
            }

            // Parse FHIR Library resource
            logger.LogInformation("Reading FHIR Library resource from {LibraryFile}", opt.LibraryFile.FullName);
            var libraryJson = File.ReadAllText(opt.LibraryFile.FullName);
            var library = libraryJson.DeserializeJsonToFhir<Library>();

            var libraryName = library.Name ?? library.Id;
            var libraryVersion = library.Version;
            var libraryIdentifier = $"{libraryName}-{libraryVersion}";

            logger.LogInformation("Processing FHIR Library: {LibraryIdentifier}", libraryIdentifier);

            if (library.Content is null || library.Content.Count == 0)
            {
                logger.LogWarning("No content attachments found in FHIR Library resource.");
                return ExitCode.Normal;
            }

            int extractedCount = 0;

            // Process each attachment
            foreach (var attachment in library.Content)
            {
                if (attachment.Data is null)
                {
                    logger.LogWarning("Skipping attachment with ID {AttachmentId}: no data", attachment.ElementId);
                    continue;
                }

                var contentType = attachment.ContentType;
                var elementId = attachment.ElementId;

                logger.LogDebug("Processing attachment: ID={ElementId}, ContentType={ContentType}", elementId, contentType);

                // Determine which type of attachment this is and extract if requested
                var extracted = contentType switch
                {
                    "text/cql" when opt.CqlOutDir is not null
                        => ExtractTextAttachment(attachment, opt.CqlOutDir, libraryIdentifier, ".cql"),

                    "application/elm+json" when opt.ElmOutDir is not null
                        => ExtractTextAttachment(attachment, opt.ElmOutDir, libraryIdentifier, ".json"),

                    "text/plain" when opt.CSharpOutDir is not null && elementId?.Contains("csharp") == true
                        => ExtractTextAttachment(attachment, opt.CSharpOutDir, libraryIdentifier, ".g.cs"),

                    "application/octet-stream" when opt.DllOutDir is not null && elementId?.Contains("dll") == true
                        => ExtractBinaryAttachment(attachment, opt.DllOutDir, libraryIdentifier, ".dll"),

                    "application/octet-stream" when opt.PdbOutDir is not null && elementId?.Contains("pdb") == true
                        => ExtractBinaryAttachment(attachment, opt.PdbOutDir, libraryIdentifier, ".pdb"),

                    _ => false
                };

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

    private bool ExtractTextAttachment(Attachment attachment, DirectoryInfo outputDir, string libraryIdentifier, string extension)
    {
        try
        {
            if (attachment.Data is null)
            {
                logger.LogWarning("Attachment has no data: {ElementId}", attachment.ElementId);
                return false;
            }

            var data = attachment.Data;
            var text = Encoding.UTF8.GetString(data);
            var fileName = $"{libraryIdentifier}{extension}";
            var outputPath = Path.Combine(outputDir.FullName, fileName);

            if (!outputDir.Exists)
            {
                outputDir.Create();
            }

            File.WriteAllText(outputPath, text);
            logger.LogInformation("Extracted {Extension} to {OutputPath}", extension, outputPath);
            return true;
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Failed to extract text attachment: {ElementId}", attachment.ElementId);
            return false;
        }
    }

    private bool ExtractBinaryAttachment(Attachment attachment, DirectoryInfo outputDir, string libraryIdentifier, string extension)
    {
        try
        {
            if (attachment.Data is null)
            {
                logger.LogWarning("Attachment has no data: {ElementId}", attachment.ElementId);
                return false;
            }

            var data = attachment.Data;
            var fileName = $"{libraryIdentifier}{extension}";
            var outputPath = Path.Combine(outputDir.FullName, fileName);

            if (!outputDir.Exists)
            {
                outputDir.Create();
            }

            File.WriteAllBytes(outputPath, data);
            logger.LogInformation("Extracted {Extension} to {OutputPath}", extension, outputPath);
            return true;
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Failed to extract binary attachment: {ElementId}", attachment.ElementId);
            return false;
        }
    }

    internal static int CommandHandler(
        IConsole console,
        LoggingCommand loggingCommand,
        GlobalCommand globalCommand,
        LibraryExtractAttachmentsCommand extractAttachmentsCommand) =>
        RunProgram<LibraryExtractAttachmentsProgram>(
            console,
            loggingCommand,
            globalCommand,
            extractAttachmentsCommand.GetConfigMapping,
            (_, services) =>
                services.AddAndBindOptions<LibraryExtractAttachmentsOptions>());
}
