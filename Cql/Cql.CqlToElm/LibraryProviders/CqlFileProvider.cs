using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Hl7.Cql.CqlToElm.Grammar;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm.LibraryProviders
{
    internal class DiskStreamProvider: IStreamProvider
    {
        public DiskStreamProvider(IOptions<CqlToElmOptions> options)
        {
            var rootDirectory = options.Value.Input switch
            {
                { } => new DirectoryInfo(options.Value.Input),
                _ => new DirectoryInfo(".")
            };
            if (!rootDirectory.Exists)
                throw new ArgumentException($"Directory {rootDirectory} does not exist.");
            RootDirectory = rootDirectory;
            Configuration = options.Value;
            ScanDirectory();
        }

        private CqlToElmOptions Configuration { get; }
        private DirectoryInfo RootDirectory { get; }

        private VersionInfoListener Listener { get; } = new();

        private Dictionary<(string, string?), FileInfo> Files { get; } = new();

        public bool TryGet(string id, string? version, out Stream? stream)
        {
            if (Files.TryGetValue((id, version), out var file))
            {
                stream = new FileStream(file.FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                return true;
            }
            stream = null;
            return false;
        }

        internal void ScanDirectory()
        {
            var mask = "*.*";
            if (Configuration.AssumeInputExtensions ?? true)
                mask = "*.cql";
            var cqlFiles = RootDirectory.GetFiles(mask, SearchOption.AllDirectories);
            for (int i = 0; i < cqlFiles.Length; i++)
            {
                var file = cqlFiles[i];
                using var stream = new FileStream(file.FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                var antlStream = new AntlrInputStream(stream);
                var lexer = new cqlLexer(antlStream);
                lexer.RemoveErrorListeners();
                var parser = new cqlParser(new CommonTokenStream(lexer));
                Antlr4.Runtime.Tree.ParseTreeWalker.Default.Walk(Listener, parser.library());
            }



        }

        private class VersionInfoListener : cqlBaseListener
        {
            public override void EnterLibraryIdentifier([NotNull] cqlParser.LibraryIdentifierContext context)
            {
                base.EnterLibraryIdentifier(context);
            }
        }
    }
}
