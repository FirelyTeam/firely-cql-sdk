/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Antlr4.Runtime;
using Hl7.Cql.CqlToElm.Grammar;

namespace Hl7.Cql.Runtime.Parsing;

internal static class StringCqlParseExtensions
{
    public static bool TryParseCqlLibraryDefinition(
        this string cql,
        [NotNullWhen(true)] out (string qualifier, string identifier, string version)? result,
        CqlParseErrorHandler? onError = null,
        bool ensureAtEndOfInput = false)
    {
        onError ??= CqlParseErrorHandlerStrategies.OnErrorIgnore;
        var cqlParser = cql.ToCqlParser(onError);
        return cqlParser.TryParseLibraryDefinition(out result, onError)
               && (!ensureAtEndOfInput || cqlParser.EnsureAtEndOfInput(onError));
    }

    public static cqlParser ToCqlParser(
        this string cql,
        CqlParseErrorHandler? onError = null)
    {
        var stringReader = new StringReader(cql);
        var antlrInputStream = new AntlrInputStream(stringReader);
        var cqlLexer = new cqlLexer(antlrInputStream);
        var cqlParser = new cqlParser(new CommonTokenStream(cqlLexer));
        cqlParser.RemoveErrorListeners();
        if (onError is { } fn)
            cqlParser.AddErrorListener(new DelegatedAntlrErrorListener(fn));
        return cqlParser;
    }

    private class DelegatedAntlrErrorListener(CqlParseErrorHandler onError) : IAntlrErrorListener<IToken>
    {
        public void SyntaxError(
            TextWriter output,
            IRecognizer recognizer,
            IToken offendingSymbol,
            int line,
            int charPositionInLine,
            string msg,
            RecognitionException e) =>
            onError((CqlParseErrors.SyntaxError_1, msg));
    }
}
