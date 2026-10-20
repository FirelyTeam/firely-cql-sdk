/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Invocation.Toolkit.Internal;

/// <summary>
/// Finds the version of the host's assembly of a name, where the toolkit binds a reference to it: the toolkit's load
/// contexts resolve no assembly themselves, so they bind a reference to an assembly outside the toolkit through the
/// default load context, which binds it to the assembly of that name it has loaded, or else to the one its trusted
/// platform assemblies list, and only when that one is of at least the version referenced.
/// </summary>
/// <remarks>
/// No assembly is loaded: the version of one the trusted platform assemblies list is read from its file's metadata. A
/// version once found is kept, as the default load context neither unloads an assembly nor loads a second one of the
/// same name, and the trusted platform assemblies are fixed for the life of the process.
/// </remarks>
internal static class HostAssemblyVersions
{
    private static readonly ConcurrentDictionary<string, Version> Versions = new(StringComparer.OrdinalIgnoreCase);

    private static readonly Lazy<FrozenDictionary<string, string>> TrustedPlatformAssemblyPaths =
        new(ReadTrustedPlatformAssemblyPaths);

    /// <summary>
    /// Finds the version of the host's assembly of the given simple name, which compares without regard to case, as
    /// the runtime compares it.
    /// </summary>
    /// <returns>
    /// The version, or <see langword="null"/> when the host has no assembly of that name whose version can be read.
    /// </returns>
    public static Version? Find(string assemblyName)
    {
        if (Versions.TryGetValue(assemblyName, out var version))
            return version;

        version = FindLoaded(assemblyName) ?? FindTrustedPlatformAssembly(assemblyName);
        return version is null ? null : Versions.GetOrAdd(assemblyName, version);
    }

    private static Version? FindLoaded(string assemblyName)
    {
        foreach (var assembly in AssemblyLoadContext.Default.Assemblies)
        {
            var name = assembly.GetName();
            if (string.Equals(name.Name, assemblyName, StringComparison.OrdinalIgnoreCase))
                return name.Version;
        }

        return null;
    }

    private static Version? FindTrustedPlatformAssembly(string assemblyName)
    {
        if (!TrustedPlatformAssemblyPaths.Value.TryGetValue(assemblyName, out var path))
            return null;

        try
        {
            return AssemblyName.GetAssemblyName(path).Version;
        }
        catch (Exception exception) when (exception is not OutOfMemoryException)
        {
            // A file that cannot be read is no assembly the default load context can bind a reference to either.
            return null;
        }
    }

    /// <summary>
    /// The paths of the trusted platform assemblies, by simple name, which the runtime takes from the file name.
    /// </summary>
    private static FrozenDictionary<string, string> ReadTrustedPlatformAssemblyPaths()
    {
        Dictionary<string, string> paths = new(StringComparer.OrdinalIgnoreCase);
        if (AppContext.GetData("TRUSTED_PLATFORM_ASSEMBLIES") is string trustedPlatformAssemblies)
        {
            foreach (var path in trustedPlatformAssemblies.Split(Path.PathSeparator, StringSplitOptions.RemoveEmptyEntries))
                paths.TryAdd(Path.GetFileNameWithoutExtension(path), path);
        }

        return paths.ToFrozenDictionary(StringComparer.OrdinalIgnoreCase);
    }
}
