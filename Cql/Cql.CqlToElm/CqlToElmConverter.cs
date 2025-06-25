using Antlr4.Runtime;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.CqlToElm.Visitors;
using Hl7.Cql.Elm;

namespace Hl7.Cql.CqlToElm
{
    /// <summary>
    /// Converts CQL To ELM.
    /// </summary>
    public class CqlToElmConverter
    {
        /// <summary>
        /// Converts CQL To ELM.
        /// </summary>
        public CqlToElmConverter(IServiceProvider services,
            ILogger<CqlToElmConverter> logger)
        {
            Services = services;
            Logger = logger;
        }

        /// <summary>
        /// CQL to Elm IServiceProvider
        /// </summary>
        private IServiceProvider Services { get; }

        /// <summary>
        /// CQL to Elm Logger
        /// </summary>
        private ILogger<CqlToElmConverter> Logger { get; }

        /// <summary>
        /// Converts the CQL contained in <paramref name="cqlLibrary"/> to an ELM <see cref="Library"/>.
        /// </summary>
        /// <param name="cqlLibrary">A <see cref="TextReader"/> which contains a complete CQL library</param>
        /// <returns>The <see cref="Library"/> which represents this CQL.</returns>
        /// <exception cref="ArgumentException">if <paramref name="cqlLibrary"/> is empty.</exception>
        public Library ConvertLibrary(TextReader cqlLibrary) => ConvertLibrary(cqlLibrary.ReadToEnd());

        /// <summary>
        /// Converts the CQL contained in <paramref name="cqlLibrary"/> to an ELM <see cref="Library"/>.
        /// </summary>
        /// <param name="cqlLibrary">A <see cref="Stream"/> which contains a complete CQL library</param>
        /// <returns>The <see cref="Library"/> which represents this CQL.</returns>
        /// <exception cref="ArgumentException">if <paramref name="cqlLibrary"/> is empty.</exception>
        public Library ConvertLibrary(Stream cqlLibrary) => ConvertLibrary(new StreamReader(cqlLibrary));

        /// <summary>
        /// Converts the CQL contained in <paramref name="cql"/> to an ELM <see cref="Library"/>.
        /// </summary>
        /// <param name="cql">A <see cref="string"/> which contains a complete CQL library</param>
        /// <returns>The <see cref="Library"/> which represents this CQL.</returns>
        /// <exception cref="ArgumentException">if <paramref name="cql"/> is empty.</exception>
        public Library ConvertLibrary(string cql)
        {
            using var scope = Services.CreateScope();
            var libraryVisitorScoped = scope.GetLibraryVisitorScoped();
            var libraryBuilder = GetBuilder(libraryVisitorScoped, cql);
            var lib = libraryBuilder.Build();
           if (lib.GetErrors().Any(e => e.errorSeverity == ErrorSeverity.error))
                Logger.LogWarning("Parsed ELM tree contains errors.");
            return lib;
        }

        internal LibraryBuilder GetBuilder(LibraryVisitor libraryVisitor, string cql)
        {
            using var cqlLibrary = new StringReader(cql);
            return GetBuilder(libraryVisitor, cqlLibrary);
        }

        internal LibraryBuilder GetBuilder(LibraryVisitor libraryVisitor, TextReader cqlReader)
        {
            var libraryContext = ParseLibrary(cqlReader);
            var libraryBuilder = libraryVisitor.Visit(libraryContext);
            return libraryBuilder;
        }


        internal static cqlParser.LibraryContext ParseLibrary(TextReader cqlLibrary)
        {
            if (cqlLibrary.Peek() < 0)
                throw new ArgumentException(@"The provided text reader is empty and cannot be read.", nameof(cqlLibrary));

            var errorListener = new ThrowingErrorListener();

            var antlStream = new AntlrInputStream(cqlLibrary);
            var lexer = new cqlLexer(antlStream);
            lexer.RemoveErrorListeners();
            lexer.AddErrorListener(errorListener);

            var parser = new cqlParser(new CommonTokenStream(lexer));
            parser.RemoveErrorListeners();
            parser.AddErrorListener(errorListener);

            return parser.library();
        }


        private class ThrowingErrorListener : IAntlrErrorListener<int>, IAntlrErrorListener<IToken>
        {
            public void SyntaxError(TextWriter output, IRecognizer recognizer, int offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)
            {
                throw new InvalidOperationException($"Syntax error on line {line} position {charPositionInLine}: {msg}");
            }

            public void SyntaxError(TextWriter output, IRecognizer recognizer, IToken offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)
            {
                throw new InvalidOperationException($"Syntax error on line {line} position {charPositionInLine}: {msg}");
            }
        }
    }
}