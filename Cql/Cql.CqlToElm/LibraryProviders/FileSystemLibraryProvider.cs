using Hl7.Cql.Elm;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm.LibraryProviders
{
    /// <summary>
    /// Provides libraries by interrogating the file system for matching libraries.  When a file is discovered
    /// that matches the requested library, it will be converted to a <see cref="Library"/> and cached.
    /// Subsequent changes to the library while not be observed without calling <see cref="ScanDirectory"/>.
    /// </summary>
    internal class FileSystemLibraryProvider : ILibraryProvider
    {

        public FileSystemLibraryProvider(IOptions<CqlToElmOptions> options,
            CqlToElmConverter converter,
            StreamInspector streamInspector,
            IServiceProvider services)
        {
            System.Diagnostics.Debug.WriteLine($"[{nameof(FileSystemLibraryProvider)}] Creating new instance.");
            var rootDirectory = options.Value.Input switch
            {
                { } => new DirectoryInfo(options.Value.Input),
                _ => new DirectoryInfo(".")
            };
            if (!rootDirectory.Exists)
                throw new ArgumentException($"Directory {rootDirectory} does not exist.");
            RootDirectory = rootDirectory;
            Converter = converter;
            StreamInspector = streamInspector;
            Services = services;
            Configuration = options.Value;
            Libraries = new(); // make case sensitivity configurable?
            LibrariesByFile = new();
            ScanDirectory();
        }


        internal void ScanDirectory()
        {
            if (Configuration.AssumeInputExtensions ?? true)
            {
                var cqlFiles = RootDirectory.GetFiles("*.cql", SearchOption.AllDirectories);
                for (int i = 0; i < cqlFiles.Length; i++)
                {
                    var file = cqlFiles[i];
                    using var stream = new FileStream(file.FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                    if (StreamInspector.TryCql(stream, out var li)
                        && li is not null
                        && li.VersionedIdentifier is not null)
                    {
                        var info = new LibraryInfo(file, li.Library);
                        Libraries.Add(li.VersionedIdentifier.id, li.VersionedIdentifier.version, info);
                        LibrariesByFile.Add(file, info);
                        
                    }
                }
                var jsonFiles = RootDirectory.GetFiles("*.json", SearchOption.AllDirectories);
                for (int i = 0; i < jsonFiles.Length; i++)
                {
                    var file = jsonFiles[i];
                    using var stream = new FileStream(file.FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                    if (StreamInspector.TryJsonLibrary(stream, out var li)
                        && li is not null
                        && li.VersionedIdentifier is not null)
                    {
                        var info = new LibraryInfo(file, li.Library);
                        Libraries.Add(li.VersionedIdentifier.id, li.VersionedIdentifier.version, info);
                        LibrariesByFile.Add(file, info);
                    }
                }
                var xmlFiles = RootDirectory.GetFiles("*.json", SearchOption.AllDirectories);
                for (int i = 0; i < xmlFiles.Length; i++)
                {
                    var file = xmlFiles[i];
                    using var stream = new FileStream(file.FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                    if (StreamInspector.TryXmlLibrary(stream, out var li)
                        && li is not null
                        && li.VersionedIdentifier is not null)
                    {
                        var info = new LibraryInfo(file, li.Library);
                        Libraries.Add(li.VersionedIdentifier.id, li.VersionedIdentifier.version, info);
                        LibrariesByFile.Add(file, info);
                    }
                }
            }
            else
            {
                var files = RootDirectory.GetFiles("*.*", SearchOption.AllDirectories);
                for (int i = 0; i < files.Length; i++)
                {
                    var file = files[i];
                    using var stream = new FileStream(file.FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                    if (StreamInspector.TryIdentify(stream, out var li)
                        && li is not null
                        && li.VersionedIdentifier is not null)
                    {
                        Libraries.Add(li.VersionedIdentifier.id, li.VersionedIdentifier.version, new LibraryInfo(file, li.Library));
                    }
                }
            }
        }

        public DirectoryInfo RootDirectory { get; }
        public CqlToElmConverter Converter { get; }
        private StreamInspector StreamInspector { get; }
        public IServiceProvider Services { get; }
        private CqlToElmOptions Configuration { get; }


        private class LibraryInfo
        {
            public LibraryInfo(FileInfo file, LibraryBuilder? library)
            {
                this.file = file;
                this.library = library;
            }
            public FileInfo file { get; set; }
            public LibraryBuilder? library { get; set; }
        }

        private Dictionary<FileInfo, LibraryInfo> LibrariesByFile { get; }
        private VersionedIdentifierDictionary<LibraryInfo> Libraries { get; }

        public bool TryAddLibrary(string libraryName, string? version, FileInfo location, LibraryBuilder library)
        {
            if (TryResolveLibrary(libraryName, version, out _, out _))
                return false;
            var info = new LibraryInfo(new FileInfo("in-memory"), library);
            Libraries.Add(libraryName, version, info);
            LibrariesByFile.Add(location, info);
            return true;
        }

        public bool TryResolveLibrary(FileInfo file, [NotNullWhen(true)] out LibraryBuilder? libraryBuilder)
        {
            if (LibrariesByFile.TryGetValue(file, out var li))
            {
                if (li.library is not null)
                {
                    libraryBuilder = li.library;
                    return true;
                }
            }
            libraryBuilder = null;
            return false;
        }

        public bool TryResolveLibrary(string libraryName, string? version, [NotNullWhen(true)] out LibraryBuilder? library, out string? error)
        {
            if (Libraries.TryGet(libraryName, version, out var lib))
            {
                if (lib.library is not null)
                    library = lib.library;
                else
                {
                    System.Diagnostics.Debug.WriteLine($"[{nameof(FileSystemLibraryProvider)}] Converting {lib.file}");
                    using var stream = lib.file.OpenRead();
                    var sr = new StreamReader(stream);
                    var cql = sr.ReadToEnd();
                    using var scope = Services.CreateScope();
                    library = Converter.GetBuilder(cql, scope);
                    lib.library = library;
                }
                error = null;
                return true;
            }
            else
            {
                library = null;
                error = null;
                return false;
            }
        }
    }
}
