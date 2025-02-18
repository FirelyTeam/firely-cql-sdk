/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Compiler;
using Microsoft.Extensions.DependencyInjection;

namespace Hl7.Cql.CodeGeneration.NET.Toolkit.Internal;

internal sealed class ElmToolkitScopedState(IServiceScope scope) : IDisposable
{
    public LibrarySetExpressionBuilder LibrarySetExpressionBuilder { get; } = scope.ServiceProvider.GetRequiredService<LibrarySetExpressionBuilder>();

    public void Dispose() => scope.Dispose();
}
