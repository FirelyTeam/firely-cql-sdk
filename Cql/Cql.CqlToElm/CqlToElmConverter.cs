using Antlr4.Runtime;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.CqlToElm.Visitors;
using Hl7.Cql.Elm;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;

namespace Hl7.Cql.CqlToElm
{
    /// <summary>
    /// Converts CQL To ELM.
    /// </summary>
    internal class CqlToElmConverter
    {
        /// <summary>
        /// Constructs an instance.
        /// </summary>
        /// <param name="services">The service provider.</param>
        public CqlToElmConverter(IServiceProvider services)
        {
            Services = services;
        }

        internal IServiceProvider Services { get; }

        /// <summary>
        /// Converts the CQL contained in <paramref name="cqlLibrary"/> to an ELM <see cref="Library"/>.
        /// </summary>
        /// <param name="cqlLibrary">A <see cref="TextReader"/> which contains a complete CQL library</param>
        /// <returns>The <see cref="Library"/> which represents this CQL.</returns>
        /// <exception cref="ArgumentException">if <paramref name="cqlLibrary"/> is empty.</exception>
        public Library ConvertLibrary(TextReader cqlLibrary)
        {
            if (cqlLibrary.Peek() < 0)
                throw new ArgumentException("The provided text reader is empty and cannot be read.", nameof(cqlLibrary));

            var lexerListener = new ThrowingErrorListener();
            var parserListener = lexerListener;
            
            var antlStream = new AntlrInputStream(cqlLibrary);
            var lexer = new cqlLexer(antlStream);
            lexer.RemoveErrorListeners();
            lexer.AddErrorListener(lexerListener);

            var parser = new cqlParser(new CommonTokenStream(lexer));
            parser.RemoveErrorListeners();
            parser.AddErrorListener(parserListener);

            using (var scope = Services.CreateScope())
            {
                var libCtx = scope.ServiceProvider.GetRequiredService<LibraryContext>();
                var visitor = scope.ServiceProvider.GetRequiredService<LibraryVisitor>();
                var library = visitor.Visit(parser.library());
                return library;
            }
        }

        /// <summary>
        /// Converts the CQL contained in <paramref name="cqlLibrary"/> to an ELM <see cref="Library"/>.
        /// </summary>
        /// <param name="cqlLibrary">A <see cref="Stream"/> which contains a complete CQL library</param>
        /// <returns>The <see cref="Library"/> which represents this CQL.</returns>
        /// <exception cref="ArgumentException">if <paramref name="cqlLibrary"/> is empty.</exception>
        public Library ConvertLibrary(Stream cqlLibrary) => ConvertLibrary(new StreamReader(cqlLibrary));

        /// <summary>
        /// Converts the CQL contained in <paramref name="cqlLibrary"/> to an ELM <see cref="Library"/>.
        /// </summary>
        /// <param name="cqlLibrary">A <see cref="string"/> which contains a complete CQL library</param>
        /// <returns>The <see cref="Library"/> which represents this CQL.</returns>
        /// <exception cref="ArgumentException">if <paramref name="cqlLibrary"/> is empty.</exception>
        public Library ConvertLibrary(string cqlLibrary) => ConvertLibrary(new StringReader(cqlLibrary));

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