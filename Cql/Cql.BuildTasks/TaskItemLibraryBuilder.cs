using Hl7.Cql.CqlToElm;
using Hl7.Cql.CqlToElm.LibraryProviders;
using Microsoft.Build.Framework;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.Tools.BuildTasks
{
    // TODO: this class is similar to FileSystemLibraryProvider, consider merging them
    // Main difference is that FileSystemLibraryProvider scans directories to find librararies,
    // whereas this one accepts them explicitly
    internal class TaskItemLibraryProvider : ILibraryProvider
    {
        public TaskItemLibraryProvider(CqlToElmConverter converter, StreamInspector streamInspector,
             IServiceProvider services)
        {
            Converter = converter;
            StreamInspector = streamInspector;
            Services = services;
        }

        private Dictionary<FileInfo, LibraryInfo> LibrariesByFile { get; } = new();

        private VersionedIdentifierDictionary<LibraryInfo> Libraries { get; } = new();
        public CqlToElmConverter Converter { get; }
        public StreamInspector StreamInspector { get; }
        public IServiceProvider Services { get; }

        public void SetItems(ITaskItem[] items)
        {
            var files = items.FlattenToFiles();
            foreach (var file in files)
            {
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
        }

        public bool TryResolveLibrary(FileInfo file, [NotNullWhen(true)] out LibraryBuilder libraryBuilder)
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

        public bool TryResolveLibrary(string libraryName, string version, [NotNullWhen(true)] out LibraryBuilder library, out string error)
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

        public bool TryAddLibrary(string libraryName, string version, FileInfo location, LibraryBuilder library)
        {
            if (TryResolveLibrary(libraryName, version, out _, out _))
                return false;
            var info = new LibraryInfo(location, library);
            Libraries.Add(libraryName, version, info);
            LibrariesByFile.Add(location, info);
            return true;
        }

        public IEnumerable<LibraryBuilder> All => Libraries!
            .SelectMany(kvp => kvp.Value.Select(li => li.library!))
            .Where(lb => lb is not null);

        private class LibraryInfo
        {
            public LibraryInfo(FileInfo file, LibraryBuilder library)
            {
                this.file = file;
                this.library = library;
            }
            public FileInfo file { get; set; }
            public LibraryBuilder library { get; set; }
        }
    }
}
