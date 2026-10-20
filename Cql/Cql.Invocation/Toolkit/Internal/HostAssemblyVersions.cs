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
/// <para>
/// A lookup costs dictionary lookups only, whether it finds a version or not. The versions of the assemblies the
/// default load context has loaded are kept by name, from a snapshot taken on the first lookup and kept current by
/// <see cref="AppDomain.AssemblyLoad"/>, so an assembly the host loads there later is found from then on. They stay
/// valid, as that context neither unloads an assembly nor loads a second one of the same name.
/// </para>
/// <para>
/// No assembly is loaded: the version of one the trusted platform assemblies list is read from its file's metadata,
/// once, as that list is fixed for the life of the process. A name it does not hold is a miss without reading
/// anything.
/// </para>
/// </remarks>
internal static class HostAssemblyVersions
{
    private static readonly Lazy<ConcurrentDictionary<string, Version>> LoadedVersions = new(TrackLoadedVersions);

    private static readonly Lazy<FrozenDictionary<string, string>> TrustedPlatformAssemblyPaths =
        new(ReadTrustedPlatformAssemblyPaths);

    /// <summary>
    /// The versions read so far of the trusted platform assemblies, by simple name; <see langword="null"/> for one
    /// whose version cannot be read. Holds only names the list holds.
    /// </summary>
    private static readonly ConcurrentDictionary<string, Version?> TrustedPlatformAssemblyVersions =
        new(StringComparer.OrdinalIgnoreCase);

    /// <summary>
    /// Finds the version of the host's assembly of the given simple name, which compares without regard to case, as
    /// the runtime compares it.
    /// </summary>
    /// <returns>
    /// The version, or <see langword="null"/> when the host has no assembly of that name whose version can be read.
    /// </returns>
    public static Version? Find(string assemblyName) =>
        LoadedVersions.Value.TryGetValue(assemblyName, out var version)
            ? version
            : FindTrustedPlatformAssembly(assemblyName);

    private static Version? FindTrustedPlatformAssembly(string assemblyName) =>
        TrustedPlatformAssemblyPaths.Value.TryGetValue(assemblyName, out var path)
            ? TrustedPlatformAssemblyVersions.GetOrAdd(assemblyName, static (_, path) => ReadVersion(path), path)
            : null;

    private static Version? ReadVersion(string path)
    {
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
    /// Keeps the versions of the assemblies the default load context has loaded, by simple name: those it holds now,
    /// and each it loads from now on. Subscribes before it takes the snapshot, so that no load in between is missed.
    /// </summary>
    private static ConcurrentDictionary<string, Version> TrackLoadedVersions()
    {
        var versions = new ConcurrentDictionary<string, Version>(StringComparer.OrdinalIgnoreCase);
        AppDomain.CurrentDomain.AssemblyLoad += (_, loaded) => AddIfInTheDefaultContext(versions, loaded.LoadedAssembly);
        foreach (var assembly in AssemblyLoadContext.Default.Assemblies)
            AddIfInTheDefaultContext(versions, assembly);

        return versions;
    }

    /// <summary>
    /// Keeps the version of an assembly the default load context has loaded, unless one of its name is kept already.
    /// </summary>
    /// <remarks>
    /// Never throws, as it runs for every assembly the process loads, where an exception would fail that load.
    /// </remarks>
    private static void AddIfInTheDefaultContext(ConcurrentDictionary<string, Version> versions, Assembly assembly)
    {
        try
        {
            if (AssemblyLoadContext.GetLoadContext(assembly) != AssemblyLoadContext.Default)
                return;

            var name = assembly.GetName();
            if (name.Name is { } simpleName && name.Version is { } version)
                versions.TryAdd(simpleName, version);
        }
        catch (Exception exception) when (exception is not OutOfMemoryException)
        {
            // An assembly whose name cannot be read is no assembly a reference can name either.
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
