namespace Hl7.Cql.Packaging;

#pragma warning disable CS1591

// TODO: Remove?
public static class LibraryLoader
{
    // TODO: Remove?
    public static IDictionary<string, Elm.Library> LoadLibraries(DirectoryInfo elmDir)
    {
        // Load libraries from ELM files in a deterministic order

        (FileInfo file, int index)[] input = elmDir
            .GetFiles("*.json", SearchOption.AllDirectories)
            .OrderBy(f => f.FullName)
            .Select((file, index) => (file, index))
            .ToArray();

        Elm.Library[] libraries = new Elm.Library[input.Length];

        Parallel.ForEach(input, tuple =>
        {
            var library = Elm.Library.LoadFromJson(tuple.file);
            if (library?.NameAndVersion != null)
            {
                libraries[tuple.index] = library;
            }
        });

        var dict = new Dictionary<string, Elm.Library>();
        foreach (var library in libraries)
        {
            if (library?.NameAndVersion != null)
            {
                dict.TryAdd(library.NameAndVersion, library);
            }
        }

        return dict;
    }
}