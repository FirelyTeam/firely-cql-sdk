/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.CqlToElm.Visitors;

namespace Hl7.Cql.CqlToElm;

internal static class ScopedServicesExtensions
{
    internal static LibraryVisitor GetLibraryVisitorScoped(this IServiceScope scope) => scope.ServiceProvider.GetRequiredService<LibraryVisitor>();
}
