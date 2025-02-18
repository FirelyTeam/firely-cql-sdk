/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Compiler;

namespace CqlSdkPrototype.Elm.Internal;

internal sealed class ElmToolkitScopedState(IServiceScope scope) : IDisposable
{
    public LibrarySetExpressionBuilder LibrarySetExpressionBuilder { get; } = scope.ServiceProvider.GetRequiredService<LibrarySetExpressionBuilder>();

    public void Dispose() => scope.Dispose();
}
