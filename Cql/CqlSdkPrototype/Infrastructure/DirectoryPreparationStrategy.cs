using Hl7.Cql.Abstractions.Infrastructure;

namespace CqlSdkPrototype.Infrastructure;

public abstract class DirectoryPreparationStrategy
{
    public abstract void PrepareDirectory(DirectoryInfo directory); // Create delegate

    public static DirectoryPreparationStrategy CreateIfNotExists { get; } = new CreateIfNotExistsDirectoryPreparationStrategy();

    public static DirectoryPreparationStrategy Recreate { get; } = new RecreateDirectoryPreparationStrategy();

    public static DeleteFilesDirectoryPreparationStrategy CreateFileDeletorStragegy(
        string searchPattern = "*",
        EnumerationOptions? enumerationOptions = null,
        Func<FileInfo, bool>? fileSelector = null) =>
        new(searchPattern, enumerationOptions, fileSelector);
}

public class DelegatedDirectoryPreparationStrategy(Action<DirectoryInfo> prepareDirectory) : DirectoryPreparationStrategy
{
    public sealed override void PrepareDirectory(DirectoryInfo directory) => prepareDirectory(directory);
}

public class RecreateDirectoryPreparationStrategy() : DelegatedDirectoryPreparationStrategy(d => d.Recreate());

public class CreateIfNotExistsDirectoryPreparationStrategy() : DelegatedDirectoryPreparationStrategy(d => d.Create());

public class DeleteFilesDirectoryPreparationStrategy(
    string searchPattern = "*",
    EnumerationOptions? enumerationOptions = null,
    Func<FileInfo, bool>? fileSelector = null) : DelegatedDirectoryPreparationStrategy(
        d =>
        {
            if (d.Exists)
            {
                enumerationOptions ??= DefaultEnumerationOptions;
                fileSelector ??= IncludeFile;
                foreach (var file in d.EnumerateFiles(searchPattern, enumerationOptions).Where(fileSelector))
                    file.Delete();
            }
            else d.Create();

            static bool IncludeFile(FileInfo fi) => true;
        })
{
    public EnumerationOptions? Options { get; } = enumerationOptions;
    public Func<FileInfo, bool>? FileSelector { get; } = fileSelector;
    public string SearchPattern { get; } = searchPattern;
    private static readonly EnumerationOptions DefaultEnumerationOptions = new();
}