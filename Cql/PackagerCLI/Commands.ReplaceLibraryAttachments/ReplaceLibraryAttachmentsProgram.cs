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
using Hl7.Cql.Packaging;
using Hl7.Fhir.Model;

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
            if (opt is { CqlFile: null, ElmFile: null, CSharpFile: null, DllFile: null, PdbFile: null })
            {
                logger.LogError("At least one attachment file must be specified (--cql-file, --elm-file, --csharp-file, --dll-file, or --pdb-file).");
                return ExitCode.NoInputFiles;
            }

            // Validate that all specified input files exist
            var missingFiles = new List<string>();

            if (opt.CqlFile is { Exists: false })
                missingFiles.Add($"--cql-file: {opt.CqlFile.FullName}");

            if (opt.ElmFile is { Exists: false })
                missingFiles.Add($"--elm-file: {opt.ElmFile.FullName}");

            if (opt.CSharpFile is { Exists: false })
                missingFiles.Add($"--csharp-file: {opt.CSharpFile.FullName}");

            if (opt.DllFile is { Exists: false })
                missingFiles.Add($"--dll-file: {opt.DllFile.FullName}");

            if (opt.PdbFile is { Exists: false })
                missingFiles.Add($"--pdb-file: {opt.PdbFile.FullName}");

            if (missingFiles.Count > 0)
            {
                var filesPluralized = missingFiles.Count > 1 ? "files do" : "file does";
                var missingFilesNewLines = string.Join(Environment.NewLine, missingFiles);
                var template = $$"""The following {{filesPluralized}} not exist:{{Environment.NewLine}}{MissingFiles}{{Environment.NewLine}}All specified attachment input files must exist before processing can begin.""";
                logger.LogError(template, missingFilesNewLines);
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
                    if (outDir is { Exists: false })
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

            FhirLibrary library;
            try
            {
                library = FhirLibrary.ReadLibraryFromJson(libraryJson);
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

            var libraryIdentifier = CqlVersionedLibraryIdentifier.ParseFromIdentifierAndVersion(library.Name, library.Version);
            logger.LogInformation("Processing library: {LibraryIdentifier}", libraryIdentifier);

            // Replace or add attachments
            ReplaceOrAddAttachment(library, opt.CqlFile, libraryIdentifier, "+cql");
            ReplaceOrAddAttachment(library, opt.ElmFile, libraryIdentifier, "+elm");
            ReplaceOrAddAttachment(library, opt.CSharpFile, libraryIdentifier, "+csharp");
            ReplaceOrAddAttachment(library, opt.DllFile, libraryIdentifier, "+dll");
            ReplaceOrAddAttachment(library, opt.PdbFile, libraryIdentifier, "+pdb");

            logger.LogInformation("Attachments processed successfully.");

            // Serialize and save the updated library
            var updatedLibraryJson = library.WriteLibraryToJson(packOpt.JsonPretty);

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

    private void ReplaceOrAddAttachment(
        FhirLibrary library,
        FileInfo? attachmentFile,
        CqlVersionedLibraryIdentifier libraryIdentifier,
        string idSuffix)
    {
        if (attachmentFile == null)
            return;

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
            return;
        }

        library.ReplaceOrAddAttachment(libraryIdentifier, idSuffix, data);
        logger.LogInformation("Processed {Suffix} attachment (ID: {AttachmentId})", idSuffix, $"{libraryIdentifier}{idSuffix}");
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
