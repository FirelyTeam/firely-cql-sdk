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

            // Validate that all specified input files exist
            var missingFiles = new List<string>();
            
            if (opt.CqlFile != null && !opt.CqlFile.Exists)
                missingFiles.Add($"--cql-file: {opt.CqlFile.FullName}");
            
            if (opt.ElmFile != null && !opt.ElmFile.Exists)
                missingFiles.Add($"--elm-file: {opt.ElmFile.FullName}");
            
            if (opt.CSharpFile != null && !opt.CSharpFile.Exists)
                missingFiles.Add($"--csharp-file: {opt.CSharpFile.FullName}");
            
            if (opt.DllFile != null && !opt.DllFile.Exists)
                missingFiles.Add($"--dll-file: {opt.DllFile.FullName}");
            
            if (opt.PdbFile != null && !opt.PdbFile.Exists)
                missingFiles.Add($"--pdb-file: {opt.PdbFile.FullName}");

            if (missingFiles.Count > 0)
            {
                logger.LogError("The following input files do not exist:");
                foreach (var file in missingFiles)
                {
                    logger.LogError("  {MissingFile}", file);
                }
                logger.LogError("All specified attachment input files must exist before processing can begin.");
                return ExitCode.NoInputFiles;
            }

            // Determine the output file
            FileInfo outputFile;
            if (opt.LibraryOutFile != null)
            {
                // Copy library-file to library-out-file
                try
                {
                    logger.LogInformation("Copying library file from: {SourceFile} to: {DestFile}", opt.LibraryFile.FullName, opt.LibraryOutFile.FullName);
                    
                    // Ensure output directory exists
                    var outDir = opt.LibraryOutFile.Directory;
                    if (outDir != null && !outDir.Exists)
                    {
                        outDir.Create();
                    }
                    
                    File.Copy(opt.LibraryFile.FullName, opt.LibraryOutFile.FullName, overwrite: true);
                    logger.LogInformation("Library file copied successfully.");
                    outputFile = opt.LibraryOutFile;
                }
                catch (Exception ex)
                {
                    logger.LogError(ex, "Failed to copy library file to output location: {OutFile}", opt.LibraryOutFile.FullName);
                    return ExitCode.UnknownError;
                }
            }
            else
            {
                // Update in-place
                logger.LogInformation("Updating library file in-place: {LibraryFile}", opt.LibraryFile.FullName);
                outputFile = opt.LibraryFile;
            }

            // Read and parse the FHIR library from the output file
            logger.LogInformation("Reading FHIR library from: {LibraryFile}", outputFile.FullName);
            var libraryJson = File.ReadAllText(outputFile.FullName);

            Library library;
            try
            {
                library = JsonSerializer.Deserialize<Library>(libraryJson, new JsonSerializerOptions().ForFhir(ModelInfo.ModelInspector))
                    ?? throw new InvalidOperationException($"Failed to deserialize FHIR library from {outputFile.FullName}. Please verify the file contains valid FHIR Library JSON.");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Failed to parse FHIR library JSON from {LibraryFile}. Please verify the file contains valid FHIR Library JSON.", outputFile.FullName);
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

            File.WriteAllText(outputFile.FullName, updatedLibraryJson);
            logger.LogInformation("Updated FHIR library saved to: {LibraryFile}", outputFile.FullName);

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

        // This should not happen as we validate file existence upfront
        if (!attachmentFile.Exists)
        {
            throw new InvalidOperationException($"Attachment file does not exist: {attachmentFile.FullName}. This should have been caught during validation.");
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
