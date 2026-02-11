/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Packager.Commands.Global;
using Hl7.Cql.Packager.Commands.Logging;
using Hl7.Cql.Packager.Options;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace Hl7.Cql.Packager.Commands.ReplaceLibraryAttachments;

internal sealed class ReplaceLibraryAttachmentsProgram
(
    ILogger<ReplaceLibraryAttachmentsProgram> logger,
    IOptions<PackagingOptions> packagingOptions,
    IOptions<ReplaceLibraryAttachmentsOptions> replaceLibraryAttachmentsOptions) : IProgram
{
    public int Run()
    {
        try
        {
            var opt = replaceLibraryAttachmentsOptions.Value;
            var packOpt = packagingOptions.Value;

            // Validate that at least one attachment file is provided
            if (opt.CqlFile == null && opt.ElmFile == null && opt.CSharpFile == null &&
                opt.DllFile == null && opt.PdbFile == null)
            {
                logger.LogError("At least one attachment file must be specified (--cql-file, --elm-file, --csharp-file, --dll-file, or --pdb-file).");
                return ExitCode.NoInputFiles;
            }

            // Read and parse the FHIR library
            logger.LogInformation("Reading FHIR library from: {LibraryFile}", opt.LibraryFile.FullName);
            var libraryJson = File.ReadAllText(opt.LibraryFile.FullName);

            Library library;
            try
            {
                library = JsonSerializer.Deserialize<Library>(libraryJson, new JsonSerializerOptions().ForFhir(ModelInfo.ModelInspector))
                    ?? throw new InvalidOperationException($"Failed to deserialize FHIR library from {opt.LibraryFile.FullName}. Please verify the file contains valid FHIR Library JSON.");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Failed to parse FHIR library JSON from {LibraryFile}. Please verify the file contains valid FHIR Library JSON.", opt.LibraryFile.FullName);
                return ExitCode.InvalidLibraryJson;
            }

            // Get the library identifier for building attachment IDs
            if (string.IsNullOrWhiteSpace(library.Name) || string.IsNullOrWhiteSpace(library.Version))
            {
                logger.LogError("Library must have both Name and Version properties.");
                return ExitCode.InvalidLibraryJson;
            }

            var libraryIdentifier = $"{library.Name}-{library.Version}";
            logger.LogInformation("Processing library: {LibraryIdentifier}", libraryIdentifier);

            // Ensure Content collection is initialized
            library.Content ??= [];

            // Replace or add attachments
            int replacedCount = 0;
            int addedCount = 0;

            var (replaced, added) = ReplaceOrAddAttachment(library, opt.CqlFile, libraryIdentifier, "+cql", "text/cql");
            replacedCount += replaced;
            addedCount += added;

            (replaced, added) = ReplaceOrAddAttachment(library, opt.ElmFile, libraryIdentifier, "+elm", "application/elm+json");
            replacedCount += replaced;
            addedCount += added;

            (replaced, added) = ReplaceOrAddAttachment(library, opt.CSharpFile, libraryIdentifier, "+csharp", "text/plain");
            replacedCount += replaced;
            addedCount += added;

            (replaced, added) = ReplaceOrAddAttachment(library, opt.DllFile, libraryIdentifier, "+dll", "application/octet-stream");
            replacedCount += replaced;
            addedCount += added;

            (replaced, added) = ReplaceOrAddAttachment(library, opt.PdbFile, libraryIdentifier, "+pdb", "application/octet-stream");
            replacedCount += replaced;
            addedCount += added;

            logger.LogInformation("Replaced {ReplacedCount} attachment(s), added {AddedCount} new attachment(s).", replacedCount, addedCount);

            // Serialize and save the updated library
            var jsonOptions = new JsonSerializerOptions().ForFhir(ModelInfo.ModelInspector);
            jsonOptions.WriteIndented = packOpt.JsonPretty;
            var updatedLibraryJson = JsonSerializer.Serialize(library, jsonOptions);

            File.WriteAllText(opt.LibraryFile.FullName, updatedLibraryJson);
            logger.LogInformation("Updated FHIR library saved to: {LibraryFile}", opt.LibraryFile.FullName);

            return ExitCode.Normal;
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "An unexpected error occurred.");
            return ExitCode.UnknownError;
        }
    }

    private (int replaced, int added) ReplaceOrAddAttachment(
        Library library,
        FileInfo? attachmentFile,
        string libraryIdentifier,
        string idSuffix,
        string contentType)
    {
        if (attachmentFile == null)
            return (0, 0);

        if (!attachmentFile.Exists)
        {
            logger.LogWarning("Attachment file not found, skipping: {FilePath}", attachmentFile.FullName);
            return (0, 0);
        }

        logger.LogInformation("Processing {Suffix} attachment from: {FilePath}", idSuffix, attachmentFile.FullName);

        // Read the attachment data
        byte[] data;
        try
        {
            data = File.ReadAllBytes(attachmentFile.FullName);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Failed to read attachment file: {FilePath}", attachmentFile.FullName);
            return (0, 0);
        }

        var attachmentId = $"{libraryIdentifier}{idSuffix}";

        // Find existing attachment with this ID (ensure ElementId is not null)
        var existingAttachment = library.Content.FirstOrDefault(a => a.ElementId != null && a.ElementId == attachmentId);

        if (existingAttachment != null)
        {
            // Replace existing attachment
            existingAttachment.ContentType = contentType;
            existingAttachment.Data = data;
            logger.LogInformation("Replaced existing {Suffix} attachment (ID: {AttachmentId})", idSuffix, attachmentId);
            return (1, 0);
        }
        else
        {
            // Add new attachment
            var newAttachment = new Attachment
            {
                ElementId = attachmentId,
                ContentType = contentType,
                Data = data
            };
            library.Content.Add(newAttachment);
            logger.LogInformation("Added new {Suffix} attachment (ID: {AttachmentId})", idSuffix, attachmentId);
            return (0, 1);
        }
    }

    internal static int CommandHandler(
        IConsole console,
        LoggingCommand loggingCommand,
        GlobalCommand globalCommand,
        ReplaceLibraryAttachmentsCommand replaceLibraryAttachmentsCommand) =>
        RunProgram<ReplaceLibraryAttachmentsProgram>(
            console,
            loggingCommand,
            globalCommand,
            replaceLibraryAttachmentsCommand.GetConfigMapping,
            (_, services) =>
                services.AddAndBindOptions<ReplaceLibraryAttachmentsOptions>());
}
