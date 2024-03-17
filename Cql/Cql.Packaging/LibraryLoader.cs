using Hl7.Cql.Compiler;

namespace Hl7.Cql.Packaging;

#pragma warning disable CS1591

public static class LibraryLoader
{
    public static LibrarySet LoadLibraries(DirectoryInfo elmDir)
    {
        var files = elmDir.GetFiles("*.json", SearchOption.AllDirectories);
        LibrarySet librarySet = new(elmDir.FullName);
        librarySet.LoadLibraries(files);
        return librarySet;
    }
}