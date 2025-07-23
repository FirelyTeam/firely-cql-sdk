/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.CqlToElm.Grammar;

namespace Hl7.Cql.Runtime.Parsing;

internal static class CqlParserExtensions
{
    internal static bool TryParseLibraryDefinition(
        this cqlParser p,
        [NotNullWhen(true)] out (string qualifier, string identifier, string version)? result,
        CqlParseErrorHandler onError)
    {
        result = null;

        if (p.libraryDefinition() is not { } libraryDefinition)
        {
            onError((CqlParseErrors.ExpectedTokenNotFound_1, "libraryDefinition"));
            return false;
        }

        if (libraryDefinition.qualifiedIdentifier() is not { } qualifiedIdentifier)
        {
            onError((CqlParseErrors.ExpectedTokenNotFound_1, "qualifiedIdentifier"));
            return false;
        }

        string qualifierPart = "";
        switch (qualifiedIdentifier.qualifier())
        {
            case null:
                onError((CqlParseErrors.ExpectedTokenNotFound_1, "qualifier"));
                return false;

            case {} qualifiers:
            {
                StringBuilder sbQualifierPart = new StringBuilder();
                for (int i = 0; i < qualifiers.Length; i++)
                {
                    var qualifier = qualifiers[i];
                    var qualifierText = qualifier.identifier().GetText();
                    if (!TryUnquote(qualifierText, out qualifierPart, onError, '\"', '`'))
                    {
                        return false;
                    }

                    if (sbQualifierPart.Length > 0)
                        sbQualifierPart.Append(CqlVersionedLibraryIdentifierFormatting.SystemIdentifierDelimiter);

                    sbQualifierPart.Append(qualifierPart);
                }
                qualifierPart = sbQualifierPart.ToString();
                break;
            }
        }

        string? identifierText;
        switch (qualifiedIdentifier.identifier()?.GetText())
        {
            case null:
                onError((CqlParseErrors.ExpectedTokenNotFound_1, "identifier"));
                return false;
            
            case { } text:
                identifierText = text;
                break;
        }

        if (!TryUnquote(identifierText, out var identifierPart, onError, '\"', '`'))
        {
            return false;
        }

        var versionText = libraryDefinition.versionSpecifier()?.GetText() ?? string.Empty;
        if (!TryUnquote(versionText, out var versionPart, onError, '\''))
        {
            return false;
        }

        result = (qualifierPart, identifierPart, versionPart);
        return true;
    }

    private static bool TryUnquote(
        string input,
        out string result,
        CqlParseErrorHandler onError,
        params char[] allowedQuotationChars)
    {
        result = input;
        if (string.IsNullOrEmpty(input))
            return true;

        for (int i = 0; i < allowedQuotationChars.Length; i++)
        {
            char quoteChar = allowedQuotationChars[i];
            if (input.StartsWith(quoteChar))
            {
                if (input.Length == 1
                    || !input.EndsWith(quoteChar))
                {
                    onError((CqlParseErrors.TextOpenedButNotClosed));
                    return false;
                }
                result = input[1..^1];
                result = Regex.Unescape(result);
                break;
            }
        }

        return true;
    }

    internal static bool EnsureAtEndOfInput(
        this cqlParser p,
        CqlParseErrorHandler onError)
    {
        if (p.CurrentToken.Type != cqlParser.Eof)
        {
            onError(CqlParseErrors.MoreTokensAfterEndOfInput);
            return false;
        }

        return true;
    }

    internal static bool EnsureNoSyntaxErrors(
        this cqlParser p,
        CqlParseErrorHandler onError)
    {
        if (p.NumberOfSyntaxErrors != 0)
        {
            onError(CqlParseErrors.SyntaxErrorFound);
            return false;
        }

        return true;
    }
}