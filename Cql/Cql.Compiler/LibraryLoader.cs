using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Hl7.Cql.Abstractions.Exceptions;
using Hl7.Cql.Compiler.Infrastructure;
using Hl7.Cql.Elm;

namespace Hl7.Cql.Compiler;

internal class LibraryLoader
{
    // public HashSet<Library> LoadLibraries(
    //     IReadOnlyCollection<FileInfo> files,
    //     HashSet<Library>? intoLibraries = null)
    // {
    //     // Loading libraries in parallel
    //
    //     (FileInfo file, int index)[] input = files
    //         .Select((file, ordinal) => (file, index: ordinal))
    //         .ToArray();
    //
    //     var librariesArr = new Library[input.Length];
    //
    //     Parallel.ForEach(input, t =>
    //     {
    //         var library = LoadLibrary(t.file);
    //         librariesArr[t.index] = library;
    //     });
    //
    //     if (intoLibraries is null)
    //     {
    //         intoLibraries = new(librariesArr);
    //     }
    //     else
    //     {
    //         intoLibraries.AddRange(librariesArr);
    //     }
    //
    //     return intoLibraries;
    // }
    
    public static Library LoadLibrary(FileInfo fileInfo)
    {
        var library = Library.LoadFromJson(fileInfo) ?? throw new NotAValidLibraryFileError(fileInfo.FullName).ToException();
        // if (string.IsNullOrEmpty(library.GetNameAndVersion()))
        // {
        //     throw new LibraryMissingNameAndVersionError(fileInfo.FullName, library).ToException();
        // }
    
        return library;
    }
    //
    // public HashSet<Library> LoadLibraryAndDependencies(
    //     DirectoryInfo directory,
    //     string libraryName, 
    //     string libraryVersion,
    //     bool includeDependencies = true,
    //     HashSet<Library>? intoLibraries = null)
    // {
    //     var elmFile = GetFileInfoByNameAndVersion(directory, libraryName, libraryVersion);
    //     var library = LoadLibrary(elmFile);
    //
    //     intoLibraries ??= new();
    //     intoLibraries.Add(library);
    //
    //     if (includeDependencies)
    //     {
    //         intoLibraries = LoadLibraryDependencies(library, directory, intoLibraries);
    //     }
    //
    //     return intoLibraries;
    // }
    //
    // private HashSet<Library> LoadLibraryDependencies(
    //     Library library, 
    //     DirectoryInfo directory,
    //     HashSet<Library> intoLibraries)
    // {
    //     var fileInfos = library.includes
    //         .Select(includeDef => includeDef.NameAndVersion(false) ?? throw new LibraryMissingIncludeDefPathError(library, includeDef).ToException())
    //         .Where(includeNameAndVersion => intoLibraries.All(lib => lib.NameAndVersion! != includeNameAndVersion))
    //         .Select(key => key.Split('-', 2))
    //         .Select(arr => GetFileInfoByNameAndVersion(directory, arr[0], arr.ElementAtOrDefault(1)))
    //         .ToList();
    //
    //     if (fileInfos.Any())
    //     {
    //         var loaded = LoadLibraries(fileInfos).Except(intoLibraries);
    //     }
    //
    //     return intoLibraries;
    // }
    //
    public FileInfo GetFileInfoByNameAndVersion(
        DirectoryInfo directory, 
        string libraryName,
        string? libraryVersion = null)
    {
        FileInfo elmFile;
    
        if (libraryVersion != null)
        {
            elmFile = new FileInfo(Path.Combine(directory.FullName, $"{libraryName}-{libraryVersion}.json"));
            if (elmFile.Exists)
                return elmFile;
        }
        
        elmFile = new FileInfo(Path.Combine(directory.FullName, $"{libraryName}.json"));
        if (!elmFile.Exists)
            throw new CannotFindLibraryInDirectoryError(directory.FullName, libraryName, null).ToException();
    
        return elmFile;
    }
}

