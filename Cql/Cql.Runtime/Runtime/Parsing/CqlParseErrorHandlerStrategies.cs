/*
 * Copyright (c) 2025, Firely and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Runtime.Parsing;

internal static class CqlParseErrorHandlerStrategies
{

    public static CqlParseErrorHandler OnErrorThrowException(Type TargetType) =>
        e =>
            throw (e.Format switch
           {
               CqlParseErrors.NullOrEmpty => new ArgumentNullException(),
               _                          => new FormatException($"Not a valid {TargetType}: {e}")
           });

    public static CqlParseErrorHandler OnErrorThrowInvalidOperationException =>
        error => throw new InvalidOperationException(error.ToString());

    public static CqlParseErrorHandler OnErrorIgnore =>
        error => { };
}
