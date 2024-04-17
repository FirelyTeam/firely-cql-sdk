using Antlr4.Runtime;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.CqlToElm.Visitors;
using Hl7.Cql.Elm;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.IO;
using System.Linq;

namespace Hl7.Cql.CqlToElm
{
    /// <summary>
    /// Converts CQL To ELM.
    /// </summary>
    internal class CqlToElmConverter
    {
        public CqlToElmConverter(IServiceProvider services,
            ILogger<CqlToElmConverter> logger)
        {
            Services = services;
            Logger = logger;
        }

        public IServiceProvider Services { get; }
        public ILogger<CqlToElmConverter> Logger { get; }

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
            using (var cqlLibrary = new StringReader(cql))
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

                var lib = parser.library();
                var statements = lib.statement();
                using (var scope = Services.CreateScope())
                {
                    var visitor = scope.ServiceProvider.GetRequiredService<OrderingVisitor>();
                    var defRefs = statements
                        .Select(visitor.Visit)
                        .ToArray();
                }
            }

            using (var cqlLibrary = new StringReader(cql))
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
                    var visitor = scope.ServiceProvider.GetRequiredService<LibraryVisitor>();
                    try
                    {
                        var library = visitor.Visit(parser.library());
                        if (library.GetErrors().Any(e => e.errorSeverity == ErrorSeverity.error))
                            Logger.LogWarning("Parsed ELM tree contains errors.");

                        return library;
                    }
#if !DEBUG
                catch (Exception e)
                {
                        Logger.LogCritical(e, "Exception while converting CQL to ELM.");
                }
#else
                    catch
                    {
                        throw;
                    }
#endif
                }
            }
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