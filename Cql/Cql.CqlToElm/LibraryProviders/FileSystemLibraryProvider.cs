using Hl7.Cql.Elm;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
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

        //public static FileSystemLibraryProvider Create(IServiceProvider services)
        //{
        //    var config = services.GetRequiredService<IOptions<CqlToElmOptions>>().Value;
        //    var rootDirectory = config.Input switch
        //    {
        //        { } => new DirectoryInfo(config.Input),
        //        _ => new DirectoryInfo(".")
        //    };
        //    if (!rootDirectory.Exists)
        //        throw new ArgumentException($"Directory {rootDirectory} does not exist.");
        //    var converter = services.GetRequiredService<CqlToElmConverter>();
        //    var inspector = services.GetRequiredService<StreamInspector>();
        //    var lp = new FileSystemLibraryProvider(rootDirectory, converter, inspector);
        //    lp.ScanDirectory();
        //    return lp;
        //}


        internal FileSystemLibraryProvider(DirectoryInfo rootDirectory, 
            Func<Stream, Library> converter,
            StreamInspector streamInspector)
        {
            RootDirectory = rootDirectory;
            Converter = converter;
            StreamInspector = streamInspector;
            Libraries = new(); // make case sensitivity configurable?
        }


        internal void ScanDirectory()
        {
            var files = RootDirectory.GetFiles("*.*", SearchOption.AllDirectories);
            for(int i = 0; i < files.Length; i++)
            {
                var file = files[i];
                using var stream = new FileStream(file.FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                if (StreamInspector.TryIdentify(stream, out var li) 
                    && li is not null 
                    && li.VersionedIdentifier is not null)
                {
                    var lib = li.Library ?? Converter(stream);
                    Libraries.Add(li.VersionedIdentifier.id, li.VersionedIdentifier.version, lib);
                }
            }
        }

        public DirectoryInfo RootDirectory { get; }
        public Func<Stream, Library> Converter { get; }
        private StreamInspector StreamInspector { get; }
        
        private VersionedIdentifierDictionary<Library> Libraries { get; }

        public bool TryResolveLibrary(string libraryName, string? version, out Library? library, out string? error)
        {
            if (Libraries.TryGet(libraryName, version, out var lib))
            {
                library = lib;
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
