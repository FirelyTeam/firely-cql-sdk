/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Invocation.Toolkit.Internal;

internal readonly record struct LibrarySetInvokerBuilderServices(
    ILogger<InvocationToolkit> Logger)
{
    public static LibrarySetInvokerBuilderServices Create(
        ILoggerFactory loggerFactory)
    {
        // No other services needed at this time.
        return new LibrarySetInvokerBuilderServices(loggerFactory.CreateLogger<InvocationToolkit>());
    }
}
