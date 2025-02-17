using Hl7.Cql.Abstractions.Infrastructure;

namespace CqlSdkPrototype.Infrastructure;

public delegate void DirectoryInfoHandler(DirectoryInfo directory);

public static class DirectoryPreparationStrategy
{
    public static DirectoryInfoHandler CreateIfNotExists { get; } = d => d.Create();

    public static DirectoryInfoHandler Recreate { get; } = d => d.Recreate();

    private static EnumerationOptions DefaultEnumerationOptions { get; } = new();

    public static DirectoryInfoHandler CreateFileDeletionDirectoryHandler(
        string searchPattern = "*",
        EnumerationOptions? enumerationOptions = null,
        Func<FileInfo, bool>? fileSelector = null) =>
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
        };
}
